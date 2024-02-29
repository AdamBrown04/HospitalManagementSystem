namespace HospitalManagementSystem
{
    partial class viewDepartment
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
            lbl_depName = new Label();
            textBox1 = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
            SuspendLayout();
            // 
            // lbl_depName
            // 
            lbl_depName.AutoSize = true;
            lbl_depName.Location = new Point(10, 11);
            lbl_depName.Name = "lbl_depName";
            lbl_depName.Size = new Size(131, 20);
            lbl_depName.TabIndex = 0;
            lbl_depName.Text = "department name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 1;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(14, 72);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(382, 50);
            btn_saveChanges.TabIndex = 2;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(14, 128);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(382, 50);
            btn_return.TabIndex = 3;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            // 
            // viewDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 191);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(textBox1);
            Controls.Add(lbl_depName);
            Name = "viewDepartment";
            Text = "department";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_depName;
        private TextBox textBox1;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}