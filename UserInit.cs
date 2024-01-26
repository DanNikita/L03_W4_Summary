using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace L03_W4_Summary
{
    public partial class UserInit : UserControl
    {
        public UserInit()
        {
            InitializeComponent();
        }

        public bool authorise;
        public string Login // Login
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Pin // Pin
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Login uses letters only");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Pin uses numbers only");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture is clicked");
        }
        public string InitLog(string a)
        {
            a = Login;
            return a;
        }
        public string InitPin(string b)
        {
            b = Pin;
            return b;
        }

}
}
