namespace Quanlykhachsan
{
    partial class FormHistoryBill
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.pnBill = new System.Windows.Forms.Panel();
            this.dgvGroupBillHistory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roomcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMauDo = new System.Windows.Forms.Label();
            this.lbTimeTotalMoney = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupBillHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Roomcode,
            this.TimePayment});
            this.dgvBill.Location = new System.Drawing.Point(11, 103);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(251, 238);
            this.dgvBill.TabIndex = 1;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // pnBill
            // 
            this.pnBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnBill.Location = new System.Drawing.Point(288, 88);
            this.pnBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(695, 520);
            this.pnBill.TabIndex = 2;
            // 
            // dgvGroupBillHistory
            // 
            this.dgvGroupBillHistory.AllowUserToAddRows = false;
            this.dgvGroupBillHistory.AllowUserToDeleteRows = false;
            this.dgvGroupBillHistory.AllowUserToResizeColumns = false;
            this.dgvGroupBillHistory.AllowUserToResizeRows = false;
            this.dgvGroupBillHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupBillHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvGroupBillHistory.Location = new System.Drawing.Point(11, 368);
            this.dgvGroupBillHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGroupBillHistory.Name = "dgvGroupBillHistory";
            this.dgvGroupBillHistory.ReadOnly = true;
            this.dgvGroupBillHistory.RowHeadersVisible = false;
            this.dgvGroupBillHistory.RowHeadersWidth = 51;
            this.dgvGroupBillHistory.RowTemplate.Height = 24;
            this.dgvGroupBillHistory.Size = new System.Drawing.Size(251, 240);
            this.dgvGroupBillHistory.TabIndex = 1;
            this.dgvGroupBillHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupBillHistory_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDCustomer";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Customer";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TimePayment";
            this.dataGridViewTextBoxColumn2.HeaderText = "TimePayment";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Roomcode
            // 
            this.Roomcode.DataPropertyName = "Roomcode";
            this.Roomcode.HeaderText = "Roomcode";
            this.Roomcode.MinimumWidth = 6;
            this.Roomcode.Name = "Roomcode";
            this.Roomcode.Width = 90;
            // 
            // TimePayment
            // 
            this.TimePayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimePayment.DataPropertyName = "TimePayment";
            this.TimePayment.HeaderText = "TimePayment";
            this.TimePayment.MinimumWidth = 6;
            this.TimePayment.Name = "TimePayment";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(288, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(56, 56);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time Begin";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(98, 41);
            this.dtpEnd.MaxDate = new System.DateTime(2032, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(164, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBegin.Location = new System.Drawing.Point(98, 5);
            this.dtpBegin.MaxDate = new System.DateTime(2032, 12, 31, 0, 0, 0, 0);
            this.dtpBegin.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(164, 20);
            this.dtpBegin.TabIndex = 4;
            this.dtpBegin.ValueChanged += new System.EventHandler(this.dtpBegin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Single Bill History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Group Bill History";
            // 
            // lbMauDo
            // 
            this.lbMauDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMauDo.ForeColor = System.Drawing.Color.Red;
            this.lbMauDo.Location = new System.Drawing.Point(32, 635);
            this.lbMauDo.Name = "lbMauDo";
            this.lbMauDo.Size = new System.Drawing.Size(195, 27);
            this.lbMauDo.TabIndex = 8;
            this.lbMauDo.Text = "TOTAL MONEY : ";
            this.lbMauDo.Visible = false;
            // 
            // lbTimeTotalMoney
            // 
            this.lbTimeTotalMoney.BackColor = System.Drawing.SystemColors.Control;
            this.lbTimeTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeTotalMoney.ForeColor = System.Drawing.Color.Red;
            this.lbTimeTotalMoney.Location = new System.Drawing.Point(218, 636);
            this.lbTimeTotalMoney.Name = "lbTimeTotalMoney";
            this.lbTimeTotalMoney.Size = new System.Drawing.Size(765, 27);
            this.lbTimeTotalMoney.TabIndex = 9;
            this.lbTimeTotalMoney.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 56);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormHistoryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 686);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbTimeTotalMoney);
            this.Controls.Add(this.lbMauDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pnBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.dgvGroupBillHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHistoryBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormHistoryBill";
            this.Load += new System.EventHandler(this.FormHistoryBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupBillHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roomcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePayment;
        private System.Windows.Forms.DataGridView dgvGroupBillHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMauDo;
        private System.Windows.Forms.Label lbTimeTotalMoney;
        private System.Windows.Forms.Button btnCancel;
    }
}