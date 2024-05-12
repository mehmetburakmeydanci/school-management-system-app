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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciDataSet1.ogrencitablo' table. You can move, or remove it, as needed.
            this.ogrencitabloTableAdapter.Fill(this.ogrenciDataSet1.ogrencitablo);
            // TODO: This line of code loads data into the 'ogrenciDataSet1.secilendersler' table. You can move, or remove it, as needed.
            this.secilenderslerTableAdapter.Fill(this.ogrenciDataSet1.secilendersler);

        }
    }
}
