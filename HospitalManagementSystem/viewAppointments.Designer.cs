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
            txb_pName = new TextBox();
            lbl_hName = new Label();
            txb_hName = new TextBox();
            lbl_date = new Label();
            txb_date = new TextBox();
            lbl_time = new Label();
            txb_time = new TextBox();
            btn_saveChanges = new Button();
            btn_return = new Button();
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
            // txb_pName
            // 
            txb_pName.Location = new Point(127, 9);
            txb_pName.Name = "txb_pName";
            txb_pName.Size = new Size(220, 27);
            txb_pName.TabIndex = 1;
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
            // txb_hName
            // 
            txb_hName.Location = new Point(127, 51);
            txb_hName.Name = "txb_hName";
            txb_hName.Size = new Size(220, 27);
            txb_hName.TabIndex = 3;
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
            // txb_date
            // 
            txb_date.Location = new Point(60, 98);
            txb_date.Name = "txb_date";
            txb_date.Size = new Size(287, 27);
            txb_date.TabIndex = 5;
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
            // txb_time
            // 
            txb_time.Location = new Point(60, 143);
            txb_time.Name = "txb_time";
            txb_time.Size = new Size(287, 27);
            txb_time.TabIndex = 7;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(12, 176);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(332, 62);
            btn_saveChanges.TabIndex = 10;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
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
            // viewAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 317);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(txb_time);
            Controls.Add(lbl_time);
            Controls.Add(txb_date);
            Controls.Add(lbl_date);
            Controls.Add(txb_hName);
            Controls.Add(lbl_hName);
            Controls.Add(txb_pName);
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
        private TextBox txb_pName;
        private Label lbl_hName;
        private TextBox txb_hName;
        private Label lbl_date;
        private TextBox txb_date;
        private Label lbl_time;
        private TextBox txb_time;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}