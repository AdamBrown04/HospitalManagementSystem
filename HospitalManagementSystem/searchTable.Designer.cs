﻿namespace HospitalManagementSystem
{
    partial class searchTable
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
            lsb_Tablerecords = new ListBox();
            btn_select = new Button();
            btn_return = new Button();
            btn_addNewEntry = new Button();
            SuspendLayout();
            // 
            // lsb_Tablerecords
            // 
            lsb_Tablerecords.FormattingEnabled = true;
            lsb_Tablerecords.Location = new Point(12, 12);
            lsb_Tablerecords.Name = "lsb_Tablerecords";
            lsb_Tablerecords.Size = new Size(776, 304);
            lsb_Tablerecords.TabIndex = 2;
            lsb_Tablerecords.SelectedIndexChanged += lsb_Tablerecords_SelectedIndexChanged;
            // 
            // btn_select
            // 
            btn_select.Enabled = false;
            btn_select.Location = new Point(12, 322);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(245, 58);
            btn_select.TabIndex = 3;
            btn_select.Text = "select";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(527, 322);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(261, 58);
            btn_return.TabIndex = 4;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // btn_addNewEntry
            // 
            btn_addNewEntry.Enabled = false;
            btn_addNewEntry.Location = new Point(263, 322);
            btn_addNewEntry.Name = "btn_addNewEntry";
            btn_addNewEntry.Size = new Size(258, 58);
            btn_addNewEntry.TabIndex = 5;
            btn_addNewEntry.Text = "add new entry";
            btn_addNewEntry.UseVisualStyleBackColor = true;
            btn_addNewEntry.Click += btn_addNewEntry_Click;
            // 
            // searchTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 387);
            Controls.Add(btn_addNewEntry);
            Controls.Add(btn_return);
            Controls.Add(btn_select);
            Controls.Add(lsb_Tablerecords);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "searchTable";
            Text = "search group";
            FormClosed += searchTable_FormClosed;
            Load += searchTable_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListBox lsb_Tablerecords;
        private Button btn_select;
        private Button btn_return;
        private Button btn_addNewEntry;
    }
}