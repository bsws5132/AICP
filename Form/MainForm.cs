using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SPOAICP
{
    public partial class MainForm : Form
    {
        private static readonly string clientId = "27840cda88d14f4dab5dd0f29ea781ff";
        private static readonly string clientSecret = "981e7dd893bf4c02b001cf5a44c32984";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string artistInput = textBox1.Text;
            if (!int.TryParse(textBox2.Text, out int bpm))
            {
                MessageBox.Show("BPM 값을 올바르게 입력하세요.");
                return;
            }

            string accessToken = await GetAccessToken(clientId, clientSecret);

            var tracks = await SearchTracksByArtist(artistInput, accessToken);

            var matchingTracks = await Task.WhenAll(tracks
                .Select(async track => new
                {
                    Track = track,
                    Features = await GetAudioFeatures(track["id"].ToString(), accessToken)
                }));

            var filteredTracks = matchingTracks
                .Where(t => Math.Abs((double)t.Features["tempo"] - bpm) <= 8)
                .ToList();

            if (!filteredTracks.Any())
            {
                label1.Text = "해당 BPM에 맞는 트랙을 찾을 수 없습니다.";
                return;
            }

            var mostPopularTrack = filteredTracks.OrderByDescending(t => (int)t.Track["popularity"]).First();
            var trackInfo = mostPopularTrack.Track;
            var trackFeatures = mostPopularTrack.Features;

            label1.Text = $"입력한 아티스트와 BPM:\n" +
                               $"아티스트: {artistInput}\n" +
                               $"BPM: {bpm}\n\n" +
                               $"입력 값과 유사한 트랙 정보:\n" +
                               $"트랙 이름: {trackInfo["name"]}\n" +
                               $"아티스트: {string.Join(", ", trackInfo["artists"].Select(a => a["name"].ToString()))}\n" +
                               $"인기도: {trackInfo["popularity"]}\n" +
                               $"트랙 BPM: {trackFeatures["tempo"]}\n" +
                               $"트랙 키: {trackFeatures["key"]}";
        }

        private static async Task<string> GetAccessToken(string clientId, string clientSecret)
        {
            using (var client = new HttpClient())
            {
                var authHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);

                var request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token");
                request.Content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "client_credentials")
                });

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var token = JObject.Parse(responseBody)["access_token"].ToString();

                return token;
            }
        }

        private static async Task<JToken[]> SearchTracksByArtist(string artist, string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var response = await client.GetStringAsync($"https://api.spotify.com/v1/search?q=artist:{artist}&type=track&limit=50");
                var jsonResponse = JObject.Parse(response);
                return jsonResponse["tracks"]["items"].ToArray();
            }
        }

        private static async Task<JObject> GetAudioFeatures(string trackId, string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var response = await client.GetStringAsync($"https://api.spotify.com/v1/audio-features/{trackId}");
                return JObject.Parse(response);
            }
        }

        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FavoriteListForm favoriteListForm = new FavoriteListForm(this);
            favoriteListForm.Show();
            this.Hide();
        }
    }
}
