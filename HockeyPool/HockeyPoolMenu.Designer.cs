namespace HockeyPool
{
    partial class HockeyPoolMenu
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
            System.Windows.Forms.Label betPoolLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmd1Dollar = new System.Windows.Forms.Button();
            this.cmd2Dollar = new System.Windows.Forms.Button();
            this.cmd5Dollar = new System.Windows.Forms.Button();
            this.dataGridSchedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hockeyPoolDataSet = new HockeyPool.HockeyPoolDataSet();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAddMoney = new System.Windows.Forms.Button();
            this.cmdPreviousDay = new System.Windows.Forms.Button();
            this.cmdNextDay = new System.Windows.Forms.Button();
            this.betPoolTextBox = new System.Windows.Forms.TextBox();
            this.tblBetPoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridSquares = new System.Windows.Forms.DataGridView();
            this.txtHomeTeamLabel = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblUsersTableAdapter = new HockeyPool.HockeyPoolDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new HockeyPool.HockeyPoolDataSetTableAdapters.TableAdapterManager();
            this.tblBetsTableAdapter = new HockeyPool.HockeyPoolDataSetTableAdapters.tblBetsTableAdapter();
            this.tblBetPoolTableAdapter = new HockeyPool.HockeyPoolDataSetTableAdapters.tblBetPoolTableAdapter();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            betPoolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyPoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBetPoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSquares)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // betPoolLabel
            // 
            betPoolLabel.AutoSize = true;
            betPoolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            betPoolLabel.Location = new System.Drawing.Point(229, 55);
            betPoolLabel.Name = "betPoolLabel";
            betPoolLabel.Size = new System.Drawing.Size(69, 18);
            betPoolLabel.TabIndex = 21;
            betPoolLabel.Text = "Bet Pool:";
            // 
            // cmd1Dollar
            // 
            this.cmd1Dollar.BackColor = System.Drawing.Color.SandyBrown;
            this.cmd1Dollar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd1Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1Dollar.Location = new System.Drawing.Point(7, 292);
            this.cmd1Dollar.Name = "cmd1Dollar";
            this.cmd1Dollar.Size = new System.Drawing.Size(78, 26);
            this.cmd1Dollar.TabIndex = 7;
            this.cmd1Dollar.Text = "$1";
            this.cmd1Dollar.UseVisualStyleBackColor = false;
            this.cmd1Dollar.Click += new System.EventHandler(this.cmd1Dollar_Click);
            // 
            // cmd2Dollar
            // 
            this.cmd2Dollar.BackColor = System.Drawing.Color.SandyBrown;
            this.cmd2Dollar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd2Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2Dollar.Location = new System.Drawing.Point(110, 292);
            this.cmd2Dollar.Name = "cmd2Dollar";
            this.cmd2Dollar.Size = new System.Drawing.Size(78, 26);
            this.cmd2Dollar.TabIndex = 9;
            this.cmd2Dollar.Text = "$2";
            this.cmd2Dollar.UseVisualStyleBackColor = false;
            this.cmd2Dollar.Click += new System.EventHandler(this.cmd2Dollar_Click);
            // 
            // cmd5Dollar
            // 
            this.cmd5Dollar.BackColor = System.Drawing.Color.SandyBrown;
            this.cmd5Dollar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmd5Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd5Dollar.Location = new System.Drawing.Point(211, 292);
            this.cmd5Dollar.Name = "cmd5Dollar";
            this.cmd5Dollar.Size = new System.Drawing.Size(78, 26);
            this.cmd5Dollar.TabIndex = 10;
            this.cmd5Dollar.Text = "$5";
            this.cmd5Dollar.UseVisualStyleBackColor = false;
            this.cmd5Dollar.Click += new System.EventHandler(this.cmd5Dollar_Click);
            // 
            // dataGridSchedule
            // 
            this.dataGridSchedule.AllowUserToAddRows = false;
            this.dataGridSchedule.AllowUserToDeleteRows = false;
            this.dataGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSchedule.Location = new System.Drawing.Point(7, 156);
            this.dataGridSchedule.Name = "dataGridSchedule";
            this.dataGridSchedule.ReadOnly = true;
            this.dataGridSchedule.RowHeadersVisible = false;
            this.dataGridSchedule.Size = new System.Drawing.Size(282, 78);
            this.dataGridSchedule.TabIndex = 11;
            this.dataGridSchedule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridSchedule_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leaderboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblUsersDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 182);
            this.panel1.TabIndex = 13;
            // 
            // tblUsersDataGridView
            // 
            this.tblUsersDataGridView.AllowUserToAddRows = false;
            this.tblUsersDataGridView.AllowUserToDeleteRows = false;
            this.tblUsersDataGridView.AutoGenerateColumns = false;
            this.tblUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tblUsersDataGridView.DataSource = this.tblUsersBindingSource;
            this.tblUsersDataGridView.Location = new System.Drawing.Point(7, 26);
            this.tblUsersDataGridView.Name = "tblUsersDataGridView";
            this.tblUsersDataGridView.ReadOnly = true;
            this.tblUsersDataGridView.RowHeadersVisible = false;
            this.tblUsersDataGridView.Size = new System.Drawing.Size(282, 147);
            this.tblUsersDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "balance";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.hockeyPoolDataSet;
            // 
            // hockeyPoolDataSet
            // 
            this.hockeyPoolDataSet.DataSetName = "HockeyPoolDataSet";
            this.hockeyPoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSchedule.Location = new System.Drawing.Point(32, 130);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(232, 21);
            this.dtpSchedule.TabIndex = 14;
            this.dtpSchedule.ValueChanged += new System.EventHandler(this.dtpSchedule_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Make a Bet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dad\'s Hockey Pool";
            // 
            // cmdAddMoney
            // 
            this.cmdAddMoney.BackColor = System.Drawing.Color.SandyBrown;
            this.cmdAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddMoney.Location = new System.Drawing.Point(110, 240);
            this.cmdAddMoney.Name = "cmdAddMoney";
            this.cmdAddMoney.Size = new System.Drawing.Size(78, 26);
            this.cmdAddMoney.TabIndex = 19;
            this.cmdAddMoney.Text = "Add Money";
            this.cmdAddMoney.UseVisualStyleBackColor = false;
            this.cmdAddMoney.Click += new System.EventHandler(this.cmdAddMoney_Click);
            // 
            // cmdPreviousDay
            // 
            this.cmdPreviousDay.BackColor = System.Drawing.Color.SandyBrown;
            this.cmdPreviousDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPreviousDay.Location = new System.Drawing.Point(7, 130);
            this.cmdPreviousDay.Name = "cmdPreviousDay";
            this.cmdPreviousDay.Size = new System.Drawing.Size(24, 20);
            this.cmdPreviousDay.TabIndex = 20;
            this.cmdPreviousDay.Text = "<";
            this.cmdPreviousDay.UseVisualStyleBackColor = false;
            this.cmdPreviousDay.Click += new System.EventHandler(this.cmdPreviousDay_Click);
            // 
            // cmdNextDay
            // 
            this.cmdNextDay.BackColor = System.Drawing.Color.SandyBrown;
            this.cmdNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNextDay.Location = new System.Drawing.Point(266, 130);
            this.cmdNextDay.Name = "cmdNextDay";
            this.cmdNextDay.Size = new System.Drawing.Size(23, 20);
            this.cmdNextDay.TabIndex = 21;
            this.cmdNextDay.Text = ">";
            this.cmdNextDay.UseVisualStyleBackColor = false;
            this.cmdNextDay.Click += new System.EventHandler(this.cmdNextDay_Click);
            // 
            // betPoolTextBox
            // 
            this.betPoolTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.betPoolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betPoolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBetPoolBindingSource, "BetPool", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.betPoolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betPoolTextBox.Location = new System.Drawing.Point(295, 55);
            this.betPoolTextBox.Name = "betPoolTextBox";
            this.betPoolTextBox.Size = new System.Drawing.Size(100, 17);
            this.betPoolTextBox.TabIndex = 22;
            // 
            // tblBetPoolBindingSource
            // 
            this.tblBetPoolBindingSource.DataMember = "tblBetPool";
            this.tblBetPoolBindingSource.DataSource = this.hockeyPoolDataSet;
            // 
            // gridSquares
            // 
            this.gridSquares.AllowUserToAddRows = false;
            this.gridSquares.AllowUserToDeleteRows = false;
            this.gridSquares.AllowUserToResizeColumns = false;
            this.gridSquares.AllowUserToResizeRows = false;
            this.gridSquares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSquares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSquares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSquares.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSquares.Location = new System.Drawing.Point(334, 128);
            this.gridSquares.Name = "gridSquares";
            this.gridSquares.RowHeadersWidth = 50;
            this.gridSquares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridSquares.ShowEditingIcon = false;
            this.gridSquares.Size = new System.Drawing.Size(355, 266);
            this.gridSquares.TabIndex = 24;
            // 
            // txtHomeTeamLabel
            // 
            this.txtHomeTeamLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtHomeTeamLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHomeTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeTeamLabel.Location = new System.Drawing.Point(334, 94);
            this.txtHomeTeamLabel.Name = "txtHomeTeamLabel";
            this.txtHomeTeamLabel.Size = new System.Drawing.Size(355, 23);
            this.txtHomeTeamLabel.TabIndex = 26;
            this.txtHomeTeamLabel.Text = "Home Team";
            this.txtHomeTeamLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.changeUserToolStripMenuItem.Text = "Change user...";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBetPoolTableAdapter = null;
            this.tableAdapterManager.tblBetsTableAdapter = null;
            this.tableAdapterManager.tblPwdTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = HockeyPool.HockeyPoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblBetsTableAdapter
            // 
            this.tblBetsTableAdapter.ClearBeforeFill = true;
            // 
            // tblBetPoolTableAdapter
            // 
            this.tblBetPoolTableAdapter.ClearBeforeFill = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(537, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 17);
            this.lblUser.TabIndex = 28;
            this.lblUser.Text = "Current User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HockeyPool.Properties.Resources.NHL_logo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // HockeyPoolMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(712, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtHomeTeamLabel);
            this.Controls.Add(this.gridSquares);
            this.Controls.Add(betPoolLabel);
            this.Controls.Add(this.betPoolTextBox);
            this.Controls.Add(this.cmdAddMoney);
            this.Controls.Add(this.cmdNextDay);
            this.Controls.Add(this.cmdPreviousDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridSchedule);
            this.Controls.Add(this.cmd5Dollar);
            this.Controls.Add(this.cmd2Dollar);
            this.Controls.Add(this.cmd1Dollar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HockeyPoolMenu";
            this.Text = "Dad\'s Hockey Pool";
            this.Load += new System.EventHandler(this.HockeyPoolMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyPoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBetPoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSquares)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd1Dollar;
        private System.Windows.Forms.Button cmd2Dollar;
        private System.Windows.Forms.Button cmd5Dollar;
        private System.Windows.Forms.DataGridView dataGridSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private HockeyPoolDataSet hockeyPoolDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private HockeyPoolDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private HockeyPoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblUsersDataGridView;
        private HockeyPoolDataSetTableAdapters.tblBetsTableAdapter tblBetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdAddMoney;
        private System.Windows.Forms.Button cmdPreviousDay;
        private System.Windows.Forms.Button cmdNextDay;
        private System.Windows.Forms.BindingSource tblBetPoolBindingSource;
        private HockeyPoolDataSetTableAdapters.tblBetPoolTableAdapter tblBetPoolTableAdapter;
        private System.Windows.Forms.TextBox betPoolTextBox;
        private System.Windows.Forms.DataGridView gridSquares;
        private System.Windows.Forms.TextBox txtHomeTeamLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}