namespace HospitalManagementSystem
{
    partial class viewStaff
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
            lbl_name = new Label();
            txb_name = new TextBox();
            txb_job = new TextBox();
            lbl_job = new Label();
            txb_department = new TextBox();
            txb_DoB = new TextBox();
            lbl_department = new Label();
            lbl_DoB = new Label();
            lbl_address = new Label();
            textBox1 = new TextBox();
            lbl_email = new Label();
            textBox2 = new TextBox();
            lbl_phoneNumber = new Label();
            txb_phoneNumber = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            lbl_accessLevel = new Label();
            txb_accessLevel = new TextBox();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(12, 9);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(49, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "name:";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(67, 9);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(287, 27);
            txb_name.TabIndex = 1;
            // 
            // txb_job
            // 
            txb_job.Location = new Point(67, 42);
            txb_job.Name = "txb_job";
            txb_job.Size = new Size(287, 27);
            txb_job.TabIndex = 2;
            // 
            // lbl_job
            // 
            lbl_job.AutoSize = true;
            lbl_job.Location = new Point(12, 45);
            lbl_job.Name = "lbl_job";
            lbl_job.Size = new Size(34, 20);
            lbl_job.TabIndex = 3;
            lbl_job.Text = "job:";
            // 
            // txb_department
            // 
            txb_department.Location = new Point(108, 75);
            txb_department.Name = "txb_department";
            txb_department.Size = new Size(246, 27);
            txb_department.TabIndex = 4;
            // 
            // txb_DoB
            // 
            txb_DoB.Location = new Point(67, 108);
            txb_DoB.Name = "txb_DoB";
            txb_DoB.Size = new Size(287, 27);
            txb_DoB.TabIndex = 5;
            // 
            // lbl_department
            // 
            lbl_department.AutoSize = true;
            lbl_department.Location = new Point(12, 78);
            lbl_department.Name = "lbl_department";
            lbl_department.Size = new Size(90, 20);
            lbl_department.TabIndex = 6;
            lbl_department.Text = "department:";
            // 
            // lbl_DoB
            // 
            lbl_DoB.AutoSize = true;
            lbl_DoB.Location = new Point(12, 115);
            lbl_DoB.Name = "lbl_DoB";
            lbl_DoB.Size = new Size(41, 20);
            lbl_DoB.TabIndex = 7;
            lbl_DoB.Text = "DoB:";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(12, 150);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(63, 20);
            lbl_address.TabIndex = 8;
            lbl_address.Text = "address:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 150);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 66);
            textBox1.TabIndex = 9;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(12, 241);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(49, 20);
            lbl_email.TabIndex = 10;
            lbl_email.Text = "email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(287, 27);
            textBox2.TabIndex = 11;
            // 
            // lbl_phoneNumber
            // 
            lbl_phoneNumber.AutoSize = true;
            lbl_phoneNumber.Location = new Point(12, 289);
            lbl_phoneNumber.Name = "lbl_phoneNumber";
            lbl_phoneNumber.Size = new Size(109, 20);
            lbl_phoneNumber.TabIndex = 12;
            lbl_phoneNumber.Text = "phone number:";
            // 
            // txb_phoneNumber
            // 
            txb_phoneNumber.Location = new Point(127, 289);
            txb_phoneNumber.Name = "txb_phoneNumber";
            txb_phoneNumber.Size = new Size(227, 27);
            txb_phoneNumber.TabIndex = 13;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(10, 380);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(344, 53);
            btn_saveChanges.TabIndex = 14;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(10, 439);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(344, 53);
            btn_return.TabIndex = 15;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // lbl_accessLevel
            // 
            lbl_accessLevel.AutoSize = true;
            lbl_accessLevel.Location = new Point(12, 337);
            lbl_accessLevel.Name = "lbl_accessLevel";
            lbl_accessLevel.Size = new Size(89, 20);
            lbl_accessLevel.TabIndex = 16;
            lbl_accessLevel.Text = "access level:";
            // 
            // txb_accessLevel
            // 
            txb_accessLevel.Location = new Point(105, 334);
            txb_accessLevel.Name = "txb_accessLevel";
            txb_accessLevel.Size = new Size(249, 27);
            txb_accessLevel.TabIndex = 17;
            // 
            // viewStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 501);
            Controls.Add(txb_accessLevel);
            Controls.Add(lbl_accessLevel);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_phoneNumber);
            Controls.Add(lbl_phoneNumber);
            Controls.Add(textBox2);
            Controls.Add(lbl_email);
            Controls.Add(textBox1);
            Controls.Add(lbl_address);
            Controls.Add(lbl_DoB);
            Controls.Add(lbl_department);
            Controls.Add(txb_DoB);
            Controls.Add(txb_department);
            Controls.Add(lbl_job);
            Controls.Add(txb_job);
            Controls.Add(txb_name);
            Controls.Add(lbl_name);
            Name = "viewStaff";
            Text = "view staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private TextBox txb_name;
        private TextBox txb_job;
        private Label lbl_job;
        private TextBox txb_department;
        private TextBox txb_DoB;
        private Label lbl_department;
        private Label lbl_DoB;
        private Label lbl_address;
        private TextBox textBox1;
        private Label lbl_email;
        private TextBox textBox2;
        private Label lbl_phoneNumber;
        private TextBox txb_phoneNumber;
        private Button btn_saveChanges;
        private Button btn_return;
        private Label lbl_accessLevel;
        private TextBox txb_accessLevel;
    }
}