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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            setDefault();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private int state = 0;
        // یک ارایه یا لیست برای ذخیره دکترها
        // list[]
        private void setDefault()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label3.Text= "Choose your option";
            state = 0;// state 1: add , state2: edit , state 3: delete
            button1.Text = "Show all Doctor information";
            button2.Text = "Add Doctor";
            button3.Text = "Edit Doctor information";
            button4.Text = "Delete Doctor";
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
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
            dataGridView1.DataSource = null; // حتما اول باید نال بشه تا درست نشون بده
            // تمام دکترا روی توی دیتا گرید ویو نمایش بده
            //dataGridView1.DataSource = List;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (state != 1 && state != 0)
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
            if(state == 1) //یعنی تو همین استیت بوده
            {
                // مقادیر از تکس باکس های 1و2 میگیره و به دیتابیس اضافه میکنه
                setDefault();
                button1_Click(sender, e);
            }
            else
            {
                state = 1;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button2.Text = "Save new Doctor";
                button2.ForeColor = Color.Green;
                label3.Text = "Enter new doctor information";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (state != 2 && state != 0)
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
            if(state == 2)
            {
                // مقادیر داخل تکس باکس 3و4 رو جایگزین میکنه
                // اگر با دیتا گرید ویو بخوایم کار کنیم میشه تکس باکس 1و2 رو غیر فعال کرد تا با کلیک روی دیتا گرید ویو مقدار دهی بشن 
                // اگر نه که باید چم کنیم مقادیر داخل 1و2 درستن تا بعد بشه تغیرشون داد
                setDefault();
                button1_Click(sender, e);
            }
            else
            {
                state = 2;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                button3.Text = "Update Doctor Information";
                button3.ForeColor = Color.Green;
                label3.Text = "Enter doctor information";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (state != 3 && state != 0)
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
            if (state == 3)
            {
                //
                setDefault();
                button1_Click(sender, e);
            }
            else
            {
                state = 3;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button4.Text = "Delete Doctor Information";
                button4.ForeColor = Color.Green;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(state != 0)
            {
                int index = e.RowIndex;
                // با استفاده از این ایندکس اطلاعات مربوط به دکتر داخل تکس باکی ها مینویسیم.
                textBox1.Text = "list[index].username";
                textBox2.Text = "list[index].password";
            }
            
        }
    }
}
