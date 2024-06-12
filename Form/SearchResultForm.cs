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
    public partial class SearchResultForm : MetroFramework.Forms.MetroForm
    {
        MainForm cachedMainform;
        
        public SearchResultForm(MainForm mainForm)
        {
            InitializeComponent();
            cachedMainform = mainForm;
        }

        private void 메인화면으로돌아가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cachedMainform.Visible = true;
            this.Close();
        }
    }
}
