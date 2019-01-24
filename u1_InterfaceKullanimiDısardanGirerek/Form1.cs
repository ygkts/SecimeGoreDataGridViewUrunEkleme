using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u1_InterfaceKullanimiDısardanGirerek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KupKutu kup = new KupKutu();
        DikdortgenKutu dik = new DikdortgenKutu();
        SilindirKutu sil = new SilindirKutu();

        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        DataTable tablo3 = new DataTable();
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //KupKutu kup = (KupKutu)dataGridView1.CurrentRow.DataBoundItem;
            int hacim = kup.Hacim();
            MessageBox.Show("Küp Hacmi : " + hacim + " dir.");
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int hacim = dik.Hacim();
            MessageBox.Show("Dikdörtgen Hacmi  : " + hacim + " dir.");
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int hacim = sil.Hacim();
            MessageBox.Show("Silindir Hacmi : " + hacim + " dir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonKup.Checked == true)
                {
                    kup.Id = Convert.ToInt16(txtID.Text);
                    kup.UrunAd = txtUrunAd.Text;
                    kup.Yukseklik = Convert.ToInt16(txtYukseklik.Text);

                    tablo.Rows.Add(kup.Id, kup.UrunAd, kup.Yukseklik); // satır ekleme
                    dataGridView1.DataSource = tablo;
                }
                else if (radioButtonDik.Checked == true)
                {
                    dik.Id = Convert.ToInt16(txtID.Text);
                    dik.UrunAd = txtUrunAd.Text;
                    dik.Yukseklik = Convert.ToInt16(txtYukseklik.Text);
                    dik.KisaKenar = Convert.ToInt16(txtKisaKenar.Text);
                    dik.UzunKenar = Convert.ToInt16(txtUzunKenar.Text);

                    tablo2.Rows.Add(dik.Id, dik.UrunAd, dik.Yukseklik, dik.KisaKenar, dik.UzunKenar);
                    dataGridView2.DataSource = tablo2;
                }
                else if (radioButtonSil.Checked == true)
                {
                    sil.Id = Convert.ToInt16(txtID.Text);
                    sil.UrunAd = txtUrunAd.Text;
                    sil.Yukseklik = Convert.ToInt16(txtYukseklik.Text);
                    sil.Yaricap = Convert.ToInt16(txtYariCap.Text);

                    tablo3.Rows.Add(sil.Id, sil.UrunAd, sil.Yukseklik, sil.Yaricap);
                    dataGridView3.DataSource = tablo3;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Değer Giriniz");
            }
            
            txtID.Clear(); txtUrunAd.Clear(); txtYukseklik.Clear();  txtKisaKenar.Clear(); txtUzunKenar.Clear(); txtYariCap.Clear();
        }

        private void radioButtonKup_CheckedChanged(object sender, EventArgs e)
        {
            lblKisaKenar.Visible = false;
            lblUzunKenar.Visible = false;
            lblYariCap.Visible = false;
            txtKisaKenar.Visible = false;
            txtUzunKenar.Visible = false;
            txtYariCap.Visible = false;
        }

        private void radioButtonDik_CheckedChanged(object sender, EventArgs e)
        {
            lblKisaKenar.Visible = true;
            lblUzunKenar.Visible = true;
            lblYariCap.Visible = false;
            txtKisaKenar.Visible = true;
            txtUzunKenar.Visible = true;
            txtYariCap.Visible = false;
        }

        private void radioButtonSil_CheckedChanged(object sender, EventArgs e)
        {
            lblKisaKenar.Visible = false;
            lblUzunKenar.Visible = false;
            lblYariCap.Visible = true;
            txtKisaKenar.Visible = false;
            txtUzunKenar.Visible = false;
            txtYariCap.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sütun ekleme
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("AD", typeof(string));
            tablo.Columns.Add("YUKSEKLIK", typeof(int));
            dataGridView1.DataSource = tablo;

            tablo2.Columns.Add("ID", typeof(int));
            tablo2.Columns.Add("AD", typeof(string));
            tablo2.Columns.Add("YUKSEKLIK", typeof(int));
            tablo2.Columns.Add("KISA KENAR", typeof(int));
            tablo2.Columns.Add("UZUN KENAR", typeof(int));
            dataGridView2.DataSource = tablo2;

            tablo3.Columns.Add("ID", typeof(int));
            tablo3.Columns.Add("AD", typeof(string));
            tablo3.Columns.Add("YUKSEKLIK", typeof(int));
            tablo3.Columns.Add("YARIÇAP", typeof(int));
            dataGridView3.DataSource = tablo3;
        }
    }
}
