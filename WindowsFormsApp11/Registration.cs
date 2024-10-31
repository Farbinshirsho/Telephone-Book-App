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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           

      

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.toolStripButton1.Enabled = false;
            this.toolStripButton2.Enabled = true;
            this.groupBox1.Enabled = true;

            //to clear the trextbox when the button is pressed
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            this.textBox8.ResetText();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter your ID");
                return;
            }
            this.toolStripButton1.Enabled = true;
            this.toolStripButton2.Enabled = false;
            this.groupBox1.Enabled = false;
            String fn;
            fn = "C:\\Users\\USER\\Desktop\\Farbin\\";
            String pn;
            pn = fn + textBox1.Text + "FirstName.txt";
            System.IO.File.WriteAllText(pn, textBox2.Text, Encoding.UTF8);

            pn = fn + textBox1.Text + "Lastname.txt";
            System.IO.File.WriteAllText(pn, textBox3.Text, Encoding.UTF8);

            pn = fn + textBox1.Text + "telephone.txt";
            System.IO.File.WriteAllText(pn, textBox4.Text, Encoding.UTF8);

            pn = fn + textBox1.Text + "cellphone.txt";
            System.IO.File.WriteAllText(pn, textBox5.Text, Encoding.UTF8);

            pn = fn + textBox1.Text + "email.txt";
            System.IO.File.WriteAllText(pn, textBox6.Text, Encoding.UTF8);

            pn = fn + textBox1.Text + "contact.txt";
            System.IO.File.WriteAllText(pn, textBox7.Text, Encoding.UTF8);

            pn = fn + textBox1.Text + "address.txt";
            System.IO.File.WriteAllText(pn, textBox8.Text, Encoding.UTF8);
        }
    }
}
