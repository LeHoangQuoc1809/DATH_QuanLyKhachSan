namespace Quanlykhachsan
{
    partial class TypeAccountErrorWarning
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
            this.lbWarning_DeleteTypeAccount = new System.Windows.Forms.Label();
            this.cbbTypeAccount = new System.Windows.Forms.ComboBox();
            this.btnChangeType1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWarning_DeleteTypeAccount
            // 
            this.lbWarning_DeleteTypeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbWarning_DeleteTypeAccount.Location = new System.Drawing.Point(9, 7);
            this.lbWarning_DeleteTypeAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWarning_DeleteTypeAccount.Name = "lbWarning_DeleteTypeAccount";
            this.lbWarning_DeleteTypeAccount.Size = new System.Drawing.Size(461, 125);
            this.lbWarning_DeleteTypeAccount.TabIndex = 0;
            this.lbWarning_DeleteTypeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbTypeAccount
            // 
            this.cbbTypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeAccount.Enabled = false;
            this.cbbTypeAccount.FormattingEnabled = true;
            this.cbbTypeAccount.Location = new System.Drawing.Point(202, 146);
            this.cbbTypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTypeAccount.Name = "cbbTypeAccount";
            this.cbbTypeAccount.Size = new System.Drawing.Size(92, 21);
            this.cbbTypeAccount.TabIndex = 1;
            // 
            // btnChangeType1
            // 
            this.btnChangeType1.Location = new System.Drawing.Point(309, 144);
            this.btnChangeType1.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeType1.Name = "btnChangeType1";
            this.btnChangeType1.Size = new System.Drawing.Size(70, 24);
            this.btnChangeType1.TabIndex = 2;
            this.btnChangeType1.Text = "Change";
            this.btnChangeType1.UseVisualStyleBackColor = true;
            this.btnChangeType1.Click += new System.EventHandler(this.btnChangeType1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(104, 146);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(71, 13);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "TypeAccount";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(202, 255);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(92, 31);
            this.btnDeleteAll.TabIndex = 7;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(208, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "****Status****";
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(104, 212);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(299, 41);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(202, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TypeAccountErrorWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 297);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnChangeType1);
            this.Controls.Add(this.cbbTypeAccount);
            this.Controls.Add(this.lbWarning_DeleteTypeAccount);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TypeAccountErrorWarning";
            this.Text = "TypeAccountErrorWarning";
            this.Load += new System.EventHandler(this.TypeAccountErrorWarning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWarning_DeleteTypeAccount;
        private System.Windows.Forms.ComboBox cbbTypeAccount;
        private System.Windows.Forms.Button btnChangeType1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnCancel;
    }
}