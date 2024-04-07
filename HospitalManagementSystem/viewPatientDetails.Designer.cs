namespace HospitalManagementSystem
{
    partial class viewPatientDetails
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
            lbl_DoB = new Label();
            lbl_email = new Label();
            lbl_phoneNumber = new Label();
            lbl_gender = new Label();
            lbl_address1 = new Label();
            txb_name = new TextBox();
            txb_email = new TextBox();
            txb_phoneNumber = new TextBox();
            txb_gender = new TextBox();
            txb_address1 = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            dtb_dob = new DateTimePicker();
            txb_address2 = new TextBox();
            txb_address3 = new TextBox();
            lbl_address2 = new Label();
            lbl_address3 = new Label();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(14, 16);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(49, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "name:";
            // 
            // lbl_DoB
            // 
            lbl_DoB.AutoSize = true;
            lbl_DoB.Location = new Point(14, 55);
            lbl_DoB.Name = "lbl_DoB";
            lbl_DoB.Size = new Size(41, 20);
            lbl_DoB.TabIndex = 1;
            lbl_DoB.Text = "DoB:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(14, 91);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(49, 20);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "email:";
            // 
            // lbl_phoneNumber
            // 
            lbl_phoneNumber.AutoSize = true;
            lbl_phoneNumber.Location = new Point(14, 133);
            lbl_phoneNumber.Name = "lbl_phoneNumber";
            lbl_phoneNumber.Size = new Size(109, 20);
            lbl_phoneNumber.TabIndex = 3;
            lbl_phoneNumber.Text = "phone number:";
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Location = new Point(14, 178);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(59, 20);
            lbl_gender.TabIndex = 4;
            lbl_gender.Text = "gender:";
            // 
            // lbl_address1
            // 
            lbl_address1.AutoSize = true;
            lbl_address1.Location = new Point(15, 222);
            lbl_address1.Name = "lbl_address1";
            lbl_address1.Size = new Size(103, 20);
            lbl_address1.TabIndex = 5;
            lbl_address1.Text = "address line 1:";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(69, 16);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(358, 27);
            txb_name.TabIndex = 6;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(69, 91);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(358, 27);
            txb_email.TabIndex = 8;
            // 
            // txb_phoneNumber
            // 
            txb_phoneNumber.Location = new Point(129, 133);
            txb_phoneNumber.Name = "txb_phoneNumber";
            txb_phoneNumber.Size = new Size(298, 27);
            txb_phoneNumber.TabIndex = 9;
            // 
            // txb_gender
            // 
            txb_gender.Location = new Point(79, 171);
            txb_gender.Name = "txb_gender";
            txb_gender.Size = new Size(348, 27);
            txb_gender.TabIndex = 10;
            // 
            // txb_address1
            // 
            txb_address1.Location = new Point(124, 219);
            txb_address1.Name = "txb_address1";
            txb_address1.Size = new Size(303, 27);
            txb_address1.TabIndex = 11;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(12, 338);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(415, 59);
            btn_saveChanges.TabIndex = 12;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            btn_saveChanges.Click += btn_saveChanges_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(15, 403);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(415, 59);
            btn_return.TabIndex = 13;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // dtb_dob
            // 
            dtb_dob.Location = new Point(69, 56);
            dtb_dob.Name = "dtb_dob";
            dtb_dob.Size = new Size(358, 27);
            dtb_dob.TabIndex = 14;
            // 
            // txb_address2
            // 
            txb_address2.Location = new Point(124, 261);
            txb_address2.Name = "txb_address2";
            txb_address2.Size = new Size(303, 27);
            txb_address2.TabIndex = 15;
            // 
            // txb_address3
            // 
            txb_address3.Location = new Point(124, 305);
            txb_address3.Name = "txb_address3";
            txb_address3.Size = new Size(303, 27);
            txb_address3.TabIndex = 16;
            // 
            // lbl_address2
            // 
            lbl_address2.AutoSize = true;
            lbl_address2.Location = new Point(17, 259);
            lbl_address2.Name = "lbl_address2";
            lbl_address2.Size = new Size(103, 20);
            lbl_address2.TabIndex = 17;
            lbl_address2.Text = "address line 2:";
            // 
            // lbl_address3
            // 
            lbl_address3.AutoSize = true;
            lbl_address3.Location = new Point(12, 305);
            lbl_address3.Name = "lbl_address3";
            lbl_address3.Size = new Size(103, 20);
            lbl_address3.TabIndex = 18;
            lbl_address3.Text = "address line 3:";
            // 
            // viewPatientDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 470);
            Controls.Add(lbl_address3);
            Controls.Add(lbl_address2);
            Controls.Add(txb_address3);
            Controls.Add(txb_address2);
            Controls.Add(dtb_dob);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_address1);
            Controls.Add(txb_gender);
            Controls.Add(txb_phoneNumber);
            Controls.Add(txb_email);
            Controls.Add(txb_name);
            Controls.Add(lbl_address1);
            Controls.Add(lbl_gender);
            Controls.Add(lbl_phoneNumber);
            Controls.Add(lbl_email);
            Controls.Add(lbl_DoB);
            Controls.Add(lbl_name);
            Name = "viewPatientDetails";
            Text = "viewPatientDetails";
            FormClosed += viewPatientDetails_FormClosed;
            Load += viewPatientDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_DoB;
        private Label lbl_email;
        private Label lbl_phoneNumber;
        private Label lbl_gender;
        private Label lbl_address1;
        private TextBox txb_name;
        private TextBox txb_email;
        private TextBox txb_phoneNumber;
        private TextBox txb_gender;
        private TextBox txb_address1;
        private Button btn_saveChanges;
        private Button btn_return;
        private DateTimePicker dtb_dob;
        private TextBox txb_address2;
        private TextBox txb_address3;
        private Label lbl_address2;
        private Label lbl_address3;
    }
}