using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
	public Class1()
	{

    public string bit;
    public string sympol = "#";
    public int Xpos, Ypos;
    public noddes Left = null;
    public noddes Right = null;
    public int prob = 1;
}
public class h_noddes
{
    public string bit;
    public string sympol = "#";
    public int Xpos, Ypos;
    public h_noddes Left = null;
    public h_noddes Right = null;
    public h_noddes prev = null;
    public int prob = 1;
    public bool is_new = false;
}
public class noddes
{
    public char sympol;
    public bool root = false;
    public bool leave;
    public int c = 0;
    public noddes parent, Right, Left;
    public int Xpos;
    public int Ypos;

    public noddes()
    {
        leave = false;
        root = true;
        this.Left = null;
        this.parent = null;
        this.Right = null;
    }
    public noddes(noddes parent)
    {
        leave = false;
        this.Left = null;
        this.parent = parent;
        this.Right = null;
    }
    public node(node parent, char c)
    {
        leave = true;
        sympol = c;
        this.Left = null;
        this.parent = parent;
        this.Right = null;
    }


}
