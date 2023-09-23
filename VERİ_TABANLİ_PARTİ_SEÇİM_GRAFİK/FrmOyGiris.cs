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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection Baglanti = new SqlConnection(@"Data Source=MONSTER1771\MSSQLSERVER01;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNGİRİS_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLİCEE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values " +
                "(@P1,@P2,@P3,@P4,@P5,@P6)", Baglanti);
            komut.Parameters.AddWithValue("@P1", TXTAD.Text);
            komut.Parameters.AddWithValue("@P2", TXTA.Text);
            komut.Parameters.AddWithValue("@P3", TxtB.Text);
            komut.Parameters.AddWithValue("@P4", TxtC.Text);
            komut.Parameters.AddWithValue("@P5", TxtD.Text);
            komut.Parameters.AddWithValue("@P6", TxtE.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Oy Verme İşlemi Gerçekleşmiştir");
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
            this.Hide();
        }
    }
}
