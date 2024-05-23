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
    public partial class ResultForm : Form
    {
        private int BPM;
        private string Genre;

        public ResultForm(int BPM, string Genre)
        {
            InitializeComponent();
            this.BPM = BPM;
            this.Genre = Genre;

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            // 입력받은 정보를 띄워줍니다.
            BPM_label.Text = "BPM : " + BPM.ToString();
            Genre_label.Text = "Genre : " + Genre;
        }
    }
}
