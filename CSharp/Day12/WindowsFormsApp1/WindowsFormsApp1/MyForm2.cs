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
    public partial class MyForm2 : Form
    {
        public MyForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                c.BackColor = Color.Blue;
                c.ForeColor = Color.White;
            }
            Control o = (Control)sender;
            o.BackColor = Color.Green;
            o.ForeColor = Color.Azure;
        }
    }
}
