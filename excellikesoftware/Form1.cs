using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace excellikesoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void returnNameOfCell(string s)
        {
            Text = s;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
