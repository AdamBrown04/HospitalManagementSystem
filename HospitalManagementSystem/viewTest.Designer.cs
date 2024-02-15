namespace HospitalManagementSystem
{
    partial class viewTest
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
            lbl_testID = new Label();
            lbl_staffName = new Label();
            lbl_testResults = new Label();
            lbl_patientID = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            SuspendLayout();
            // 
            // lbl_testID
            // 
            lbl_testID.AutoSize = true;
            lbl_testID.Location = new Point(15, 25);
            lbl_testID.Name = "lbl_testID";
            lbl_testID.Size = new Size(53, 20);
            lbl_testID.TabIndex = 0;
            lbl_testID.Text = "test id:";
            // 
            // lbl_staffName
            // 
            lbl_staffName.AutoSize = true;
            lbl_staffName.Location = new Point(12, 61);
            lbl_staffName.Name = "lbl_staffName";
            lbl_staffName.Size = new Size(82, 20);
            lbl_staffName.TabIndex = 1;
            lbl_staffName.Text = "staff name:";
            // 
            // lbl_testResults
            // 
            lbl_testResults.AutoSize = true;
            lbl_testResults.Location = new Point(12, 138);
            lbl_testResults.Name = "lbl_testResults";
            lbl_testResults.Size = new Size(82, 20);
            lbl_testResults.TabIndex = 2;
            lbl_testResults.Text = "test results:";
            // 
            // lbl_patientID
            // 
            lbl_patientID.AutoSize = true;
            lbl_patientID.Location = new Point(12, 98);
            lbl_patientID.Name = "lbl_patientID";
            lbl_patientID.Size = new Size(100, 20);
            lbl_patientID.TabIndex = 3;
            lbl_patientID.Text = "patient name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(100, 138);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(340, 130);
            textBox4.TabIndex = 7;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(7, 297);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(436, 67);
            btn_saveChanges.TabIndex = 8;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(7, 370);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(436, 67);
            btn_return.TabIndex = 9;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            // 
            // viewTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 447);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_patientID);
            Controls.Add(lbl_testResults);
            Controls.Add(lbl_staffName);
            Controls.Add(lbl_testID);
            Name = "viewTest";
            Text = "viewTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_testID;
        private Label lbl_staffName;
        private Label lbl_testResults;
        private Label lbl_patientID;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}