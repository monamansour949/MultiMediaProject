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
    public partial class dictionary_De : Form
    {
        public dictionary_De(string input)
        {
            InitializeComponent();
            
        }
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        Dictionary<string, Tuple<Double, Double>> char_range_from_to = new Dictionary<string, Tuple<Double, Double>>();

        List<List<String>> result = new List<List<string>>();
        private void dictionary_De_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            dictionary.Clear();
            char_range_from_to.Clear();
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (dictionary.ContainsKey(textBox1.Text[i].ToString()))
                {
                    dictionary[textBox1.Text[i].ToString()]++;
                }
                else
                {
                    dictionary[textBox1.Text[i].ToString()] = 1;
                }
            }
        }
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
