using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciselneSoustavy01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox1.Text);
            if (JePrvocislo(cislo)) MessageBox.Show("Je prvočíslo\n" + cislo);
            else MessageBox.Show("Není prvočíslo\n" + cislo);
        }
        static private bool JePrvocislo(int cislo)
        {
            bool jePrvocislo = true;
            for(int i =2;i<=cislo/2&&jePrvocislo;i++)
            {
                if(cislo%i==0)jePrvocislo=false;
            }
            return jePrvocislo;
        }
    }
}
