﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmk mk=new quenmk();
            mk.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text== "quanly@" && textBox2.Text=="55555")
            {
                
                đnthanhcong login=new đnthanhcong();
                login.Show();
               
             }
            
            else if(textBox1.Text=="thuthu@" && textBox2.Text == "55555")
            { 
                đnthanhcong2 login = new đnthanhcong2();
                login.Show();
               

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
