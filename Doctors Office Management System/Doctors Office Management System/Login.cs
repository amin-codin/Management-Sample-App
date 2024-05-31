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

namespace Doctors_Office_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            String query = "";
            /*
            if (username == "admin")
            {
                query = "Select U.password From Users as U Where U.username = 'admin';";
            }
            else
            {
                query = "Select U.password From Users as U Where U.username = '" + username + "';";
            }
            */
            AdminDashboard a = new AdminDashboard();
            a.ShowDialog();
            DoctorDashboard d = new DoctorDashboard();
           // d.ShowDialog();
            NewMedicalRecord newMedicalRecord = new NewMedicalRecord();
            //newMedicalRecord.ShowDialog();

        }

        AboutUs aboutUs = new AboutUs();
        private void Button2_Click(object sender, EventArgs e)
        {
            aboutUs.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;

                System.Diagnostics.Process.Start(projectDirectory + @"./README.md");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
