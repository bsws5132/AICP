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
    public partial class FavoriteForm : Form
    {
        public FavoriteForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 지금은 그냥 닫습니다, 이후 메인메뉴로 돌아가는 코드로 바꿀 예정입니다.
            this.Close();
        }
    }
}
