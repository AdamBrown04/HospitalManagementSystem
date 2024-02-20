namespace HospitalManagementSystem
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_welcome = new Label();
            btn_Submit = new Button();
            txb_username = new TextBox();
            lbl_username = new Label();
            txb_password = new TextBox();
            lbl_password = new Label();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 20F);
            lbl_welcome.Location = new Point(75, 9);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(160, 46);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Welcome";
            // 
            // btn_Submit
            // 
            btn_Submit.Font = new Font("Segoe UI", 9F);
            btn_Submit.Location = new Point(11, 192);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(279, 53);
            btn_Submit.TabIndex = 1;
            btn_Submit.Text = "submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // txb_username
            // 
            txb_username.Location = new Point(93, 78);
            txb_username.Name = "txb_username";
            txb_username.Size = new Size(197, 27);
            txb_username.TabIndex = 2;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(11, 81);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(76, 20);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "username:";
            // 
            // txb_password
            // 
            txb_password.Location = new Point(93, 138);
            txb_password.Name = "txb_password";
            txb_password.Size = new Size(197, 27);
            txb_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(11, 141);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(75, 20);
            lbl_password.TabIndex = 5;
            lbl_password.Text = "password:";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 253);
            Controls.Add(lbl_password);
            Controls.Add(txb_password);
            Controls.Add(lbl_username);
            Controls.Add(txb_username);
            Controls.Add(btn_Submit);
            Controls.Add(lbl_welcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private Button btn_Submit;
        private TextBox txb_username;
        private Label lbl_username;
        private TextBox txb_password;
        private Label lbl_password;
    }
}
