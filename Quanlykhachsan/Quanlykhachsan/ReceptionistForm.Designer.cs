namespace Quanlykhachsan
{
    partial class ReceptionistForm
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
            this.pnToTalBookGroup = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnLeftMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookGroup = new System.Windows.Forms.Button();
            this.btnBookSingle = new System.Windows.Forms.Button();
            this.btnHistoryBill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnToTalBookGroup.SuspendLayout();
            this.pnLeftMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnToTalBookGroup
            // 
            this.pnToTalBookGroup.BackColor = System.Drawing.Color.Aquamarine;
            this.pnToTalBookGroup.Controls.Add(this.lbWelcome);
            this.pnToTalBookGroup.Location = new System.Drawing.Point(177, 76);
            this.pnToTalBookGroup.Name = "pnToTalBookGroup";
            this.pnToTalBookGroup.Size = new System.Drawing.Size(1427, 694);
            this.pnToTalBookGroup.TabIndex = 1;
            this.pnToTalBookGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.pnToTalBookGroup_Paint);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Magenta;
            this.lbWelcome.Location = new System.Drawing.Point(492, 342);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(433, 31);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "WelCome to Hotel Management!";
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTop.Location = new System.Drawing.Point(177, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1506, 76);
            this.pnTop.TabIndex = 7;
            // 
            // pnLeftMenu
            // 
            this.pnLeftMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnLeftMenu.Controls.Add(this.btnHistoryBill);
            this.pnLeftMenu.Controls.Add(this.btnBookSingle);
            this.pnLeftMenu.Controls.Add(this.btnBookGroup);
            this.pnLeftMenu.Location = new System.Drawing.Point(0, 76);
            this.pnLeftMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnLeftMenu.Name = "pnLeftMenu";
            this.pnLeftMenu.Size = new System.Drawing.Size(177, 694);
            this.pnLeftMenu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOTEL MANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBookGroup
            // 
            this.btnBookGroup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBookGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBookGroup.FlatAppearance.BorderSize = 0;
            this.btnBookGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBookGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookGroup.Location = new System.Drawing.Point(0, 332);
            this.btnBookGroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookGroup.Name = "btnBookGroup";
            this.btnBookGroup.Size = new System.Drawing.Size(177, 38);
            this.btnBookGroup.TabIndex = 2;
            this.btnBookGroup.Text = "BOOK A GROUP\r\n";
            this.btnBookGroup.UseVisualStyleBackColor = false;
            this.btnBookGroup.Click += new System.EventHandler(this.btnBookGroup_Click);
            this.btnBookGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBookGroup_MouseDown);
            this.btnBookGroup.MouseLeave += new System.EventHandler(this.btnBookGroup_MouseLeave);
            this.btnBookGroup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBookGroup_MouseMove);
            // 
            // btnBookSingle
            // 
            this.btnBookSingle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBookSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBookSingle.FlatAppearance.BorderSize = 0;
            this.btnBookSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSingle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookSingle.Location = new System.Drawing.Point(0, 141);
            this.btnBookSingle.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookSingle.Name = "btnBookSingle";
            this.btnBookSingle.Size = new System.Drawing.Size(177, 38);
            this.btnBookSingle.TabIndex = 3;
            this.btnBookSingle.Text = "BOOK A SINGLE";
            this.btnBookSingle.UseVisualStyleBackColor = false;
            this.btnBookSingle.Click += new System.EventHandler(this.btnBookSingle_Click);
            this.btnBookSingle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBookSingle_MouseDown);
            this.btnBookSingle.MouseLeave += new System.EventHandler(this.btnBookSingle_MouseLeave);
            this.btnBookSingle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBookSingle_MouseMove);
            // 
            // btnHistoryBill
            // 
            this.btnHistoryBill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHistoryBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistoryBill.FlatAppearance.BorderSize = 0;
            this.btnHistoryBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHistoryBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistoryBill.Location = new System.Drawing.Point(0, 527);
            this.btnHistoryBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistoryBill.Name = "btnHistoryBill";
            this.btnHistoryBill.Size = new System.Drawing.Size(177, 38);
            this.btnHistoryBill.TabIndex = 5;
            this.btnHistoryBill.Text = "HISTORY BILL";
            this.btnHistoryBill.UseVisualStyleBackColor = false;
            this.btnHistoryBill.Click += new System.EventHandler(this.btnHistoryBill_Click);
            this.btnHistoryBill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHistoryBill_MouseDown);
            this.btnHistoryBill.MouseLeave += new System.EventHandler(this.btnHistoryBill_MouseLeave);
            this.btnHistoryBill.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHistoryBill_MouseMove);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 772);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 68);
            this.label3.TabIndex = 4;
            this.label3.Text = "HOTEL MANAGEMENT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnLeftMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnTop);
            this.panel1.Controls.Add(this.pnToTalBookGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1604, 854);
            this.panel1.TabIndex = 0;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 854);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionistForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceptionistForm_FormClosing);
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.pnToTalBookGroup.ResumeLayout(false);
            this.pnToTalBookGroup.PerformLayout();
            this.pnLeftMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnToTalBookGroup;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLeftMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHistoryBill;
        private System.Windows.Forms.Button btnBookSingle;
        private System.Windows.Forms.Button btnBookGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}