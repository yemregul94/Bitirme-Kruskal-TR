using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KruskalProjesi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            Reset();
        }

        bool dugumEklemeModu;
        bool kenarEklemeModu;

        const int dugumCap = 24;
        const int dugumYariCap = (dugumCap / 2);

        Color dugumRenk = Color.LawnGreen;
        Color kenarRenk = Color.Red;

        string harf = "ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz";

        List<Dugum> dugumListe;
        List<Kenar> baslangicKenarListe, sonKenarListe;

        Dugum ilkDugum, ikinciDugum;

        bool kenarEklemeDurumu, cozulmeDurumu, ilerlemeDurumu;

        int adimSayaci, optimumSayac, ilerlemeMaliyet;

        RichTextBox geciciBox = new RichTextBox();

        int gecikme;      

        #region Buton Özellikleri

        private void StandartButton_MouseEnter(object sender, EventArgs e)
        {
            standartButton.BackColor = Color.Maroon;
        }

        private void StandartButton_MouseLeave(object sender, EventArgs e)
        {
            standartButton.BackColor = Color.Black;
        }

        private void GirisliButton_MouseEnter(object sender, EventArgs e)
        {
            girisliButton.BackColor = Color.Maroon;
        }

        private void GirisliButton_MouseLeave(object sender, EventArgs e)
        {
            girisliButton.BackColor = Color.Black;
        }

        private void StandartButton_Click(object sender, EventArgs e)
        {
            altPanel.Visible = false;
            baslikLabel.Visible = false;
            menuPanel.Visible = true;

            anaPanel.Visible = true;

            temizleButton.Visible = false;
            dugumEkleButton.Visible = false;
            kenarEkleButton.Visible = false;

            AnaForm.ActiveForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            AnaForm.ActiveForm.MaximizeBox = false;

            BaslangicDegerleri();
        }

        private void GirisliButton_Click(object sender, EventArgs e)
        {
            altPanel.Visible = false;
            baslikLabel.Visible = false;
            menuPanel.Visible = true;

            anaPanel.Visible = true;

            AnaForm.ActiveForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            AnaForm.ActiveForm.MaximizeBox = false;
        }

        private void AnaMenuButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            Reset();

            AnaForm.ActiveForm.FormBorderStyle = FormBorderStyle.Sizable;
            AnaForm.ActiveForm.MaximizeBox = true;
        }      

        private void DugumEkleButton_Click(object sender, EventArgs e)
        {
            if (dugumEklemeModu)
            {
                dugumEkleButton.BackColor = Color.LawnGreen;
                dugumEkleButton.Text = "Düğüm Ekle";

                cizimPanel.Enabled = false;

                dugumEklemeModu = false;

                hesaplaButton.Enabled = true;
                ilerleButton.Enabled = true;
                kenarEkleButton.Enabled = true;
                temizleButton.Enabled = true;
            }
            else
            {
                dugumEkleButton.BackColor = Color.Aqua;
                dugumEkleButton.Text = "Onayla";

                cizimPanel.Enabled = true;

                dugumEklemeModu = true;

                hesaplaButton.Enabled = false;
                ilerleButton.Enabled = false;
                kenarEkleButton.Enabled = false;
                temizleButton.Enabled = false;
            }
        }

        private void KenarEkleButton_Click(object sender, EventArgs e)
        {
            if (kenarEklemeModu)
            {
                kenarEkleButton.BackColor = Color.LawnGreen;
                kenarEkleButton.Text = "Kenar Ekle";

                cizimPanel.Enabled = false;

                kenarEklemeModu = false;

                hesaplaButton.Enabled = true;
                ilerleButton.Enabled = true;               
                dugumEkleButton.Enabled = true;
                temizleButton.Enabled = true;
            }
            else
            {
                kenarEkleButton.BackColor = Color.Aqua;
                kenarEkleButton.Text = "Onayla";

                cizimPanel.Enabled = true;

                kenarEklemeModu = true;

                hesaplaButton.Enabled = false;
                ilerleButton.Enabled = false;
                dugumEkleButton.Enabled = false;
                temizleButton.Enabled = false;
            }            
        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            Graphics g = cizimPanel.CreateGraphics();
            g.Clear(cizimPanel.BackColor);
            Reset();

            hesaplaButton.Enabled = true;
            ilerleButton.Enabled = true;
            dugumEkleButton.Enabled = true;
            kenarEkleButton.Enabled = true;

        }

        #endregion

        private void BaslangicDegerleri()
        {
            Dugum dugum1, dugum2, dugum3, dugum4, dugum5, dugum6, dugum7, dugum8, dugum9, dugum10;

            Point nokta1 = new Point(20, 20);
            Point nokta2 = new Point(250, 40);
            Point nokta3 = new Point(100, 200);
            Point nokta4 = new Point(75, 450);
            Point nokta5 = new Point(250, 300);
            Point nokta6 = new Point(400, 100);
            Point nokta7 = new Point(550, 50);
            Point nokta8 = new Point(500, 250);
            Point nokta9 = new Point(320, 500);
            Point nokta10 = new Point(570, 470);

            dugumListe.Add(new Dugum(dugumListe.Count, nokta1));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta2));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta3));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta4));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta5));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta6));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta7));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta8));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta9));
            dugumListe.Add(new Dugum(dugumListe.Count, nokta10));

            dugum1 = SecilenDugumuGetir(nokta1);
            dugum2 = SecilenDugumuGetir(nokta2);
            dugum3 = SecilenDugumuGetir(nokta3);
            dugum4 = SecilenDugumuGetir(nokta4);
            dugum5 = SecilenDugumuGetir(nokta5);
            dugum6 = SecilenDugumuGetir(nokta6);
            dugum7 = SecilenDugumuGetir(nokta7);
            dugum8 = SecilenDugumuGetir(nokta8);
            dugum9 = SecilenDugumuGetir(nokta9);
            dugum10 = SecilenDugumuGetir(nokta10);

            baslangicKenarListe.Add(new Kenar(dugum1, dugum2, 10, YaziKonumBul(dugum1.konum, dugum2.konum))); //A-B
            kenarListBox.Items.Add(harf[dugum1.İsim] + " - " + harf[dugum2.İsim] + " : " + 10);

            baslangicKenarListe.Add(new Kenar(dugum2, dugum3, 15, YaziKonumBul(dugum2.konum, dugum3.konum))); //B-C
            kenarListBox.Items.Add(harf[dugum2.İsim] + " - " + harf[dugum3.İsim] + " : " + 15);

            baslangicKenarListe.Add(new Kenar(dugum1, dugum3, 18, YaziKonumBul(dugum1.konum, dugum3.konum))); //A-C
            kenarListBox.Items.Add(harf[dugum1.İsim] + " - " + harf[dugum3.İsim] + " : " + 18);

            baslangicKenarListe.Add(new Kenar(dugum3, dugum4, 9, YaziKonumBul(dugum3.konum, dugum4.konum))); //C-D
            kenarListBox.Items.Add(harf[dugum3.İsim] + " - " + harf[dugum4.İsim] + " : " + 9);

            baslangicKenarListe.Add(new Kenar(dugum3, dugum5, 25, YaziKonumBul(dugum3.konum, dugum5.konum))); //C-E
            kenarListBox.Items.Add(harf[dugum3.İsim] + " - " + harf[dugum5.İsim] + " : " + 25);

            baslangicKenarListe.Add(new Kenar(dugum2, dugum6, 19, YaziKonumBul(dugum2.konum, dugum6.konum))); //B-F
            kenarListBox.Items.Add(harf[dugum2.İsim] + " - " + harf[dugum6.İsim] + " : " + 19);

            baslangicKenarListe.Add(new Kenar(dugum5, dugum6, 16, YaziKonumBul(dugum5.konum, dugum6.konum))); //E-F
            kenarListBox.Items.Add(harf[dugum5.İsim] + " - " + harf[dugum6.İsim] + " : " + 16);

            baslangicKenarListe.Add(new Kenar(dugum4, dugum9, 10, YaziKonumBul(dugum4.konum, dugum9.konum))); //D-I
            kenarListBox.Items.Add(harf[dugum4.İsim] + " - " + harf[dugum9.İsim] + " : " + 10);

            baslangicKenarListe.Add(new Kenar(dugum5, dugum9, 13, YaziKonumBul(dugum5.konum, dugum9.konum))); //E-I
            kenarListBox.Items.Add(harf[dugum5.İsim] + " - " + harf[dugum9.İsim] + " : " + 13);

            baslangicKenarListe.Add(new Kenar(dugum5, dugum8, 26, YaziKonumBul(dugum5.konum, dugum8.konum))); //E-H
            kenarListBox.Items.Add(harf[dugum5.İsim] + " - " + harf[dugum8.İsim] + " : " + 26);

            baslangicKenarListe.Add(new Kenar(dugum5, dugum10, 19, YaziKonumBul(dugum5.konum, dugum10.konum))); //E-J
            kenarListBox.Items.Add(harf[dugum5.İsim] + " - " + harf[dugum10.İsim] + " : " + 19);

            baslangicKenarListe.Add(new Kenar(dugum2, dugum7, 6, YaziKonumBul(dugum2.konum, dugum7.konum))); //B-G
            kenarListBox.Items.Add(harf[dugum2.İsim] + " - " + harf[dugum7.İsim] + " : " + 6);

            baslangicKenarListe.Add(new Kenar(dugum7, dugum8, 11, YaziKonumBul(dugum7.konum, dugum8.konum))); //G-H
            kenarListBox.Items.Add(harf[dugum7.İsim] + " - " + harf[dugum8.İsim] + " : " + 11);

            baslangicKenarListe.Add(new Kenar(dugum9, dugum10, 22, YaziKonumBul(dugum9.konum, dugum10.konum))); //I-J
            kenarListBox.Items.Add(harf[dugum9.İsim] + " - " + harf[dugum10.İsim] + " : " + 22);


        }

        private void CizimPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point tiklananNokta = new Point(e.X - dugumYariCap, e.Y - dugumYariCap);

            if (dugumEklemeModu == true)
            {
                dugumListe.Add(new Dugum(dugumListe.Count, tiklananNokta));
                cizimPanel.Invalidate();
            }

            else if (kenarEklemeModu == true)
            {
                if (!kenarEklemeDurumu)
                {
                    ilkDugum = SecilenDugumuGetir(tiklananNokta);
                    kenarEklemeDurumu = true;
                }
                else
                {

                    ikinciDugum = SecilenDugumuGetir(tiklananNokta);
                    kenarEklemeDurumu = false;

                    if (ilkDugum != null && ikinciDugum != null && ilkDugum.İsim != ikinciDugum.İsim)
                    {

                        if(baslangicKenarListe.Exists(x => x.Dugum1 == ilkDugum && x.Dugum2 == ikinciDugum) || 
                            baslangicKenarListe.Exists(x => x.Dugum2 == ilkDugum && x.Dugum1 == ikinciDugum))
                        {
                            MessageBox.Show("Kenar Mevcut", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        else
                        { 

                            MaliyetForm maliyetForm = new MaliyetForm();
                            maliyetForm.ShowDialog();

                            Point yaziKonum = YaziKonumBul(ilkDugum.konum, ikinciDugum.konum);
                            baslangicKenarListe.Add(new Kenar(ilkDugum, ikinciDugum, maliyetForm.maliyetGirdisi, yaziKonum));
                            cizimPanel.Invalidate();

                            kenarListBox.Items.Add(harf[ilkDugum.İsim] + " - " + harf[ikinciDugum.İsim] + " : " + maliyetForm.maliyetGirdisi);

                        }                  
                    }
                }
            }
        }

        private void CizimPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DugumCiz(g);
            KenarCiz(g);
            g.Dispose();

        }

        private void HesaplaButton_Click(object sender, EventArgs e)
        {
            if (dugumListe.Count > 2)
            {             

                if (dugumListe.All(y => baslangicKenarListe.Exists(x => x.Dugum1 == y || x.Dugum2==y)))
                {
                    dugumEkleButton.Enabled = false;

                    kenarEkleButton.Enabled = false;
                    ilerleButton.Enabled = false;

                    int toplamMaliyet = 0;

                    sonKenarListe = Cozucu(ref toplamMaliyet);


                    cozulmeDurumu = true;
                    adimSayaci = sonKenarListe.Count;

                    cizimPanel.Invalidate();

                    hesaplaButton.Enabled = false;
                    MessageBox.Show("Toplam Maliyet: " + toplamMaliyet.ToString(), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }

                else
                {                   
                    MessageBox.Show("Tüm Düğümler Ağaca Bağlanmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Düğüm Sayısı En Az 3 Olmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void İlerleButton_ClickAsync(object sender, EventArgs e)
        {

            if (dugumListe.Count > 2)
            {
                
                if (dugumListe.All(y => baslangicKenarListe.Exists(x => x.Dugum1 == y || x.Dugum2 == y)))
                {

                    hesaplaButton.Enabled = false;
                    dugumEkleButton.Enabled = false;

                    kenarEkleButton.Enabled = false;

                    int toplamMaliyet = 0;


                    if (sonKenarListe == null)
                    {
                        sonKenarListe = AnlatimliCozucu(ref toplamMaliyet);
                        ilerlemeMaliyet = toplamMaliyet;                       
                    }

                    cozulmeDurumu = true;
                    ilerlemeDurumu = true;

                    kenarListBox.SetSelected(adimSayaci, true);


                    await Task.Delay(gecikme);

                    if (geciciBox.Lines[adimSayaci].Contains("eklenmedi"))
                    {
                        AnlatimBox.SelectionColor = Color.Red;
                        AnlatimBox.AppendText(geciciBox.Lines[adimSayaci] + "\n");
                        AnlatimBox.ScrollToCaret();
                                            

                    }
                    else if (geciciBox.Lines[adimSayaci].Contains("eklendi"))
                    {
                        AnlatimBox.SelectionColor = Color.Green;
                        AnlatimBox.AppendText(geciciBox.Lines[adimSayaci] + "\n");
                        AnlatimBox.ScrollToCaret();
                        optimumSayac++;
                    }

                    await Task.Delay(gecikme);
                 
                    adimSayaci++;

                    cizimPanel.Invalidate();
                    if (adimSayaci == baslangicKenarListe.Count)
                    {
                        ilerleButton.Enabled = false;
                        MessageBox.Show("Toplam Maliyet: " + ilerlemeMaliyet.ToString(), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Tüm Düğümler Ağaca Bağlanmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Düğüm Sayısı En Az 3 Olmalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DugumCiz(Graphics g)
        {
            Pen P = new Pen(dugumRenk);
            Brush B = new SolidBrush(dugumRenk);
            foreach (Dugum d in dugumListe)
            {
                g.DrawEllipse(P, d.konum.X, d.konum.Y, dugumCap, dugumCap);
                g.FillEllipse(B, d.konum.X, d.konum.Y, dugumCap, dugumCap);
                AdEkle(harf[d.İsim].ToString(), d.konum, g);
            }
        }

        private void AdEkle(string yazi, Point konum, Graphics g)
        {
            Font fontOzellikler = new Font("Arial", 15);
            SolidBrush fircaRenk = new SolidBrush(Color.Black);
            g.DrawString(yazi, fontOzellikler, fircaRenk, konum);
        }

        private void Reset()
        {
            dugumEklemeModu = false;
            kenarEklemeModu = false;
            dugumListe = new List<Dugum>();
            baslangicKenarListe = new List<Kenar>();
            sonKenarListe = null;
            cozulmeDurumu = false;
            ilerlemeDurumu = false;
            ilkDugum = ikinciDugum = null;
            adimSayaci = 0;
            optimumSayac = 0;
            ilerlemeMaliyet = 0;
            geciciBox.Clear();
            kenarListBox.Items.Clear();
            AnlatimBox.Clear();
            gecikme = 0;
        }

        private void GecikmeBar_ValueChanged(object sender, EventArgs e)
        {
            gecikme = gecikmeBar.Value * 1000;
            gecikmeLabel.Text = gecikmeBar.Value.ToString() + " sn";
        }

        private void KenarCiz(Graphics g)
        {

            Pen P = new Pen(kenarRenk);
            List<Kenar> kenarListe = cozulmeDurumu ? sonKenarListe : baslangicKenarListe;

            for (int i = 0; i < kenarListe.Count; i++)
            {
                Kenar k = kenarListe[i];
                Point dugumKonum1 = new Point(k.Dugum1.konum.X + dugumYariCap, k.Dugum1.konum.Y + dugumYariCap);
                Point dugumKonum2 = new Point(k.Dugum2.konum.X + dugumYariCap, k.Dugum2.konum.Y + dugumYariCap);
                g.DrawLine(P, dugumKonum1, dugumKonum2);
                AdEkle(k.Maliyet.ToString(), k.YaziKonum, g);


                if (ilerlemeDurumu == true && i == optimumSayac - 1)
                {
                    break;
                }
            }
        }

        private Dugum SecilenDugumuGetir(Point tiklananNokta)
        {
            Dugum donus = null;
            double mesafe;
            foreach (Dugum d in dugumListe)
            {
                mesafe = MesafeBul(d.konum, tiklananNokta);
                if (mesafe <= dugumCap)
                {
                    donus = d;
                    break;
                }
            }
            return donus;
        }

        private double MesafeBul(Point ilkKonum, Point ikinciKonum)
        {
            return Math.Sqrt(Math.Pow(ilkKonum.X - ikinciKonum.X, 2) + Math.Pow(ilkKonum.Y - ikinciKonum.Y, 2));
        }

        private Point YaziKonumBul(Point ilkKonum, Point ikinciKonum)
        {
            int X = (ilkKonum.X + ikinciKonum.X) / 2;
            int Y = (ilkKonum.Y + ikinciKonum.Y) / 2;
            return new Point(X, Y);
        }

        private List<Kenar> Cozucu(ref int toplamMaliyet)
        {

            kenarListBox.Items.Clear();

            Kenar.QuickSort(baslangicKenarListe, 0, baslangicKenarListe.Count - 1);

            AnlatimBox.AppendText("Kenarlar küçükten büyüğe sıralandı\n");

            List<Kenar> sonKenarListe = new List<Kenar>(baslangicKenarListe.Count);


            for (int i = 0; i < baslangicKenarListe.Count; i++)
            {
                Kenar K = (Kenar)baslangicKenarListe[i];
                Dugum kok1, kok2;
                kok1 = K.Dugum1.KokBul();
                kok2 = K.Dugum2.KokBul();


                if (kok1.İsim != kok2.İsim)
                {
                    toplamMaliyet += K.Maliyet;
                    Dugum.KokBirlestir(kok1, kok2);
                    sonKenarListe.Add(new Kenar(K.Dugum1, K.Dugum2, K.Maliyet, K.YaziKonum));


                    AnlatimBox.SelectionColor = Color.Green;
                    AnlatimBox.AppendText(harf[K.Dugum1.İsim] + " - " + harf[K.Dugum2.İsim] + " : Döngü oluşmadı, kenar eklendi\n");
                    AnlatimBox.ScrollToCaret();



                }
                else
                {
                    AnlatimBox.SelectionColor = Color.Red;
                    AnlatimBox.AppendText(harf[K.Dugum1.İsim] + " - " + harf[K.Dugum2.İsim] + " : Döngü oluştuğu kenar için eklenmedi\n");
                    AnlatimBox.ScrollToCaret();
                }
                kenarListBox.Items.Add(harf[K.Dugum1.İsim] + " - " + harf[K.Dugum2.İsim] + " : " + baslangicKenarListe[i].Maliyet);

            }

            return sonKenarListe;
        }

        private List<Kenar> AnlatimliCozucu(ref int toplamMaliyet)
        {

            kenarListBox.Items.Clear();

            Kenar.QuickSort(baslangicKenarListe, 0, baslangicKenarListe.Count - 1);

            AnlatimBox.AppendText("Kenarlar küçükten büyüğe sıralandı\n");



            List<Kenar> sonKenarListe = new List<Kenar>(baslangicKenarListe.Count);


            for (int i = 0; i < baslangicKenarListe.Count; i++)
            {
                Kenar K = (Kenar)baslangicKenarListe[i];
                Dugum kok1, kok2;
                kok1 = K.Dugum1.KokBul();
                kok2 = K.Dugum2.KokBul();


                if (kok1.İsim != kok2.İsim)
                {
                    toplamMaliyet += K.Maliyet;
                    Dugum.KokBirlestir(kok1, kok2);
                    sonKenarListe.Add(new Kenar(K.Dugum1, K.Dugum2, K.Maliyet, K.YaziKonum));

                    geciciBox.SelectionColor = Color.Green;                       
                    geciciBox.AppendText(harf[K.Dugum1.İsim] + " - " + harf[K.Dugum2.İsim] + " : Döngü oluşmadı, kenar eklendi\n");
                }
                else
                {
                    geciciBox.SelectionColor = Color.Red;                    
                    geciciBox.AppendText(harf[K.Dugum1.İsim] + " - " + harf[K.Dugum2.İsim] + " : Döngü oluştuğu için kenar eklenmedi\n");
                }

                kenarListBox.Items.Add(harf[K.Dugum1.İsim] + " - " + harf[K.Dugum2.İsim] + " : " + baslangicKenarListe[i].Maliyet);
            }
            return sonKenarListe;
        }

    }
}