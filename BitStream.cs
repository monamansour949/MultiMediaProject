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

	

	public partial class BitStream : Form
    {
        public BitStream()
        {
           InitializeComponent();
           
    }
    public struct Symbol
    {
        public uint Sym;
        public uint Count;
        public uint Code;
        public uint Bits;
    }
	public class TreeNode
	{
		public TreeNode ChildA;
		public TreeNode ChildB;
		public int Symbol;
	}

	

	
	private void BitStream_Load(object sender, EventArgs e)
        {

        }
    }
}
