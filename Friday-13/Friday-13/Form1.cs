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
            int cen, j, m;
            m = 0;
            j = 1;
            string str = textBox1.Text;
            cen = int.Parse(str);
            Regex regex = new Regex(@"DayOfWeek == DayOfWeek.Friday(\w*)");
            MatchCollection matches = regex.Matches(str);
            for(int i = cen; i < cen + 1; i++)
            {
                for (j = 1; j <= 12; j++)
                {
                    DateTime dm = new DateTime(i, j, 13);
                    if (dm.DayOfWeek == DayOfWeek.Friday)
                        m += 1;
                }
            }
            listBox1.Items.Add("Количество чёрных пятниц в " + str + " году" + " = " +
            m.ToString());
        }
    }
}
