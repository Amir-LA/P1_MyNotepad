
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(337, 12);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 0;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // bntclose
            // 
            this.bntclose.Location = new System.Drawing.Point(337, 59);
            this.bntclose.Name = "bntclose";
            this.bntclose.Size = new System.Drawing.Size(75, 23);
            this.bntclose.TabIndex = 1;
            this.bntclose.Text = "Close";
            this.bntclose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What find:";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(85, 22);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(237, 20);
            this.txtfind.TabIndex = 3;
            // 
            // hkmachcase
            // 
            this.hkmachcase.AutoSize = true;
            this.hkmachcase.Location = new System.Drawing.Point(15, 73);
            this.hkmachcase.Name = "hkmachcase";
            this.hkmachcase.Size = new System.Drawing.Size(80, 17);
            this.hkmachcase.TabIndex = 4;
            this.hkmachcase.Text = "Mach Case";
            this.hkmachcase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoup);
            this.groupBox1.Controls.Add(this.rdodown);
            this.groupBox1.Location = new System.Drawing.Point(120, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // rdoup
            // 
            this.rdoup.AutoSize = true;
            this.rdoup.Location = new System.Drawing.Point(11, 25);
            this.rdoup.Name = "rdoup";
            this.rdoup.Size = new System.Drawing.Size(39, 17);
            this.rdoup.TabIndex = 7;
            this.rdoup.Text = "Up";
            this.rdoup.UseVisualStyleBackColor = true;
            // 
            // rdodown
            // 
            this.rdodown.AutoSize = true;
            this.rdodown.Checked = true;
            this.rdodown.Location = new System.Drawing.Point(101, 23);
            this.rdodown.Name = "rdodown";
            this.rdodown.Size = new System.Drawing.Size(53, 17);
            this.rdodown.TabIndex = 6;
            this.rdodown.TabStop = true;
            this.rdodown.Text = "Down";
            this.rdodown.UseVisualStyleBackColor = true;
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 127);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hkmachcase);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntclose);
            this.Controls.Add(this.btnfind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFind";
            this.Text = "FrmFind";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button bntclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.CheckBox hkmachcase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoup;
        private System.Windows.Forms.RadioButton rdodown;
    }
}