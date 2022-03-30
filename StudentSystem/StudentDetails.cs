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
    class StudentDetails
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public StudentDetails(string studentNumber, string firstName, string lastName, string password)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }

        public void AddStudentDetails()
        {

            try
            {
                string query = "INSERT INTO StudentInfo VALUES (@StudentNumber,@StudentPassword,@FirstName,@LastName)"; // Inserting values into the database
                string connetionString = @"Data Source=ML-RefVm-631348\SQLEXPRESS;Initial Catalog=StudentDetails;Integrated Security=True"; // The database connection
                SqlConnection cnn = new SqlConnection(connetionString);

                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.Add("@StudentNumber", SqlDbType.VarChar).Value = StudentNumber; // Adds the details into the database
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                    cmd.Parameters.Add("@StudentPassword", SqlDbType.VarChar).Value = Password;

                    cmd.ExecuteNonQuery();
                }
                cnn.Close();

            }
                catch (Exception ex) // An error message if the database could not be connected or if the database can't be found
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Your details could not be captured onto our system. Please contact an admin for assitance");
            }
        }
    }
}
