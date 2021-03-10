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
        string fn;
        Boolean saveflag;

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
                if (x.Text == ((ToolStripMenuItem)sender).Text) 
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText(@"E:\Git\P1_ My Notepad\My Notepad\layout.txt", txtNotepad.BackColor.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(@"E:\Git\P1_ My Notepad\My Notepad\layout.txt") == true) { 
            string s;
            s = System.IO.File.ReadAllText(@"E:\Git\P1_ My Notepad\My Notepad\layout.txt");
                ToolStripMenuItem temp = new ToolStripMenuItem();
                temp.Text = s;
                Setbk(temp, null);
                saveflag = true;
            //txtNotepad.BackColor = Color.FromName(s);
                
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

            txtNotepad.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fn == null)
            {
                DialogResult x;
                saveFileDialog1.DefaultExt = "txt";    
                x=saveFileDialog1.ShowDialog();
                if (x == DialogResult.Cancel)
                {
                    
                  return;
                }
                    
                fn = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fn, txtNotepad.Text);
            saveflag = true;
            this.Text = fn;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveflag == false)

            {
                DialogResult r;
                r= MessageBox.Show("Do want to Save?", "Save",MessageBoxButtons.YesNo );
                if (r == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                               
                    txtNotepad.Text = null;
                this.Text = "My Notepad";
                    fn = null;
                saveflag = true;


                
            }  
                
        }

        private void txtNotepad_TextChanged(object sender, EventArgs e)
        {
            saveflag = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File|*.txt|Document File|*.doc|All Files|*.*";
            newToolStripMenuItem_Click(null, null);
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            openFileDialog1.ShowDialog();
            fn = openFileDialog1.FileName;
            txtNotepad.Text=System.IO.File.ReadAllText(fn);
            saveflag = true;
            this.Text = fn;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn = null;
            saveAsToolStripMenuItem_Click(null, null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtNotepad.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectedText = Clipboard.GetText();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectedText = "";

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
            delToolStripMenuItem_Click(null, null);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFind f1 = new FrmFind(this);
            f1.Show(this);
        }

        public Boolean Findfunction(string s)
        {
            int i;
            i = txtNotepad.Text.IndexOf(s);
            if (i == -1)
            {
                MessageBox.Show("Nof Found");
                return false;
            }
            else
            {
                txtNotepad.SelectionStart = i;
                txtNotepad.SelectionLength = s.Length;
                txtNotepad.Focus();
                return true;
            }
        }

    }
}
