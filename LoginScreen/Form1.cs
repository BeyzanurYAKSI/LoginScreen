﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string username;
        string password;
        private void button1_Click(object sender, EventArgs e)
        {
              

            if(textBox1.Text=="Beyzanur" && textBox2.Text=="123456789")
            {
                MessageBox.Show("WELCOME");
                Form2 form = new Form2();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorret");
            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            password = textBox2.Text;
        }
    }
}
