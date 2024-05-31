using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors_Office_Management_System
{
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
            setDefault();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int state = 0;

        private void setDefault()
        {
            textBox1.Enabled = false;
            //textBox1.Text = "";
            button4.Enabled = false;
            state = 0;
            label1.Text = "Choose your option";
            button1.Text = "Show all Patient information";
            button2.Text = "Create new Patient";
            button3.Text = "Search Patient";
            button4.Text = "Show Medical Record";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            //button4.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state != 0)
            {
                if (MessageBox.Show("Dont save your change \nAre you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    setDefault();
                }
                else
                {
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (state != 0)
            {
                if (MessageBox.Show("Dont save your change \nAre you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    setDefault();
                }
                else
                {
                    return;
                }
            }
            NewMedicalRecord newMedicalRecord = new NewMedicalRecord();
            newMedicalRecord.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(state == 1)
            {
                bool find = false;
                // جستجو و نمایش اطلاعات بیمار با شو مسیج در صورت وجود داشتن یوزر نیم
                if(find)
                {
                    MessageBox.Show("");
                    setDefault();
                    button4.Enabled = true;
                    button4.ForeColor = Color.Green;
                    
                }
                else
                {
                    MessageBox.Show("username is Not exist!");
                    setDefault();
                    button4.Enabled = false;
                }
            }
            else
            {
                state = 1;
                label1.Text = "Enter username";
                button3.Text = "Patient search with username";
                textBox1.Enabled = true;
                textBox1.Text = "";
                button3.ForeColor = Color.Green;
                button4.ForeColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (state != 0)
            {
                if (MessageBox.Show("Dont save your change \nAre you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    setDefault();
                }
                else
                {
                    return;
                }
            }
            MedicalRecord medicalRecord = new MedicalRecord();
            medicalRecord.ShowDialog();
        }
    }
}
