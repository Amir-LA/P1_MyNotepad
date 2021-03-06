﻿using System;
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
        MyUndo notepadUndo = new MyUndo();

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
            string[] a = new string[5];
            a[0] = txtNotepad.BackColor.Name;
            a[1] = txtNotepad.Font.Name;
            a[2] = txtNotepad.Font.Size.ToString();
            a[3] = this.Height.ToString();
            a[4] = this.Width.ToString();
            System.IO.File.WriteAllLines(@"E:\Git\P1_ My Notepad\My Notepad\layout.txt", a);
            //System.IO.File.WriteAllText(@"E:\Git\P1_ My Notepad\My Notepad\layout.txt", txtNotepad.BackColor.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] x = new string[5];
            if(System.IO.File.Exists(@"E:\Git\P1_ My Notepad\My Notepad\layout.txt") == true)
            {
               
                x=System.IO.File.ReadAllLines(@"E:\Git\P1_ My Notepad\My Notepad\layout.txt");
                ToolStripMenuItem temp = new ToolStripMenuItem();
                temp.Text = x[0];
                Setbk(temp, null);
                txtNotepad.Font = new Font(x[1], Convert.ToInt16(x[2]));
                this.Height = Convert.ToInt16(x[3]);
                this.Width = Convert.ToInt16(x[4]);
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
            setrowcol();
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
                MessageBox.Show("NOT Found");
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

        public Boolean FindNextfunction(string s, StringComparison compairtype, Boolean righttoleft)
        {
            int i;
            if(righttoleft==true)
            i = txtNotepad.Text.IndexOf(s,txtNotepad.SelectionStart+1, compairtype);
            else
                i = txtNotepad.Text.LastIndexOf (s, txtNotepad.SelectionStart - 1, compairtype);

            if (i == -1)
            {
                MessageBox.Show("NOT Found");
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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Text = notepadUndo.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotepad.Text = notepadUndo.Redo();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            notepadUndo.settext(txtNotepad.Text);
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmreplace f = new Frmreplace(this);
            f.Show(this);
        }

        public void replacefunction(string str)
        {
            if (txtNotepad.SelectionLength > 0)
                txtNotepad.SelectedText = str;
        }

        /// <summary>
        /// Method for replacing all components
        /// </summary>
        /// <param name="str1">the chosen string</param>
        /// <param name="">the replaced string</param>
        /// <param name="cmptype">comparison type</param>
        /// <param name="lefttoright">comparison direction</param>
        public void replaceallfunction(string str1,string str2,StringComparison cmptype, Boolean lefttoright)
        {
            while (FindNextfunction(str1, cmptype, lefttoright))
                replacefunction(str2);
        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmgotocs f = new Frmgotocs(this);
            f.ShowDialog();

        }

        /// <summary>
        /// number of lines
        /// </summary>
        /// <returns></returns>
        public int getlines()
        {
            return txtNotepad.Lines.Count();
        }


        public void gotofunction(int x)
        {
            txtNotepad.SelectionStart = txtNotepad.GetFirstCharIndexFromLine(x);
        }


        public void setrowcol()
        {
            int row = txtNotepad.GetLineFromCharIndex(txtNotepad.SelectionStart)+1;
            int col = txtNotepad.SelectionStart - txtNotepad.GetFirstCharIndexOfCurrentLine()+1;
            lblrowcol.Text = "Ln " + row.ToString() + " , col" + col.ToString();
        }

        private void txtNotepad_Click(object sender, EventArgs e)
        {
            setrowcol();
        }

        private void txtNotepad_KeyUp(object sender, KeyEventArgs e)
        {
            setrowcol();
        }

        public void setenables()
        {
            copyToolStripMenuItem.Enabled = Convert.ToBoolean(txtNotepad.SelectionLength);
            cutToolStripMenuItem.Enabled = txtNotepad.SelectionLength > 0;
            delToolStripMenuItem.Enabled = txtNotepad.SelectionLength > 0;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            findNextToolStripMenuItem.Enabled = txtNotepad.Text.Length > 0;
            gotoToolStripMenuItem.Enabled = txtNotepad.TextLength > 0;
            saveAsToolStripMenuItem.Enabled = !saveflag;
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            setenables();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;

            printDialog1.Document = printDocument1;
            x=printDialog1.ShowDialog();

            if (x == DialogResult.OK)
                printDocument1.Print();
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtNotepad.Text, txtNotepad.Font, Brushes.Black, 0, 0);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
    // new class of MyUndo
    public class MyUndo
    {

        string[] temp = new string[100];
        int index;
        int currentposition;
        public MyUndo()
        {
            index = 0;
            currentposition = 0;
        }

        public void settext(string s)
        {
            temp[index] = s;
            currentposition = index;
            ++index;

        }

        public string Undo()
        {
            if (currentposition > 0)
                return temp[--currentposition];
            return null;
        }

        public string Redo()
        {
            if (currentposition < index)
                return temp[++currentposition];
            return null;
        }

    }
}
