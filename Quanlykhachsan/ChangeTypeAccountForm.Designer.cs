namespace Quanlykhachsan
{
    partial class ChangeTypeAccountForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbTypeAccount = new System.Windows.Forms.ComboBox();
            this.btnAdd_TypeAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewTypeAccount = new System.Windows.Forms.TextBox();
            this.btnModify_TypeAccount = new System.Windows.Forms.Button();
            this.btnDelete_TypeAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus_TypeAccount = new System.Windows.Forms.Label();
            this.dgvTypeAccount = new System.Windows.Forms.DataGridView();
            this.TypeAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave_TypeAccount = new System.Windows.Forms.Button();
            this.btnCancel_TypeAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTypeAccount
            // 
            this.cbbTypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeAccount.FormattingEnabled = true;
            this.cbbTypeAccount.Location = new System.Drawing.Point(230, 34);
            this.cbbTypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTypeAccount.Name = "cbbTypeAccount";
            this.cbbTypeAccount.Size = new System.Drawing.Size(102, 21);
            this.cbbTypeAccount.TabIndex = 0;
            // 
            // btnAdd_TypeAccount
            // 
            this.btnAdd_TypeAccount.Location = new System.Drawing.Point(173, 150);
            this.btnAdd_TypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd_TypeAccount.Name = "btnAdd_TypeAccount";
            this.btnAdd_TypeAccount.Size = new System.Drawing.Size(56, 25);
            this.btnAdd_TypeAccount.TabIndex = 1;
            this.btnAdd_TypeAccount.Text = "Add";
            this.btnAdd_TypeAccount.UseVisualStyleBackColor = true;
            this.btnAdd_TypeAccount.Click += new System.EventHandler(this.btnAdd_TypeAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TypeAccount";
            // 
            // txtNewTypeAccount
            // 
            this.txtNewTypeAccount.Location = new System.Drawing.Point(230, 76);
            this.txtNewTypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewTypeAccount.Name = "txtNewTypeAccount";
            this.txtNewTypeAccount.Size = new System.Drawing.Size(102, 20);
            this.txtNewTypeAccount.TabIndex = 3;
            this.txtNewTypeAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewTypeAccount_KeyPress);
            // 
            // btnModify_TypeAccount
            // 
            this.btnModify_TypeAccount.Location = new System.Drawing.Point(249, 150);
            this.btnModify_TypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify_TypeAccount.Name = "btnModify_TypeAccount";
            this.btnModify_TypeAccount.Size = new System.Drawing.Size(56, 25);
            this.btnModify_TypeAccount.TabIndex = 4;
            this.btnModify_TypeAccount.Text = "Modify";
            this.btnModify_TypeAccount.UseVisualStyleBackColor = true;
            this.btnModify_TypeAccount.Click += new System.EventHandler(this.btnModify_TypeAccount_Click);
            // 
            // btnDelete_TypeAccount
            // 
            this.btnDelete_TypeAccount.Location = new System.Drawing.Point(173, 204);
            this.btnDelete_TypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete_TypeAccount.Name = "btnDelete_TypeAccount";
            this.btnDelete_TypeAccount.Size = new System.Drawing.Size(56, 25);
            this.btnDelete_TypeAccount.TabIndex = 5;
            this.btnDelete_TypeAccount.Text = "Delete";
            this.btnDelete_TypeAccount.UseVisualStyleBackColor = true;
            this.btnDelete_TypeAccount.Click += new System.EventHandler(this.btnDelete_TypeAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NewTypeAccount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(198, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "****Status****";
            // 
            // lbStatus_TypeAccount
            // 
            this.lbStatus_TypeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus_TypeAccount.ForeColor = System.Drawing.Color.Red;
            this.lbStatus_TypeAccount.Location = new System.Drawing.Point(135, 299);
            this.lbStatus_TypeAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus_TypeAccount.Name = "lbStatus_TypeAccount";
            this.lbStatus_TypeAccount.Size = new System.Drawing.Size(196, 57);
            this.lbStatus_TypeAccount.TabIndex = 8;
            this.lbStatus_TypeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTypeAccount
            // 
            this.dgvTypeAccount.AllowUserToAddRows = false;
            this.dgvTypeAccount.AllowUserToDeleteRows = false;
            this.dgvTypeAccount.AllowUserToResizeColumns = false;
            this.dgvTypeAccount.AllowUserToResizeRows = false;
            this.dgvTypeAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeAccount});
            this.dgvTypeAccount.Location = new System.Drawing.Point(9, 34);
            this.dgvTypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTypeAccount.Name = "dgvTypeAccount";
            this.dgvTypeAccount.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTypeAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTypeAccount.RowHeadersVisible = false;
            this.dgvTypeAccount.RowHeadersWidth = 51;
            this.dgvTypeAccount.RowTemplate.Height = 24;
            this.dgvTypeAccount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTypeAccount.Size = new System.Drawing.Size(120, 306);
            this.dgvTypeAccount.TabIndex = 9;
            this.dgvTypeAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeAccount_CellClick);
            // 
            // TypeAccount
            // 
            this.TypeAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeAccount.DataPropertyName = "ListType";
            this.TypeAccount.HeaderText = "     Type Account";
            this.TypeAccount.MinimumWidth = 6;
            this.TypeAccount.Name = "TypeAccount";
            this.TypeAccount.ReadOnly = true;
            // 
            // btnSave_TypeAccount
            // 
            this.btnSave_TypeAccount.Location = new System.Drawing.Point(249, 204);
            this.btnSave_TypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave_TypeAccount.Name = "btnSave_TypeAccount";
            this.btnSave_TypeAccount.Size = new System.Drawing.Size(56, 25);
            this.btnSave_TypeAccount.TabIndex = 10;
            this.btnSave_TypeAccount.Text = "Save";
            this.btnSave_TypeAccount.UseVisualStyleBackColor = true;
            this.btnSave_TypeAccount.Click += new System.EventHandler(this.btnSave_TypeAccount_Click);
            // 
            // btnCancel_TypeAccount
            // 
            this.btnCancel_TypeAccount.BackColor = System.Drawing.Color.Pink;
            this.btnCancel_TypeAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel_TypeAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel_TypeAccount.FlatAppearance.BorderSize = 0;
            this.btnCancel_TypeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel_TypeAccount.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCancel_TypeAccount.Location = new System.Drawing.Point(249, 204);
            this.btnCancel_TypeAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel_TypeAccount.Name = "btnCancel_TypeAccount";
            this.btnCancel_TypeAccount.Size = new System.Drawing.Size(56, 25);
            this.btnCancel_TypeAccount.TabIndex = 11;
            this.btnCancel_TypeAccount.Text = "Cancel";
            this.btnCancel_TypeAccount.UseVisualStyleBackColor = false;
            this.btnCancel_TypeAccount.Click += new System.EventHandler(this.btnCancel_TypeAccount_Click);
            // 
            // ChangeTypeAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 366);
            this.Controls.Add(this.btnSave_TypeAccount);
            this.Controls.Add(this.dgvTypeAccount);
            this.Controls.Add(this.lbStatus_TypeAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete_TypeAccount);
            this.Controls.Add(this.btnModify_TypeAccount);
            this.Controls.Add(this.txtNewTypeAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd_TypeAccount);
            this.Controls.Add(this.cbbTypeAccount);
            this.Controls.Add(this.btnCancel_TypeAccount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeTypeAccountForm";
            this.Text = "ChangeTypeAccount";
            this.Load += new System.EventHandler(this.ChangeTypeAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTypeAccount;
        private System.Windows.Forms.Button btnAdd_TypeAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewTypeAccount;
        private System.Windows.Forms.Button btnModify_TypeAccount;
        private System.Windows.Forms.Button btnDelete_TypeAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus_TypeAccount;
        private System.Windows.Forms.DataGridView dgvTypeAccount;
        private System.Windows.Forms.Button btnSave_TypeAccount;
        private System.Windows.Forms.Button btnCancel_TypeAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeAccount;
    }
}