using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Instructiunea_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.label1.Text = "Ati ales Laptop!";
            }
            else
            {
                this.label1.Text = "Ati ales Desktop!";
            }
        }
    }
}
