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
            SuspendLayout();
            // 
            // lsb_selectTable
            // 
            lsb_selectTable.FormattingEnabled = true;
            lsb_selectTable.Location = new Point(12, 12);
            lsb_selectTable.Name = "lsb_selectTable";
            lsb_selectTable.Size = new Size(301, 264);
            lsb_selectTable.TabIndex = 0;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(12, 282);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(301, 65);
            btn_submit.TabIndex = 1;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // selectTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 352);
            Controls.Add(btn_submit);
            Controls.Add(lsb_selectTable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "selectTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "select group";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsb_selectTable;
        private Button btn_submit;
    }
}