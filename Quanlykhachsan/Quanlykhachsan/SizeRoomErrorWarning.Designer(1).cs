namespace Quanlykhachsan
{
    partial class SizeRoomErrorWarning
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
            this.cbbSizeRoom = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lbNotify = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbSizeRoom
            // 
            this.cbbSizeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSizeRoom.FormattingEnabled = true;
            this.cbbSizeRoom.Location = new System.Drawing.Point(201, 198);
            this.cbbSizeRoom.Name = "cbbSizeRoom";
            this.cbbSizeRoom.Size = new System.Drawing.Size(139, 24);
            this.cbbSizeRoom.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(201, 253);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(125, 46);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply&&Delete";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lbNotify
            // 
            this.lbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNotify.Location = new System.Drawing.Point(12, 9);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(526, 186);
            this.lbNotify.TabIndex = 3;
            this.lbNotify.Text = "\r\n";
            this.lbNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(116, 198);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(70, 16);
            this.lb.TabIndex = 4;
            this.lb.Text = "SizeRoom";
            // 
            // SizeRoomErrorWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 323);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbbSizeRoom);
            this.Location = new System.Drawing.Point(600, 250);
            this.Name = "SizeRoomErrorWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SizeRoomErrorWarning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSizeRoom;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.Label lb;
    }
}