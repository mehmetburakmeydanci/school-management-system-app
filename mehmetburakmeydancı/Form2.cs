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

namespace OgrenciTablosuDenemesi
{
    public partial class Form2 : Form
    {
        
        //Database database;
        //SqlCommand komut;
        //SqlDataAdapter data;
        public int ID = -1;

        void Yeni()
        {

            var row = ogrenciDataSet.ogrencitablo.NewogrencitabloRow();
            ogrenciDataSet.ogrencitablo.AddogrencitabloRow(row);
        }

        private void InitData()
        {
            ogrenciDataSet.ogrencitablo.TableNewRow += (o, e) =>
            {
                e.Row[ogrenciDataSet.ogrencitablo.ogrenciadsoyadColumn] = string.Empty;
                e.Row[ogrenciDataSet.ogrencitablo.ogrencinumaraColumn] = 0;
                e.Row[ogrenciDataSet.ogrencitablo.ogrenciokulColumn] = string.Empty;
                e.Row[ogrenciDataSet.ogrencitablo.ogrencibolumColumn] = string.Empty;


            };


        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnKaydetKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string sorgu = "INSERT INTO ogrencitablo(ogrencinumara,ogrenciadsoyad,ogrenciokul,ogrencibolum) VALUES (@numara,@ad,@okul,@bolum)";
            //komut = new SqlCommand(sorgu,database.baglanti);
            //komut.Parameters.AddWithValue("@numara",txtNumara.Text);
            //komut.Parameters.AddWithValue("@ad",txtAdSoyad.Text);
            //komut.Parameters.AddWithValue("@okul",txtOkul.Text);
            //komut.Parameters.AddWithValue("@bolum",txtBolum.Text);
            //database.baglanti.Open();
            //komut.ExecuteNonQuery();
            //database.baglanti.Close();
            try
            {
                bindingSource1.EndEdit();
                var row = ogrenciDataSet.ogrencitablo.First();
                if (ID == -1)
                {
                    ogrencitabloTableAdapter.Insert(row.ogrencinumara, row.ogrenciadsoyad, row.ogrenciokul, row.ogrencibolum);
                }
                else
                {
                    ogrencitabloTableAdapter.Update(row.ogrencinumara,row.ogrenciadsoyad,row.ogrenciokul,row.ogrencibolum,row.ogrenciID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            InitData();
            if (ID == -1)
            {
                Yeni();
            }
            else
            {
                this.ogrencitabloTableAdapter.FillByID(this.ogrenciDataSet.ogrencitablo, ID);
            }

        }

    }
}
