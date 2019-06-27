using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenkBahçeliler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string[] Taslar = { "Fil", "Kale", "At" };
            comboBox1.Items.AddRange(Taslar);
            TahtaOlustur();
        }
        List<Label> labelListesi = new List<Label>();
        List<PictureBox> ResimKutuListesi = new List<PictureBox>();
        bool[] DogruMu = new bool[64];
        int sayac = 0;
        void TahtaOlustur()
        {
            int SiyahSutun = 100; int SiyahSatir = 50;
            int BeyazSutun = 150; int BeyazSatir = 50;
            int a = 1; int b = 0;

            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    SiyahLabelOlustur(SiyahSutun, SiyahSatir);
                    SiyahSutun += 100;
                    BeyazLabelOlustur(BeyazSutun, BeyazSatir);
                    BeyazSutun += 100;
                }
                a++;
                SiyahSatir += 50; BeyazSatir += 50;
                if (a % 2 == 0)
                {
                    SiyahSutun = 100;
                    BeyazSutun = 150;
                    b = SiyahSutun;
                    SiyahSutun = BeyazSutun;
                    BeyazSutun = b;
                }
                else
                {
                    SiyahSutun = 100;
                    BeyazSutun = 150;
                }
            }
        }
        public void KaleResimKutusuOlustur()
        {
        tekrar:
            int sayi = rnd.Next(0, 63);
            if (DogruMu[sayi] == false)
            {
                PictureBox pb = new PictureBox();
                pb.Width = 50; pb.Height = 50;
                pb.Image = ımageList1.Images[0];
                Point konum = new Point(labelListesi[sayi].Left, labelListesi[sayi].Top);
                pb.Location = konum;
                DogruMu[sayi] = true;
                ResimKutuListesi.Add(pb);
                this.Controls.Add(pb);
                pb.BringToFront();
                sayac++;
            }
            else
            {
                goto tekrar;
            }
        }
        public void AtResimKutusuOlustur()
        {
            {
            tekrar:
                int sayi = rnd.Next(0, 63);
                if (DogruMu[sayi] == false)
                {
                    PictureBox pb = new PictureBox();
                    pb.Width = 50; pb.Height = 50;
                    pb.Image = ımageList1.Images[2];
                    Point konum = new Point(labelListesi[sayi].Left, labelListesi[sayi].Top);
                    pb.Location = konum;
                    DogruMu[sayi] = true;
                    ResimKutuListesi.Add(pb);
                    this.Controls.Add(pb);
                    pb.BringToFront();
                    sayac++;
                }
                else
                {
                    goto tekrar;
                }
            }
        }
        public void FilResimKutusuOlustur()
        {
            {
            tekrar:
                int sayi = rnd.Next(0, 63);
                if (DogruMu[sayi] == false)
                {
                    PictureBox pb = new PictureBox();
                    pb.Width = 50; pb.Height = 50;
                    pb.Image = ımageList1.Images[1];
                    Point konum = new Point(labelListesi[sayi].Left, labelListesi[sayi].Top);
                    pb.Location = konum;
                    DogruMu[sayi] = true;
                    ResimKutuListesi.Add(pb);
                    this.Controls.Add(pb);
                    pb.BringToFront();
                    sayac++;
                }
                else
                {
                    goto tekrar;
                }
            }
        }
        public void ListeyiYenile()
        {
            listBox1.Items.Clear();
            foreach (PictureBox item in ResimKutuListesi)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
        public void SiyahLabelOlustur(int sayi1, int sayi2)
        {
            Label lbl = new Label();
            Size boyut = new Size(50, 50);
            Point konum = new Point(sayi1, sayi2);
            lbl.Location = konum;
            lbl.Size = boyut;
            lbl.BackColor = Color.Black;
            labelListesi.Add(lbl);
            this.Controls.Add(lbl);
        }
        public void BeyazLabelOlustur(int sayi1, int sayi2)
        {
            Label lbl = new Label();
            Size boyut = new Size(50, 50);
            Point konum = new Point(sayi1, sayi2);
            lbl.Location = konum;
            lbl.Size = boyut;
            lbl.BackColor = Color.White;
            labelListesi.Add(lbl);
            this.Controls.Add(lbl);
        }
        private void btnTasEkle_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Kale":
                    KaleResimKutusuOlustur();
                    ListeyiYenile();
                    break;
                case "Fil":
                    FilResimKutusuOlustur();
                    ListeyiYenile();
                    break;
                case "At":
                    AtResimKutusuOlustur();
                    ListeyiYenile();
                    break;
                default:
                    MessageBox.Show("Lütfen bir taş seçiniz.");
                    break;
            }
        }
        private void btnHareketEttir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        Random rnd = new Random();
        public int RandomSayiUret()
        {
            int rasgele = rnd.Next(0, 63);
            return rasgele;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox item in ResimKutuListesi)
            {
                if (item.Image == ımageList1.Images[0])
                {
                    item.Left = labelListesi[RandomSayiUret()].Left;
                    item.Top = labelListesi[RandomSayiUret()].Top;
                }
                else if (item.Image == ımageList1.Images[1])
                {
                    item.Left = labelListesi[RandomSayiUret()].Left;
                    item.Top = labelListesi[RandomSayiUret()].Top;
                }
                else if (item.Image == ımageList1.Images[2])
                {
                    item.Left = labelListesi[RandomSayiUret()].Left;
                    item.Top = labelListesi[RandomSayiUret()].Top;
                }
                else
                {
                    item.Left = labelListesi[RandomSayiUret()].Left;
                    item.Top = labelListesi[RandomSayiUret()].Top;
                }
            }
        }
    }
}




