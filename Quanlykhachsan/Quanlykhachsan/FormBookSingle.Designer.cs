namespace Quanlykhachsan
{
    partial class FormBookSingle
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
            this.components = new System.ComponentModel.Container();
            this.fpnRoomDiagram = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbStatusFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTimeFilter = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFULL = new System.Windows.Forms.Label();
            this.lbEMPTY = new System.Windows.Forms.Label();
            this.lbDIRTY = new System.Windows.Forms.Label();
            this.btnFilterStatus = new System.Windows.Forms.Button();
            this.lbREPAIR = new System.Windows.Forms.Label();
            this.btnFilterTime = new System.Windows.Forms.Button();
            this.lbBorderStatus = new System.Windows.Forms.Label();
            this.lbBorderTime = new System.Windows.Forms.Label();
            this.lbCOMING = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbAOT = new System.Windows.Forms.Label();
            this.pnInFoSingle = new System.Windows.Forms.Panel();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNODay = new System.Windows.Forms.TextBox();
            this.grbTypeRental = new System.Windows.Forms.GroupBox();
            this.rdoDay = new System.Windows.Forms.RadioButton();
            this.rdoOverNight = new System.Windows.Forms.RadioButton();
            this.rdoHour = new System.Windows.Forms.RadioButton();
            this.lbProvisionalMoney = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFirstHour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbNormalHour = new System.Windows.Forms.Label();
            this.lbOverNight = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTimeCheckin = new System.Windows.Forms.CheckBox();
            this.dtpTimeCheckout = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNameEmployee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbRoomCode = new System.Windows.Forms.Label();
            this.btnReload = new Quanlykhachsan.CCricleButton();
            this.pnInFoSingle.SuspendLayout();
            this.grbTypeRental.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnRoomDiagram
            // 
            this.fpnRoomDiagram.AutoScroll = true;
            this.fpnRoomDiagram.BackColor = System.Drawing.Color.White;
            this.fpnRoomDiagram.Location = new System.Drawing.Point(1, 82);
            this.fpnRoomDiagram.Margin = new System.Windows.Forms.Padding(2);
            this.fpnRoomDiagram.Name = "fpnRoomDiagram";
            this.fpnRoomDiagram.Size = new System.Drawing.Size(913, 600);
            this.fpnRoomDiagram.TabIndex = 0;
            // 
            // cbbStatusFilter
            // 
            this.cbbStatusFilter.BackColor = System.Drawing.Color.White;
            this.cbbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatusFilter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbbStatusFilter.FormattingEnabled = true;
            this.cbbStatusFilter.Items.AddRange(new object[] {
            "<none>",
            "EMPTY",
            "COMING",
            "FULL",
            "DIRTY",
            "REPAIR",
            "TIME\'S UP"});
            this.cbbStatusFilter.Location = new System.Drawing.Point(81, 5);
            this.cbbStatusFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStatusFilter.Name = "cbbStatusFilter";
            this.cbbStatusFilter.Size = new System.Drawing.Size(192, 21);
            this.cbbStatusFilter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "StatusRoom";
            // 
            // dtpTimeFilter
            // 
            this.dtpTimeFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimeFilter.Location = new System.Drawing.Point(81, 33);
            this.dtpTimeFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeFilter.Name = "dtpTimeFilter";
            this.dtpTimeFilter.Size = new System.Drawing.Size(192, 20);
            this.dtpTimeFilter.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time";
            // 
            // lbFULL
            // 
            this.lbFULL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFULL.Location = new System.Drawing.Point(9, 58);
            this.lbFULL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFULL.Name = "lbFULL";
            this.lbFULL.Size = new System.Drawing.Size(78, 22);
            this.lbFULL.TabIndex = 8;
            this.lbFULL.Text = "FULL";
            this.lbFULL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEMPTY
            // 
            this.lbEMPTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEMPTY.Location = new System.Drawing.Point(261, 58);
            this.lbEMPTY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEMPTY.Name = "lbEMPTY";
            this.lbEMPTY.Size = new System.Drawing.Size(78, 22);
            this.lbEMPTY.TabIndex = 9;
            this.lbEMPTY.Text = "EMPTY";
            this.lbEMPTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDIRTY
            // 
            this.lbDIRTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDIRTY.Location = new System.Drawing.Point(391, 58);
            this.lbDIRTY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDIRTY.Name = "lbDIRTY";
            this.lbDIRTY.Size = new System.Drawing.Size(78, 22);
            this.lbDIRTY.TabIndex = 8;
            this.lbDIRTY.Text = "DIRTY";
            this.lbDIRTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilterStatus
            // 
            this.btnFilterStatus.Location = new System.Drawing.Point(285, 5);
            this.btnFilterStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterStatus.Name = "btnFilterStatus";
            this.btnFilterStatus.Size = new System.Drawing.Size(50, 20);
            this.btnFilterStatus.TabIndex = 10;
            this.btnFilterStatus.Text = "Filter";
            this.btnFilterStatus.UseVisualStyleBackColor = true;
            this.btnFilterStatus.Click += new System.EventHandler(this.btnFilterStatus_Click);
            // 
            // lbREPAIR
            // 
            this.lbREPAIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbREPAIR.Location = new System.Drawing.Point(516, 58);
            this.lbREPAIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbREPAIR.Name = "lbREPAIR";
            this.lbREPAIR.Size = new System.Drawing.Size(78, 22);
            this.lbREPAIR.TabIndex = 12;
            this.lbREPAIR.Text = "REPAIR";
            this.lbREPAIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilterTime
            // 
            this.btnFilterTime.Location = new System.Drawing.Point(285, 32);
            this.btnFilterTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterTime.Name = "btnFilterTime";
            this.btnFilterTime.Size = new System.Drawing.Size(50, 20);
            this.btnFilterTime.TabIndex = 10;
            this.btnFilterTime.Text = "Filter";
            this.btnFilterTime.UseVisualStyleBackColor = true;
            this.btnFilterTime.Click += new System.EventHandler(this.btnFilterTime_Click);
            // 
            // lbBorderStatus
            // 
            this.lbBorderStatus.BackColor = System.Drawing.Color.Red;
            this.lbBorderStatus.Location = new System.Drawing.Point(80, 3);
            this.lbBorderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorderStatus.Name = "lbBorderStatus";
            this.lbBorderStatus.Size = new System.Drawing.Size(194, 23);
            this.lbBorderStatus.TabIndex = 13;
            this.lbBorderStatus.Visible = false;
            // 
            // lbBorderTime
            // 
            this.lbBorderTime.BackColor = System.Drawing.Color.Red;
            this.lbBorderTime.Location = new System.Drawing.Point(80, 32);
            this.lbBorderTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorderTime.Name = "lbBorderTime";
            this.lbBorderTime.Size = new System.Drawing.Size(194, 21);
            this.lbBorderTime.TabIndex = 14;
            this.lbBorderTime.Visible = false;
            // 
            // lbCOMING
            // 
            this.lbCOMING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCOMING.Location = new System.Drawing.Point(133, 58);
            this.lbCOMING.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCOMING.Name = "lbCOMING";
            this.lbCOMING.Size = new System.Drawing.Size(78, 22);
            this.lbCOMING.TabIndex = 15;
            this.lbCOMING.Text = "COMING";
            this.lbCOMING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAOT
            // 
            this.lbAOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAOT.ForeColor = System.Drawing.Color.Red;
            this.lbAOT.Location = new System.Drawing.Point(640, 58);
            this.lbAOT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAOT.Name = "lbAOT";
            this.lbAOT.Size = new System.Drawing.Size(110, 22);
            this.lbAOT.TabIndex = 12;
            this.lbAOT.Text = "Time\'s up";
            this.lbAOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnInFoSingle
            // 
            this.pnInFoSingle.Controls.Add(this.btnModify);
            this.pnInFoSingle.Controls.Add(this.btnCheckout);
            this.pnInFoSingle.Controls.Add(this.lbStatus);
            this.pnInFoSingle.Controls.Add(this.label17);
            this.pnInFoSingle.Controls.Add(this.btnCheckin);
            this.pnInFoSingle.Controls.Add(this.btnCancel);
            this.pnInFoSingle.Controls.Add(this.label12);
            this.pnInFoSingle.Controls.Add(this.txtNODay);
            this.pnInFoSingle.Controls.Add(this.grbTypeRental);
            this.pnInFoSingle.Controls.Add(this.lbProvisionalMoney);
            this.pnInFoSingle.Controls.Add(this.label7);
            this.pnInFoSingle.Controls.Add(this.groupBox1);
            this.pnInFoSingle.Controls.Add(this.cbTimeCheckin);
            this.pnInFoSingle.Controls.Add(this.dtpTimeCheckout);
            this.pnInFoSingle.Controls.Add(this.label4);
            this.pnInFoSingle.Controls.Add(this.lbNameEmployee);
            this.pnInFoSingle.Controls.Add(this.label5);
            this.pnInFoSingle.Controls.Add(this.dtpTimeCheckin);
            this.pnInFoSingle.Controls.Add(this.cbbStatus);
            this.pnInFoSingle.Controls.Add(this.label11);
            this.pnInFoSingle.Controls.Add(this.label10);
            this.pnInFoSingle.Controls.Add(this.lbRank);
            this.pnInFoSingle.Controls.Add(this.label8);
            this.pnInFoSingle.Controls.Add(this.lbSize);
            this.pnInFoSingle.Controls.Add(this.label6);
            this.pnInFoSingle.Controls.Add(this.txtID);
            this.pnInFoSingle.Controls.Add(this.label14);
            this.pnInFoSingle.Controls.Add(this.label16);
            this.pnInFoSingle.Controls.Add(this.txtName);
            this.pnInFoSingle.Controls.Add(this.lbRoomCode);
            this.pnInFoSingle.Location = new System.Drawing.Point(919, 2);
            this.pnInFoSingle.Name = "pnInFoSingle";
            this.pnInFoSingle.Size = new System.Drawing.Size(468, 680);
            this.pnInFoSingle.TabIndex = 17;
            this.pnInFoSingle.Visible = false;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(261, 569);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(101, 42);
            this.btnModify.TabIndex = 97;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(121, 631);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(101, 42);
            this.btnCheckout.TabIndex = 96;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(35, 496);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(408, 63);
            this.lbStatus.TabIndex = 95;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(209, 483);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 94;
            this.label17.Text = "****Status****";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(121, 569);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(101, 42);
            this.btnCheckin.TabIndex = 92;
            this.btnCheckin.Text = "Check in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(261, 631);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 42);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(267, 396);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 29);
            this.label12.TabIndex = 91;
            this.label12.Text = "Enter number of day";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Visible = false;
            // 
            // txtNODay
            // 
            this.txtNODay.Enabled = false;
            this.txtNODay.Location = new System.Drawing.Point(330, 404);
            this.txtNODay.Margin = new System.Windows.Forms.Padding(2);
            this.txtNODay.Name = "txtNODay";
            this.txtNODay.Size = new System.Drawing.Size(37, 20);
            this.txtNODay.TabIndex = 90;
            this.txtNODay.Visible = false;
            this.txtNODay.TextChanged += new System.EventHandler(this.txtNODay_TextChanged);
            this.txtNODay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNODay_KeyPress);
            // 
            // grbTypeRental
            // 
            this.grbTypeRental.Controls.Add(this.rdoDay);
            this.grbTypeRental.Controls.Add(this.rdoOverNight);
            this.grbTypeRental.Controls.Add(this.rdoHour);
            this.grbTypeRental.Enabled = false;
            this.grbTypeRental.Location = new System.Drawing.Point(48, 388);
            this.grbTypeRental.Margin = new System.Windows.Forms.Padding(2);
            this.grbTypeRental.Name = "grbTypeRental";
            this.grbTypeRental.Padding = new System.Windows.Forms.Padding(2);
            this.grbTypeRental.Size = new System.Drawing.Size(214, 37);
            this.grbTypeRental.TabIndex = 89;
            this.grbTypeRental.TabStop = false;
            this.grbTypeRental.Text = "Type Rental";
            // 
            // rdoDay
            // 
            this.rdoDay.AutoSize = true;
            this.rdoDay.Location = new System.Drawing.Point(164, 15);
            this.rdoDay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDay.Name = "rdoDay";
            this.rdoDay.Size = new System.Drawing.Size(44, 17);
            this.rdoDay.TabIndex = 2;
            this.rdoDay.Text = "Day";
            this.rdoDay.UseVisualStyleBackColor = true;
            this.rdoDay.CheckedChanged += new System.EventHandler(this.rdoDay_CheckedChanged);
            this.rdoDay.Click += new System.EventHandler(this.rdoDay_Click);
            // 
            // rdoOverNight
            // 
            this.rdoOverNight.AutoSize = true;
            this.rdoOverNight.Location = new System.Drawing.Point(74, 15);
            this.rdoOverNight.Margin = new System.Windows.Forms.Padding(2);
            this.rdoOverNight.Name = "rdoOverNight";
            this.rdoOverNight.Size = new System.Drawing.Size(73, 17);
            this.rdoOverNight.TabIndex = 1;
            this.rdoOverNight.Text = "OverNight";
            this.rdoOverNight.UseVisualStyleBackColor = true;
            // 
            // rdoHour
            // 
            this.rdoHour.AutoSize = true;
            this.rdoHour.Checked = true;
            this.rdoHour.Location = new System.Drawing.Point(5, 15);
            this.rdoHour.Margin = new System.Windows.Forms.Padding(2);
            this.rdoHour.Name = "rdoHour";
            this.rdoHour.Size = new System.Drawing.Size(48, 17);
            this.rdoHour.TabIndex = 0;
            this.rdoHour.TabStop = true;
            this.rdoHour.Text = "Hour";
            this.rdoHour.UseVisualStyleBackColor = true;
            this.rdoHour.CheckedChanged += new System.EventHandler(this.rdoHour_CheckedChanged);
            // 
            // lbProvisionalMoney
            // 
            this.lbProvisionalMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbProvisionalMoney.Enabled = false;
            this.lbProvisionalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbProvisionalMoney.Location = new System.Drawing.Point(121, 444);
            this.lbProvisionalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProvisionalMoney.Name = "lbProvisionalMoney";
            this.lbProvisionalMoney.Size = new System.Drawing.Size(181, 30);
            this.lbProvisionalMoney.TabIndex = 88;
            this.lbProvisionalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(45, 444);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 30);
            this.label7.TabIndex = 87;
            this.label7.Text = "Provisional Money";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFirstHour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbDay);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbNormalHour);
            this.groupBox1.Controls.Add(this.lbOverNight);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(195, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(244, 64);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // lbFirstHour
            // 
            this.lbFirstHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFirstHour.Enabled = false;
            this.lbFirstHour.Location = new System.Drawing.Point(69, 18);
            this.lbFirstHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstHour.Name = "lbFirstHour";
            this.lbFirstHour.Size = new System.Drawing.Size(46, 13);
            this.lbFirstHour.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "FirstHour";
            // 
            // lbDay
            // 
            this.lbDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDay.Enabled = false;
            this.lbDay.Location = new System.Drawing.Point(185, 42);
            this.lbDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(46, 13);
            this.lbDay.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "OverNight";
            // 
            // lbNormalHour
            // 
            this.lbNormalHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNormalHour.Enabled = false;
            this.lbNormalHour.Location = new System.Drawing.Point(185, 17);
            this.lbNormalHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNormalHour.Name = "lbNormalHour";
            this.lbNormalHour.Size = new System.Drawing.Size(46, 13);
            this.lbNormalHour.TabIndex = 55;
            // 
            // lbOverNight
            // 
            this.lbOverNight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOverNight.Enabled = false;
            this.lbOverNight.Location = new System.Drawing.Point(69, 43);
            this.lbOverNight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOverNight.Name = "lbOverNight";
            this.lbOverNight.Size = new System.Drawing.Size(46, 13);
            this.lbOverNight.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "NormalHour";
            // 
            // cbTimeCheckin
            // 
            this.cbTimeCheckin.Enabled = false;
            this.cbTimeCheckin.Location = new System.Drawing.Point(310, 274);
            this.cbTimeCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeCheckin.Name = "cbTimeCheckin";
            this.cbTimeCheckin.Size = new System.Drawing.Size(52, 20);
            this.cbTimeCheckin.TabIndex = 85;
            this.cbTimeCheckin.Text = "Set";
            this.cbTimeCheckin.UseVisualStyleBackColor = true;
            this.cbTimeCheckin.CheckedChanged += new System.EventHandler(this.cbTimeCheckin_CheckedChanged);
            // 
            // dtpTimeCheckout
            // 
            this.dtpTimeCheckout.Enabled = false;
            this.dtpTimeCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeCheckout.Location = new System.Drawing.Point(121, 317);
            this.dtpTimeCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeCheckout.Name = "dtpTimeCheckout";
            this.dtpTimeCheckout.Size = new System.Drawing.Size(182, 20);
            this.dtpTimeCheckout.TabIndex = 82;
            this.dtpTimeCheckout.ValueChanged += new System.EventHandler(this.dtpTimeCheckout_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Time check out";
            // 
            // lbNameEmployee
            // 
            this.lbNameEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameEmployee.Enabled = false;
            this.lbNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameEmployee.Location = new System.Drawing.Point(121, 359);
            this.lbNameEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameEmployee.Name = "lbNameEmployee";
            this.lbNameEmployee.Size = new System.Drawing.Size(272, 13);
            this.lbNameEmployee.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Employee";
            // 
            // dtpTimeCheckin
            // 
            this.dtpTimeCheckin.Enabled = false;
            this.dtpTimeCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeCheckin.Location = new System.Drawing.Point(121, 274);
            this.dtpTimeCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeCheckin.MaxDate = new System.DateTime(2032, 12, 31, 0, 0, 0, 0);
            this.dtpTimeCheckin.Name = "dtpTimeCheckin";
            this.dtpTimeCheckin.Size = new System.Drawing.Size(182, 20);
            this.dtpTimeCheckin.TabIndex = 78;
            this.dtpTimeCheckin.ValueChanged += new System.EventHandler(this.dtpTimeCheckin_ValueChanged);
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Enabled = false;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "EMPTY",
            "COMING",
            "FULL",
            "DIRTY",
            "REPAIR",
            "TIME\'S UP"});
            this.cbbStatus.Location = new System.Drawing.Point(121, 234);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(182, 21);
            this.cbbStatus.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Time check in";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Status";
            // 
            // lbRank
            // 
            this.lbRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRank.Enabled = false;
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRank.Location = new System.Drawing.Point(121, 190);
            this.lbRank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(66, 20);
            this.lbRank.TabIndex = 74;
            this.lbRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Rank";
            // 
            // lbSize
            // 
            this.lbSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSize.Enabled = false;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSize.Location = new System.Drawing.Point(121, 153);
            this.lbSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(66, 20);
            this.lbSize.TabIndex = 72;
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Size";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(123, 115);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.MaxLength = 12;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(271, 20);
            this.txtID.TabIndex = 70;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "IDCustomer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "NameCustomer";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(123, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 20);
            this.txtName.TabIndex = 67;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lbRoomCode
            // 
            this.lbRoomCode.AutoSize = true;
            this.lbRoomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRoomCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbRoomCode.Location = new System.Drawing.Point(189, 31);
            this.lbRoomCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRoomCode.Name = "lbRoomCode";
            this.lbRoomCode.Size = new System.Drawing.Size(0, 31);
            this.lbRoomCode.TabIndex = 66;
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
            this.btnReload.Location = new System.Drawing.Point(391, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(29, 28);
            this.btnReload.TabIndex = 16;
            this.btnReload.TextColor = System.Drawing.Color.White;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormBookSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 686);
            this.Controls.Add(this.pnInFoSingle);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lbCOMING);
            this.Controls.Add(this.lbAOT);
            this.Controls.Add(this.lbREPAIR);
            this.Controls.Add(this.btnFilterTime);
            this.Controls.Add(this.btnFilterStatus);
            this.Controls.Add(this.lbEMPTY);
            this.Controls.Add(this.lbDIRTY);
            this.Controls.Add(this.lbFULL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTimeFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbStatusFilter);
            this.Controls.Add(this.fpnRoomDiagram);
            this.Controls.Add(this.lbBorderStatus);
            this.Controls.Add(this.lbBorderTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBookSingle";
            this.Load += new System.EventHandler(this.FormBookSingle_Load);
            this.EnabledChanged += new System.EventHandler(this.FormBookSingle_EnabledChanged);
            this.pnInFoSingle.ResumeLayout(false);
            this.pnInFoSingle.PerformLayout();
            this.grbTypeRental.ResumeLayout(false);
            this.grbTypeRental.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnRoomDiagram;
        private System.Windows.Forms.ComboBox cbbStatusFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTimeFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFULL;
        private System.Windows.Forms.Label lbEMPTY;
        private System.Windows.Forms.Label lbDIRTY;
        private System.Windows.Forms.Button btnFilterStatus;
        private System.Windows.Forms.Label lbREPAIR;
        private System.Windows.Forms.Button btnFilterTime;
        private System.Windows.Forms.Label lbBorderStatus;
        private System.Windows.Forms.Label lbBorderTime;
        private System.Windows.Forms.Label lbCOMING;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbAOT;
        private CCricleButton btnReload;
        private System.Windows.Forms.Panel pnInFoSingle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNODay;
        private System.Windows.Forms.GroupBox grbTypeRental;
        private System.Windows.Forms.RadioButton rdoDay;
        private System.Windows.Forms.RadioButton rdoOverNight;
        private System.Windows.Forms.RadioButton rdoHour;
        private System.Windows.Forms.Label lbProvisionalMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbFirstHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbNormalHour;
        private System.Windows.Forms.Label lbOverNight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbTimeCheckin;
        private System.Windows.Forms.DateTimePicker dtpTimeCheckout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNameEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTimeCheckin;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbRoomCode;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCancel;
    }
}