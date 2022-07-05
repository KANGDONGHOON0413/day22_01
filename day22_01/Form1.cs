using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day22_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save success");
        }

        private void menu01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mennu01 success");

        }

        private void menu02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mennu02 success");
        }
    }
}
