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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // لیستی برای دارو ها
        //list

        private void showMedicines()
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = List;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ذخیره اطلاعات گرفته شده از تکس باکس ها

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {

        }
    }
}
