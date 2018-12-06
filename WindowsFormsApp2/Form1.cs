using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.ClearSelected();
            int[] Sayılar = new int[5] { 10, 20, 25, 28, 34 };
            int toplam = 0, i = 0;
            do
            {

                listBox3.Items.Add(Sayılar[i]);
                toplam +=Sayılar[i];
                i++;
            }
            while (i < Sayılar.Length);

            listBox3.Items.Add("Toplam=" + toplam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            int[] Sayılar = new int[5] { 10, 20, 25, 28, 34 };
            int toplam = 0;
            for (int i=0;i<5;++i )
            {
                listBox1.Items.Add(Sayılar[i]);
                toplam +=Sayılar[i];

            }
            listBox1.Items.Add("Toplam=" + toplam);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.ClearSelected();
            int[] Sayılar = new int[5] { 10, 20, 25, 28, 34 };
            int toplam = 0, i= 0;
            while (i < Sayılar.Length)
            {
                listBox2.Items.Add(Sayılar[i]);
                toplam +=  Sayılar[i];
                i++;

            }
            listBox2.Items.Add("Toplam=" + toplam);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] Sayılar = new int[5] { 10, 20, 25, 28, 34 };
            int toplam = 0, i = 0;
            listBox4.ClearSelected();
            IEnumerator enm = Sayılar.GetEnumerator();
            while(enm.MoveNext())
            {
                listBox4.Items.Add(enm.Current);
                toplam +=Sayılar[i];
                i++;
            }
            listBox4.Items.Add("Toplam=" + toplam);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox5.ClearSelected();
            int[] Sayılar = new int[5] { 10, 20, 25, 28, 34 };
            int toplam = 0;
            foreach (int m in Sayılar)
            {
                listBox5.Items.Add(m);
                toplam += m;
            }
            listBox5.Items.Add("Toplam=" + toplam);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
