using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Cmp( string m,string c)
        {
            m = m.Replace(",","|");
            string res = "";
            foreach (var item in m)
            {
                if(!c.Contains(item))
                {
                    res=res+item;
                }
            }
            return res.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Cmp("GOD99,Win.,2845130560,dalele,asd4527,1483261260`,", "GOD99,Win.,"));
        }
    }
}
