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
            this.btn_Logout5 = new System.Windows.Forms.Button();
            this.btn_Back5 = new System.Windows.Forms.Button();
            this.dataShow_Residents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow_Residents)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logout5
            // 
            this.btn_Logout5.Location = new System.Drawing.Point(794, 13);
            this.btn_Logout5.Name = "btn_Logout5";
            this.btn_Logout5.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout5.TabIndex = 0;
            this.btn_Logout5.Text = "Logout";
            this.btn_Logout5.UseVisualStyleBackColor = true;
            this.btn_Logout5.Click += new System.EventHandler(this.btn_Logout5_Click);
            // 
            // btn_Back5
            // 
            this.btn_Back5.Location = new System.Drawing.Point(713, 12);
            this.btn_Back5.Name = "btn_Back5";
            this.btn_Back5.Size = new System.Drawing.Size(75, 23);
            this.btn_Back5.TabIndex = 1;
            this.btn_Back5.Text = "Back";
            this.btn_Back5.UseVisualStyleBackColor = true;
            this.btn_Back5.Click += new System.EventHandler(this.btn_Back5_Click);
            // 
            // dataShow_Residents
            // 
            this.dataShow_Residents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow_Residents.Location = new System.Drawing.Point(122, 266);
            this.dataShow_Residents.Name = "dataShow_Residents";
            this.dataShow_Residents.RowTemplate.Height = 24;
            this.dataShow_Residents.Size = new System.Drawing.Size(240, 150);
            this.dataShow_Residents.TabIndex = 2;
            this.dataShow_Residents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataShow_Resident_CellContentClick);
            // 
            // ResidentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 603);
            this.Controls.Add(this.dataShow_Residents);
            this.Controls.Add(this.btn_Back5);
            this.Controls.Add(this.btn_Logout5);
            this.Name = "ResidentSearch";
            this.Text = "ResidentSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataShow_Residents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout5;
        private System.Windows.Forms.Button btn_Back5;
        private System.Windows.Forms.DataGridView dataShow_Residents;
    }
}