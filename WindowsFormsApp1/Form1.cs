using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Restaurant> Corbalar = new List<Restaurant>();
        List<Restaurant> Yemekler = new List<Restaurant>();
        List<Restaurant> Tatlılar = new List<Restaurant>();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Çorbalar";
            label2.Text = "Ana Yemek";
            label3.Text = "Tatlılar";
            label8.Text = "Eğer indirim kuponu alırsanız indirimden faydalanırsınız...";
     

            Restaurant corba= new Corba();
            corba.adi = "Mercimek Çorbası";
            corba.fiyat = 10;
            Corbalar.Add(corba);
            listBox1.Items.Add(corba.adi + ", Fiyatı:" + corba.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant corba1 = new Corba();
            corba1.adi = "Yayla Çorbası";
            corba1.fiyat = 15;
            Corbalar.Add(corba1);
            listBox1.Items.Add(corba1.adi + ", Fiyatı:" + corba1.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant corba2 = new Corba();
            corba2.adi = "İşkembe Çorbası";
            corba2.fiyat = 20;
            Corbalar.Add(corba2);
            listBox1.Items.Add(corba2.adi + ", Fiyatı:" + corba2.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant corba3 = new Corba();
            corba3.adi = "Tarhana Çorbası";
            corba3.fiyat = 25;
            Corbalar.Add(corba3);
            listBox1.Items.Add(corba3.adi + ", Fiyatı:" + corba3.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant yemek = new Yemek();
            yemek.adi = "Patlıcan";
            yemek.fiyat = 10;
            Yemekler.Add(yemek);
            listBox2.Items.Add(yemek.adi + ", Fiyatı:" + yemek.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant yemek1 = new Yemek();
            yemek1.adi = "Makarna";
            yemek1.fiyat = 15;
            Yemekler.Add(yemek1);
            listBox2.Items.Add(yemek1.adi + ", Fiyatı:" + yemek1.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant yemek2 = new Yemek();
            yemek2.adi = "İçliköfte";
            yemek2.fiyat = 20;
            Yemekler.Add(yemek2);
            listBox2.Items.Add(yemek2.adi + ", Fiyatı:" + yemek2.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant yemek3 = new Yemek();
            yemek3.adi = "Kuru fasulye";
            yemek3.fiyat = 25;
            Yemekler.Add(yemek3);
            listBox2.Items.Add(yemek3.adi + ", Fiyatı:" + yemek3.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant yemek4 = new Yemek();
            yemek4.adi = "Pirinç Pilavı";
            yemek4.fiyat = 30;
            Yemekler.Add(yemek4);
            listBox2.Items.Add(yemek4.adi + ", Fiyatı:" + yemek4.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant tatli = new Tatli();
            tatli.adi = "Kadayıf";
            tatli.fiyat = 5;
            Tatlılar.Add(tatli);
            listBox3.Items.Add(tatli.adi + ", Fiyatı:" + tatli.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant tatli1 = new Tatli();
            tatli1.adi = "Kazandibi";
            tatli1.fiyat = 10;
            Tatlılar.Add(tatli1);
            listBox3.Items.Add(tatli1.adi + ", Fiyatı:" + tatli1.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant tatli2 = new Tatli();
            tatli2.adi = "Baklava";
            tatli2.fiyat = 15;
            Tatlılar.Add(tatli2);
            listBox3.Items.Add(tatli2.adi + ", Fiyatı:" + tatli2.fiyat.ToString("C", CultureInfo.CurrentCulture));

            Restaurant tatli3 = new Tatli();
            tatli3.adi = "Sütlaç";
            tatli3.fiyat = 20;
            Tatlılar.Add(tatli3);
            listBox3.Items.Add(tatli3.adi + ", Fiyatı:" + tatli3.fiyat.ToString("C", CultureInfo.CurrentCulture));


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value ==0)
            {
                MessageBox.Show("Spariş sayısını giriniz!");
            }
            else if(listBox1.SelectedItem==null && listBox2.SelectedItem == null && listBox3.SelectedItem == null)
            {
                MessageBox.Show("Spariş vermek için en az bir ürün seçmelisiniz!");
            }
            else
            {
                Restaurant yemek=new Yemek();
                Restaurant corba=new Corba();
                Restaurant tatli=new Tatli();
                double yemekfiyati = 0;
                double corbafiyati = 0;
                double tatlifiyati = 0;

                double toplamfiyat;
                if (listBox2.SelectedItem != null)
                {
                    string[] metin;
                    metin = listBox2.Text.ToString().Split(',');
                    yemek = Yemekler.Where(x => x.adi == metin[0]).FirstOrDefault();
                    yemekfiyati = yemek.fiyat;
                }
                if(listBox1.SelectedItem != null)
                {
                    string[] metin1;
                    metin1 = listBox1.Text.ToString().Split(',');
                    corba = Corbalar.Where(x => x.adi == metin1[0]).FirstOrDefault();
                    corbafiyati = corba.fiyat;

                    if (indirimtxt.Text != string.Empty)
                    {
                        Corba cb = new Corba();
                        double indirimtutari = cb.indirim(corbafiyati);
                        corbafiyati = corbafiyati - indirimtutari;
                    }
                }
                if (listBox3.SelectedItem != null)
                {
                    string[] metin2;
                    metin2 = listBox3.Text.ToString().Split(',');
                    tatli = Tatlılar.Where(x => x.adi == metin2[0]).FirstOrDefault();
                    tatlifiyati = tatli.fiyat;

                    if (indirimtxt.Text != string.Empty)
                    {
                        Tatli Ta = new Tatli();
                        double indirimtutari = Ta.indirim(tatlifiyati);
                        tatlifiyati = tatlifiyati - indirimtutari;
                    }
                }
                toplamfiyat = yemekfiyati + corbafiyati + tatlifiyati;
                Restaurant.mstrsayisi = Convert.ToInt32(numericUpDown1.Value);
                decimal sparistutari = Restaurant.hesapla(toplamfiyat);
                
                listBox4.Items.Add("-" + corba.adi + " , " + yemek.adi + " , " + tatli.adi + " , " + "Spariş Tutarı: " + sparistutari.ToString("C", CultureInfo.CurrentCulture));
            }
            indirimtxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int indirimkodu= rnd.Next();
            indirimtxt.Text = indirimkodu.ToString();


        }
    }
}
