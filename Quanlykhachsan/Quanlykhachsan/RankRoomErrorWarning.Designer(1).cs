namespace Quanlykhachsan
{
    partial class RankRoomErrorWarning
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
            this.lbNotify_Rank = new System.Windows.Forms.Label();
            this.cbbRankRoom = new System.Windows.Forms.ComboBox();
            this.btnApply_Rank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNotify_Rank
            // 
            this.lbNotify_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNotify_Rank.Location = new System.Drawing.Point(9, 7);
            this.lbNotify_Rank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotify_Rank.Name = "lbNotify_Rank";
            this.lbNotify_Rank.Size = new System.Drawing.Size(394, 151);
            this.lbNotify_Rank.TabIndex = 0;
            // 
            // cbbRankRoom
            // 
            this.cbbRankRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRankRoom.FormattingEnabled = true;
            this.cbbRankRoom.Location = new System.Drawing.Point(151, 161);
            this.cbbRankRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbRankRoom.Name = "cbbRankRoom";
            this.cbbRankRoom.Size = new System.Drawing.Size(105, 21);
            this.cbbRankRoom.TabIndex = 1;
            // 
            // btnApply_Rank
            // 
            this.btnApply_Rank.Location = new System.Drawing.Point(151, 206);
            this.btnApply_Rank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply_Rank.Name = "btnApply_Rank";
            this.btnApply_Rank.Size = new System.Drawing.Size(94, 37);
            this.btnApply_Rank.TabIndex = 2;
            this.btnApply_Rank.Text = "Apply";
            this.btnApply_Rank.UseVisualStyleBackColor = true;
            this.btnApply_Rank.Click += new System.EventHandler(this.btnApply_Rank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RankRoom";
            // 
            // RankRoomErrorWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply_Rank);
            this.Controls.Add(this.cbbRankRoom);
            this.Controls.Add(this.lbNotify_Rank);
            this.Location = new System.Drawing.Point(600, 250);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RankRoomErrorWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RankRoomErrorWarning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNotify_Rank;
        private System.Windows.Forms.ComboBox cbbRankRoom;
        private System.Windows.Forms.Button btnApply_Rank;
        private System.Windows.Forms.Label label1;
    }
}