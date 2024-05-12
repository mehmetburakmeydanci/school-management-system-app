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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.derstabloTableAdapter.Fill(this.ogrenciDataSet1.derstablo);
            ogrencitabloTableAdapter.Fill(ogrenciDataSet1.ogrencitablo);
            this.secilenderslerTableAdapter.Fill(this.ogrenciDataSet1.secilendersler);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            int DersID = Convert.ToInt32(checkedComboBoxEdit1.EditValue);
            int DersID1 = Convert.ToInt32(checkedComboBoxEdit2.EditValue);
            int DersID2 = Convert.ToInt32(checkedComboBoxEdit3.EditValue);
            int OgrenciID = Convert.ToInt32(checkedComboBoxEdit4.EditValue);
            secilenderslerTableAdapter.Insert(OgrenciID,DersID);
            secilenderslerTableAdapter.Insert(OgrenciID,DersID1);
            secilenderslerTableAdapter.Insert(OgrenciID,DersID2);
            this.Close();
        }
    }
}
