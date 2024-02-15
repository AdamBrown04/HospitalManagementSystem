namespace HospitalManagementSystem
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
            textBox1 = new TextBox();
            lbl_Dname = new Label();
            textBox2 = new TextBox();
            lbl_date = new Label();
            txb_date = new TextBox();
            lbl_time = new Label();
            textBox3 = new TextBox();
            lbl_location = new Label();
            textBox4 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(127, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 1;
            // 
            // lbl_Dname
            // 
            lbl_Dname.AutoSize = true;
            lbl_Dname.Location = new Point(12, 54);
            lbl_Dname.Name = "lbl_Dname";
            lbl_Dname.Size = new Size(106, 20);
            lbl_Dname.TabIndex = 2;
            lbl_Dname.Text = "doctor's name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(60, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 27);
            textBox3.TabIndex = 7;
            // 
            // lbl_location
            // 
            lbl_location.AutoSize = true;
            lbl_location.Location = new Point(12, 195);
            lbl_location.Name = "lbl_location";
            lbl_location.Size = new Size(66, 20);
            lbl_location.TabIndex = 8;
            lbl_location.Text = "location:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 27);
            textBox4.TabIndex = 9;
            // 
            // btn_saveChanges
            // 
            btn_saveChanges.Location = new Point(14, 248);
            btn_saveChanges.Name = "btn_saveChanges";
            btn_saveChanges.Size = new Size(332, 62);
            btn_saveChanges.TabIndex = 10;
            btn_saveChanges.Text = "save changes";
            btn_saveChanges.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(15, 316);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(332, 62);
            btn_return.TabIndex = 11;
            btn_return.Text = "return to menu";
            btn_return.UseVisualStyleBackColor = true;
            // 
            // viewAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 386);
            Controls.Add(btn_return);
            Controls.Add(btn_saveChanges);
            Controls.Add(textBox4);
            Controls.Add(lbl_location);
            Controls.Add(textBox3);
            Controls.Add(lbl_time);
            Controls.Add(txb_date);
            Controls.Add(lbl_date);
            Controls.Add(textBox2);
            Controls.Add(lbl_Dname);
            Controls.Add(textBox1);
            Controls.Add(lbl_Pname);
            Name = "viewAppointments";
            Text = "viewAppointments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Pname;
        private TextBox textBox1;
        private Label lbl_Dname;
        private TextBox textBox2;
        private Label lbl_date;
        private TextBox txb_date;
        private Label lbl_time;
        private TextBox textBox3;
        private Label lbl_location;
        private TextBox textBox4;
        private Button btn_saveChanges;
        private Button btn_return;
    }
}