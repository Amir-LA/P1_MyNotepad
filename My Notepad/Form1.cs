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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Setbk(object sender, EventArgs e)
        {
            txtNotepad.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem x in backColorToolStripMenuItem.DropDownItems)
                if (x == (sender))
                    x.Checked = true;
                else
                    x.Checked = false;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusbar1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            txtNotepad.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtNotepad.Font;
            fontDialog1.ShowDialog();
            txtNotepad.Font = fontDialog1.Font;
        }
    }
}
