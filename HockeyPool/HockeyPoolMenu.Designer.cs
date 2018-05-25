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
            this.cmd1Dollar = new System.Windows.Forms.Button();
            this.cmd2Dollar = new System.Windows.Forms.Button();
            this.cmd5Dollar = new System.Windows.Forms.Button();
            this.dataGridSchedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.hockeyPoolDataSet = new HockeyPool.HockeyPoolDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new HockeyPool.HockeyPoolDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new HockeyPool.HockeyPoolDataSetTableAdapters.TableAdapterManager();
            this.tblUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyPoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tblUsersDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(199, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 177);
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
            // hockeyPoolDataSet
            // 
            this.hockeyPoolDataSet.DataSetName = "HockeyPoolDataSet";
            this.hockeyPoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.hockeyPoolDataSet;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblPwdTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = HockeyPool.HockeyPoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tblUsersDataGridView.Location = new System.Drawing.Point(10, 33);
            this.tblUsersDataGridView.Name = "tblUsersDataGridView";
            this.tblUsersDataGridView.ReadOnly = true;
            this.tblUsersDataGridView.RowHeadersVisible = false;
            this.tblUsersDataGridView.Size = new System.Drawing.Size(248, 141);
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
            this.dataGridViewTextBoxColumn3.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // HockeyPoolMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 546);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridSchedule);
            this.Controls.Add(this.cmd5Dollar);
            this.Controls.Add(this.cmd2Dollar);
            this.Controls.Add(this.cmd1Dollar);
            this.Name = "HockeyPoolMenu";
            this.Text = "Hockey Pool Menu";
            this.Load += new System.EventHandler(this.HockeyPoolMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSchedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyPoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersDataGridView)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}