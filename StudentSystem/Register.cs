using StudentSystem.Validators;
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

        public StudentInfoValidator infoValidator = new StudentInfoValidator();
        public StudentModuleValidator moduleValidator = new StudentModuleValidator();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            addStudentInfo();
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

        private void chkRepeatModules_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRepeatModules.Checked)
            {
                chkbModulesRepeat.Visible = true;
                cmbGroupRepeat.Visible = true;
                cmbYearRepeat.Visible = true;
                btnRepeatModules.Visible = true;
            }
            else
            {
                chkbModulesRepeat.Visible = false;
                cmbGroupRepeat.Visible = false;
                cmbYearRepeat.Visible = false;
                btnRepeatModules.Visible = false;
            }
            
        }

        private void btnRepeatModules_Click(object sender, EventArgs e)
        {
            try
            {
                string userNameCourse = txtbStudentNumber.Text + "_" + cmbYearRepeat.SelectedItem.ToString();
                string group = cmbGroupRepeat.SelectedItem.ToString();
                string course = cmbYearRepeat.SelectedItem.ToString();
                if (cmbYearRepeat.SelectedIndex < cmbYearOfReg.SelectedIndex)
                {
                    var RepeatModules = new List<string>();
                    foreach (var module in chkbModulesRepeat.CheckedItems)
                    {
                        RepeatModules.Add(module.ToString()); //Adds all the checked items into the List
                    }
                    string modules = null;
                    foreach (var item in RepeatModules)
                    {
                        modules += item + ",";
                    }

                    StudentModules studentModules = new StudentModules(course, modules, group, userNameCourse);
                    studentModules.AddStudentDetails();
                }
                else
                {
                    MessageBox.Show("Please choose the correct course");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void cmbYearRepeat_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void addStudentInfo() 
        {
            try
            { 
                string studentNumber = txtbStudentNumber.Text;
                string firstName = txtbFirstName.Text;
                string lastName = txtbLastName.Text;
                string password = txtbPassword.Text;

                StudentDetails student = new StudentDetails(studentNumber, firstName, lastName, password); // The student class is used to capture the details of the user
                var result = infoValidator.Validate(student);
                if (result.IsValid)
                { 
                    student.AddStudentDetails();
                    addStudentModules();
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        MessageBox.Show($"{item.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void addStudentModules() 
        {
            try
            { 
                string yearOfReg = cmbYearOfReg.SelectedItem.ToString();
                string group = cmbGroup.SelectedItem.ToString();

                var Modules = new List<string>();

                foreach (var module in chkbModules.CheckedItems)
                {
                    Modules.Add(module.ToString()); //Adds all the checked items into the List
                }
                string modules = null;
                foreach (var item in Modules)
                {
                    modules += item + ",";
                }

                string userNameCourse = txtbStudentNumber.Text + "_" + yearOfReg;
                StudentModules studentModules = new StudentModules(yearOfReg, modules, group, userNameCourse);

                var valid = moduleValidator.Validate(studentModules);
                if (valid.IsValid)
                {
                    studentModules.AddStudentDetails();
                }
                else
                {
                    foreach (var item in valid.Errors)
                    {
                        MessageBox.Show($"{item.ErrorMessage}");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    } 
}
