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
    public partial class MedicalRecord : Form
    {
        public MedicalRecord(/*Patient p */)
        {
            InitializeComponent();
            textBox5.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Text = "patient.firstName";
            textBox2.Text = "patient.lastName";
            textBox3.Text = "patient.dateOfBrith";
            textBox4.Text = "patient.insurance";
            textBox5.Text = "patient.underlyingDisease";
            //patient = p;
            updateDataGridView();
        }

        //Patient patient ;

        private void updateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = "patient.prescription";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.ShowDialog(/*patient*/);
            updateDataGridView();
        }
    }
}
