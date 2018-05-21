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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed yes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you pressed no");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            button2.Location = new Point
            (
                r.Next(0, this.ClientSize.Width-20), r.Next(0, this.ClientSize.Height-10)
            );
        }
    }
}
