using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OgrenciTablosuDenemesi
{
    public partial class Form1 : Form
    {
        Database database;
        SqlCommand komut;
        SqlDataAdapter data;

        public Form1()
        {

            InitializeComponent();
        }
        void OgrenciGetir()
        {

            this.ogrencitabloTableAdapter.Fill(this.ogrenciDataSet.ogrencitablo);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciDataSet.ogrencitablo' table. You can move, or remove it, as needed.
            OgrenciGetir();

            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
   
         
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ID = -1;
            form2.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogrenciDataSet.ogrencitabloRow selectedRow = (ogrenciDataSet.ogrencitabloRow)gridView1.GetFocusedDataRow();
            if (selectedRow != null)
            {
                //string sorgu = "DELETE FROM ogrencitablo WHERE ogrenciID=@ogrenciid";
                //komut = new SqlCommand(sorgu,database.baglanti);
                //komut.Parameters.AddWithValue("@ogrenciid",selectedRow.ogrenciID);
                //database.baglanti.Open();
                //komut.ExecuteNonQuery();
                //database.baglanti.Close();
                ogrencitabloTableAdapter.Delete(selectedRow.ogrenciID);

                OgrenciGetir();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Öğrenci Seçiniz!");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
   
            ogrenciDataSet.ogrencitabloRow selectedRow = (ogrenciDataSet.ogrencitabloRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow != null)
            {
                Form2 Form2 = new Form2();
                Form2.ID = selectedRow.ogrenciID;
                Form2.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Öğrenci Seçiniz!");
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OgrenciGetir();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form Form5 = new Form5();
            Form5.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form Form7 = new Form7();
            Form7.Show();
        }
    }


}

