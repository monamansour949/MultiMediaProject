using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            rlc rlc = new rlc(txtinput.Text);
            rlc.ShowDialog();
            //var newForm = new rlc();
            //newForm.Show();
            //MessageBox.Show(F2.TextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var newForm = new rlc_decode();
            //newForm.Show();
            rlc_decode rlcd = new rlc_decode(txtinput.Text);
            rlcd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shanon rlc = new shanon(txtinput.Text);
            rlc.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtinput.Text.Length.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shanon_decode rlc = new shanon_decode(txtinput.Text);
            rlc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            huffman rlcd = new huffman(txtinput.Text);
            rlcd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            huffman_decode rlcd = new huffman_decode(txtinput.Text);
            rlcd.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            adabtive_huffman rlcd = new adabtive_huffman(txtinput.Text);
            rlcd.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new dictionary_E(txtinput.Text);
            newForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dictionary_De rlcd = new dictionary_De(txtinput.Text);
            rlcd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
