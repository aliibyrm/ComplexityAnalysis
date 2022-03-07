using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karmaşık_Analizi
{
    public partial class S : Form
    {
        public S()
        {
            InitializeComponent();
        }
        private void S_Load(object sender, EventArgs e)
        {

        }

        private void BtnSureKarsilastir_Click(object sender, EventArgs e)
        {
            int diziSize = 500;
            int [] sayilar = new int[diziSize];

            Random rnd = new Random();
            for (int i = 0; i < diziSize; i++)
            {
                sayilar[i] = rnd.Next(-100, 100);
            }
            int sonuc;
            string s = "";

           
            MaxAltDiziTopla diziTopla = new MaxAltDiziTopla();
           
            lsbAnaliz.Items.Clear();

            DateTime start = DateTime.Now;
            sonuc = diziTopla.BruteForce(sayilar);
            DateTime son = DateTime.Now.AddMilliseconds(1);
            TimeSpan span1 = son.Subtract(start);          
            s = "BrutForce: " + "Süre: " + span1.ToString() + " Sonuç:" + sonuc.ToString() + Environment.NewLine;
            MessageBox.Show(s);
            lsbAnaliz.Items.Add(s);

            DateTime dateTime = DateTime.Now;
            sonuc = diziTopla.BruteForceImproved(sayilar);
            DateTime sonTime = DateTime.Now.AddMilliseconds(1);
            TimeSpan sp = sonTime.Subtract(dateTime);         
            s = "BrutForce Improved: " + "Süre: " + sp.ToString() + " Sonuç:" + sonuc.ToString() + Environment.NewLine;
            MessageBox.Show(s);
            lsbAnaliz.Items.Add(s);

            DateTime time = DateTime.Now;
            sonuc = diziTopla.dogrusal(sayilar);
            DateTime endtime = DateTime.Now.AddMilliseconds(1);
            TimeSpan timeSpan = endtime.Subtract(time);
            s = "BrutForce Improved: " + "Süre: " + timeSpan.ToString() + " Sonuç:" + sonuc.ToString() + Environment.NewLine;
            MessageBox.Show(s);
            lsbAnaliz.Items.Add(s);

        }
    }
}
