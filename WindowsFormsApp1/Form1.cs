using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[16];
        Image[] resimler = new Image[8]; int dakika = 0, saniye = 0 ,bitis=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            karistir();
            resimleriata();
        }
        
        void resimleriata()
        {
            resimler[0] = Properties.Resources._1;
            resimler[1] = Properties.Resources._2;
            resimler[2] = Properties.Resources._3;
            resimler[3] = Properties.Resources._4;
            resimler[4] = Properties.Resources._5;
            resimler[5] = Properties.Resources._6;
            resimler[6] = Properties.Resources._7;
            resimler[7] = Properties.Resources._8;
        }

        void karistir()
        {
            Random berf = new Random();
            int sayac1 = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0, sayac5 = 0, sayac6 = 0, sayac7 = 0, sayac8 = 0;
            int sayi = 0,i=0;

            while(true)
            {
                int a = berf.Next(8);

                if(a == 0 && sayac1 != 2) // WHİLE DÖNGÜSÜNÜN KAÇ DEFA ÇALIŞACAĞINI 
                {                        // BİLMEDİĞİMİZ İÇİN RANDOM DEĞER 0 İSE VE RESMİ
                    dizi[i] = a;          // EN FAZLA 2 KEZ SEÇMEMİZİ SAĞLAR.
                    sayac1++;
                    sayi++;
                    i++;
                }
                else if(a == 1 && sayac2 != 2)
                {
                    dizi[i] = a;
                    sayac2++;
                    sayi++;
                    i++;
                }
                else if (a == 2 && sayac3 != 2)
                {
                    dizi[i] = a;
                    sayac3++;
                    sayi++;
                    i++;
                }
                else if (a == 3 && sayac4 != 2)
                {
                    dizi[i] = a;
                    sayac4++;
                    sayi++;
                    i++;
                }
                else if (a == 4 && sayac5 != 2)
                {
                    dizi[i] = a;
                    sayac5++;
                    sayi++;
                    i++;
                }
                else if (a == 5 && sayac6 != 2)
                {
                    dizi[i] = a;
                    sayac6++;
                    sayi++;
                    i++;
                }
                else if (a == 6 && sayac7 != 2)
                {
                    dizi[i] = a;
                    sayac7++;
                    sayi++;
                    i++;
                }
                else if (a == 7 && sayac8 != 2)
                {
                    dizi[i] = a;
                    sayac8++;
                    sayi++;
                    i++;
                }

                if(i == 16)
                {
                    break;
                }


                
            }
        }
        Button onceki; int berfin=0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Image = resimler[dizi[0]];
            if (berfin == 0)
            {
                berfin++;
                onceki = button1;
            }
            else
            {
                berfin = 0;
                if(button1.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button1.Image = resimler[dizi[0]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button1.Image = null;
                }
            }

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Image = resimler[dizi[1]];
            if (berfin == 0)
            {
                berfin++;
                onceki = button2;
            }
            else
            {
                berfin = 0;
                if (button2.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button2.Image = resimler[dizi[1]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button2.Image = null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Image = resimler[dizi[2]];
            if (berfin == 0)
            {
                berfin++;
                
                onceki = button3;
            }
            else
            {
                berfin = 0;
                if (resimler[dizi[2]] == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button3.Image = resimler[dizi[2]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button3.Image = null;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Image = resimler[dizi[3]];
            if (berfin == 0)
            {
                berfin++;
              
                onceki = button4;
            }
            else
            {
                berfin = 0;
                if (button4.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button4.Image = resimler[dizi[3]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button4.Image = null;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Image = resimler[dizi[4]];
            if (berfin == 0)
            {
                berfin++;
               
                onceki = button5;
            }
            else
            {
                berfin = 0;
                if (button5.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button5.Image = resimler[dizi[4]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button5.Image = null;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Image = resimler[dizi[5]];
            if (berfin == 0)
            {
                berfin++;
                
                onceki = button6;
            }
            else
            {
                berfin = 0;
                if (button6.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button6.Image = resimler[dizi[5]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button6.Image = null;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Image = resimler[dizi[6]];
            if (berfin == 0)
            {
                berfin++;
               
                onceki = button7;
            }
            else
            {
                berfin = 0;
                if (button7.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button7.Image = resimler[dizi[6]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button7.Image = null;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Image = resimler[dizi[7]];
            if (berfin == 0)
            {
                berfin++;
                
                onceki = button8;
            }
            else
            {
                berfin = 0;
                if (button8.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button8.Image = resimler[dizi[7]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button8.Image = null;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Image = resimler[dizi[8]];
            if (berfin == 0)
            {
                berfin++;
              
                onceki = button9;
            }
            else
            {
                berfin = 0;
                if (button9.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button9.Image = resimler[dizi[8]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button9.Image = null;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Image = resimler[dizi[9]];
            if (berfin == 0)
            {
                berfin++;
              
                onceki = button10;
            }
            else
            {
                berfin = 0;
                if (button10.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button10.Image = resimler[dizi[9]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button10.Image = null;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Image = resimler[dizi[10]];
            if (berfin == 0)
            {
                berfin++;
               
                onceki = button11;
            }
            else
            {
                berfin = 0;
                if (button11.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button11.Image = resimler[dizi[10]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button11.Image = null;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Image = resimler[dizi[11]];
            if (berfin == 0)
            {
                berfin++;
             
                onceki = button12;
            }
            else
            {
                berfin = 0;
                if (button12.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button12.Image = resimler[dizi[11]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button12.Image = null;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Image = resimler[dizi[12]];
            if (berfin == 0)
            {
                berfin++;
              
                onceki = button13;
            }
            else
            {
                berfin = 0;
                if (button13.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button13.Image = resimler[dizi[12]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button13.Image = null;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Image = resimler[dizi[13]];
            if (berfin == 0)
            {
                berfin++;
               
                onceki = button14;
            }
            else
            {
                berfin = 0;
                if (button14.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button14.Image = resimler[dizi[13]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button14.Image = null;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Image = resimler[dizi[14]];
            if (berfin == 0)
            {
                berfin++;
                
                onceki = button15;
            }
            else
            {
                berfin = 0;
                if (button15.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button15.Image = resimler[dizi[14]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button15.Image = null;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Image = resimler[dizi[15]];
            if (berfin == 0)
            {
                berfin++;
             
                onceki = button16;
            }
            else
            {
                berfin = 0;
                if (button16.Image == onceki.Image)
                {
                    bitis++;
                }
                else
                {
                    button16.Image = resimler[dizi[15]];
                    MessageBox.Show("RESİMLER AYNI DEĞİL TEKRAR DENEYİNİZ.");
                    onceki.Image = null;
                    button16.Image = null;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(saniye >59)
            {
                dakika++;
                saniye = 0;
            }
            else
            {
                saniye++;
            }

            if(bitis == 8)
            {
                bitis = 0;
                MessageBox.Show( "TEBRİKLER" +  dakika.ToString()  +   "  dakika " + saniye + " saniye" + " içerisinde buldunuz");
                timer1.Stop();
                
            }
        }
    }
}
