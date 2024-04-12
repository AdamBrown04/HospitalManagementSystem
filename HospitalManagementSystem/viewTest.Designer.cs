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
            txb_testID = new TextBox();
            txb_testResults = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            txb_testName = new TextBox();
            lbl_testName = new Label();
            cmb_sName = new ComboBox();
            cmb_pName = new ComboBox();
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
            lbl_testResults.Location = new Point(12, 187);
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
            // txb_testID
            // 
            txb_testID.Enabled = false;
            txb_testID.Location = new Point(74, 19);
            txb_testID.Name = "txb_testID";
            txb_testID.Size = new Size(366, 27);
            txb_testID.TabIndex = 4;
            // 
            // txb_testResults
            // 
            txb_testResults.Location = new Point(100, 187);
            txb_testResults.Multiline = true;
            txb_testResults.Name = "txb_testResults";
            txb_testResults.Size = new Size(340, 130);
            txb_testResults.TabIndex = 7;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(4, 350);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(436, 67);
            btn_saveChanges.TabIndex = 8;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            btn_saveChanges.Click += btn_saveChanges_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(4, 423);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(436, 67);
            btn_return.TabIndex = 9;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // txb_testName
            // 
            txb_testName.Location = new Point(95, 143);
            txb_testName.Name = "txb_testName";
            txb_testName.Size = new Size(345, 27);
            txb_testName.TabIndex = 10;
            // 
            // lbl_testName
            // 
            lbl_testName.AutoSize = true;
            lbl_testName.Location = new Point(12, 146);
            lbl_testName.Name = "lbl_testName";
            lbl_testName.Size = new Size(77, 20);
            lbl_testName.TabIndex = 11;
            lbl_testName.Text = "test name:";
            // 
            // cmb_sName
            // 
            cmb_sName.FormattingEnabled = true;
            cmb_sName.Location = new Point(100, 61);
            cmb_sName.Name = "cmb_sName";
            cmb_sName.Size = new Size(340, 28);
            cmb_sName.TabIndex = 12;
            // 
            // cmb_pName
            // 
            cmb_pName.FormattingEnabled = true;
            cmb_pName.Location = new Point(118, 98);
            cmb_pName.Name = "cmb_pName";
            cmb_pName.Size = new Size(322, 28);
            cmb_pName.TabIndex = 13;
            // 
            // viewTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 506);
            Controls.Add(cmb_pName);
            Controls.Add(cmb_sName);
            Controls.Add(lbl_testName);
            Controls.Add(txb_testName);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_testResults);
            Controls.Add(txb_testID);
            Controls.Add(lbl_patientID);
            Controls.Add(lbl_testResults);
            Controls.Add(lbl_staffName);
            Controls.Add(lbl_testID);
            Name = "viewTest";
            Text = "viewTest";
            FormClosed += viewTest_FormClosed;
            Load += viewTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_testID;
        private Label lbl_staffName;
        private Label lbl_testResults;
        private Label lbl_patientID;
        private TextBox txb_testID;
        private TextBox txb_testResults;
        private Button btn_saveChanges;
        private Button btn_return;
        private TextBox txb_testName;
        private Label lbl_testName;
        private ComboBox cmb_sName;
        private ComboBox cmb_pName;
    }
}