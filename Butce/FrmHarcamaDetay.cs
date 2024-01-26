using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butce
{
    public partial class FrmHarcamaDetay : Form
    {
        public FrmHarcamaDetay()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var harcama = new Harcama
            {
                Tarih = tarihDateTimePicker.Value,
                Kategori = kategoriComboBox.Text,
                Tutar = decimal.Parse(tutarTextBox.Text),
                Aciklama = aciklamaTextBox.Text
            };
            DbHelper.AddHaracama(harcama);
            Close();
        }

        private void FrmHarcamaDetay_Load(object sender, EventArgs e)
        {
            var kategories = DbHelper.GetKategoriList().ToArray();
            kategoriComboBox.Items.AddRange(kategories);
        }
    }
}
