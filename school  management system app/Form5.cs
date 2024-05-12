using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTablosuDenemesi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciDataSet1.ogretmen' table. You can move, or remove it, as needed.
            this.ogretmenTableAdapter.Fill(this.ogrenciDataSet1.ogretmen);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogretmenTableAdapter.Fill(ogrenciDataSet1.ogretmen);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogrenciDataSet.ogretmenRow selectedRow =(ogrenciDataSet.ogretmenRow)gridView1.GetFocusedDataRow();
            if(selectedRow!=null)
            {
                ogretmenTableAdapter.Delete(selectedRow.OgretmenID);

            }
            else
            {
                MessageBox.Show("Lütfen bir Öğretmen seçiniz!");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ID = -1;
            form6.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogrenciDataSet.ogretmenRow selectedRow = (ogrenciDataSet.ogretmenRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if(selectedRow!=null)
            {
                Form6 Form6 = new Form6();
                Form6.ID = selectedRow.OgretmenID;
                Form6.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Öğretmen Seçiniz!");
            }
        }
    }
}
