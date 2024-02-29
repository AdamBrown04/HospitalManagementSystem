namespace HospitalManagementSystem
{
    partial class selectTable
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
            lsb_selectTable = new ListBox();
            btn_submit = new Button();
            lbl_jobRole = new Label();
            SuspendLayout();
            // 
            // lsb_selectTable
            // 
            lsb_selectTable.FormattingEnabled = true;
            lsb_selectTable.Location = new Point(12, 36);
            lsb_selectTable.Name = "lsb_selectTable";
            lsb_selectTable.Size = new Size(301, 264);
            lsb_selectTable.TabIndex = 0;
            lsb_selectTable.SelectedIndexChanged += lsb_selectTable_SelectedIndexChanged;
            // 
            // btn_submit
            // 
            btn_submit.Enabled = false;
            btn_submit.Location = new Point(12, 306);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(301, 65);
            btn_submit.TabIndex = 1;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // lbl_jobRole
            // 
            lbl_jobRole.AutoSize = true;
            lbl_jobRole.Location = new Point(12, 9);
            lbl_jobRole.Name = "lbl_jobRole";
            lbl_jobRole.Size = new Size(64, 20);
            lbl_jobRole.TabIndex = 2;
            lbl_jobRole.Text = "job role:";
            // 
            // selectTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 383);
            Controls.Add(lbl_jobRole);
            Controls.Add(btn_submit);
            Controls.Add(lsb_selectTable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "selectTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "select group";
            FormClosed += selectTable_FormClosed;
            Load += selectTable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsb_selectTable;
        private Button btn_submit;
        private Label lbl_jobRole;
    }
}