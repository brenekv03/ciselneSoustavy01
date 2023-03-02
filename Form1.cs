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
            int n = int.Parse(textBox1.Text);
            listBox1.Items.Clear();
            Random rnd = new Random();
            bool prvniPrvocislo = false;
            for(int i =0;i<n&&!prvniPrvocislo;i++)
            {
                int cislo = rnd.Next(1, 121);
                listBox1.Items.Add(cislo);

                if (JePrvocislo(cislo))
                {
                    MessageBox.Show("Obsahuje prvočíslo\n" + cislo);
                    prvniPrvocislo=true;
                }
            }
            if(!prvniPrvocislo) MessageBox.Show("Neobsahuje prvočíslo");
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
