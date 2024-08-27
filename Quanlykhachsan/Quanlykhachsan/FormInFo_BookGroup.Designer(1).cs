namespace Quanlykhachsan
{
    partial class FormInFo_BookGroup
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNameEmployee = new System.Windows.Forms.Label();
            this.dtpTimeCheckout = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNODay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.dgvListMain = new System.Windows.Forms.DataGridView();
            this.IDCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbRooms = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.btnSreach = new System.Windows.Forms.Button();
            this.dgvListSub = new System.Windows.Forms.DataGridView();
            this.IDCellSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCellSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSub)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(88, 100);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.MaxLength = 12;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(271, 20);
            this.txtID.TabIndex = 35;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "IDCustomer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "NameCustomer";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(88, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 20);
            this.txtName.TabIndex = 32;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(88, 136);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSize.MaxLength = 3;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(78, 20);
            this.txtSize.TabIndex = 37;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Size";
            // 
            // lbSize
            // 
            this.lbSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSize.Enabled = false;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSize.Location = new System.Drawing.Point(282, 136);
            this.lbSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(78, 20);
            this.lbSize.TabIndex = 39;
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSize.TextChanged += new System.EventHandler(this.lbSize_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Size";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(210, 465);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 32);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Employee";
            // 
            // lbNameEmployee
            // 
            this.lbNameEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameEmployee.Enabled = false;
            this.lbNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameEmployee.Location = new System.Drawing.Point(87, 317);
            this.lbNameEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameEmployee.Name = "lbNameEmployee";
            this.lbNameEmployee.Size = new System.Drawing.Size(272, 20);
            this.lbNameEmployee.TabIndex = 64;
            this.lbNameEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpTimeCheckout
            // 
            this.dtpTimeCheckout.Enabled = false;
            this.dtpTimeCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeCheckout.Location = new System.Drawing.Point(80, 62);
            this.dtpTimeCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTimeCheckout.Name = "dtpTimeCheckout";
            this.dtpTimeCheckout.Size = new System.Drawing.Size(152, 20);
            this.dtpTimeCheckout.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Time checkout";
            // 
            // txtNODay
            // 
            this.txtNODay.Enabled = false;
            this.txtNODay.Location = new System.Drawing.Point(298, 41);
            this.txtNODay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNODay.MaxLength = 2;
            this.txtNODay.Name = "txtNODay";
            this.txtNODay.Size = new System.Drawing.Size(46, 20);
            this.txtNODay.TabIndex = 66;
            this.txtNODay.TextChanged += new System.EventHandler(this.txtNODay_TextChanged);
            this.txtNODay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNODay_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Time checkin";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(246, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 41);
            this.label12.TabIndex = 67;
            this.label12.Text = "Enter Number Of Day";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTimeCheckin
            // 
            this.dtpTimeCheckin.Enabled = false;
            this.dtpTimeCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeCheckin.Location = new System.Drawing.Point(80, 25);
            this.dtpTimeCheckin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTimeCheckin.MaxDate = new System.DateTime(2032, 12, 31, 0, 0, 0, 0);
            this.dtpTimeCheckin.Name = "dtpTimeCheckin";
            this.dtpTimeCheckin.Size = new System.Drawing.Size(152, 20);
            this.dtpTimeCheckin.TabIndex = 58;
            this.dtpTimeCheckin.ValueChanged += new System.EventHandler(this.dtpTimeCheckin_ValueChanged);
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.txtNODay);
            this.grbTime.Controls.Add(this.label12);
            this.grbTime.Controls.Add(this.dtpTimeCheckin);
            this.grbTime.Controls.Add(this.label11);
            this.grbTime.Controls.Add(this.label3);
            this.grbTime.Controls.Add(this.dtpTimeCheckout);
            this.grbTime.Location = new System.Drawing.Point(8, 202);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(351, 100);
            this.grbTime.TabIndex = 68;
            this.grbTime.TabStop = false;
            // 
            // dgvListMain
            // 
            this.dgvListMain.AllowUserToAddRows = false;
            this.dgvListMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCell,
            this.NameCell});
            this.dgvListMain.EnableHeadersVisualStyles = false;
            this.dgvListMain.Location = new System.Drawing.Point(8, 553);
            this.dgvListMain.Name = "dgvListMain";
            this.dgvListMain.ReadOnly = true;
            this.dgvListMain.RowHeadersVisible = false;
            this.dgvListMain.RowHeadersWidth = 51;
            this.dgvListMain.Size = new System.Drawing.Size(164, 163);
            this.dgvListMain.TabIndex = 69;
            this.dgvListMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsRental_CellClick);
            // 
            // IDCell
            // 
            this.IDCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDCell.HeaderText = "ID";
            this.IDCell.MinimumWidth = 6;
            this.IDCell.Name = "IDCell";
            this.IDCell.ReadOnly = true;
            // 
            // NameCell
            // 
            this.NameCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCell.HeaderText = "Name";
            this.NameCell.MinimumWidth = 6;
            this.NameCell.Name = "NameCell";
            this.NameCell.ReadOnly = true;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(8, 410);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(148, 32);
            this.btnCheckin.TabIndex = 70;
            this.btnCheckin.Text = "Check in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.TextChanged += new System.EventHandler(this.btnCheckin_TextChanged);
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(146, 345);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "****Status****";
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(9, 369);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(350, 32);
            this.lbStatus.TabIndex = 73;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Location = new System.Drawing.Point(210, 410);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(148, 32);
            this.btnCheckout.TabIndex = 74;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Rooms";
            // 
            // lbRooms
            // 
            this.lbRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRooms.Enabled = false;
            this.lbRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRooms.Location = new System.Drawing.Point(88, 171);
            this.lbRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(272, 20);
            this.lbRooms.TabIndex = 77;
            this.lbRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb.Location = new System.Drawing.Point(73, 14);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(236, 31);
            this.lb.TabIndex = 78;
            this.lb.Text = "BOOK A GROUP";
            // 
            // btnSreach
            // 
            this.btnSreach.ForeColor = System.Drawing.Color.Black;
            this.btnSreach.Location = new System.Drawing.Point(8, 465);
            this.btnSreach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.Size = new System.Drawing.Size(147, 32);
            this.btnSreach.TabIndex = 79;
            this.btnSreach.Text = "Sreach";
            this.btnSreach.UseVisualStyleBackColor = true;
            this.btnSreach.Click += new System.EventHandler(this.btnSreach_Click);
            // 
            // dgvListSub
            // 
            this.dgvListSub.AllowUserToAddRows = false;
            this.dgvListSub.AllowUserToDeleteRows = false;
            this.dgvListSub.AllowUserToResizeColumns = false;
            this.dgvListSub.AllowUserToResizeRows = false;
            this.dgvListSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCellSub,
            this.NameCellSub});
            this.dgvListSub.EnableHeadersVisualStyles = false;
            this.dgvListSub.Location = new System.Drawing.Point(194, 553);
            this.dgvListSub.Name = "dgvListSub";
            this.dgvListSub.ReadOnly = true;
            this.dgvListSub.RowHeadersVisible = false;
            this.dgvListSub.RowHeadersWidth = 51;
            this.dgvListSub.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListSub.Size = new System.Drawing.Size(164, 163);
            this.dgvListSub.TabIndex = 69;
            this.dgvListSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSub_CellClick);
            // 
            // IDCellSub
            // 
            this.IDCellSub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDCellSub.HeaderText = "ID";
            this.IDCellSub.MinimumWidth = 6;
            this.IDCellSub.Name = "IDCellSub";
            this.IDCellSub.ReadOnly = true;
            // 
            // NameCellSub
            // 
            this.NameCellSub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCellSub.HeaderText = "Name";
            this.NameCellSub.MinimumWidth = 6;
            this.NameCellSub.Name = "NameCellSub";
            this.NameCellSub.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 537);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Main";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 537);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Sub";
            // 
            // FormInFo_BookGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 716);
            this.Controls.Add(this.btnSreach);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbRooms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.dgvListSub);
            this.Controls.Add(this.dgvListMain);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.lbNameEmployee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormInFo_BookGroup";
            this.Text = "FormInFo_BookGroup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInFo_BookGroup_FormClosing);
            this.Load += new System.EventHandler(this.FormInFo_BookGroup_Load);
            this.EnabledChanged += new System.EventHandler(this.FormInFo_BookGroup_EnabledChanged);
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNameEmployee;
        private System.Windows.Forms.DateTimePicker dtpTimeCheckout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNODay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpTimeCheckin;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.DataGridView dgvListMain;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbRooms;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnSreach;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCell;
        private System.Windows.Forms.DataGridView dgvListSub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCellSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCellSub;
    }
}