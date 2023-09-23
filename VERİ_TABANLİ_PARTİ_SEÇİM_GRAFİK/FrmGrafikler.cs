using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VERİ_TABANLİ_PARTİ_SEÇİM_GRAFİK
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(@"Data Source=MONSTER1771\MSSQLSERVER01;Initial Catalog=DBSECIMPROJE;Integrated Security=True");


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // İlçe Adlarını Comboboxa Çekme
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from TBLİCEE", Baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                CMBİLCE.Items.Add(rd[0]);
            }
            Baglanti.Close();
            // Grafiğe Toplam Sonuçları Getirme

            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) from TBLİCEE", Baglanti);
            SqlDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", rd2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", rd2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", rd2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", rd2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", rd2[4]);
            }
            Baglanti.Close();

        }

        private void CMBİLCE_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ProgressBar'a Oy Yoüunluğunu Yansıtma
            Baglanti.Open();
            SqlCommand komut = new SqlCommand(" select * from TBLİCEE where ILCEAD=@P1", Baglanti);
            komut.Parameters.AddWithValue("@p1", CMBİLCE.Text);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                PRBA.Value = int.Parse(rd[2].ToString());
                PRBb.Value = int.Parse(rd[3].ToString());
                PRBC.Value = int.Parse(rd[4].ToString());
                PRBD.Value = int.Parse(rd[5].ToString());
                PRBE.Value = int.Parse(rd[6].ToString());

                // Labela Verilen Oy Sayısını Gösterme

                LblA.Text = rd[2].ToString();
                LblB.Text = rd[3].ToString();
                LblC.Text = rd[4].ToString();
                LblD.Text = rd[5].ToString();
                LblE.Text = rd[6].ToString();
            }
            Baglanti.Close();
        }
    }
}
