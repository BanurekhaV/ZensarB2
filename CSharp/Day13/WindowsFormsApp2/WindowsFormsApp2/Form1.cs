using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //onclick of one control, all the buttons are set to different backcolor
        //and then the button which is a sender gets a different color
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                c.BackColor = Color.Blue;
            }
            //set the clicked control(button) to a different color
            Control bc = (Control)sender;
            bc.BackColor = Color.GreenYellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
           // textBox2.Text = string.Empty;
            for(int i=0; i<this.Controls.Count;i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = "";
                    this.Controls[i].BackColor = Color.DimGray;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Coral;
            ((TextBox)sender).ForeColor = Color.White;            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            this.textBox3.MouseEnter+=new System.EventHandler(this.textBox1_MouseEnter);
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            this.textBox3.MouseLeave+=new System.EventHandler(this.textBox1_MouseLeave);
        }
        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            this.textBox4.MouseEnter+= new System.EventHandler(this.textBox1_MouseEnter);
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            this.textBox4.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            this.textBox5.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
