using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 invoked");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi All!! I am a Button in the Form ");
            if(UserName.Text=="Zensar")
            {
                MessageBox.Show("It is a company name");
            }
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            //  BtnLogin.BackColor = Color.Red;
            ((Button)sender).BackColor = Color.Red;

        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            //BtnLogin.ForeColor = Color.White;
            //MyForm2 frm2=new MyForm2();
            //frm2.Show();
            ((Button)sender).ForeColor = Color.White;
        }
                  
        
        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            this.button1.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            this.button1.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
        }

        private void button2_MouseEnter_1(object sender, EventArgs e)
        {
            this.button2.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
        this.button2.MouseEnter += new System.EventHandler(this.BtnLogin_MouseLeave);
    }
    }
}
