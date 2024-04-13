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
            lbl_job = new Label();
            lbl_department = new Label();
            lbl_DoB = new Label();
            lbl_address1 = new Label();
            txb_address1 = new TextBox();
            lbl_email = new Label();
            txb_email = new TextBox();
            lbl_phoneNumber = new Label();
            txb_phoneNumber = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            lbl_accessLevel = new Label();
            dt_dob = new DateTimePicker();
            lbl_address2 = new Label();
            lbl_address3 = new Label();
            txb_address2 = new TextBox();
            txb_address3 = new TextBox();
            cmb_job = new ComboBox();
            cmb_department = new ComboBox();
            nud_accessLevel = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_accessLevel).BeginInit();
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
            // lbl_job
            // 
            lbl_job.AutoSize = true;
            lbl_job.Location = new Point(12, 45);
            lbl_job.Name = "lbl_job";
            lbl_job.Size = new Size(34, 20);
            lbl_job.TabIndex = 3;
            lbl_job.Text = "job:";
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
            // lbl_address1
            // 
            lbl_address1.AutoSize = true;
            lbl_address1.Location = new Point(12, 150);
            lbl_address1.Name = "lbl_address1";
            lbl_address1.Size = new Size(103, 20);
            lbl_address1.TabIndex = 8;
            lbl_address1.Text = "address line 1:";
            // 
            // txb_address1
            // 
            txb_address1.Location = new Point(127, 150);
            txb_address1.Name = "txb_address1";
            txb_address1.Size = new Size(227, 27);
            txb_address1.TabIndex = 9;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(12, 256);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(49, 20);
            lbl_email.TabIndex = 10;
            lbl_email.Text = "email:";
            // 
            // txb_email
            // 
            txb_email.Location = new Point(67, 256);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(287, 27);
            txb_email.TabIndex = 11;
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
            btn_saveChanges.Click += btn_saveChanges_Click;
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
            // dt_dob
            // 
            dt_dob.Location = new Point(69, 115);
            dt_dob.Name = "dt_dob";
            dt_dob.Size = new Size(285, 27);
            dt_dob.TabIndex = 18;
            // 
            // lbl_address2
            // 
            lbl_address2.AutoSize = true;
            lbl_address2.Location = new Point(12, 185);
            lbl_address2.Name = "lbl_address2";
            lbl_address2.Size = new Size(103, 20);
            lbl_address2.TabIndex = 19;
            lbl_address2.Text = "address line 2:";
            // 
            // lbl_address3
            // 
            lbl_address3.AutoSize = true;
            lbl_address3.Location = new Point(10, 222);
            lbl_address3.Name = "lbl_address3";
            lbl_address3.Size = new Size(103, 20);
            lbl_address3.TabIndex = 20;
            lbl_address3.Text = "address line 3:";
            // 
            // txb_address2
            // 
            txb_address2.Location = new Point(127, 185);
            txb_address2.Name = "txb_address2";
            txb_address2.Size = new Size(227, 27);
            txb_address2.TabIndex = 21;
            // 
            // txb_address3
            // 
            txb_address3.Location = new Point(127, 223);
            txb_address3.Name = "txb_address3";
            txb_address3.Size = new Size(227, 27);
            txb_address3.TabIndex = 22;
            // 
            // cmb_job
            // 
            cmb_job.FormattingEnabled = true;
            cmb_job.Location = new Point(52, 42);
            cmb_job.Name = "cmb_job";
            cmb_job.Size = new Size(302, 28);
            cmb_job.TabIndex = 23;
            // 
            // cmb_department
            // 
            cmb_department.FormattingEnabled = true;
            cmb_department.Location = new Point(108, 75);
            cmb_department.Name = "cmb_department";
            cmb_department.Size = new Size(246, 28);
            cmb_department.TabIndex = 24;
            // 
            // nud_accessLevel
            // 
            nud_accessLevel.Location = new Point(108, 335);
            nud_accessLevel.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            nud_accessLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_accessLevel.Name = "nud_accessLevel";
            nud_accessLevel.Size = new Size(246, 27);
            nud_accessLevel.TabIndex = 25;
            nud_accessLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // viewStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 501);
            Controls.Add(nud_accessLevel);
            Controls.Add(cmb_department);
            Controls.Add(cmb_job);
            Controls.Add(txb_address3);
            Controls.Add(txb_address2);
            Controls.Add(lbl_address3);
            Controls.Add(lbl_address2);
            Controls.Add(dt_dob);
            Controls.Add(lbl_accessLevel);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_phoneNumber);
            Controls.Add(lbl_phoneNumber);
            Controls.Add(txb_email);
            Controls.Add(lbl_email);
            Controls.Add(txb_address1);
            Controls.Add(lbl_address1);
            Controls.Add(lbl_DoB);
            Controls.Add(lbl_department);
            Controls.Add(lbl_job);
            Controls.Add(txb_name);
            Controls.Add(lbl_name);
            Name = "viewStaff";
            Text = "view staff";
            FormClosed += viewStaff_FormClosed;
            Load += viewStaff_Load;
            ((System.ComponentModel.ISupportInitialize)nud_accessLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private TextBox txb_name;
        private Label lbl_job;
        private Label lbl_department;
        private Label lbl_DoB;
        private Label lbl_address1;
        private TextBox txb_address1;
        private Label lbl_email;
        private TextBox txb_email;
        private Label lbl_phoneNumber;
        private TextBox txb_phoneNumber;
        private Button btn_saveChanges;
        private Button btn_return;
        private Label lbl_accessLevel;
        private DateTimePicker dt_dob;
        private Label lbl_address2;
        private Label lbl_address3;
        private TextBox txb_address2;
        private TextBox txb_address3;
        private ComboBox cmb_job;
        private ComboBox cmb_department;
        private NumericUpDown nud_accessLevel;
    }
}