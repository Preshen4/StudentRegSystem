using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    class StudentModules
    {

        public string RegYear { get; set; }
        public List<string> Modules { get; set; }
        public string Group { get; set; }
        public string UserName_Course { get; set; }

        public StudentModules(string regYear, List<string> modules, string group, string userName_Course)
        {
            RegYear = regYear;
            Modules = modules;
            Group = group;
            UserName_Course = userName_Course;
        }
        public void AddStudentDetails()
        {
            string modules=null;
            foreach (var item in Modules)
            {
                modules += item + ",";
            }

            try
            {
                string query = "INSERT INTO StudentCourse VALUES (@StudentNumber_Course,@Module,@CourseGroup,@Course)"; // Inserting values into the database
                string connetionString = @"Data Source=ML-RefVm-631348\SQLEXPRESS;Initial Catalog=StudentDetails;Integrated Security=True"; // The database connection
                SqlConnection cnn = new SqlConnection(connetionString);

                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.Add("@StudentNumber_Course", SqlDbType.VarChar).Value = UserName_Course; // Adds the details into the database
                    cmd.Parameters.Add("@Module", SqlDbType.VarChar).Value = modules;
                    cmd.Parameters.Add("@CourseGroup", SqlDbType.VarChar).Value = Group;
                    cmd.Parameters.Add("@Course", SqlDbType.VarChar).Value = RegYear;

                    cmd.ExecuteNonQuery();
                }
                cnn.Close();

                MessageBox.Show("You are now registered at Varsity College");

            }
            catch (Exception ex) // An error message if the database could not be connected or if the database can't be found
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Your details could not be captured onto our system. Please contact an admin for assitance");
            }
        }
    }
}
