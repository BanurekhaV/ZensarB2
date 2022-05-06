using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int countCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader("AsyncSampleFile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private async void ClickMe_Click(object sender, EventArgs e)
        {
            //int z = countCharacters();
            Task<int> task = new Task<int>(countCharacters);
            task.Start();
            label1.BackColor = Color.GreenYellow;
            label1.ForeColor = Color.Red;
            label1.Text = "Processing file .. Please wait..";
            int z = await task;
            label1.Text = z.ToString() + " " + "Characters are there in the File";
        }
    }
}
