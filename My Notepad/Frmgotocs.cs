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
    public partial class Frmgotocs : Form
    {
        Form1 frmmain;
        public Frmgotocs( Form1 frm)
        {
            frmmain = frm;
            InitializeComponent();
        }

        private void Frmgotocs_Load(object sender, EventArgs e)
        {
            txtlinenumber.Text = frmmain.getlines().ToString();
            txtlinenumber.SelectAll();
        }

        private void btngoto_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt16(txtlinenumber.Text) - 1;
            if (n > frmmain.getlines())
            {
             MessageBox.Show("OUT of Range");
             txtlinenumber.SelectAll();
                txtlinenumber.Focus();
            }
            else
            {
                frmmain.gotofunction(n);
                this.Close();
            }
               

        }
    }
}
