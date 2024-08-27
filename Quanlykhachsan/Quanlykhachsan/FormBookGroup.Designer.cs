namespace Quanlykhachsan
{
    partial class FormBookGroup
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
            this.lbCOMING = new System.Windows.Forms.Label();
            this.lbAOT = new System.Windows.Forms.Label();
            this.lbREPAIR = new System.Windows.Forms.Label();
            this.btnFilterTime = new System.Windows.Forms.Button();
            this.lbEMPTY = new System.Windows.Forms.Label();
            this.lbDIRTY = new System.Windows.Forms.Label();
            this.lbFULL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTimeFilter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fpnRoomDiagram = new System.Windows.Forms.FlowLayoutPanel();
            this.lbBorderStatus = new System.Windows.Forms.Label();
            this.lbBorderTime = new System.Windows.Forms.Label();
            this.txtStatusFilter = new System.Windows.Forms.TextBox();
            this.pnInFoRentalGroup = new System.Windows.Forms.Panel();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRooms = new System.Windows.Forms.Label();
            this.btnSreach = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.dgvListSub = new System.Windows.Forms.DataGridView();
            this.IDCellSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCellSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListMain = new System.Windows.Forms.DataGridView();
            this.IDCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.txtNODay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTimeCheckout = new System.Windows.Forms.DateTimePicker();
            this.lbNameEmployee = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReload = new Quanlykhachsan.CCricleButton();
            this.pnInFoRentalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMain)).BeginInit();
            this.grbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCOMING
            // 
            this.lbCOMING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCOMING.Location = new System.Drawing.Point(133, 54);
            this.lbCOMING.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCOMING.Name = "lbCOMING";
            this.lbCOMING.Size = new System.Drawing.Size(78, 22);
            this.lbCOMING.TabIndex = 31;
            this.lbCOMING.Text = "COMING";
            this.lbCOMING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAOT
            // 
            this.lbAOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAOT.ForeColor = System.Drawing.Color.Red;
            this.lbAOT.Location = new System.Drawing.Point(640, 54);
            this.lbAOT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAOT.Name = "lbAOT";
            this.lbAOT.Size = new System.Drawing.Size(110, 22);
            this.lbAOT.TabIndex = 27;
            this.lbAOT.Text = "Time\'s up";
            this.lbAOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbREPAIR
            // 
            this.lbREPAIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbREPAIR.Location = new System.Drawing.Point(516, 54);
            this.lbREPAIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbREPAIR.Name = "lbREPAIR";
            this.lbREPAIR.Size = new System.Drawing.Size(78, 22);
            this.lbREPAIR.TabIndex = 28;
            this.lbREPAIR.Text = "REPAIR";
            this.lbREPAIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilterTime
            // 
            this.btnFilterTime.Location = new System.Drawing.Point(285, 28);
            this.btnFilterTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterTime.Name = "btnFilterTime";
            this.btnFilterTime.Size = new System.Drawing.Size(50, 20);
            this.btnFilterTime.TabIndex = 25;
            this.btnFilterTime.Text = "Filter";
            this.btnFilterTime.UseVisualStyleBackColor = true;
            this.btnFilterTime.Click += new System.EventHandler(this.btnFilterTime_Click);
            // 
            // lbEMPTY
            // 
            this.lbEMPTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEMPTY.Location = new System.Drawing.Point(261, 54);
            this.lbEMPTY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEMPTY.Name = "lbEMPTY";
            this.lbEMPTY.Size = new System.Drawing.Size(78, 22);
            this.lbEMPTY.TabIndex = 24;
            this.lbEMPTY.Text = "EMPTY";
            this.lbEMPTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDIRTY
            // 
            this.lbDIRTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDIRTY.Location = new System.Drawing.Point(391, 54);
            this.lbDIRTY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDIRTY.Name = "lbDIRTY";
            this.lbDIRTY.Size = new System.Drawing.Size(78, 22);
            this.lbDIRTY.TabIndex = 22;
            this.lbDIRTY.Text = "DIRTY";
            this.lbDIRTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFULL
            // 
            this.lbFULL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFULL.Location = new System.Drawing.Point(9, 54);
            this.lbFULL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFULL.Name = "lbFULL";
            this.lbFULL.Size = new System.Drawing.Size(78, 22);
            this.lbFULL.TabIndex = 23;
            this.lbFULL.Text = "FULL";
            this.lbFULL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Time";
            // 
            // dtpTimeFilter
            // 
            this.dtpTimeFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeFilter.Location = new System.Drawing.Point(81, 29);
            this.dtpTimeFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeFilter.Name = "dtpTimeFilter";
            this.dtpTimeFilter.Size = new System.Drawing.Size(192, 20);
            this.dtpTimeFilter.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "StatusRoom";
            // 
            // fpnRoomDiagram
            // 
            this.fpnRoomDiagram.AutoScroll = true;
            this.fpnRoomDiagram.BackColor = System.Drawing.Color.White;
            this.fpnRoomDiagram.Enabled = false;
            this.fpnRoomDiagram.Location = new System.Drawing.Point(1, 80);
            this.fpnRoomDiagram.Margin = new System.Windows.Forms.Padding(2);
            this.fpnRoomDiagram.Name = "fpnRoomDiagram";
            this.fpnRoomDiagram.Size = new System.Drawing.Size(913, 600);
            this.fpnRoomDiagram.TabIndex = 17;
            // 
            // lbBorderStatus
            // 
            this.lbBorderStatus.BackColor = System.Drawing.Color.Red;
            this.lbBorderStatus.Location = new System.Drawing.Point(80, -1);
            this.lbBorderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorderStatus.Name = "lbBorderStatus";
            this.lbBorderStatus.Size = new System.Drawing.Size(194, 23);
            this.lbBorderStatus.TabIndex = 29;
            this.lbBorderStatus.Visible = false;
            // 
            // lbBorderTime
            // 
            this.lbBorderTime.BackColor = System.Drawing.Color.Red;
            this.lbBorderTime.Location = new System.Drawing.Point(80, 28);
            this.lbBorderTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorderTime.Name = "lbBorderTime";
            this.lbBorderTime.Size = new System.Drawing.Size(194, 21);
            this.lbBorderTime.TabIndex = 30;
            this.lbBorderTime.Visible = false;
            // 
            // txtStatusFilter
            // 
            this.txtStatusFilter.Enabled = false;
            this.txtStatusFilter.Location = new System.Drawing.Point(81, 2);
            this.txtStatusFilter.Name = "txtStatusFilter";
            this.txtStatusFilter.Size = new System.Drawing.Size(192, 20);
            this.txtStatusFilter.TabIndex = 33;
            this.txtStatusFilter.Text = "EMPTY";
            // 
            // pnInFoRentalGroup
            // 
            this.pnInFoRentalGroup.Controls.Add(this.txtSize);
            this.pnInFoRentalGroup.Controls.Add(this.lbSize);
            this.pnInFoRentalGroup.Controls.Add(this.label16);
            this.pnInFoRentalGroup.Controls.Add(this.label5);
            this.pnInFoRentalGroup.Controls.Add(this.lbRooms);
            this.pnInFoRentalGroup.Controls.Add(this.btnSreach);
            this.pnInFoRentalGroup.Controls.Add(this.lb);
            this.pnInFoRentalGroup.Controls.Add(this.label8);
            this.pnInFoRentalGroup.Controls.Add(this.btnCheckout);
            this.pnInFoRentalGroup.Controls.Add(this.lbStatus);
            this.pnInFoRentalGroup.Controls.Add(this.label7);
            this.pnInFoRentalGroup.Controls.Add(this.btnCheckin);
            this.pnInFoRentalGroup.Controls.Add(this.dgvListSub);
            this.pnInFoRentalGroup.Controls.Add(this.dgvListMain);
            this.pnInFoRentalGroup.Controls.Add(this.grbTime);
            this.pnInFoRentalGroup.Controls.Add(this.lbNameEmployee);
            this.pnInFoRentalGroup.Controls.Add(this.label10);
            this.pnInFoRentalGroup.Controls.Add(this.label9);
            this.pnInFoRentalGroup.Controls.Add(this.label4);
            this.pnInFoRentalGroup.Controls.Add(this.txtID);
            this.pnInFoRentalGroup.Controls.Add(this.label13);
            this.pnInFoRentalGroup.Controls.Add(this.label14);
            this.pnInFoRentalGroup.Controls.Add(this.txtName);
            this.pnInFoRentalGroup.Controls.Add(this.btnCancel);
            this.pnInFoRentalGroup.Location = new System.Drawing.Point(919, 1);
            this.pnInFoRentalGroup.Name = "pnInFoRentalGroup";
            this.pnInFoRentalGroup.Size = new System.Drawing.Size(468, 680);
            this.pnInFoRentalGroup.TabIndex = 0;
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(140, 117);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.MaxLength = 3;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(78, 20);
            this.txtSize.TabIndex = 104;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // lbSize
            // 
            this.lbSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSize.Location = new System.Drawing.Point(334, 116);
            this.lbSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(78, 20);
            this.lbSize.TabIndex = 103;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(281, 117);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 103;
            this.label16.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "Size";
            // 
            // lbRooms
            // 
            this.lbRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRooms.Enabled = false;
            this.lbRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRooms.Location = new System.Drawing.Point(140, 155);
            this.lbRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(272, 20);
            this.lbRooms.TabIndex = 102;
            this.lbRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSreach
            // 
            this.btnSreach.ForeColor = System.Drawing.Color.Black;
            this.btnSreach.Location = new System.Drawing.Point(60, 455);
            this.btnSreach.Margin = new System.Windows.Forms.Padding(2);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.Size = new System.Drawing.Size(147, 32);
            this.btnSreach.TabIndex = 101;
            this.btnSreach.Text = "Sreach";
            this.btnSreach.UseVisualStyleBackColor = true;
            this.btnSreach.Click += new System.EventHandler(this.btnSreach_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb.Location = new System.Drawing.Point(125, 1);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(236, 31);
            this.lb.TabIndex = 100;
            this.lb.Text = "BOOK A GROUP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Rooms";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Location = new System.Drawing.Point(262, 407);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(148, 32);
            this.btnCheckout.TabIndex = 98;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(61, 339);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(349, 61);
            this.lbStatus.TabIndex = 97;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(198, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "****Status****";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(60, 407);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(148, 32);
            this.btnCheckin.TabIndex = 94;
            this.btnCheckin.Text = "Check in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.TextChanged += new System.EventHandler(this.btnCheckin_TextChanged);
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
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
            this.dgvListSub.Location = new System.Drawing.Point(246, 516);
            this.dgvListSub.Name = "dgvListSub";
            this.dgvListSub.ReadOnly = true;
            this.dgvListSub.RowHeadersVisible = false;
            this.dgvListSub.RowHeadersWidth = 51;
            this.dgvListSub.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListSub.Size = new System.Drawing.Size(164, 149);
            this.dgvListSub.TabIndex = 92;
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
            // dgvListMain
            // 
            this.dgvListMain.AllowUserToAddRows = false;
            this.dgvListMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCell,
            this.NameCell});
            this.dgvListMain.EnableHeadersVisualStyles = false;
            this.dgvListMain.Location = new System.Drawing.Point(60, 516);
            this.dgvListMain.Name = "dgvListMain";
            this.dgvListMain.ReadOnly = true;
            this.dgvListMain.RowHeadersVisible = false;
            this.dgvListMain.RowHeadersWidth = 51;
            this.dgvListMain.Size = new System.Drawing.Size(164, 149);
            this.dgvListMain.TabIndex = 93;
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
            // grbTime
            // 
            this.grbTime.Controls.Add(this.txtNODay);
            this.grbTime.Controls.Add(this.label12);
            this.grbTime.Controls.Add(this.dtpTimeCheckin);
            this.grbTime.Controls.Add(this.label11);
            this.grbTime.Controls.Add(this.label3);
            this.grbTime.Controls.Add(this.dtpTimeCheckout);
            this.grbTime.Location = new System.Drawing.Point(60, 185);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(351, 100);
            this.grbTime.TabIndex = 91;
            this.grbTime.TabStop = false;
            // 
            // txtNODay
            // 
            this.txtNODay.Enabled = false;
            this.txtNODay.Location = new System.Drawing.Point(298, 41);
            this.txtNODay.Margin = new System.Windows.Forms.Padding(2);
            this.txtNODay.MaxLength = 2;
            this.txtNODay.Name = "txtNODay";
            this.txtNODay.Size = new System.Drawing.Size(46, 20);
            this.txtNODay.TabIndex = 66;
            this.txtNODay.TextChanged += new System.EventHandler(this.txtNODay_TextChanged);
            this.txtNODay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNODay_KeyPress);
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
            this.dtpTimeCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeCheckin.MaxDate = new System.DateTime(2032, 12, 31, 0, 0, 0, 0);
            this.dtpTimeCheckin.Name = "dtpTimeCheckin";
            this.dtpTimeCheckin.Size = new System.Drawing.Size(152, 20);
            this.dtpTimeCheckin.TabIndex = 58;
            this.dtpTimeCheckin.ValueChanged += new System.EventHandler(this.dtpTimeCheckin_ValueChanged);
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
            // dtpTimeCheckout
            // 
            this.dtpTimeCheckout.Enabled = false;
            this.dtpTimeCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeCheckout.Location = new System.Drawing.Point(80, 62);
            this.dtpTimeCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeCheckout.Name = "dtpTimeCheckout";
            this.dtpTimeCheckout.Size = new System.Drawing.Size(152, 20);
            this.dtpTimeCheckout.TabIndex = 60;
            // 
            // lbNameEmployee
            // 
            this.lbNameEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameEmployee.Enabled = false;
            this.lbNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameEmployee.Location = new System.Drawing.Point(139, 299);
            this.lbNameEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameEmployee.Name = "lbNameEmployee";
            this.lbNameEmployee.Size = new System.Drawing.Size(272, 20);
            this.lbNameEmployee.TabIndex = 90;
            this.lbNameEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 500);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Sub";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 500);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Main";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Employee";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(140, 79);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.MaxLength = 12;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(271, 20);
            this.txtID.TabIndex = 83;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "IDCustomer";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 41);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "NameCustomer";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(140, 41);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 20);
            this.txtName.TabIndex = 80;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(262, 455);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 32);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReload
            // 
            this.btnReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.BackgroundColor = System.Drawing.Color.White;
            this.btnReload.BorderColor = System.Drawing.Color.White;
            this.btnReload.BorderRadius = 20;
            this.btnReload.BorderSize = 0;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = global::Quanlykhachsan.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(391, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(29, 28);
            this.btnReload.TabIndex = 32;
            this.btnReload.TextColor = System.Drawing.Color.White;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormBookGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 686);
            this.Controls.Add(this.pnInFoRentalGroup);
            this.Controls.Add(this.txtStatusFilter);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lbCOMING);
            this.Controls.Add(this.lbAOT);
            this.Controls.Add(this.lbREPAIR);
            this.Controls.Add(this.btnFilterTime);
            this.Controls.Add(this.lbEMPTY);
            this.Controls.Add(this.lbDIRTY);
            this.Controls.Add(this.lbFULL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTimeFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fpnRoomDiagram);
            this.Controls.Add(this.lbBorderStatus);
            this.Controls.Add(this.lbBorderTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBookGroup";
            this.Text = "FormBookGroup";
            this.Load += new System.EventHandler(this.FormBookGroup_Load);
            this.EnabledChanged += new System.EventHandler(this.FormBookGroup_EnabledChanged);
            this.pnInFoRentalGroup.ResumeLayout(false);
            this.pnInFoRentalGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMain)).EndInit();
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCricleButton btnReload;
        private System.Windows.Forms.Label lbCOMING;
        private System.Windows.Forms.Label lbAOT;
        private System.Windows.Forms.Label lbREPAIR;
        private System.Windows.Forms.Button btnFilterTime;
        private System.Windows.Forms.Label lbEMPTY;
        private System.Windows.Forms.Label lbDIRTY;
        private System.Windows.Forms.Label lbFULL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTimeFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fpnRoomDiagram;
        private System.Windows.Forms.Label lbBorderStatus;
        private System.Windows.Forms.Label lbBorderTime;
        private System.Windows.Forms.TextBox txtStatusFilter;
        private System.Windows.Forms.Panel pnInFoRentalGroup;
        private System.Windows.Forms.Button btnSreach;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.DataGridView dgvListSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCellSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCellSub;
        private System.Windows.Forms.DataGridView dgvListMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCell;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.TextBox txtNODay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpTimeCheckin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTimeCheckout;
        private System.Windows.Forms.Label lbNameEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbRooms;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label16;
    }
}