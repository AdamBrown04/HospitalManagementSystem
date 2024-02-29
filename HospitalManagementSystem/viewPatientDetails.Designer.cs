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
            lbl_address = new Label();
            txb_name = new TextBox();
            txb_dob = new TextBox();
            txb_email = new TextBox();
            txb_phoneNumber = new TextBox();
            txb_gender = new TextBox();
            txb_address = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
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
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(15, 222);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(63, 20);
            lbl_address.TabIndex = 5;
            lbl_address.Text = "address:";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(69, 16);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(358, 27);
            txb_name.TabIndex = 6;
            // 
            // txb_dob
            // 
            txb_dob.Location = new Point(69, 55);
            txb_dob.Name = "txb_dob";
            txb_dob.Size = new Size(358, 27);
            txb_dob.TabIndex = 7;
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
            // txb_address
            // 
            txb_address.Location = new Point(79, 219);
            txb_address.Multiline = true;
            txb_address.Name = "txb_address";
            txb_address.Size = new Size(348, 104);
            txb_address.TabIndex = 11;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(12, 338);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(415, 59);
            btn_saveChanges.TabIndex = 12;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
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
            // viewPatientDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 469);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_address);
            Controls.Add(txb_gender);
            Controls.Add(txb_phoneNumber);
            Controls.Add(txb_email);
            Controls.Add(txb_dob);
            Controls.Add(txb_name);
            Controls.Add(lbl_address);
            Controls.Add(lbl_gender);
            Controls.Add(lbl_phoneNumber);
            Controls.Add(lbl_email);
            Controls.Add(lbl_DoB);
            Controls.Add(lbl_name);
            Name = "viewPatientDetails";
            Text = "viewPatientDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_DoB;
        private Label lbl_email;
        private Label lbl_phoneNumber;
        private Label lbl_gender;
        private Label lbl_address;
        private TextBox txb_name;
        private TextBox txb_dob;
        private TextBox txb_email;
        private TextBox txb_phoneNumber;
        private TextBox txb_gender;
        private TextBox txb_address;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}