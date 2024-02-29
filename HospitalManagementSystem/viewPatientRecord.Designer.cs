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
            lbl_name = new Label();
            lbl_height = new Label();
            lbl_weight = new Label();
            lbl_diagnosis = new Label();
            txb_name = new TextBox();
            txb_height = new TextBox();
            txb_weight = new TextBox();
            txb_diagnosis = new TextBox();
            lbl_doctor = new Label();
            txb_doctor = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(10, 22);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(49, 20);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "name:";
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
            // lbl_diagnosis
            // 
            lbl_diagnosis.AutoSize = true;
            lbl_diagnosis.Location = new Point(10, 129);
            lbl_diagnosis.Name = "lbl_diagnosis";
            lbl_diagnosis.Size = new Size(75, 20);
            lbl_diagnosis.TabIndex = 3;
            lbl_diagnosis.Text = "diagnosis:";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(65, 22);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(376, 27);
            txb_name.TabIndex = 4;
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
            // txb_diagnosis
            // 
            txb_diagnosis.Location = new Point(91, 129);
            txb_diagnosis.Multiline = true;
            txb_diagnosis.Name = "txb_diagnosis";
            txb_diagnosis.Size = new Size(350, 125);
            txb_diagnosis.TabIndex = 7;
            // 
            // lbl_doctor
            // 
            lbl_doctor.AutoSize = true;
            lbl_doctor.Location = new Point(12, 280);
            lbl_doctor.Name = "lbl_doctor";
            lbl_doctor.Size = new Size(56, 20);
            lbl_doctor.TabIndex = 8;
            lbl_doctor.Text = "doctor:";
            // 
            // txb_doctor
            // 
            txb_doctor.Location = new Point(74, 277);
            txb_doctor.Name = "txb_doctor";
            txb_doctor.Size = new Size(367, 27);
            txb_doctor.TabIndex = 9;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(11, 327);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(431, 61);
            btn_saveChanges.TabIndex = 10;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(12, 394);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(431, 61);
            btn_return.TabIndex = 11;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // viewPatientRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 472);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_doctor);
            Controls.Add(lbl_doctor);
            Controls.Add(txb_diagnosis);
            Controls.Add(txb_weight);
            Controls.Add(txb_height);
            Controls.Add(txb_name);
            Controls.Add(lbl_diagnosis);
            Controls.Add(lbl_weight);
            Controls.Add(lbl_height);
            Controls.Add(lbl_name);
            Name = "viewPatientRecord";
            Text = "viewPatientRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_height;
        private Label lbl_weight;
        private Label lbl_diagnosis;
        private TextBox txb_name;
        private TextBox txb_height;
        private TextBox txb_weight;
        private TextBox txb_diagnosis;
        private Label lbl_doctor;
        private TextBox txb_doctor;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}