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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox9.Text =="")
            {
                MessageBox.Show("Enter yur ID");
                return;
            }
            string fn;
            fn = "C:\\Users\\USER\\Desktop\\Farbin\\";
            string pn;
            pn = fn + textBox9.Text + "FirstName.txt";
            if(System.IO.File.Exists(pn)==true)
            {
                string r;
                r=System.IO.File.ReadAllText(pn ,Encoding.UTF8);
                this.textBox2.Text = r;
            }
            pn = fn + textBox9.Text + "Lastname.txt";
            if (System.IO.File.Exists(pn) == true)
            {
                string r;
                r = System.IO.File.ReadAllText(pn, Encoding.UTF8);
                this.textBox3.Text = r;
            }
            pn = fn + textBox9.Text + "telephone.txt";
            if (System.IO.File.Exists(pn) == true)
            {
                string r;
                r = System.IO.File.ReadAllText(pn, Encoding.UTF8);
                this.textBox4.Text = r;
            }
            pn = fn + textBox9.Text + "cellphone.txt";
            if (System.IO.File.Exists(pn) == true)
            {
                string r;
                r = System.IO.File.ReadAllText(pn, Encoding.UTF8);
                this.textBox5.Text = r;
            }
            pn = fn + textBox9.Text + "email.txt";
            if (System.IO.File.Exists(pn) == true)
            {
                string r;
                r = System.IO.File.ReadAllText(pn, Encoding.UTF8);
                this.textBox6.Text = r;
            }
            pn = fn + textBox9.Text + "contact.txt";
            if (System.IO.File.Exists(pn) == true)
            {
                string r;
                r = System.IO.File.ReadAllText(pn, Encoding.UTF8);
                this.textBox7.Text = r;
            }
            pn = fn + textBox9.Text + "address.txt";
            if (System.IO.File.Exists(pn) == true)
            {
                string r;
                r = System.IO.File.ReadAllText(pn, Encoding.UTF8);
                this.textBox8.Text = r;
            }
           

        }
    }
}
