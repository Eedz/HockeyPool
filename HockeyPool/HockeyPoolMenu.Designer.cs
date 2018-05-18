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
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hockeyDataDataSet = new HockeyPool.HockeyDataDataSet();
            this.peopleTableAdapter = new HockeyPool.HockeyDataDataSetTableAdapters.PeopleTableAdapter();
            this.tableAdapterManager = new HockeyPool.HockeyDataDataSetTableAdapters.TableAdapterManager();
            this.cmd1Dollar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd2Dollar = new System.Windows.Forms.Button();
            this.cmd5Dollar = new System.Windows.Forms.Button();
            this.teamsTableAdapter1 = new HockeyPool.HockeyDataDataSetTableAdapters.TeamsTableAdapter();
            this.dataGridSchedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyDataDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.hockeyDataDataSet;
            // 
            // hockeyDataDataSet
            // 
            this.hockeyDataDataSet.DataSetName = "HockeyDataDataSet";
            this.hockeyDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BetsTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.PeopleTableAdapter = this.peopleTableAdapter;
            this.tableAdapterManager.TeamsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HockeyPool.HockeyDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmd1Dollar
            // 
            this.cmd1Dollar.Location = new System.Drawing.Point(58, 55);
            this.cmd1Dollar.Name = "cmd1Dollar";
            this.cmd1Dollar.Size = new System.Drawing.Size(100, 30);
            this.cmd1Dollar.TabIndex = 7;
            this.cmd1Dollar.Text = "$1";
            this.cmd1Dollar.UseVisualStyleBackColor = true;
            this.cmd1Dollar.Click += new System.EventHandler(this.cmd1Dollar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleListToolStripMenuItem,
            this.gameListToolStripMenuItem});
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.peopleToolStripMenuItem.Text = "View";
            // 
            // peopleListToolStripMenuItem
            // 
            this.peopleListToolStripMenuItem.Name = "peopleListToolStripMenuItem";
            this.peopleListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peopleListToolStripMenuItem.Text = "People List";
            this.peopleListToolStripMenuItem.Click += new System.EventHandler(this.peopleListToolStripMenuItem_Click);
            // 
            // gameListToolStripMenuItem
            // 
            this.gameListToolStripMenuItem.Name = "gameListToolStripMenuItem";
            this.gameListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameListToolStripMenuItem.Text = "Game List";
            // 
            // cmd2Dollar
            // 
            this.cmd2Dollar.Location = new System.Drawing.Point(58, 92);
            this.cmd2Dollar.Name = "cmd2Dollar";
            this.cmd2Dollar.Size = new System.Drawing.Size(100, 30);
            this.cmd2Dollar.TabIndex = 9;
            this.cmd2Dollar.Text = "$2";
            this.cmd2Dollar.UseVisualStyleBackColor = true;
            this.cmd2Dollar.Click += new System.EventHandler(this.cmd2Dollar_Click);
            // 
            // cmd5Dollar
            // 
            this.cmd5Dollar.Location = new System.Drawing.Point(58, 128);
            this.cmd5Dollar.Name = "cmd5Dollar";
            this.cmd5Dollar.Size = new System.Drawing.Size(100, 30);
            this.cmd5Dollar.TabIndex = 10;
            this.cmd5Dollar.Text = "$5";
            this.cmd5Dollar.UseVisualStyleBackColor = true;
            this.cmd5Dollar.Click += new System.EventHandler(this.cmd5Dollar_Click);
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridSchedule
            // 
            this.dataGridSchedule.AllowUserToAddRows = false;
            this.dataGridSchedule.AllowUserToDeleteRows = false;
            this.dataGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSchedule.Location = new System.Drawing.Point(209, 55);
            this.dataGridSchedule.Name = "dataGridSchedule";
            this.dataGridSchedule.ReadOnly = true;
            this.dataGridSchedule.RowHeadersVisible = false;
            this.dataGridSchedule.Size = new System.Drawing.Size(249, 172);
            this.dataGridSchedule.TabIndex = 11;
            this.dataGridSchedule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridSchedule_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leaderboard";
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.AllowUserToAddRows = false;
            this.peopleDataGridView.AllowUserToDeleteRows = false;
            this.peopleDataGridView.AutoGenerateColumns = false;
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.peopleDataGridView.DataSource = this.peopleBindingSource;
            this.peopleDataGridView.Location = new System.Drawing.Point(10, 43);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.ReadOnly = true;
            this.peopleDataGridView.RowHeadersVisible = false;
            this.peopleDataGridView.Size = new System.Drawing.Size(249, 113);
            this.peopleDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn3.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.peopleDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(199, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 168);
            this.panel1.TabIndex = 13;
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.Location = new System.Drawing.Point(209, 29);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(248, 20);
            this.dtpSchedule.TabIndex = 14;
            this.dtpSchedule.ValueChanged += new System.EventHandler(this.dtpSchedule_ValueChanged);
            // 
            // HockeyPoolMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 471);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridSchedule);
            this.Controls.Add(this.cmd5Dollar);
            this.Controls.Add(this.cmd2Dollar);
            this.Controls.Add(this.cmd1Dollar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HockeyPoolMenu";
            this.Text = "Hockey Pool Menu";
            this.Load += new System.EventHandler(this.HockeyPoolMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyDataDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HockeyDataDataSet hockeyDataDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private HockeyDataDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private HockeyDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button cmd1Dollar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameListToolStripMenuItem;
        private System.Windows.Forms.Button cmd2Dollar;
        private System.Windows.Forms.Button cmd5Dollar;
        private HockeyDataDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
    }
}