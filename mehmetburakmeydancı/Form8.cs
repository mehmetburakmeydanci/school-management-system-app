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
    public partial class Form8 : Form
    {
        public int ID = -1;

        void Yeni()
        {
            var row = ogrenciDataSet1.notlar.NewnotlarRow();
            ogrenciDataSet1.notlar.AddnotlarRow(row);
        }

        private void InitData()
        {
            ogrenciDataSet1.notlar.TableNewRow += (o, e) =>
            {
                e.Row[ogrenciDataSet1.notlar.vizenotuColumn] = 0;
                e.Row[ogrenciDataSet1.notlar.finalnotuColumn] = 0;
                e.Row[ogrenciDataSet1.notlar.projenotuColumn] = 0;
                e.Row[ogrenciDataSet1.notlar.ogrenciIDColumn] = 0;
                
            };
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void form8kapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            ogrencitabloTableAdapter.Fill(ogrenciDataSet1.ogrencitablo);
            InitData();
           if(ID==-1)
            {
                Yeni();
            }
            else
            {
                notlarTableAdapter.FillByID(this.ogrenciDataSet1.notlar,ID);
            }

        }

        private void form8kaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                var row =ogrenciDataSet1.notlar.First();

                if (ID == -1)
                {
                    notlarTableAdapter.Insert((int)comboBoxEdit1.EditValue, Convert.ToInt32(textEdit1.Text), Convert.ToInt32(textEdit2.Text), Convert.ToInt32(textEdit3.Text));
                }
                else
                {
                    notlarTableAdapter.Update(ogrenciDataSet1.notlar);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

     
       
    }
}
