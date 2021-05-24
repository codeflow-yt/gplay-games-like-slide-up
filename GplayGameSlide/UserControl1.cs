using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GplayGameSlide
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(panel1.Size.Width,30);
        }

        int panel1_y = 30; int waiter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 200)
            {
                label1.Hide();
                panel1_y += 6;
                panel1.Size = new Size(panel1.Size.Width,panel1_y);
                if (panel1_y > 251)
                {
                    panel2.Hide();
                    timer1.Enabled = false;
                }
            }
        }
    }
}
