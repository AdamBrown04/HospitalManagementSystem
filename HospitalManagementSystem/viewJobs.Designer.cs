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
            textBox1 = new TextBox();
            lbl_departmentName = new Label();
            textBox2 = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(86, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 1;
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
            // textBox2
            // 
            textBox2.Location = new Point(101, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 3;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(5, 104);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(351, 54);
            btn_saveChanges.TabIndex = 4;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
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
            // viewJobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 227);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(textBox2);
            Controls.Add(lbl_departmentName);
            Controls.Add(textBox1);
            Controls.Add(lbl_jobName);
            Name = "viewJobs";
            Text = "view Job";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_jobName;
        private TextBox textBox1;
        private Label lbl_departmentName;
        private TextBox textBox2;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}