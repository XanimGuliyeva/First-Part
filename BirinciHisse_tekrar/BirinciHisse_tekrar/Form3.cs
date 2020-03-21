using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirinciHisse_tekrar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label5.Text = ("Zehmet olmazsa formu doldurub,sonra ise oturacaginiz oturacagin nomresini secin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Surucunun nomresini qeyd edin");
            }
            else
            {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("2");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked==true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked==true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("3");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("4");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("5");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button5.Enabled = false;
        }
    }
}
