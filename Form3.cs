using System;
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
    public partial class Form3 : Form
    {
        int a, b, c;
        private const int addr = 0;


        public Form3()
        {
            InitializeComponent();
            a = 0;
            b = 0;
            c = 0;
        }

        

        public Form3(int a, int b, int c)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
