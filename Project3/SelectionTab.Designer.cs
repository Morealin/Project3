namespace Project3
{
    partial class SelectionTab
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
            this.btn_NewRes = new System.Windows.Forms.Button();
            this.btn_ShowRes = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewRes
            // 
            this.btn_NewRes.Location = new System.Drawing.Point(100, 146);
            this.btn_NewRes.Name = "btn_NewRes";
            this.btn_NewRes.Size = new System.Drawing.Size(138, 113);
            this.btn_NewRes.TabIndex = 0;
            this.btn_NewRes.Text = "Add";
            this.btn_NewRes.UseVisualStyleBackColor = true;
            this.btn_NewRes.Click += new System.EventHandler(this.btn_NewRes_Click);
            // 
            // btn_ShowRes
            // 
            this.btn_ShowRes.Location = new System.Drawing.Point(274, 146);
            this.btn_ShowRes.Name = "btn_ShowRes";
            this.btn_ShowRes.Size = new System.Drawing.Size(136, 113);
            this.btn_ShowRes.TabIndex = 1;
            this.btn_ShowRes.Text = "Search";
            this.btn_ShowRes.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(450, 22);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 30);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // SelectionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 421);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_ShowRes);
            this.Controls.Add(this.btn_NewRes);
            this.Name = "SelectionTab";
            this.Text = "SelectionTab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewRes;
        private System.Windows.Forms.Button btn_ShowRes;
        private System.Windows.Forms.Button btn_Logout;
    }
}