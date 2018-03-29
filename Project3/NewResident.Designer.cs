namespace Project3
{
    partial class NewResident
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
            this.btn_Logout2 = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_ResID = new System.Windows.Forms.Label();
            this.txt_ResID = new System.Windows.Forms.TextBox();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.lbl_ResType = new System.Windows.Forms.Label();
            this.drop_ResType = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.drop_Floor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Logout2
            // 
            this.btn_Logout2.Location = new System.Drawing.Point(304, 13);
            this.btn_Logout2.Name = "btn_Logout2";
            this.btn_Logout2.Size = new System.Drawing.Size(75, 32);
            this.btn_Logout2.TabIndex = 0;
            this.btn_Logout2.Text = "Logout";
            this.btn_Logout2.UseVisualStyleBackColor = true;
            this.btn_Logout2.Click += new System.EventHandler(this.btn_Logout2_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(223, 13);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 32);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_ResID
            // 
            this.lbl_ResID.AutoSize = true;
            this.lbl_ResID.Location = new System.Drawing.Point(40, 91);
            this.lbl_ResID.Name = "lbl_ResID";
            this.lbl_ResID.Size = new System.Drawing.Size(81, 17);
            this.lbl_ResID.TabIndex = 2;
            this.lbl_ResID.Text = "Resident ID";
            // 
            // txt_ResID
            // 
            this.txt_ResID.Location = new System.Drawing.Point(138, 86);
            this.txt_ResID.Name = "txt_ResID";
            this.txt_ResID.Size = new System.Drawing.Size(100, 22);
            this.txt_ResID.TabIndex = 3;
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Location = new System.Drawing.Point(46, 123);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(76, 17);
            this.lbl_FName.TabIndex = 4;
            this.lbl_FName.Text = "First Name";
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Location = new System.Drawing.Point(45, 156);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(76, 17);
            this.lbl_LName.TabIndex = 5;
            this.lbl_LName.Text = "Last Name";
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(138, 117);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(100, 22);
            this.txt_FName.TabIndex = 6;
            // 
            // txt_LName
            // 
            this.txt_LName.Location = new System.Drawing.Point(138, 150);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(100, 22);
            this.txt_LName.TabIndex = 7;
            // 
            // lbl_ResType
            // 
            this.lbl_ResType.AutoSize = true;
            this.lbl_ResType.Location = new System.Drawing.Point(21, 192);
            this.lbl_ResType.Name = "lbl_ResType";
            this.lbl_ResType.Size = new System.Drawing.Size(100, 17);
            this.lbl_ResType.TabIndex = 8;
            this.lbl_ResType.Text = "Resident Type";
            // 
            // drop_ResType
            // 
            this.drop_ResType.FormattingEnabled = true;
            this.drop_ResType.Items.AddRange(new object[] {
            "Student Worker",
            "Student Athlete",
            "Scholorship Recipient"});
            this.drop_ResType.Location = new System.Drawing.Point(138, 192);
            this.drop_ResType.Name = "drop_ResType";
            this.drop_ResType.Size = new System.Drawing.Size(121, 24);
            this.drop_ResType.TabIndex = 9;
            this.drop_ResType.SelectedIndexChanged += new System.EventHandler(this.drop_ResType_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(138, 302);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 28);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // drop_Floor
            // 
            this.drop_Floor.FormattingEnabled = true;
            this.drop_Floor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.drop_Floor.Location = new System.Drawing.Point(138, 223);
            this.drop_Floor.Name = "drop_Floor";
            this.drop_Floor.Size = new System.Drawing.Size(121, 24);
            this.drop_Floor.TabIndex = 11;
            this.drop_Floor.SelectedIndexChanged += new System.EventHandler(this.drop_Floor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Floor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(138, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Room";
            // 
            // NewResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drop_Floor);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.drop_ResType);
            this.Controls.Add(this.lbl_ResType);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.txt_ResID);
            this.Controls.Add(this.lbl_ResID);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout2);
            this.Name = "NewResident";
            this.Text = "NewResident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_ResID;
        private System.Windows.Forms.TextBox txt_ResID;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.Label lbl_ResType;
        private System.Windows.Forms.ComboBox drop_ResType;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox drop_Floor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}