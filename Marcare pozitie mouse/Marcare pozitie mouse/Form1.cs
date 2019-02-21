using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marcare_pozitie_mouse
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private int mouse_rel_x()
        {
            if ((Control.MousePosition.X >= this.Location.X)
            && (Control.MousePosition.X - this.Location.X <= this.Size.Width))
                return System.Convert.ToInt16(Control.MousePosition.X - this.Location.X - 8);
            else
                return -1;

        }
        private int mouse_rel_y()
        {
            if ((Control.MousePosition.Y >= this.Location.Y)
            && (Control.MousePosition.Y - this.Location.Y <= this.Size.Height))
                return System.Convert.ToInt16(Control.MousePosition.Y - this.Location.Y - 30);
            else
                return -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int poz_x, poz_y;
            poz_x = mouse_rel_x();
            poz_y = mouse_rel_y();
            if ((poz_x >= 0) & (poz_y >= 0))
            {
                this.label1.Text = System.Convert.ToString(poz_x);
                this.label2.Text = System.Convert.ToString(poz_y);
            }
            else
            {
                this.label1.Text = "Mouse-ul nu este in fereastra ! ";
                this.label2.Text = "";
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_albastru;
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Desen.DrawLine(Creion_albastru, mouse_rel_x() - 4, mouse_rel_y(), mouse_rel_x() + 4, mouse_rel_y());
            Desen.DrawLine(Creion_albastru, mouse_rel_x(), mouse_rel_y() - 4, mouse_rel_x(), mouse_rel_y() + 4);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_albastru;
            Desen = this.CreateGraphics();
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            Desen.DrawEllipse(Creion_albastru, mouse_rel_x() - 20, mouse_rel_y() - 20, 40, 40);

            for (int i = 1; i <= 5; i++)
                Desen.DrawEllipse(Creion_albastru, mouse_rel_x() - i * 10, mouse_rel_y() - i * 10, 2 * i * 10, 2 * i * 10);
        }
    }
}
