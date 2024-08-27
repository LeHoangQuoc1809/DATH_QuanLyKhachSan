namespace Quanlykhachsan
{
    partial class ChooseMode
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
            this.btnMng = new System.Windows.Forms.Button();
            this.btnRct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMng
            // 
            this.btnMng.Location = new System.Drawing.Point(12, 12);
            this.btnMng.Name = "btnMng";
            this.btnMng.Size = new System.Drawing.Size(181, 182);
            this.btnMng.TabIndex = 0;
            this.btnMng.Text = "Manager";
            this.btnMng.UseVisualStyleBackColor = true;
            this.btnMng.Click += new System.EventHandler(this.btnMng_Click);
            // 
            // btnRct
            // 
            this.btnRct.Location = new System.Drawing.Point(199, 12);
            this.btnRct.Name = "btnRct";
            this.btnRct.Size = new System.Drawing.Size(184, 182);
            this.btnRct.TabIndex = 1;
            this.btnRct.Text = "Receptionist";
            this.btnRct.UseVisualStyleBackColor = true;
            this.btnRct.Click += new System.EventHandler(this.btnRct_Click);
            // 
            // ChooseMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 204);
            this.Controls.Add(this.btnRct);
            this.Controls.Add(this.btnMng);
            this.Location = new System.Drawing.Point(620, 290);
            this.Name = "ChooseMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChooseMode";
            this.Load += new System.EventHandler(this.ChooseMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMng;
        private System.Windows.Forms.Button btnRct;
    }
}