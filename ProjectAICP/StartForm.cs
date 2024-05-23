using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAICP
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }



        private void RecommandButton_Click(object sender, EventArgs e)
        {
            // 정보를 입력받습니다.
           int BPM = int.Parse(BPM_Textbox.Text);
           string Genre = Genre_TextBox.Text;

            // 입력받은 정보를 옮깁니다.

            ResultForm resultForm = new ResultForm(BPM, Genre);
            resultForm.Show();
        }

        private void FavoriteButton_Click(object sender, EventArgs e)
        {

            // 즐겨찾기 화면으로 이동합니다.
            FavoriteForm favoriteForm = new FavoriteForm();
            favoriteForm.Show();

            
        }
    }
}
