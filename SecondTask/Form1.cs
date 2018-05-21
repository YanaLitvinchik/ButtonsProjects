using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTask
{
    public partial class Form1 : Form
    {
        public int x_ { get; set; }
        public int y_ { get; set; }
        public Form1()
        {

            x_ = 10;
            y_ = 10;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(
                    button1.Location.X + x_,
                    button1.Location.Y + y_
                );
            if (button1.Location.Y >= this.ClientSize.Height-30)
                y_ = -10;
            if (button1.Location.X >= this.ClientSize.Width - 50)
                x_ = -10;
            if (button1.Location.Y <= 0)
                y_ = 10;
            if (button1.Location.X <= 0)
                x_ = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
            
        }
    }
}
