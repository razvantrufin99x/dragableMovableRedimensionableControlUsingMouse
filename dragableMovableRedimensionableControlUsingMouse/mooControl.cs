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
    public partial class mooControl : UserControl
    {
        public mooControl()
        {
            InitializeComponent();
        }

        bool ismd = false;


        public void update()
        {
            this.Width = this.dj.Left + 7;
            this.Height = this.dj.Top + 7;

            this.dc.Left = this.dj.Left;
            this.dc.Top = this.Height / 2;

            this.ds.Left = this.dj.Left;
            this.ds.Top = 0;

            this.sc.Left = 0;
            this.sc.Top = this.Height / 2;

            this.sj.Left = 0;
            this.sj.Top = this.Height - 7;

            this.ss.Left = 0;
            this.ss.Top = 0;

            this.cj.Left = this.Width / 2;
            this.cj.Top = this.Height - 7;

            this.cs.Left = this.Width / 2;
            this.cs.Top = 0;
          
        }
        private void mooControl_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void mooControl_MouseMove(object sender, MouseEventArgs e)
        {
            if(ismd==true)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void mooControl_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }

        private void mooControl_MouseHover(object sender, EventArgs e)
        {
              dc.Visible = true;
             ds.Visible = true;
            sc.Visible = true; 
            sj.Visible = true; 
                ss.Visible = true;
            cj.Visible = true;
            cs.Visible = true;
            ds.Visible = true;
            dj.Visible = true;

            update();

        }

        private void mooControl_MouseLeave(object sender, EventArgs e)
        {
           
           


            update();
        }

        private void mooControl_Load(object sender, EventArgs e)
        {
            dc.Visible = false;
            ds.Visible = false;
            sc.Visible = false;
            sj.Visible = false;
            ss.Visible = false;
            cj.Visible = false;
            cs.Visible = false;
            dj.Visible = false;
        }
    }
}
