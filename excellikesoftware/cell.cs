using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace excellikesoftware
{
    public partial class cell : UserControl
    {
        public cell()
        {
            InitializeComponent();
        }

        public Form1 f;

        private void cell_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)this.ParentForm;
            }
            catch { }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            f.returnNameOfCell(this.Name);
        }
    }
}
