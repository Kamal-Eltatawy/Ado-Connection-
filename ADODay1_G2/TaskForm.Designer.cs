namespace ADODay1_G2
{
    partial class TaskForm
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
            cb_topId = new ComboBox();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            nud_CourseID = new NumericUpDown();
            txt_cname = new TextBox();
            grid_course = new DataGridView();
            label1 = new Label();
            nud_CourseDur = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_CourseID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_course).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_CourseDur).BeginInit();
            SuspendLayout();
            // 
            // cb_topId
            // 
            cb_topId.FormattingEnabled = true;
            cb_topId.Location = new Point(186, 67);
            cb_topId.Margin = new Padding(3, 4, 3, 4);
            cb_topId.Name = "cb_topId";
            cb_topId.Size = new Size(138, 28);
            cb_topId.TabIndex = 27;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(534, 122);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(86, 31);
            btn_delete.TabIndex = 26;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(371, 122);
            btn_edit.Margin = new Padding(3, 4, 3, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(86, 31);
            btn_edit.TabIndex = 25;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(186, 122);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(86, 31);
            btn_add.TabIndex = 24;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 75);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 23;
            label5.Text = "Topic";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 32);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 22;
            label4.Text = "Course ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 30);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 19;
            label6.Text = "Course Name";
            // 
            // nud_CourseID
            // 
            nud_CourseID.Location = new Point(496, 30);
            nud_CourseID.Margin = new Padding(3, 4, 3, 4);
            nud_CourseID.Maximum = new decimal(new int[] { 90000, 0, 0, 0 });
            nud_CourseID.Name = "nud_CourseID";
            nud_CourseID.Size = new Size(137, 27);
            nud_CourseID.TabIndex = 16;
            // 
            // txt_cname
            // 
            txt_cname.Location = new Point(186, 32);
            txt_cname.Margin = new Padding(3, 4, 3, 4);
            txt_cname.Name = "txt_cname";
            txt_cname.Size = new Size(138, 27);
            txt_cname.TabIndex = 15;
            // 
            // grid_course
            // 
            grid_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_course.Location = new Point(-3, 196);
            grid_course.Name = "grid_course";
            grid_course.RowHeadersWidth = 51;
            grid_course.RowTemplate.Height = 29;
            grid_course.Size = new Size(791, 249);
            grid_course.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 67);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 30;
            label1.Text = "Course Duration";
            // 
            // nud_CourseDur
            // 
            nud_CourseDur.Location = new Point(496, 65);
            nud_CourseDur.Margin = new Padding(3, 4, 3, 4);
            nud_CourseDur.Name = "nud_CourseDur";
            nud_CourseDur.Size = new Size(137, 27);
            nud_CourseDur.TabIndex = 29;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(nud_CourseDur);
            Controls.Add(grid_course);
            Controls.Add(cb_topId);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(nud_CourseID);
            Controls.Add(txt_cname);
            Name = "TaskForm";
            Text = "TaskForm";
            Load += TaskForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_CourseID).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_course).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_CourseDur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_topId;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private Label label5;
        private Label label4;
        private Label label6;
        private NumericUpDown nud_CourseID;
        private TextBox txt_cname;
        private DataGridView grid_course;
        private Label label1;
        private NumericUpDown nud_CourseDur;
    }
}