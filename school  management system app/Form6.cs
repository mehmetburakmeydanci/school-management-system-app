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
    public partial class Form6 : Form
    {
        public int ID=-1; 

        void Yeni()
        {
            var row = ogrenciDataSet1.ogretmen.NewogretmenRow();
            ogrenciDataSet1.ogretmen.AddogretmenRow(row);
        }

        private void InitData()
        {
            ogrenciDataSet1.ogretmen.TableNewRow += (o, e) =>
              {
                  e.Row[ogrenciDataSet1.ogretmen.OgretmenAdSoyadColumn] = string.Empty;
                  e.Row[ogrenciDataSet1.ogretmen.OgretmenOkulColumn] = string.Empty;
              };
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void form6kapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void form6kaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                var row = ogrenciDataSet1.ogretmen.First();
                if(ID==-1)
                {
                    ogretmenTableAdapter.Insert(textogretmenad.Text, textogretmenokul.Text);
                }
                else
                {
                    ogretmenTableAdapter.Update(row.OgretmenAdSoyad,row.OgretmenOkul, row.OgretmenID);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            Close();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            InitData();
            if (ID == -1)
            {
                Yeni();
            }
            else
            {
                this.ogretmenTableAdapter.FillByID(this.ogrenciDataSet1.ogretmen,ID);
            }
        }
    }
}
