﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form3 form3 = new Form3();
                form3.Show();
                Hide();
            }
            else
            {
                Form2 frm = new Form2();
                frm.Show();
                Hide();
                
            }
        }


        
    }
}
