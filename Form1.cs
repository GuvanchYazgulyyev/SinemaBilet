using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_satis_ders_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seansucret = 0;
        int seans2 = 0;
        int seans2ucret = 0;
        int seans3 = 0;
        int seans3ucret = 0;
        int misir = 0;
        int fiyat = 0;
        int su = 0;
        int sufiyat = 0;
        int kola = 0;
        int kolafiyat = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seansucret = seansucret + 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seansucret.ToString();

            if (seans1 == 15)
            {
                button1.Enabled = false;
            }

            if (seans1 >= 0)
            {
                button2.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seansucret = seansucret - 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seansucret.ToString();

            if (seans1 == 0)
            {
                button2.Enabled = false;
            }

            if (seans1 <= 15)
            {
                button1.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2ucret = seans2ucret + 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucret.ToString();

            if (seans2 == 15)
            {
                button3.Enabled = false;
            }

            if (seans2 >= 0)
            {
                button4.Enabled = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2ucret = seans2ucret - 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucret.ToString();

            if (seans2 == 0)
            {
                button4.Enabled = false;
            }

            if (seans2 <= 15)
            {
                button3.Enabled = true;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3ucret = seans3ucret + 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucret.ToString();

            if (seans3 == 15)
            {
                button5.Enabled = false;
            }

            if (seans3 >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3ucret = seans3ucret - 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucret.ToString();

            if (seans3 == 0)
            {
                button6.Enabled = false;
            }

            if (seans3 <= 15)
            {
                button5.Enabled = true;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
            misir++;
            fiyat = fiyat + 6;
            textBox7.Text = misir.ToString();
            textBox8.Text = fiyat.ToString();

            if (misir == 10)
            {
                button7.Enabled = false;
            }

            if (misir >= 0)
            {
                button10.Enabled = true;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            misir--;
            fiyat = fiyat - 6;
            textBox7.Text = misir.ToString();
            textBox8.Text = fiyat.ToString();

            if (misir == 0)
            {
                button10.Enabled = false;
            }

            if (misir <= 15)
            {
                button7.Enabled = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            su++;
            sufiyat = sufiyat + 3;
            textBox9.Text = su.ToString();
            textBox10.Text = sufiyat.ToString();

            if (su == 10)
            {
                button8.Enabled = false;
            }

            if (su >= 0)
            {
                button11.Enabled = true;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            su--;
            sufiyat = sufiyat - 3;
            textBox9.Text = su.ToString();
            textBox10.Text = sufiyat.ToString();

            if (su == 0)
            {
                button11.Enabled = false;
            }

            if (su <= 10)
            {
                button8.Enabled = true;
            }

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            kola++;
            kolafiyat = kolafiyat + 4;
            textBox11.Text = kola.ToString();
            textBox12.Text = kolafiyat.ToString();

            if (kola == 10)
            {
                button9.Enabled = false;
            }

            if (kola >= 0)
            {
                button12.Enabled = true;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            kola--;
            kolafiyat = kolafiyat - 4;
            textBox11.Text = kola.ToString();
            textBox12.Text = kolafiyat.ToString();

            if (kola == 0)
            {
                button12.Enabled = false;
            }

            if (kola <= 10)
            {
                button9.Enabled = true;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            int izleycisayi, izleyciucret;
            izleycisayi = seans1 + seans2 + seans3;
            label12.Text = izleycisayi.ToString();

            izleyciucret = seansucret + seans2ucret + seans3ucret;
            label13.Text = izleyciucret.ToString() + " TMT ";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            int satilan, fiyatt;
            satilan = misir + kola + su;
            label17.Text = satilan.ToString();

            fiyatt = kolafiyat + sufiyat + fiyat;
            label15.Text = fiyatt.ToString() + " TMT ";
        }
    }
}
