using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0;
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_albastru;
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            do
            {
                Desen.DrawLine(Creion_albastru, this.Width / 2, 0, i, this.Height - 30);
                i += 10;
            }
            while (i <= this.Width);
        }
    }
}
