namespace Project3
{
    partial class RsidentSearch
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
            this.btn_Logout4 = new System.Windows.Forms.Button();
            this.btn_Back4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Logout4
            // 
            this.btn_Logout4.Location = new System.Drawing.Point(834, 12);
            this.btn_Logout4.Name = "btn_Logout4";
            this.btn_Logout4.Size = new System.Drawing.Size(75, 31);
            this.btn_Logout4.TabIndex = 0;
            this.btn_Logout4.Text = "Logout";
            this.btn_Logout4.UseVisualStyleBackColor = true;
            this.btn_Logout4.Click += new System.EventHandler(this.btn_Logout4_Click);
            // 
            // btn_Back4
            // 
            this.btn_Back4.Location = new System.Drawing.Point(753, 12);
            this.btn_Back4.Name = "btn_Back4";
            this.btn_Back4.Size = new System.Drawing.Size(75, 31);
            this.btn_Back4.TabIndex = 1;
            this.btn_Back4.Text = "Back";
            this.btn_Back4.UseVisualStyleBackColor = true;
            this.btn_Back4.Click += new System.EventHandler(this.btn_Back4_Click);
            // 
            // RsidentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 557);
            this.Controls.Add(this.btn_Back4);
            this.Controls.Add(this.btn_Logout4);
            this.Name = "RsidentSearch";
            this.Text = "ResidentSearch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout4;
        private System.Windows.Forms.Button btn_Back4;
    }
}