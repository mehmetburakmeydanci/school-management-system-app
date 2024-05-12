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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciDataSet1.notlar' table. You can move, or remove it, as needed.
            this.notlarTableAdapter.Fill(this.ogrenciDataSet1.notlar);

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            notlarTableAdapter.Fill(ogrenciDataSet1.notlar);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.ID = -1;
            Form8.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogrenciDataSet.notlarRow selectedRow = (ogrenciDataSet.notlarRow)gridView1.GetFocusedDataRow();
            if(selectedRow!=null)
            {
                notlarTableAdapter.Delete(selectedRow.not_id, selectedRow.ogrenciID);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Not Seçiniz!");
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ogrenciDataSet.notlarRow selectedRow = (ogrenciDataSet.notlarRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if(selectedRow!=null)
            {
                Form8 Form8 = new Form8();
                Form8.ID = selectedRow.not_id;
                Form8.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Not Seçiniz!");
            }
        }
    }
}
