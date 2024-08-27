namespace Quanlykhachsan
{
    partial class TypeRoomMngForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSize = new System.Windows.Forms.TabPage();
            this.btnSave_Size = new System.Windows.Forms.Button();
            this.btnCancel_Size = new System.Windows.Forms.Button();
            this.txtNewSizeRoom = new System.Windows.Forms.TextBox();
            this.cbbSizeRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus_Size = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete_Size = new System.Windows.Forms.Button();
            this.btnModify_Size = new System.Windows.Forms.Button();
            this.btnAdd_Size = new System.Windows.Forms.Button();
            this.dgvSize = new System.Windows.Forms.DataGridView();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpRank = new System.Windows.Forms.TabPage();
            this.btnSave_Rank = new System.Windows.Forms.Button();
            this.txtNewRankRoom = new System.Windows.Forms.TextBox();
            this.cbbRankRoom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete_Rank = new System.Windows.Forms.Button();
            this.btnModify_Rank = new System.Windows.Forms.Button();
            this.lbStatus_Rank = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd_Rank = new System.Windows.Forms.Button();
            this.dgvRank = new System.Windows.Forms.DataGridView();
            this.Rankcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel_Rank = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            this.tpRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSize);
            this.tabControl1.Controls.Add(this.tpRank);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(286, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSize
            // 
            this.tpSize.Controls.Add(this.btnSave_Size);
            this.tpSize.Controls.Add(this.btnCancel_Size);
            this.tpSize.Controls.Add(this.txtNewSizeRoom);
            this.tpSize.Controls.Add(this.cbbSizeRoom);
            this.tpSize.Controls.Add(this.label5);
            this.tpSize.Controls.Add(this.label1);
            this.tpSize.Controls.Add(this.lbStatus_Size);
            this.tpSize.Controls.Add(this.label3);
            this.tpSize.Controls.Add(this.btnDelete_Size);
            this.tpSize.Controls.Add(this.btnModify_Size);
            this.tpSize.Controls.Add(this.btnAdd_Size);
            this.tpSize.Controls.Add(this.dgvSize);
            this.tpSize.Location = new System.Drawing.Point(4, 22);
            this.tpSize.Margin = new System.Windows.Forms.Padding(2);
            this.tpSize.Name = "tpSize";
            this.tpSize.Padding = new System.Windows.Forms.Padding(2);
            this.tpSize.Size = new System.Drawing.Size(278, 320);
            this.tpSize.TabIndex = 0;
            this.tpSize.Text = "RoomSize";
            this.tpSize.UseVisualStyleBackColor = true;
            // 
            // btnSave_Size
            // 
            this.btnSave_Size.Location = new System.Drawing.Point(206, 188);
            this.btnSave_Size.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave_Size.Name = "btnSave_Size";
            this.btnSave_Size.Size = new System.Drawing.Size(56, 28);
            this.btnSave_Size.TabIndex = 4;
            this.btnSave_Size.Text = "Save";
            this.btnSave_Size.UseVisualStyleBackColor = true;
            this.btnSave_Size.Click += new System.EventHandler(this.btnSave_Size_Click);
            // 
            // btnCancel_Size
            // 
            this.btnCancel_Size.Location = new System.Drawing.Point(206, 188);
            this.btnCancel_Size.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel_Size.Name = "btnCancel_Size";
            this.btnCancel_Size.Size = new System.Drawing.Size(56, 28);
            this.btnCancel_Size.TabIndex = 18;
            this.btnCancel_Size.Text = "Cancel";
            this.btnCancel_Size.UseVisualStyleBackColor = true;
            this.btnCancel_Size.Click += new System.EventHandler(this.btnCancel_Size_Click);
            // 
            // txtNewSizeRoom
            // 
            this.txtNewSizeRoom.Location = new System.Drawing.Point(199, 81);
            this.txtNewSizeRoom.MaxLength = 9;
            this.txtNewSizeRoom.Name = "txtNewSizeRoom";
            this.txtNewSizeRoom.Size = new System.Drawing.Size(76, 20);
            this.txtNewSizeRoom.TabIndex = 17;
            this.txtNewSizeRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewSizeRoom_KeyPress);
            // 
            // cbbSizeRoom
            // 
            this.cbbSizeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSizeRoom.FormattingEnabled = true;
            this.cbbSizeRoom.Location = new System.Drawing.Point(199, 41);
            this.cbbSizeRoom.Name = "cbbSizeRoom";
            this.cbbSizeRoom.Size = new System.Drawing.Size(76, 21);
            this.cbbSizeRoom.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "New SizeRoom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "SizeRoom";
            // 
            // lbStatus_Size
            // 
            this.lbStatus_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus_Size.ForeColor = System.Drawing.Color.Red;
            this.lbStatus_Size.Location = new System.Drawing.Point(114, 254);
            this.lbStatus_Size.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus_Size.Name = "lbStatus_Size";
            this.lbStatus_Size.Size = new System.Drawing.Size(161, 55);
            this.lbStatus_Size.TabIndex = 10;
            this.lbStatus_Size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(155, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "****Status****";
            // 
            // btnDelete_Size
            // 
            this.btnDelete_Size.Location = new System.Drawing.Point(125, 188);
            this.btnDelete_Size.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete_Size.Name = "btnDelete_Size";
            this.btnDelete_Size.Size = new System.Drawing.Size(56, 28);
            this.btnDelete_Size.TabIndex = 3;
            this.btnDelete_Size.Text = "Delete";
            this.btnDelete_Size.UseVisualStyleBackColor = true;
            this.btnDelete_Size.Click += new System.EventHandler(this.btnDelete_Size_Click);
            // 
            // btnModify_Size
            // 
            this.btnModify_Size.Location = new System.Drawing.Point(206, 129);
            this.btnModify_Size.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify_Size.Name = "btnModify_Size";
            this.btnModify_Size.Size = new System.Drawing.Size(56, 28);
            this.btnModify_Size.TabIndex = 2;
            this.btnModify_Size.Text = "Modify";
            this.btnModify_Size.UseVisualStyleBackColor = true;
            this.btnModify_Size.Click += new System.EventHandler(this.btnModify_Size_Click);
            // 
            // btnAdd_Size
            // 
            this.btnAdd_Size.Location = new System.Drawing.Point(125, 129);
            this.btnAdd_Size.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd_Size.Name = "btnAdd_Size";
            this.btnAdd_Size.Size = new System.Drawing.Size(56, 28);
            this.btnAdd_Size.TabIndex = 1;
            this.btnAdd_Size.Text = "Add";
            this.btnAdd_Size.UseVisualStyleBackColor = true;
            this.btnAdd_Size.Click += new System.EventHandler(this.btnAdd_Size_Click);
            // 
            // dgvSize
            // 
            this.dgvSize.AllowUserToAddRows = false;
            this.dgvSize.AllowUserToResizeColumns = false;
            this.dgvSize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSize.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSize.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSize.ColumnHeadersHeight = 29;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SizeColumn});
            this.dgvSize.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvSize.Location = new System.Drawing.Point(4, 20);
            this.dgvSize.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.ReadOnly = true;
            this.dgvSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSize.RowHeadersVisible = false;
            this.dgvSize.RowHeadersWidth = 51;
            this.dgvSize.RowTemplate.Height = 24;
            this.dgvSize.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSize.Size = new System.Drawing.Size(102, 289);
            this.dgvSize.TabIndex = 0;
            this.dgvSize.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSize_CellClick);
            // 
            // SizeColumn
            // 
            this.SizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SizeColumn.DataPropertyName = "int";
            this.SizeColumn.HeaderText = " Size Of Room";
            this.SizeColumn.MinimumWidth = 6;
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.ReadOnly = true;
            // 
            // tpRank
            // 
            this.tpRank.Controls.Add(this.btnSave_Rank);
            this.tpRank.Controls.Add(this.txtNewRankRoom);
            this.tpRank.Controls.Add(this.cbbRankRoom);
            this.tpRank.Controls.Add(this.label6);
            this.tpRank.Controls.Add(this.label7);
            this.tpRank.Controls.Add(this.btnDelete_Rank);
            this.tpRank.Controls.Add(this.btnModify_Rank);
            this.tpRank.Controls.Add(this.lbStatus_Rank);
            this.tpRank.Controls.Add(this.label4);
            this.tpRank.Controls.Add(this.btnAdd_Rank);
            this.tpRank.Controls.Add(this.dgvRank);
            this.tpRank.Controls.Add(this.btnCancel_Rank);
            this.tpRank.Location = new System.Drawing.Point(4, 22);
            this.tpRank.Margin = new System.Windows.Forms.Padding(2);
            this.tpRank.Name = "tpRank";
            this.tpRank.Padding = new System.Windows.Forms.Padding(2);
            this.tpRank.Size = new System.Drawing.Size(278, 320);
            this.tpRank.TabIndex = 1;
            this.tpRank.Text = "RoomRank";
            this.tpRank.UseVisualStyleBackColor = true;
            // 
            // btnSave_Rank
            // 
            this.btnSave_Rank.Location = new System.Drawing.Point(206, 188);
            this.btnSave_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave_Rank.Name = "btnSave_Rank";
            this.btnSave_Rank.Size = new System.Drawing.Size(56, 28);
            this.btnSave_Rank.TabIndex = 8;
            this.btnSave_Rank.Text = "Save";
            this.btnSave_Rank.UseVisualStyleBackColor = true;
            this.btnSave_Rank.Click += new System.EventHandler(this.btnSave_Rank_Click);
            // 
            // txtNewRankRoom
            // 
            this.txtNewRankRoom.Location = new System.Drawing.Point(199, 81);
            this.txtNewRankRoom.MaxLength = 15;
            this.txtNewRankRoom.Name = "txtNewRankRoom";
            this.txtNewRankRoom.Size = new System.Drawing.Size(76, 20);
            this.txtNewRankRoom.TabIndex = 21;
            this.txtNewRankRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewRankRoom_KeyPress);
            // 
            // cbbRankRoom
            // 
            this.cbbRankRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRankRoom.FormattingEnabled = true;
            this.cbbRankRoom.Location = new System.Drawing.Point(199, 41);
            this.cbbRankRoom.Name = "cbbRankRoom";
            this.cbbRankRoom.Size = new System.Drawing.Size(76, 21);
            this.cbbRankRoom.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "New RankRoom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "RankRoom";
            // 
            // btnDelete_Rank
            // 
            this.btnDelete_Rank.Location = new System.Drawing.Point(125, 188);
            this.btnDelete_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete_Rank.Name = "btnDelete_Rank";
            this.btnDelete_Rank.Size = new System.Drawing.Size(56, 28);
            this.btnDelete_Rank.TabIndex = 7;
            this.btnDelete_Rank.Text = "Delete";
            this.btnDelete_Rank.UseVisualStyleBackColor = true;
            this.btnDelete_Rank.Click += new System.EventHandler(this.btnDelete_Rank_Click);
            // 
            // btnModify_Rank
            // 
            this.btnModify_Rank.Location = new System.Drawing.Point(206, 129);
            this.btnModify_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify_Rank.Name = "btnModify_Rank";
            this.btnModify_Rank.Size = new System.Drawing.Size(56, 28);
            this.btnModify_Rank.TabIndex = 6;
            this.btnModify_Rank.Text = "Modify";
            this.btnModify_Rank.UseVisualStyleBackColor = true;
            this.btnModify_Rank.Click += new System.EventHandler(this.btnModify_Rank_Click);
            // 
            // lbStatus_Rank
            // 
            this.lbStatus_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus_Rank.ForeColor = System.Drawing.Color.Red;
            this.lbStatus_Rank.Location = new System.Drawing.Point(114, 254);
            this.lbStatus_Rank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus_Rank.Name = "lbStatus_Rank";
            this.lbStatus_Rank.Size = new System.Drawing.Size(161, 55);
            this.lbStatus_Rank.TabIndex = 5;
            this.lbStatus_Rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(155, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "****Status****";
            // 
            // btnAdd_Rank
            // 
            this.btnAdd_Rank.Location = new System.Drawing.Point(125, 129);
            this.btnAdd_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd_Rank.Name = "btnAdd_Rank";
            this.btnAdd_Rank.Size = new System.Drawing.Size(56, 28);
            this.btnAdd_Rank.TabIndex = 1;
            this.btnAdd_Rank.Text = "Add";
            this.btnAdd_Rank.UseVisualStyleBackColor = true;
            this.btnAdd_Rank.Click += new System.EventHandler(this.btnAdd_Rank_Click);
            // 
            // dgvRank
            // 
            this.dgvRank.AllowUserToAddRows = false;
            this.dgvRank.AllowUserToResizeColumns = false;
            this.dgvRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRank.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRank.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRank.ColumnHeadersHeight = 29;
            this.dgvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rankcolumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRank.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRank.Location = new System.Drawing.Point(4, 20);
            this.dgvRank.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRank.Name = "dgvRank";
            this.dgvRank.ReadOnly = true;
            this.dgvRank.RowHeadersVisible = false;
            this.dgvRank.RowHeadersWidth = 51;
            this.dgvRank.RowTemplate.Height = 24;
            this.dgvRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRank.Size = new System.Drawing.Size(102, 289);
            this.dgvRank.TabIndex = 0;
            this.dgvRank.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRank_CellClick);
            // 
            // Rankcolumn
            // 
            this.Rankcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rankcolumn.HeaderText = "Rank Of Room";
            this.Rankcolumn.MinimumWidth = 6;
            this.Rankcolumn.Name = "Rankcolumn";
            this.Rankcolumn.ReadOnly = true;
            // 
            // btnCancel_Rank
            // 
            this.btnCancel_Rank.Location = new System.Drawing.Point(206, 188);
            this.btnCancel_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel_Rank.Name = "btnCancel_Rank";
            this.btnCancel_Rank.Size = new System.Drawing.Size(56, 28);
            this.btnCancel_Rank.TabIndex = 22;
            this.btnCancel_Rank.Text = "Cancel";
            this.btnCancel_Rank.UseVisualStyleBackColor = true;
            this.btnCancel_Rank.Click += new System.EventHandler(this.btnCancel_Rank_Click);
            // 
            // TypeRoomMngForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 366);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(600, 230);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TypeRoomMngForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TypeRoomManagement";
            this.Load += new System.EventHandler(this.TypeRoomMngForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSize.ResumeLayout(false);
            this.tpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            this.tpRank.ResumeLayout(false);
            this.tpRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSize;
        private System.Windows.Forms.TabPage tpRank;
        private System.Windows.Forms.Button btnSave_Size;
        private System.Windows.Forms.Button btnDelete_Size;
        private System.Windows.Forms.Button btnModify_Size;
        private System.Windows.Forms.Button btnAdd_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus_Size;
        private System.Windows.Forms.DataGridView dgvRank;
        private System.Windows.Forms.Button btnSave_Rank;
        private System.Windows.Forms.Button btnDelete_Rank;
        private System.Windows.Forms.Button btnModify_Rank;
        private System.Windows.Forms.Label lbStatus_Rank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd_Rank;
        private System.Windows.Forms.Button btnCancel_Size;
        private System.Windows.Forms.TextBox txtNewSizeRoom;
        private System.Windows.Forms.ComboBox cbbSizeRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewRankRoom;
        private System.Windows.Forms.ComboBox cbbRankRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel_Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rankcolumn;
        private System.Windows.Forms.DataGridView dgvSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
    }
}
