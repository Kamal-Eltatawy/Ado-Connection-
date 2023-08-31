using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace ADODay1_G2
{
    public partial class TaskForm : Form
    {
        SqlConnection connection;
        DataTable dt;
        public TaskForm()
        {
            InitializeComponent();
            //Conection String => Path 
            string connectionString = "Server =. ; DataBase= iti ; Trusted_connection=true;TrustServerCertificate=true";
            //Define Connection
            connection = new SqlConnection(connectionString);
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            GetAllData();
            GetTopic();
        }
        void GetAllData()
        {
            // Define Command To get All Data
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select * from course";
            List<Course> coursesList = new List<Course>();
            #region Using List
            try
            {
                //open connection
                connection.Open();
                // excute the command 
                SqlDataReader reader = cmd.ExecuteReader();
                // Get All Data
                while (reader.Read())
                {
                    Course course = new Course()
                    {
                        ID = (int)((reader["Crs_id"] == DBNull.Value) ? 0 : reader["Crs_id"]),
                        TopID = (int)((reader["Top_id"] == DBNull.Value) ? 0 : reader["Top_id"]),
                        Duration = (int)((reader["Crs_Duration"] == DBNull.Value) ? 0 : reader["Crs_Duration"]),
                        Name = (string)((reader["Crs_Name"] == DBNull.Value) ? "" : reader["Crs_Name"])
                    };
                    coursesList.Add(course);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            grid_course.DataSource = coursesList;
            #endregion
            #region Using DataTable
            //dt = new DataTable();
            //    try
            //    {
            //        //open connection
            //        connection.Open();
            //        //Exceute The Command
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        // retrieve data
            //        dt.Load(reader);

            //    }
            //    catch (Exception e)
            //    {

            //        MessageBox.Show(e.Message);
            //    }
            //    finally
            //    {
            //        //Close Connection
            //        connection.Close();
            //    }
            //    //display
            //    grid_course.DataSource = dt;
            #endregion
        }
        void GetTopic()
        {
            // define command
            SqlCommand cmd = new SqlCommand("select [Top_Id],[Top_Name]from Topic", connection);
            try
            {
                //open connection
                connection.Open();
                //eccute command
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                //get data
                dt = new DataTable();
                dt.Load(sqlDataReader);
                //
                cb_topId.DataSource = dt;
                cb_topId.DisplayMember = "Top_Name";
                cb_topId.ValueMember = "Top_id";
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                //close connection
                connection.Close();
            }
        }
        void clear()
        {
            nud_CourseDur.Value = nud_CourseID.Value = 0;
            txt_cname.Text = "";
            cb_topId.SelectedValue = 0;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand($"insert into Course values({nud_CourseID.Value},'{txt_cname.Text}',{nud_CourseDur.Value},{cb_topId.SelectedValue})", connection);
            int rowsEffected = 0;
            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(" Invalid Inputs");
            }
            finally
            {
                connection.Close();
            }
            if (rowsEffected > 0)
            {
                MessageBox.Show($"{rowsEffected}Row Effected");
                GetAllData();
            }
            clear();

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update Course set  Crs_Name=@Cname, Crs_Duration=@Cduration , Top_Id=@Tid where Crs_Id=@Cid";
            cmd.Parameters.AddWithValue("Cname",txt_cname.Text);
            cmd.Parameters.AddWithValue("Cduration", nud_CourseDur.Value);
            cmd.Parameters.AddWithValue("Tid", cb_topId.SelectedValue);
            cmd.Parameters.AddWithValue("Cid", nud_CourseID.Value);



        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"delete Course where Crs_Id={nud_CourseID.Value}";
            int rowsEffected = 0;
            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show(" Invalid Inputs");
            }
            finally
            {
                connection.Close();
            }
            if (rowsEffected > 0)
            {
                MessageBox.Show($"{rowsEffected}Row Effected");
                GetAllData();
            }
            clear();

        }

    }
}
