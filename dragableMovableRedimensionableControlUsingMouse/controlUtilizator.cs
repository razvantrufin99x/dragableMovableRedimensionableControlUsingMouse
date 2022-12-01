using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dragableMovableRedimensionableControlUsingMouse
{
    public partial class controlUtilizator : UserControl
    {
        public controlUtilizator()
        {
            InitializeComponent();
        }

        bool ismd = false;

        private void controlUtilizator_Load(object sender, EventArgs e)
        {

        }

        private void controlUtilizator_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void controlUtilizator_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void controlUtilizator_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }
    }
}
