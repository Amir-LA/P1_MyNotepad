﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace My_Notepad
{
    public partial class Frmreplace : My_Notepad.FrmFind
    {
        Form1 frmmain;
        public Frmreplace()
        {
            InitializeComponent();
        }
        public Frmreplace(Form1 x):base(x)
        {
            frmmain = x;
            InitializeComponent();
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            frmmain.replacefunction(txtreplace.Text);
        }
    }
}
