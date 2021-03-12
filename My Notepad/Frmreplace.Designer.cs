
namespace My_Notepad
{
    partial class Frmreplace
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
            this.btnreplace = new System.Windows.Forms.Button();
            this.btnreplaceall = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntclose
            // 
            this.bntclose.Location = new System.Drawing.Point(506, 198);
            // 
            // hkmachcase
            // 
            this.hkmachcase.Location = new System.Drawing.Point(22, 162);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(180, 153);
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(506, 113);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(112, 34);
            this.btnreplace.TabIndex = 7;
            this.btnreplace.Text = "Replace";
            this.btnreplace.UseVisualStyleBackColor = true;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // btnreplaceall
            // 
            this.btnreplaceall.Location = new System.Drawing.Point(506, 155);
            this.btnreplaceall.Name = "btnreplaceall";
            this.btnreplaceall.Size = new System.Drawing.Size(112, 34);
            this.btnreplaceall.TabIndex = 8;
            this.btnreplaceall.Text = "Replace All";
            this.btnreplaceall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Replace";
            // 
            // txtreplace
            // 
            this.txtreplace.Location = new System.Drawing.Point(128, 89);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(354, 26);
            this.txtreplace.TabIndex = 10;
            // 
            // Frmreplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(639, 248);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreplaceall);
            this.Controls.Add(this.btnreplace);
            this.Name = "Frmreplace";
            this.Text = "Frmreplace";
            this.Controls.SetChildIndex(this.bntclose, 0);
            this.Controls.SetChildIndex(this.txtfind, 0);
            this.Controls.SetChildIndex(this.hkmachcase, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnreplace, 0);
            this.Controls.SetChildIndex(this.btnreplaceall, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtreplace, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.Button btnreplaceall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtreplace;
    }
}
