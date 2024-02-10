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

namespace veri_tabanlı_seçim_uygulaması
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection(@"Data Source=KAAN;Initial Catalog=DBSECIM;Integrated Security=True;Encrypt=False");
        private void btnOygiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtilce.Text);
            komut.Parameters.AddWithValue("@p2", txtA.Text);
            komut.Parameters.AddWithValue("@p3", txtB.Text);
            komut.Parameters.AddWithValue("@p4", txtC.Text);
            komut.Parameters.AddWithValue("@p5", txtD.Text);
            komut.Parameters.AddWithValue("@p6", txtE.Text);
            komut.ExecuteReader();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
