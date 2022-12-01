namespace dragableMovableRedimensionableControlUsingMouse
{
    partial class mooControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ds = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.dj = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.sj = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.cj = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.dc = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.cs = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.ss = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.sc = new dragableMovableRedimensionableControlUsingMouse.controlUtilizator();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.BackColor = System.Drawing.Color.White;
            this.ds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ds.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ds.Location = new System.Drawing.Point(79, 0);
            this.ds.Margin = new System.Windows.Forms.Padding(0);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(5, 5);
            this.ds.TabIndex = 7;
            // 
            // dj
            // 
            this.dj.BackColor = System.Drawing.Color.White;
            this.dj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dj.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dj.Location = new System.Drawing.Point(79, 81);
            this.dj.Margin = new System.Windows.Forms.Padding(0);
            this.dj.Name = "dj";
            this.dj.Size = new System.Drawing.Size(5, 5);
            this.dj.TabIndex = 6;
            // 
            // sj
            // 
            this.sj.BackColor = System.Drawing.Color.White;
            this.sj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sj.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sj.Location = new System.Drawing.Point(0, 81);
            this.sj.Margin = new System.Windows.Forms.Padding(0);
            this.sj.Name = "sj";
            this.sj.Size = new System.Drawing.Size(5, 5);
            this.sj.TabIndex = 5;
            // 
            // cj
            // 
            this.cj.BackColor = System.Drawing.Color.White;
            this.cj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cj.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cj.Location = new System.Drawing.Point(40, 81);
            this.cj.Margin = new System.Windows.Forms.Padding(0);
            this.cj.Name = "cj";
            this.cj.Size = new System.Drawing.Size(5, 5);
            this.cj.TabIndex = 4;
            // 
            // dc
            // 
            this.dc.BackColor = System.Drawing.Color.White;
            this.dc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dc.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dc.Location = new System.Drawing.Point(79, 38);
            this.dc.Margin = new System.Windows.Forms.Padding(0);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(5, 5);
            this.dc.TabIndex = 3;
            // 
            // cs
            // 
            this.cs.BackColor = System.Drawing.Color.White;
            this.cs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cs.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cs.Location = new System.Drawing.Point(40, 0);
            this.cs.Margin = new System.Windows.Forms.Padding(0);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(5, 5);
            this.cs.TabIndex = 2;
            // 
            // ss
            // 
            this.ss.BackColor = System.Drawing.Color.White;
            this.ss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ss.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Margin = new System.Windows.Forms.Padding(0);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(5, 5);
            this.ss.TabIndex = 1;
            // 
            // sc
            // 
            this.sc.BackColor = System.Drawing.Color.White;
            this.sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sc.Cursor = System.Windows.Forms.Cursors.Cross;
            this.sc.Location = new System.Drawing.Point(0, 38);
            this.sc.Margin = new System.Windows.Forms.Padding(0);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(5, 5);
            this.sc.TabIndex = 0;
            // 
            // mooControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ds);
            this.Controls.Add(this.dj);
            this.Controls.Add(this.sj);
            this.Controls.Add(this.cj);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.sc);
            this.Name = "mooControl";
            this.Size = new System.Drawing.Size(86, 90);
            this.Load += new System.EventHandler(this.mooControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mooControl_MouseDown);
            this.MouseLeave += new System.EventHandler(this.mooControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.mooControl_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mooControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mooControl_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private controlUtilizator sc;
        private controlUtilizator ss;
        private controlUtilizator cs;
        private controlUtilizator dc;
        private controlUtilizator cj;
        private controlUtilizator sj;
        private controlUtilizator dj;
        private controlUtilizator ds;
    }
}
