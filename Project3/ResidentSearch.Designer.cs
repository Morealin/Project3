namespace Project3
{
    partial class ResidentSearch
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
            this.dataShow_Resident = new System.Windows.Forms.DataGridView();
            this.resIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_ResidentsDataSet1 = new Project3.db_ResidentsDataSet1();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ResidentsDataSet = new Project3.db_ResidentsDataSet();
            this.residentTableAdapter = new Project3.db_ResidentsDataSetTableAdapters.ResidentTableAdapter();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.residentTableAdapter1 = new Project3.db_ResidentsDataSet1TableAdapters.ResidentTableAdapter();
            this.db_ResidentsDataSet2 = new Project3.db_ResidentsDataSet2();
            this.residentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.residentTableAdapter2 = new Project3.db_ResidentsDataSet2TableAdapters.ResidentTableAdapter();
            this.FloorNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow_Resident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ResidentsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ResidentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ResidentsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataShow_Resident
            // 
            this.dataShow_Resident.AutoGenerateColumns = false;
            this.dataShow_Resident.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataShow_Resident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow_Resident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.resTypeDataGridViewTextBoxColumn,
            this.FloorNum,
            this.RoomNum,
            this.Rent});
            this.dataShow_Resident.DataSource = this.residentBindingSource2;
            this.dataShow_Resident.Location = new System.Drawing.Point(60, 115);
            this.dataShow_Resident.Name = "dataShow_Resident";
            this.dataShow_Resident.RowTemplate.Height = 24;
            this.dataShow_Resident.Size = new System.Drawing.Size(746, 349);
            this.dataShow_Resident.TabIndex = 0;
            this.dataShow_Resident.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataShow_Resident_CellContentClick);
            // 
            // resIdDataGridViewTextBoxColumn
            // 
            this.resIdDataGridViewTextBoxColumn.DataPropertyName = "ResId";
            this.resIdDataGridViewTextBoxColumn.HeaderText = "ResId";
            this.resIdDataGridViewTextBoxColumn.Name = "resIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // resTypeDataGridViewTextBoxColumn
            // 
            this.resTypeDataGridViewTextBoxColumn.DataPropertyName = "ResType";
            this.resTypeDataGridViewTextBoxColumn.HeaderText = "ResType";
            this.resTypeDataGridViewTextBoxColumn.Name = "resTypeDataGridViewTextBoxColumn";
            // 
            // residentBindingSource1
            // 
            this.residentBindingSource1.DataMember = "Resident";
            this.residentBindingSource1.DataSource = this.db_ResidentsDataSet1;
            // 
            // db_ResidentsDataSet1
            // 
            this.db_ResidentsDataSet1.DataSetName = "db_ResidentsDataSet1";
            this.db_ResidentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataMember = "Resident";
            this.residentBindingSource.DataSource = this.db_ResidentsDataSet;
            // 
            // db_ResidentsDataSet
            // 
            this.db_ResidentsDataSet.DataSetName = "db_ResidentsDataSet";
            this.db_ResidentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // residentTableAdapter
            // 
            this.residentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(151, 57);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(256, 57);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(402, 22);
            this.txt_Search.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(774, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 27);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(693, 13);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 26);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // residentTableAdapter1
            // 
            this.residentTableAdapter1.ClearBeforeFill = true;
            // 
            // db_ResidentsDataSet2
            // 
            this.db_ResidentsDataSet2.DataSetName = "db_ResidentsDataSet2";
            this.db_ResidentsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // residentBindingSource2
            // 
            this.residentBindingSource2.DataMember = "Resident";
            this.residentBindingSource2.DataSource = this.db_ResidentsDataSet2;
            // 
            // residentTableAdapter2
            // 
            this.residentTableAdapter2.ClearBeforeFill = true;
            // 
            // FloorNum
            // 
            this.FloorNum.DataPropertyName = "FloorNum";
            this.FloorNum.HeaderText = "FloorNum";
            this.FloorNum.Name = "FloorNum";
            // 
            // RoomNum
            // 
            this.RoomNum.DataPropertyName = "RoomNum";
            this.RoomNum.HeaderText = "RoomNum";
            this.RoomNum.Name = "RoomNum";
            // 
            // Rent
            // 
            this.Rent.DataPropertyName = "Rent";
            this.Rent.HeaderText = "Rent";
            this.Rent.Name = "Rent";
            // 
            // ResidentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 509);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataShow_Resident);
            this.Name = "ResidentSearch";
            this.Text = "ResidentSearch";
            this.Load += new System.EventHandler(this.ResidentSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataShow_Resident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ResidentsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ResidentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ResidentsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataShow_Resident;
        private db_ResidentsDataSet db_ResidentsDataSet;
        private System.Windows.Forms.BindingSource residentBindingSource;
        private db_ResidentsDataSetTableAdapters.ResidentTableAdapter residentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Back;
        private db_ResidentsDataSet1 db_ResidentsDataSet1;
        private System.Windows.Forms.BindingSource residentBindingSource1;
        private db_ResidentsDataSet1TableAdapters.ResidentTableAdapter residentTableAdapter1;
        private db_ResidentsDataSet2 db_ResidentsDataSet2;
        private System.Windows.Forms.BindingSource residentBindingSource2;
        private db_ResidentsDataSet2TableAdapters.ResidentTableAdapter residentTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent;
    }
}