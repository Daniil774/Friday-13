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

namespace Friday_13
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

        private void button1_Click(object sender, EventArgs e)
        {
            int cen, a, b;
            b = 0;
            a = 1;
            string str = textBox1.Text;
            cen = Convert.ToInt32(str);
            Regex regex = new Regex(@"DayOfWeek == DayOfWeek.Friday(\w*)");
            MatchCollection matches = regex.Matches(str);
            for(int i = cen; i < cen + 1; i++)
            {
                for (a = 1; a <= 12; a++)
                {
                    DateTime dm = new DateTime(i, a, 13);
                    if (dm.DayOfWeek == DayOfWeek.Friday)
                        b += 1;
                }
            }
            listBox1.Items.Add("Количество чёрных пятниц в " + str + " году" + " = " +
            b.ToString());
        }
    }
}
