namespace ADODay1_G2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Students = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txt_fname = new TextBox();
            nud_age = new NumericUpDown();
            txt_address = new TextBox();
            txt_lname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            cb_deptId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Students).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            SuspendLayout();
            // 
            // dgv_Students
            // 
            dgv_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Students.Location = new Point(12, 204);
            dgv_Students.Name = "dgv_Students";
            dgv_Students.RowTemplate.Height = 25;
            dgv_Students.Size = new Size(776, 234);
            dgv_Students.TabIndex = 0;
            dgv_Students.RowHeaderMouseDoubleClick += dgv_Students_RowHeaderMouseDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(200, 26);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(100, 23);
            txt_fname.TabIndex = 1;
            // 
            // nud_age
            // 
            nud_age.Location = new Point(457, 33);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(120, 23);
            nud_age.TabIndex = 2;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(200, 116);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(100, 23);
            txt_address.TabIndex = 3;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(200, 77);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(100, 23);
            txt_lname.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 85);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 127);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 40);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 9;
            label4.Text = "age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 82);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Department";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(189, 175);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(335, 175);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 12;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(482, 175);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cb_deptId
            // 
            cb_deptId.FormattingEnabled = true;
            cb_deptId.Location = new Point(456, 77);
            cb_deptId.Name = "cb_deptId";
            cb_deptId.Size = new Size(121, 23);
            cb_deptId.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_deptId);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_lname);
            Controls.Add(txt_address);
            Controls.Add(nud_age);
            Controls.Add(txt_fname);
            Controls.Add(dgv_Students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Students).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Students;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txt_fname;
        private NumericUpDown nud_age;
        private TextBox txt_address;
        private TextBox txt_lname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private ComboBox cb_deptId;
    }
}