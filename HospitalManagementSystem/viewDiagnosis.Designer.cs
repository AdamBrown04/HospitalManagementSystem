namespace HospitalManagementSystem
{
    partial class viewDiagnosis
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
            lbl_pName = new Label();
            lbl_dName = new Label();
            lbl_diagnosis = new Label();
            txb_diagnosis = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            cmb_pName = new ComboBox();
            cmb_dName = new ComboBox();
            SuspendLayout();
            // 
            // lbl_pName
            // 
            lbl_pName.AutoSize = true;
            lbl_pName.Location = new Point(5, 5);
            lbl_pName.Name = "lbl_pName";
            lbl_pName.Size = new Size(107, 20);
            lbl_pName.TabIndex = 0;
            lbl_pName.Text = "Patient's name:";
            // 
            // lbl_dName
            // 
            lbl_dName.AutoSize = true;
            lbl_dName.Location = new Point(4, 40);
            lbl_dName.Name = "lbl_dName";
            lbl_dName.Size = new Size(108, 20);
            lbl_dName.TabIndex = 1;
            lbl_dName.Text = "Doctor's name:";
            // 
            // lbl_diagnosis
            // 
            lbl_diagnosis.AutoSize = true;
            lbl_diagnosis.Location = new Point(5, 72);
            lbl_diagnosis.Name = "lbl_diagnosis";
            lbl_diagnosis.Size = new Size(77, 20);
            lbl_diagnosis.TabIndex = 2;
            lbl_diagnosis.Text = "Diagnosis:";
            // 
            // txb_diagnosis
            // 
            txb_diagnosis.Location = new Point(88, 79);
            txb_diagnosis.Multiline = true;
            txb_diagnosis.Name = "txb_diagnosis";
            txb_diagnosis.Size = new Size(248, 140);
            txb_diagnosis.TabIndex = 5;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(8, 225);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(329, 53);
            btn_saveChanges.TabIndex = 6;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            btn_saveChanges.Click += btn_saveChanges_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(8, 284);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(328, 52);
            btn_return.TabIndex = 7;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // cmb_pName
            // 
            cmb_pName.FormattingEnabled = true;
            cmb_pName.Location = new Point(118, 2);
            cmb_pName.Name = "cmb_pName";
            cmb_pName.Size = new Size(214, 28);
            cmb_pName.TabIndex = 8;
            // 
            // cmb_dName
            // 
            cmb_dName.FormattingEnabled = true;
            cmb_dName.Location = new Point(118, 36);
            cmb_dName.Name = "cmb_dName";
            cmb_dName.Size = new Size(214, 28);
            cmb_dName.TabIndex = 9;
            // 
            // viewDiagnosis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 346);
            Controls.Add(cmb_dName);
            Controls.Add(cmb_pName);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_diagnosis);
            Controls.Add(lbl_diagnosis);
            Controls.Add(lbl_dName);
            Controls.Add(lbl_pName);
            Name = "viewDiagnosis";
            Text = "view Diagnosis";
            FormClosed += viewDiagnosis_FormClosed;
            Load += viewDiagnosis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_pName;
        private Label lbl_dName;
        private Label lbl_diagnosis;
        private TextBox txb_diagnosis;
        private Button btn_saveChanges;
        private Button btn_return;
        private ComboBox cmb_pName;
        private ComboBox cmb_dName;
    }
}