using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName, password;
            bool isStudent = false;

            userName = txtUserName.Text;
            password = txtPassword.Text;
            
            try
            {
                string connetionString = @"Data Source=ML-RefVm-631348\SQLEXPRESS;Initial Catalog=StudentDetails;Integrated Security=True";

                string query = "SELECT StudentNumber,StudentPassword FROM Students";

                SqlConnection cnn = new SqlConnection(connetionString);

                SqlCommand cmd = new SqlCommand(query, cnn);

                cnn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((userName == reader.GetString(0)) && (password == reader.GetString(1))) // Checks to see if the login details match the database
                        {
                            isStudent = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured as you tried to login... Please contact an admin");
            }

            if (isStudent)
            {
                MessageBox.Show("WELCOME BACK TO VARSITY COLLEGE {0}",userName);
            }
            else
            {
                MessageBox.Show("Your details are incorrect or you need to register!");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(); 
            register.ShowDialog();
        }
    }
}
