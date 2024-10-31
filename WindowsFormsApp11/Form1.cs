using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.MdiParent = this;
            reg.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            About_Us about = new About_Us();
            about.MdiParent = this;
            about.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search srch = new Search();
            srch.MdiParent = this;
            srch.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
