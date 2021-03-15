
namespace My_Notepad
{
    partial class Frmgotocs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtlinenumber = new System.Windows.Forms.TextBox();
            this.btngoto = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line Number:";
            // 
            // txtlinenumber
            // 
            this.txtlinenumber.Location = new System.Drawing.Point(21, 49);
            this.txtlinenumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlinenumber.Name = "txtlinenumber";
            this.txtlinenumber.Size = new System.Drawing.Size(416, 36);
            this.txtlinenumber.TabIndex = 0;
            // 
            // btngoto
            // 
            this.btngoto.Location = new System.Drawing.Point(185, 112);
            this.btngoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngoto.Name = "btngoto";
            this.btngoto.Size = new System.Drawing.Size(108, 42);
            this.btngoto.TabIndex = 0;
            this.btngoto.Text = "Goto";
            this.btngoto.UseVisualStyleBackColor = true;
            this.btngoto.Click += new System.EventHandler(this.btngoto_Click);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(315, 112);
            this.btncancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(108, 42);
            this.btncancle.TabIndex = 2;
            this.btncancle.Text = "Cancel";
            this.btncancle.UseVisualStyleBackColor = true;
            // 
            // Frmgotocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 176);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btngoto);
            this.Controls.Add(this.txtlinenumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmgotocs";
            this.Text = "Frmgotocs";
            this.Load += new System.EventHandler(this.Frmgotocs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlinenumber;
        private System.Windows.Forms.Button btngoto;
        private System.Windows.Forms.Button btncancle;
    }
}