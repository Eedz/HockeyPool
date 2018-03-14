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
            this.cmdEnterGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyDataDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEnterGame
            // 
            this.cmdEnterGame.Location = new System.Drawing.Point(47, 62);
            this.cmdEnterGame.Name = "cmdEnterGame";
            this.cmdEnterGame.Size = new System.Drawing.Size(120, 30);
            this.cmdEnterGame.TabIndex = 0;
            this.cmdEnterGame.Text = "Enter Game Result";
            this.cmdEnterGame.UseVisualStyleBackColor = true;
            this.cmdEnterGame.Click += new System.EventHandler(this.cmdEnterGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
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
            this.peopleDataGridView.Location = new System.Drawing.Point(276, 74);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.ReadOnly = true;
            this.peopleDataGridView.RowHeadersVisible = false;
            this.peopleDataGridView.Size = new System.Drawing.Size(208, 113);
            this.peopleDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn3.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            this.cmd1Dollar.Location = new System.Drawing.Point(56, 98);
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
            this.peopleListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.peopleListToolStripMenuItem.Text = "People List";
            this.peopleListToolStripMenuItem.Click += new System.EventHandler(this.peopleListToolStripMenuItem_Click);
            // 
            // gameListToolStripMenuItem
            // 
            this.gameListToolStripMenuItem.Name = "gameListToolStripMenuItem";
            this.gameListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.gameListToolStripMenuItem.Text = "Game List";
            // 
            // cmd2Dollar
            // 
            this.cmd2Dollar.Location = new System.Drawing.Point(56, 135);
            this.cmd2Dollar.Name = "cmd2Dollar";
            this.cmd2Dollar.Size = new System.Drawing.Size(100, 30);
            this.cmd2Dollar.TabIndex = 9;
            this.cmd2Dollar.Text = "$2";
            this.cmd2Dollar.UseVisualStyleBackColor = true;
            // 
            // cmd5Dollar
            // 
            this.cmd5Dollar.Location = new System.Drawing.Point(56, 171);
            this.cmd5Dollar.Name = "cmd5Dollar";
            this.cmd5Dollar.Size = new System.Drawing.Size(100, 30);
            this.cmd5Dollar.TabIndex = 10;
            this.cmd5Dollar.Text = "$5";
            this.cmd5Dollar.UseVisualStyleBackColor = true;
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // HockeyPoolMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 471);
            this.Controls.Add(this.cmd5Dollar);
            this.Controls.Add(this.cmd2Dollar);
            this.Controls.Add(this.cmd1Dollar);
            this.Controls.Add(this.peopleDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEnterGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HockeyPoolMenu";
            this.Text = "Hockey Pool Menu";
            this.Load += new System.EventHandler(this.HockeyPoolMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyDataDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEnterGame;
        private System.Windows.Forms.Label label1;
        private HockeyDataDataSet hockeyDataDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private HockeyDataDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private HockeyDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button cmd1Dollar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameListToolStripMenuItem;
        private System.Windows.Forms.Button cmd2Dollar;
        private System.Windows.Forms.Button cmd5Dollar;
        private HockeyDataDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter1;
    }
}