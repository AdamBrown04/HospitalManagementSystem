namespace HospitalManagementSystem
{
    partial class viewHospital
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
            lbl_hName = new Label();
            txb_hName = new TextBox();
            lbl_address1 = new Label();
            txb_address1 = new TextBox();
            lbl_address2 = new Label();
            label1 = new Label();
            txb_address2 = new TextBox();
            lbl_address3 = new Label();
            txb_address3 = new TextBox();
            lbl_postcode = new Label();
            txb_postcode = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            SuspendLayout();
            // 
            // lbl_hName
            // 
            lbl_hName.AutoSize = true;
            lbl_hName.Location = new Point(12, 9);
            lbl_hName.Name = "lbl_hName";
            lbl_hName.Size = new Size(106, 20);
            lbl_hName.TabIndex = 0;
            lbl_hName.Text = "hospital name:";
            // 
            // txb_hName
            // 
            txb_hName.Location = new Point(122, 6);
            txb_hName.Name = "txb_hName";
            txb_hName.Size = new Size(214, 27);
            txb_hName.TabIndex = 1;
            // 
            // lbl_address1
            // 
            lbl_address1.AutoSize = true;
            lbl_address1.Location = new Point(12, 46);
            lbl_address1.Name = "lbl_address1";
            lbl_address1.Size = new Size(103, 20);
            lbl_address1.TabIndex = 2;
            lbl_address1.Text = "address line 1:";
            // 
            // txb_address1
            // 
            txb_address1.Location = new Point(122, 43);
            txb_address1.Name = "txb_address1";
            txb_address1.Size = new Size(214, 27);
            txb_address1.TabIndex = 3;
            // 
            // lbl_address2
            // 
            lbl_address2.AutoSize = true;
            lbl_address2.Location = new Point(12, 89);
            lbl_address2.Name = "lbl_address2";
            lbl_address2.Size = new Size(103, 20);
            lbl_address2.TabIndex = 4;
            lbl_address2.Text = "address line 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 85);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // txb_address2
            // 
            txb_address2.Location = new Point(122, 87);
            txb_address2.Name = "txb_address2";
            txb_address2.Size = new Size(214, 27);
            txb_address2.TabIndex = 6;
            // 
            // lbl_address3
            // 
            lbl_address3.AutoSize = true;
            lbl_address3.Location = new Point(12, 138);
            lbl_address3.Name = "lbl_address3";
            lbl_address3.Size = new Size(103, 20);
            lbl_address3.TabIndex = 7;
            lbl_address3.Text = "address line 3:";
            // 
            // txb_address3
            // 
            txb_address3.Location = new Point(121, 138);
            txb_address3.Name = "txb_address3";
            txb_address3.Size = new Size(215, 27);
            txb_address3.TabIndex = 8;
            // 
            // lbl_postcode
            // 
            lbl_postcode.AutoSize = true;
            lbl_postcode.Location = new Point(14, 183);
            lbl_postcode.Name = "lbl_postcode";
            lbl_postcode.Size = new Size(74, 20);
            lbl_postcode.TabIndex = 9;
            lbl_postcode.Text = "postcode:";
            // 
            // txb_postcode
            // 
            txb_postcode.Location = new Point(93, 183);
            txb_postcode.Name = "txb_postcode";
            txb_postcode.Size = new Size(243, 27);
            txb_postcode.TabIndex = 10;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(14, 226);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(328, 51);
            btn_saveChanges.TabIndex = 11;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(14, 283);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(328, 51);
            btn_return.TabIndex = 12;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            // 
            // viewHospital
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 343);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_postcode);
            Controls.Add(lbl_postcode);
            Controls.Add(txb_address3);
            Controls.Add(lbl_address3);
            Controls.Add(txb_address2);
            Controls.Add(label1);
            Controls.Add(lbl_address2);
            Controls.Add(txb_address1);
            Controls.Add(lbl_address1);
            Controls.Add(txb_hName);
            Controls.Add(lbl_hName);
            Name = "viewHospital";
            Text = "view Hospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_hName;
        private TextBox txb_hName;
        private Label lbl_address1;
        private TextBox txb_address1;
        private Label lbl_address2;
        private Label label1;
        private TextBox txb_address2;
        private Label lbl_address3;
        private TextBox txb_address3;
        private Label lbl_postcode;
        private TextBox txb_postcode;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}