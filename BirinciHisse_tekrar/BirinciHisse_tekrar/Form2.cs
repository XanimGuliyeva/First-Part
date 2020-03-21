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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL=("http://46.20.7.125/listen.pls");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ("http://46.20.3.204:80/");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/?hl=tr");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 bilet = new Form3();
            bilet.Show();
            this.Hide();
        }
    }
}
