using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOAICP
{
    public partial class FavoriteListForm : Form
    {

        MainForm cachedmainForm;


        public FavoriteListForm(MainForm mainForm)
        {
            InitializeComponent();
            cachedmainForm = mainForm;
        }


        private void FavoriteListForm_Load(object sender, EventArgs e)
        {

        }

        private void 메인화면으로돌아가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cachedmainForm.Visible = true;
            this.Close();
        }

      
    }
}
