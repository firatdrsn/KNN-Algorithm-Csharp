using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knn_algoritaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bir değer giriniz");
            }
            else
            {
                double mavix = mavi.Location.X;
                double maviy = mavi.Location.Y;
                double siyah1x = siyah1.Location.X;
                double siyah1y = siyah1.Location.Y;
                double siyah2x = siyah2.Location.X;
                double siyah2y = siyah2.Location.Y;
                double siyah3x = siyah3.Location.X;
                double siyah3y = siyah3.Location.Y;
                double siyah4x = siyah4.Location.X;
                double siyah4y = siyah4.Location.Y;
                double siyah5x = siyah5.Location.X;
                double siyah5y = siyah5.Location.Y;
                double siyah6x = siyah6.Location.X;
                double siyah6y = siyah6.Location.Y;
                double siyah7x = siyah7.Location.X;
                double siyah7y = siyah7.Location.Y;
                double siyah8x = siyah8.Location.X;
                double siyah8y = siyah8.Location.Y;
                double siyah9x = siyah9.Location.X;
                double siyah9y = siyah9.Location.Y;
                double siyah10x = siyah10.Location.X;
                double siyah10y = siyah10.Location.Y;
                double siyah11x = siyah11.Location.X;
                double siyah11y = siyah11.Location.Y;
                double siyah12x = siyah12.Location.X;
                double siyah12y = siyah12.Location.Y;
                double siyah13x = siyah13.Location.X;
                double siyah13y = siyah13.Location.Y;
                double siyah14x = siyah14.Location.X;
                double siyah14y = siyah14.Location.Y;
                double siyah15x = siyah15.Location.X;
                double siyah15y = siyah15.Location.Y;
                double sari1x = sari1.Location.X;
                double sari1y = sari1.Location.Y;
                double sari2x = sari2.Location.X;
                double sari2y = sari2.Location.Y;
                double sari3x = sari3.Location.X;
                double sari3y = sari3.Location.Y;
                double sari4x = sari4.Location.X;
                double sari4y = sari4.Location.Y;
                double sari5x = sari5.Location.X;
                double sari5y = sari5.Location.Y;
                double sari6x = sari6.Location.X;
                double sari6y = sari6.Location.Y;
                double sari7x = sari7.Location.X;
                double sari7y = sari7.Location.Y;
                double sari8x = sari8.Location.X;
                double sari8y = sari8.Location.Y;
                double sari9x = sari9.Location.X;
                double sari9y = sari9.Location.Y;
                double sari10x = sari10.Location.X;
                double sari10y = sari10.Location.Y;
                double sari11x = sari11.Location.X;
                double sari11y = sari11.Location.Y;
                double sari12x = sari12.Location.X;
                double sari12y = sari12.Location.Y;
                double sari13x = sari13.Location.X;
                double sari13y = sari13.Location.Y;
                double sari14x = sari14.Location.X;
                double sari14y = sari14.Location.Y;
                double sari15x = sari15.Location.X;
                double sari15y = sari15.Location.Y;
                double sari16x = sari16.Location.X;
                double sari16y = sari16.Location.Y;
                int k = Convert.ToInt16(textBox1.Text);
                //Siyahların uzaklık hesaplamaları
                double sy_uzaklik1 = Math.Sqrt((siyah1x - mavix) * (siyah1x - mavix) + (siyah1y - maviy) * (siyah1y - maviy));
                double sy_uzaklik2 = Math.Sqrt((siyah2x - mavix) * (siyah2x - mavix) + (siyah2y - maviy) * (siyah2y - maviy));
                double sy_uzaklik3 = Math.Sqrt((siyah3x - mavix) * (siyah3x - mavix) + (siyah3y - maviy) * (siyah3y - maviy));
                double sy_uzaklik4 = Math.Sqrt((siyah4x - mavix) * (siyah4x - mavix) + (siyah4y - maviy) * (siyah4y - maviy));
                double sy_uzaklik5 = Math.Sqrt((siyah5x - mavix) * (siyah5x - mavix) + (siyah5y - maviy) * (siyah5y - maviy));
                double sy_uzaklik6 = Math.Sqrt((siyah6x - mavix) * (siyah6x - mavix) + (siyah6y - maviy) * (siyah6y - maviy));
                double sy_uzaklik7 = Math.Sqrt((siyah7x - mavix) * (siyah7x - mavix) + (siyah7y - maviy) * (siyah7y - maviy));
                double sy_uzaklik8 = Math.Sqrt((siyah8x - mavix) * (siyah8x - mavix) + (siyah8y - maviy) * (siyah8y - maviy));
                double sy_uzaklik9 = Math.Sqrt((siyah9x - mavix) * (siyah9x - mavix) + (siyah9y - maviy) * (siyah9y - maviy));
                double sy_uzaklik10 = Math.Sqrt((siyah10x - mavix) * (siyah10x - mavix) + (siyah10y - maviy) * (siyah10y - maviy));
                double sy_uzaklik11 = Math.Sqrt((siyah11x - mavix) * (siyah11x - mavix) + (siyah11y - maviy) * (siyah11y - maviy));
                double sy_uzaklik12 = Math.Sqrt((siyah12x - mavix) * (siyah12x - mavix) + (siyah12y - maviy) * (siyah12y - maviy));
                double sy_uzaklik13 = Math.Sqrt((siyah13x - mavix) * (siyah13x - mavix) + (siyah13y - maviy) * (siyah13y - maviy));
                double sy_uzaklik14 = Math.Sqrt((siyah14x - mavix) * (siyah14x - mavix) + (siyah14y - maviy) * (siyah14y - maviy));
                double sy_uzaklik15 = Math.Sqrt((siyah15x - mavix) * (siyah15x - mavix) + (siyah15y - maviy) * (siyah15y - maviy));
                //Sarıların uzaklık hesaplamaları
                double sr_uzaklik1 = Math.Sqrt((sari1x - mavix) * (sari1x - mavix) + (sari1y - maviy) * (sari1y - maviy));
                double sr_uzaklik2 = Math.Sqrt((sari2x - mavix) * (sari2x - mavix) + (sari2y - maviy) * (sari2y - maviy));
                double sr_uzaklik3 = Math.Sqrt((sari3x - mavix) * (sari3x - mavix) + (sari3y - maviy) * (sari3y - maviy));
                double sr_uzaklik4 = Math.Sqrt((sari4x - mavix) * (sari4x - mavix) + (sari4y - maviy) * (sari4y - maviy));
                double sr_uzaklik5 = Math.Sqrt((sari5x - mavix) * (sari5x - mavix) + (sari5y - maviy) * (sari5y - maviy));
                double sr_uzaklik6 = Math.Sqrt((sari6x - mavix) * (sari6x - mavix) + (sari6y - maviy) * (sari6y - maviy));
                double sr_uzaklik7 = Math.Sqrt((sari7x - mavix) * (sari7x - mavix) + (sari7y - maviy) * (sari7y - maviy));
                double sr_uzaklik8 = Math.Sqrt((sari8x - mavix) * (sari8x - mavix) + (sari8y - maviy) * (sari8y - maviy));
                double sr_uzaklik9 = Math.Sqrt((sari9x - mavix) * (sari9x - mavix) + (sari9y - maviy) * (sari9y - maviy));
                double sr_uzaklik10 = Math.Sqrt((sari10x - mavix) * (sari10x - mavix) + (sari10y - maviy) * (sari10y - maviy));
                double sr_uzaklik11 = Math.Sqrt((sari11x - mavix) * (sari11x - mavix) + (sari11y - maviy) * (sari11y - maviy));
                double sr_uzaklik12 = Math.Sqrt((sari12x - mavix) * (sari12x - mavix) + (sari12y - maviy) * (sari12y - maviy));
                double sr_uzaklik13 = Math.Sqrt((sari13x - mavix) * (sari13x - mavix) + (sari13y - maviy) * (sari13y - maviy));
                double sr_uzaklik14 = Math.Sqrt((sari14x - mavix) * (sari14x - mavix) + (sari14y - maviy) * (sari14y - maviy));
                double sr_uzaklik15 = Math.Sqrt((sari15x - mavix) * (sari15x - mavix) + (sari15y - maviy) * (sari15y - maviy));
                double sr_uzaklik16 = Math.Sqrt((sari16x - mavix) * (sari16x - mavix) + (sari16y - maviy) * (sari16y - maviy));
                double yakin = 0;
                double toplam = 0;
                double toplam2 = 0;
                if (k == 1)
                {
                    yakin = sy_uzaklik1 - sr_uzaklik1;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 2)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 3)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 4)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 5)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 6)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 7)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 8)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 9)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8 + sy_uzaklik9;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8 + sr_uzaklik9;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 10)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8 + sy_uzaklik9 + sy_uzaklik10;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8 + sr_uzaklik9 + sr_uzaklik10;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 11)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8 + sy_uzaklik9 + sy_uzaklik10 + sy_uzaklik11;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8 + sr_uzaklik9 + sr_uzaklik10 + sr_uzaklik11;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 12)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8 + sy_uzaklik9 + sy_uzaklik10 + sy_uzaklik11 + sy_uzaklik12;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8 + sr_uzaklik9 + sr_uzaklik10 + sr_uzaklik11 + sr_uzaklik12;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 13)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8 + sy_uzaklik9 + sy_uzaklik10 + sy_uzaklik11 + sy_uzaklik12 + sy_uzaklik13;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8 + sr_uzaklik9 + sr_uzaklik10 + sr_uzaklik11 + sr_uzaklik12 + sr_uzaklik13;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 14)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8 + sy_uzaklik9 + sy_uzaklik10 + sy_uzaklik11 + sy_uzaklik12 + sy_uzaklik13 + sy_uzaklik14;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8 + sr_uzaklik9 + sr_uzaklik10 + sr_uzaklik11 + sr_uzaklik12 + sr_uzaklik13 + sr_uzaklik14;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 15)
                {
                    toplam = sy_uzaklik1 + sy_uzaklik2 + sy_uzaklik3 + sy_uzaklik4 + sy_uzaklik5 + sy_uzaklik6 + sy_uzaklik7 + sy_uzaklik8 + sy_uzaklik9 + sy_uzaklik10 + sy_uzaklik11 + sy_uzaklik12 + sy_uzaklik13 + sy_uzaklik14 + sy_uzaklik15;
                    toplam2 = sr_uzaklik1 + sr_uzaklik2 + sr_uzaklik3 + sr_uzaklik4 + sr_uzaklik5 + sr_uzaklik6 + sr_uzaklik7 + sr_uzaklik8 + sr_uzaklik9 + sr_uzaklik10 + sr_uzaklik11 + sr_uzaklik12 + sr_uzaklik13 + sr_uzaklik14 + sr_uzaklik15;
                    yakin = toplam - toplam2;
                    if (yakin < 0)
                        MessageBox.Show("Siyahlar daha yakın ");
                    else
                        MessageBox.Show("Sarılar daha yakın ");
                }
                else if (k == 16)
                {
                    MessageBox.Show("Sarılar daha yakın ");
                }
                else
                {
                    MessageBox.Show("Geçerli bir değer giriniz");
                }

            }
        }



    }
}
