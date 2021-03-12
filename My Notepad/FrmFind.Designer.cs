
namespace My_Notepad
{
    partial class FrmFind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnfind = new System.Windows.Forms.Button();
            this.bntclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.hkmachcase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoup = new System.Windows.Forms.RadioButton();
            this.rdodown = new System.Windows.Forms.RadioButton();
            this.btnfindnext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(506, 18);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(112, 35);
            this.btnfind.TabIndex = 0;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // bntclose
            // 
            this.bntclose.Location = new System.Drawing.Point(506, 122);
            this.bntclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntclose.Name = "bntclose";
            this.bntclose.Size = new System.Drawing.Size(112, 35);
            this.bntclose.TabIndex = 1;
            this.bntclose.Text = "Close";
            this.bntclose.UseVisualStyleBackColor = true;
            this.bntclose.Click += new System.EventHandler(this.bntclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "What find:";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(128, 34);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(354, 26);
            this.txtfind.TabIndex = 3;
            // 
            // hkmachcase
            // 
            this.hkmachcase.AutoSize = true;
            this.hkmachcase.Location = new System.Drawing.Point(22, 112);
            this.hkmachcase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hkmachcase.Name = "hkmachcase";
            this.hkmachcase.Size = new System.Drawing.Size(115, 24);
            this.hkmachcase.TabIndex = 4;
            this.hkmachcase.Text = "Mach Case";
            this.hkmachcase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoup);
            this.groupBox1.Controls.Add(this.rdodown);
            this.groupBox1.Location = new System.Drawing.Point(180, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(240, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rdoup
            // 
            this.rdoup.AutoSize = true;
            this.rdoup.Location = new System.Drawing.Point(16, 38);
            this.rdoup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoup.Name = "rdoup";
            this.rdoup.Size = new System.Drawing.Size(55, 24);
            this.rdoup.TabIndex = 7;
            this.rdoup.Text = "Up";
            this.rdoup.UseVisualStyleBackColor = true;
            // 
            // rdodown
            // 
            this.rdodown.AutoSize = true;
            this.rdodown.Checked = true;
            this.rdodown.Location = new System.Drawing.Point(152, 35);
            this.rdodown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdodown.Name = "rdodown";
            this.rdodown.Size = new System.Drawing.Size(75, 24);
            this.rdodown.TabIndex = 6;
            this.rdodown.TabStop = true;
            this.rdodown.Text = "Down";
            this.rdodown.UseVisualStyleBackColor = true;
            // 
            // btnfindnext
            // 
            this.btnfindnext.Location = new System.Drawing.Point(506, 63);
            this.btnfindnext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfindnext.Name = "btnfindnext";
            this.btnfindnext.Size = new System.Drawing.Size(112, 35);
            this.btnfindnext.TabIndex = 6;
            this.btnfindnext.Text = "Find Next";
            this.btnfindnext.UseVisualStyleBackColor = true;
            this.btnfindnext.Click += new System.EventHandler(this.btnfindnext_Click);
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 195);
            this.Controls.Add(this.btnfindnext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hkmachcase);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntclose);
            this.Controls.Add(this.btnfind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFind";
            this.Text = "FrmFind";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfindnext;
        protected System.Windows.Forms.Button bntclose;
        protected System.Windows.Forms.TextBox txtfind;
        protected System.Windows.Forms.CheckBox hkmachcase;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.RadioButton rdoup;
        protected System.Windows.Forms.RadioButton rdodown;
    }
}