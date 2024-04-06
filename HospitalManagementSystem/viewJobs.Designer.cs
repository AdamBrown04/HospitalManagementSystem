namespace HospitalManagementSystem
{
    partial class viewJobs
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
            lbl_jobName = new Label();
            txb_jobName = new TextBox();
            lbl_departmentName = new Label();
            btn_saveChanges = new Button();
            btn_return = new Button();
            cmb_departmentName = new ComboBox();
            SuspendLayout();
            // 
            // lbl_jobName
            // 
            lbl_jobName.AutoSize = true;
            lbl_jobName.Location = new Point(5, 14);
            lbl_jobName.Name = "lbl_jobName";
            lbl_jobName.Size = new Size(75, 20);
            lbl_jobName.TabIndex = 0;
            lbl_jobName.Text = "job name:";
            // 
            // txb_jobName
            // 
            txb_jobName.Location = new Point(86, 14);
            txb_jobName.Name = "txb_jobName";
            txb_jobName.Size = new Size(270, 27);
            txb_jobName.TabIndex = 1;
            // 
            // lbl_departmentName
            // 
            lbl_departmentName.AutoSize = true;
            lbl_departmentName.Location = new Point(5, 62);
            lbl_departmentName.Name = "lbl_departmentName";
            lbl_departmentName.Size = new Size(90, 20);
            lbl_departmentName.TabIndex = 2;
            lbl_departmentName.Text = "department:";
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(5, 104);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(351, 54);
            btn_saveChanges.TabIndex = 4;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            btn_saveChanges.Click += btn_saveChanges_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(5, 164);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(351, 54);
            btn_return.TabIndex = 5;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // cmb_departmentName
            // 
            cmb_departmentName.FormattingEnabled = true;
            cmb_departmentName.Location = new Point(101, 59);
            cmb_departmentName.Name = "cmb_departmentName";
            cmb_departmentName.Size = new Size(255, 28);
            cmb_departmentName.TabIndex = 6;
            // 
            // viewJobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 227);
            Controls.Add(cmb_departmentName);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(lbl_departmentName);
            Controls.Add(txb_jobName);
            Controls.Add(lbl_jobName);
            Name = "viewJobs";
            Text = "view Job";
            FormClosed += viewJobs_FormClosed;
            Load += viewJobs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_jobName;
        private TextBox txb_jobName;
        private Label lbl_departmentName;
        private Button btn_saveChanges;
        private Button btn_return;
        private ComboBox cmb_departmentName;
    }
}