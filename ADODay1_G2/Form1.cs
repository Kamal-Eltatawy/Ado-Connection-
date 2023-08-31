using ADODay1_G2.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ADODay1_G2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            // define connection string
            string connectionStr = "server=.;Database=iti;Trusted_Connection=true;TrustServerCertificate=true";

            // define connection
            connection = new SqlConnection(connectionStr);
            //connection.ConnectionString = connectionStr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllStudents();
            GetDepartments();

            btn_add.Visible = true; 
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }

        void GetAllStudents()
        {
            // define command
            //SqlCommand cmd = new SqlCommand("select * from student",connection);

            //cmd.CommandText = "select * from student";
            //cmd.Connection = connection;
            //cmd.CommandType = System.Data.CommandType.Text;

            SqlCommand cmd = connection.CreateCommand();
            //cmd.CommandText = "select * from student";

            cmd.CommandText = "select [St_Id],[St_Fname],[St_Lname],[St_Age],[St_Address],[Dept_Id]from Student;";

            List<Student> students = new List<Student>();
            DataTable dt = new DataTable();
            try
            {
                // open connection
                connection.Open();

                // execute command
                SqlDataReader reader = cmd.ExecuteReader();
                // retrieve data



                //while (reader.Read())
                //{
                //    Student student = new Student()
                //    {
                //        Id = (int)reader["St_Id"],
                //        FirstName = reader["St_Fname"].ToString(),
                //        LastName = reader["St_Lname"].ToString(),
                //        Address = reader["St_Address"].ToString(),
                //        Age = (int)((reader["St_Age"] == DBNull.Value) ? 0 : reader["St_Age"]),
                //        //Id = (int)reader[0],
                //        //FirstName = reader[1].ToString(),
                //        //LastName = reader[2].ToString(),
                //        //Address = reader[3].ToString(),
                //        //Age = (int)((reader[4] == DBNull.Value) ? 0 : reader["St_Age"]),
                //        //Dept_id = (int)reader["Dept_Id"],
                //        //Supervisor = (int)reader["St_super"]
                //    };
                //    students.Add(student);
                //}

                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                // close connection
                connection.Close();
            }
            // display data

            dgv_Students.DataSource = dt;
        }

        void GetDepartments()
        {
            //define command 
            SqlCommand cmd = new SqlCommand("select Dept_Id,Dept_Name from department", connection);

            // open connection
            connection.Open();
            // execute command
            SqlDataReader reader = cmd.ExecuteReader();

            // retrieve data
            DataTable dt = new DataTable();
            dt.Load(reader);

            // close connection
            connection.Close();

            // display data
            cb_deptId.DataSource = dt;

            cb_deptId.DisplayMember = "Dept_Name";
            cb_deptId.ValueMember = "Dept_Id";
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            //define command
            SqlCommand cmd = new SqlCommand($"insert into Student([St_Fname],[St_Lname],[St_Address],[St_Age],[Dept_Id])  values('{txt_fname.Text}','{txt_lname.Text}','{txt_address.Text}',{nud_age.Value},{cb_deptId.SelectedValue})", connection);
            int rowsEffected = 0;
            try
            {
                //open connection
                connection.Open();
                // execute command
                rowsEffected = cmd.ExecuteNonQuery();
                // retrieve data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record wasn't added");
            }
            finally
            {
                // close connection
                connection.Close();
            }

            // display data
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data added.");
                GetAllStudents();
            }
            ClearInputs();
        }

        void ClearInputs()
        {
            txt_fname.Text = txt_lname.Text = txt_address.Text = "";
            nud_age.Value = 0;
            cb_deptId.SelectedValue = 10;
        }

        int id;
        private void dgv_Students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_Students.Rows[e.RowIndex];

            id = (int)row.Cells[0].Value;
            txt_fname.Text = row.Cells[1].Value.ToString();
            txt_lname.Text = row.Cells[2].Value.ToString();
            txt_address.Text = row.Cells[4].Value.ToString();
            nud_age.Value = (int)((row.Cells[3].Value == DBNull.Value) ? 0 : row.Cells[3].Value);
            cb_deptId.SelectedValue = (int)row.Cells[5].Value;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_edit.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Student set [St_Fname] = @fname,[St_Lname]=@lname,[St_Address]=@address,[St_Age]=@age,[Dept_Id]=@deptId where[St_Id] = @id", connection);
            cmd.Parameters.AddWithValue("fname", txt_fname.Text);
            cmd.Parameters.AddWithValue("lname", txt_lname.Text);
            cmd.Parameters.AddWithValue("address", txt_address.Text);
            cmd.Parameters.AddWithValue("age", nud_age.Value);
            cmd.Parameters.AddWithValue("deptId", cb_deptId.SelectedValue);
            cmd.Parameters.AddWithValue("id", id);

            connection.Open();

            int rowsEffected = cmd.ExecuteNonQuery();

            connection.Close();

            if (rowsEffected > 0)
            {
                MessageBox.Show("Edit was done");
                GetAllStudents();
            }

            ClearInputs();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Student where st_id=@id;",connection);

            cmd.Parameters.AddWithValue("id", id);

            connection.Open();

            int rowsEffected = cmd.ExecuteNonQuery();

            connection.Close();

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data deleted");
                GetAllStudents();
            }
            ClearInputs();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }
    }
}