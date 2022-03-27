using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class Register : Form
    {
        // Text file paths
        public string HCERT = @"C:\Users\lab_services_student\source\repos\StudentRegSystem\HCERT.txt";
        public string BCA1 = @"C:\Users\lab_services_student\source\repos\StudentRegSystem\BCA1.txt";
        public string BCA2 = @"C:\Users\lab_services_student\source\repos\StudentRegSystem\BCA2.txt";
        public string BCA3 = @"C:\Users\lab_services_student\source\repos\StudentRegSystem\BCA3.txt";
        public string POSTGRAD = @"C:\Users\lab_services_student\source\repos\StudentRegSystem\POSTGRAD.txt";
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName, lastName, password, studentNumber,yearOfReg,group;
            studentNumber = txtbStudentNumber.Text;
            firstName = txtbFirstName.Text;
            lastName = txtbLastName.Text;
            password = txtbPassword.Text;
            yearOfReg = cmbYearOfReg.SelectedItem.ToString();
            group = cmbGroup.SelectedItem.ToString();

            var Modules = new List<string>();

            foreach (var module in chkbModules.CheckedItems)
            {
                Modules.Add(module.ToString()); //Adds all the checked items into the List
            }

            StudentClass student = new StudentClass(studentNumber,firstName,lastName,password,yearOfReg,group,Modules); // The student class is used to capture the details of the user
            student.AddStudent();
        }

        private void cmbYearOfReg_SelectedIndexChanged(object sender, EventArgs e) // Reads a textfile so the appropriate modules are loaded
        {
            switch (cmbYearOfReg.SelectedIndex)
            {
                case 0:
                    setModules(HCERT);
                    break;
                case 1:
                    setModules(BCA1);
                    break;
                case 2:
                    setModules(BCA2);
                    break;
                case 3:
                    setModules(BCA3);
                    break;
                case 4:
                    setModules(POSTGRAD);
                    break;
            }
        }
        public void setModules(string name) // Reads a text file and load the items into the checkbox list
        {
            chkbModules.Items.Clear();
            String line;

            try
            { 
                StreamReader sr = new StreamReader(name);
                line = sr.ReadLine();
               
                while (line != null)
                {
                    chkbModules.Items.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured and your modules could not be loaded. Please contact an admin for assitance");
            }
        }
    }

    
}
