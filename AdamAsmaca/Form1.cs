using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        string secilenkelime = "";
        Label[] labels;
        int say = 0;
        public Form1()
        {
            InitializeComponent();
            pckb_AdamAs.ImageLocation = @"..\..\Images\01.png";
            pckb_AdamAs.Load();
            ButtonAdd();
            LabelAdd();
        }

        private void LabelAdd()
        {
            string[] kelimeler = new string[] {"TÜRKİYE", "FRANSA", "ALMANYA", "İSPANYA", "İTALYA", "LÜKSEMBURG",
                "HOLLANDA", "İSVİÇRE", "BELÇİKA", "AVUSTURYA", "RUSYA", "SLOVAKYA", "ROMANYA", "UKRAYNA", "DANİMARKA",
                "ESTONYA", "LİTVANYA", "HIRVATİSTAN", "NORVEÇ", "FİNLANDİYA", "İSVEÇ", "ARNAVUTLUK", "LETONYA", "ANDORRA",
                "KARADAĞ", "MAKEDONYA", "YUNANİSTAN", "KUZEYKIBRIS", "SLOVENYA", "SIRBİSTAN", "SANMARİNO", "MALTA", "KOSOVA",
                "PORTEKİZ", "GÜNEYOSETYA", "BULGARİSTAN", "RUSYA","SURİYE", "İRAN", "AFGANİSTAN", "ERMENİSTAN", "AZERBAYCAN",
                "JAPONYA", "ÇİN", "IRAK", "HİNDİSTAN", "MALDİVLER", "PAKİSTAN", "MOĞOLİSTAN", "NEPAL", "ARABİSTAN", "TAYLAND",
                "ÜRDÜN", "GÜRCİSTAN", "LÜBNAN", "VİETNAM", "KUZEYKORE", "FİLİPİNLER", "GÜNEYKORE", "MALEZYA", "TAYVAN", "KATAR",
                "KAMBOÇYA", "KANADA", "BREZİLYA", "AMERİKA", "JAMAİKA", "MEKSİKA", "GRANADA", "ARJANTİN", "URUGUAY", "ŞİLİİ", "PERU",
                "MISIR", "KENYA", "FAS", "GANA", "CEZAİR", "BENİN", "GİNA", "TUNUS", "GANA", "YEŞİLBURUN", "AVUSTURYA", "FİJİ", "ENDONEZYA",
                "PALAU", "KİRİBATİ"};

            Random rnd = new Random();
            secilenkelime = kelimeler[rnd.Next(kelimeler.Length)];
            labels = new Label[secilenkelime.Length];
            int x = 300, y = 150;

            for (int i = 0; i < secilenkelime.Length; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl_" + secilenkelime[i];
                lbl.Text = "_";
                lbl.Size = new Size(40, 40);
                lbl.Location = new Point(x, y);
                lbl.Font = new Font("Arial", 24, FontStyle.Bold);
                this.Controls.Add(lbl);
                labels[i] = lbl;
                labels[i].Text = "_";

                x += 40;
            }
        }

        private void ButtonAdd()
        {
            string[] harfler = new string[] {"A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M",
             "N", "O", "Ö", "P", "Q", "R", "S", "Ş", "T", "U", "Ü", "V", "W", "X", "Y", "Z"};

            int x = 0, y = 0;

            for (int i = 0; i < harfler.Length; i++)
            {
                Button btn = new Button();
                btn.Name = "btn_" + harfler[i];
                btn.Text = harfler[i].ToString();
                btn.Click += new EventHandler(button_Click);
                btn.Size = new Size(40, 40);

                if (i % 5 == 0)
                {
                    x = 40; y += 40;
                }
                else
                {
                    x += 40;
                }
                btn.Location = new Point(x, y);
                this.Controls.Add(btn);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            bool buldumu = false;

            if (say <= 6)
            {
                for (int i = 0; i < secilenkelime.Length; i++)
                {
                    if (btn.Text == secilenkelime[i].ToString())
                    {
                        labels[i].Text = btn.Text;
                        buldumu = true;
                        lbl_mesaj.Text = "Süpersin Dostum.:)";
                    }
                    else
                    {
                        lbl_mesaj.Text = "Opps.. İyi Düşün Dostum Hangi Ülke Bu .;)";
                    }
                }
            }
            else
            {
                lbl_mesaj.Text = "Malesef Kaybettin Dostum. Bir Daha Dene Şansını..:)";
            }

            if (buldumu == false)
            {
                say++;
                AdamAs();

            }
        }

        private void AdamAs()
        {
            switch (say)
            {
                case 1:
                    pckb_AdamAs.ImageLocation = @"..\..\Images\01.png";
                    pckb_AdamAs.Load();
                    break;
                case 2:
                    pckb_AdamAs.ImageLocation = @"..\..\Images\02.png";
                    pckb_AdamAs.Load();
                    break;
                case 3:
                    pckb_AdamAs.ImageLocation = @"..\..\Images\03.png";
                    pckb_AdamAs.Load();
                    break;
                case 4:
                    pckb_AdamAs.ImageLocation = @"..\..\Images\04.png";
                    pckb_AdamAs.Load();
                    break;
                case 5:
                    pckb_AdamAs.ImageLocation = @"..\..\Images\05.png";
                    pckb_AdamAs.Load();
                    break;
                case 6:
                    pckb_AdamAs.ImageLocation = @"..\..\Images\06.png";
                    pckb_AdamAs.Load();
                    break;
            }
        }

    }
}
