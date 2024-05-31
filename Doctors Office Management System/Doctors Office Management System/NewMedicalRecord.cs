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
    public partial class NewMedicalRecord : Form
    {
        public NewMedicalRecord()
        {
            InitializeComponent();
        }

        private void save()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ذخیره در دیتابیس
            save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ذخیره در دیتابیس 
            save();
            this.Close();
            MedicalRecord medicalRecord = new MedicalRecord();
            medicalRecord.ShowDialog(/*شی بیمار*/);
        }
    }
}
