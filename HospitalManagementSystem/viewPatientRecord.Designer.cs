namespace HospitalManagementSystem
{
    partial class viewPatientRecord
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
            lbl_patient = new Label();
            lbl_height = new Label();
            lbl_weight = new Label();
            lbl_bloodType = new Label();
            txb_height = new TextBox();
            txb_weight = new TextBox();
            txb_bloodType = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            cmb_patient = new ComboBox();
            SuspendLayout();
            // 
            // lbl_patient
            // 
            lbl_patient.AutoSize = true;
            lbl_patient.Location = new Point(10, 22);
            lbl_patient.Name = "lbl_patient";
            lbl_patient.Size = new Size(59, 20);
            lbl_patient.TabIndex = 0;
            lbl_patient.Text = "patient:";
            // 
            // lbl_height
            // 
            lbl_height.AutoSize = true;
            lbl_height.Location = new Point(12, 60);
            lbl_height.Name = "lbl_height";
            lbl_height.Size = new Size(54, 20);
            lbl_height.TabIndex = 1;
            lbl_height.Text = "height:";
            // 
            // lbl_weight
            // 
            lbl_weight.AutoSize = true;
            lbl_weight.Location = new Point(12, 94);
            lbl_weight.Name = "lbl_weight";
            lbl_weight.Size = new Size(57, 20);
            lbl_weight.TabIndex = 2;
            lbl_weight.Text = "weight:";
            // 
            // lbl_bloodType
            // 
            lbl_bloodType.AutoSize = true;
            lbl_bloodType.Location = new Point(10, 129);
            lbl_bloodType.Name = "lbl_bloodType";
            lbl_bloodType.Size = new Size(85, 20);
            lbl_bloodType.TabIndex = 3;
            lbl_bloodType.Text = "blood type:";
            // 
            // txb_height
            // 
            txb_height.Location = new Point(65, 60);
            txb_height.Name = "txb_height";
            txb_height.Size = new Size(376, 27);
            txb_height.TabIndex = 5;
            // 
            // txb_weight
            // 
            txb_weight.Location = new Point(74, 93);
            txb_weight.Name = "txb_weight";
            txb_weight.Size = new Size(367, 27);
            txb_weight.TabIndex = 6;
            // 
            // txb_bloodType
            // 
            txb_bloodType.Location = new Point(101, 129);
            txb_bloodType.Name = "txb_bloodType";
            txb_bloodType.Size = new Size(340, 27);
            txb_bloodType.TabIndex = 7;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(10, 162);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(431, 61);
            btn_saveChanges.TabIndex = 10;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            btn_saveChanges.Click += btn_saveChanges_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(11, 229);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(431, 61);
            btn_return.TabIndex = 11;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // cmb_patient
            // 
            cmb_patient.FormattingEnabled = true;
            cmb_patient.Location = new Point(74, 19);
            cmb_patient.Name = "cmb_patient";
            cmb_patient.Size = new Size(368, 28);
            cmb_patient.TabIndex = 12;
            // 
            // viewPatientRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 304);
            Controls.Add(cmb_patient);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_bloodType);
            Controls.Add(txb_weight);
            Controls.Add(txb_height);
            Controls.Add(lbl_bloodType);
            Controls.Add(lbl_weight);
            Controls.Add(lbl_height);
            Controls.Add(lbl_patient);
            Name = "viewPatientRecord";
            Text = "viewPatientRecord";
            FormClosed += viewPatientRecord_FormClosed;
            Load += viewPatientRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_patient;
        private Label lbl_height;
        private Label lbl_weight;
        private Label lbl_bloodType;
        private TextBox txb_height;
        private TextBox txb_weight;
        private TextBox txb_bloodType;
        private Button btn_saveChanges;
        private Button btn_return;
        private ComboBox cmb_patient;
    }
}