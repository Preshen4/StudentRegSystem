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
    class StudentClass
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string YearOfReg { get; set; }
        public string Group { get; set; }
        public List<string> Modules { get; set; }

        public StudentClass(string studentNumber, string firstName, string lastName, string password, string yearOfReg, string group, List<string> modules)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            YearOfReg = yearOfReg;
            Group = group;
            Modules = modules;
        }

        public void AddStudent() 
        {
            var modules = string.Join(",", Modules.ToArray()); // Converts the list to a string and each item is seperated by a ','
            try
            {
                string query = "INSERT INTO Students VALUES (@StudentNumber,@FirstName,@LastName,@StudentPassword,@StudentGroup,@YearReg,@Modules)"; // Inserting values into the database
                string connetionString = @"Data Source=ML-RefVm-631348\SQLEXPRESS;Initial Catalog=StudentDetails;Integrated Security=True"; // The database connection
                SqlConnection cnn = new SqlConnection(connetionString);

                cnn.Open();                     
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.Add("@StudentNumber", SqlDbType.VarChar).Value = StudentNumber; // Adds the details into the database
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                    cmd.Parameters.Add("@StudentPassword", SqlDbType.VarChar).Value = Password;
                    cmd.Parameters.Add("@StudentGroup", SqlDbType.VarChar).Value = Group;
                    cmd.Parameters.Add("@YearReg", SqlDbType.VarChar).Value = YearOfReg;
                    cmd.Parameters.Add("@Modules", SqlDbType.VarChar).Value = modules;

                    cmd.ExecuteNonQuery(); 
                }
                cnn.Close();

                MessageBox.Show("You are now registered at Varsity College");

            }
            catch (Exception ex) // An error message if the database could not be connected or if the database can't be found
            {
                MessageBox.Show("Your details could not be captured onto our system. Please contact an admin for assitance");
            }
        }
    }
}
