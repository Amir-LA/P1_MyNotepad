using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Notepad
{
    public partial class FrmFind : Form
    {
        Form1 frmmain;
        public FrmFind(Form1 frm)
        {

            frmmain = frm;
            InitializeComponent();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            //frmmain.Text = "aa";
            
            frmmain.Findfunction(txtfind.Text);

        }

        private void btnfindnext_Click(object sender, EventArgs e)
        {
            StringComparison a = StringComparison.OrdinalIgnoreCase;
            if (hkmachcase.Checked == true)
                a = StringComparison.Ordinal;

            frmmain.FindNextfunction(txtfind.Text,a);
        }

        private void bntclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
