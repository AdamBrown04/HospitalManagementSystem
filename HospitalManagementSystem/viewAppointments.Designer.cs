﻿namespace HospitalManagementSystem
{
    partial class viewAppointments
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
            lbl_Pname = new Label();
            lbl_hName = new Label();
            lbl_date = new Label();
            lbl_time = new Label();
            btn_saveChanges = new Button();
            btn_return = new Button();
            dt_date = new DateTimePicker();
            dt_time = new DateTimePicker();
            cmb_pName = new ComboBox();
            cmb_hName = new ComboBox();
            SuspendLayout();
            // 
            // lbl_Pname
            // 
            lbl_Pname.AutoSize = true;
            lbl_Pname.Location = new Point(12, 9);
            lbl_Pname.Name = "lbl_Pname";
            lbl_Pname.Size = new Size(109, 20);
            lbl_Pname.TabIndex = 0;
            lbl_Pname.Text = "patient's name:";
            // 
            // lbl_hName
            // 
            lbl_hName.AutoSize = true;
            lbl_hName.Location = new Point(12, 54);
            lbl_hName.Name = "lbl_hName";
            lbl_hName.Size = new Size(106, 20);
            lbl_hName.TabIndex = 2;
            lbl_hName.Text = "hospital name:";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(12, 99);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(42, 20);
            lbl_date.TabIndex = 4;
            lbl_date.Text = "date:";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(12, 143);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(42, 20);
            lbl_time.TabIndex = 6;
            lbl_time.Text = "time:";
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(12, 176);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(332, 62);
            btn_saveChanges.TabIndex = 10;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            btn_saveChanges.Click += btn_saveChanges_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(13, 244);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(332, 62);
            btn_return.TabIndex = 11;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // dt_date
            // 
            dt_date.CustomFormat = "yyyy-MM-dd";
            dt_date.Format = DateTimePickerFormat.Short;
            dt_date.Location = new Point(60, 92);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(287, 27);
            dt_date.TabIndex = 12;
            // 
            // dt_time
            // 
            dt_time.Format = DateTimePickerFormat.Time;
            dt_time.Location = new Point(60, 138);
            dt_time.Name = "dt_time";
            dt_time.ShowUpDown = true;
            dt_time.Size = new Size(289, 27);
            dt_time.TabIndex = 13;
            dt_time.Value = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            // 
            // cmb_pName
            // 
            cmb_pName.FormattingEnabled = true;
            cmb_pName.Location = new Point(127, 9);
            cmb_pName.Name = "cmb_pName";
            cmb_pName.Size = new Size(220, 28);
            cmb_pName.TabIndex = 14;
            // 
            // cmb_hName
            // 
            cmb_hName.FormattingEnabled = true;
            cmb_hName.Location = new Point(127, 54);
            cmb_hName.Name = "cmb_hName";
            cmb_hName.Size = new Size(220, 28);
            cmb_hName.TabIndex = 15;
            // 
            // viewAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 316);
            Controls.Add(cmb_hName);
            Controls.Add(cmb_pName);
            Controls.Add(dt_time);
            Controls.Add(dt_date);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(lbl_time);
            Controls.Add(lbl_date);
            Controls.Add(lbl_hName);
            Controls.Add(lbl_Pname);
            Name = "viewAppointments";
            Text = "viewAppointments";
            FormClosed += viewAppointments_FormClosed;
            Load += viewAppointments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Pname;
        private Label lbl_hName;
        private Label lbl_date;
        private Label lbl_time;
        private Button btn_saveChanges;
        private Button btn_return;
        private DateTimePicker dt_date;
        private DateTimePicker dt_time;
        private ComboBox cmb_pName;
        private ComboBox cmb_hName;
    }
}