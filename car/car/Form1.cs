using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
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

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (TBlogin.Text == "user" && TBpassword.Text == "1234") { 
            panel4.Visible = true;
                panel4.SetBounds(12,12,330,320);
            panel1.Visible = false;
        }
        }

        private void bRegist_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.SetBounds(60, 12, 330, 320);
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.SetBounds(12, 12, 330, 320);
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.SetBounds(70, 150, 330, 320);
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.SetBounds(12, 12, 330, 320);
            panel3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel1.Visible = true;
            panel1.SetBounds(12, 12, 330, 320);
        }
    }
}
