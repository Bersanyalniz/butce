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
    public partial class FrmIlanDetay : Form
    {
        bool guncelle = false;
        public FrmIlanDetay()
        {
            InitializeComponent();
        }

        public FrmIlanDetay(Ilan ilan):this()
        {
            Goster(ilan);
            guncelle = true;
        }


        private void Goster(Ilan ilan)
        {
            txtIlanNo.Text = ilan.IlanNo.ToString();
            tarihDateTimePicker.Value = ilan.Tarih;
            
            txtM2.Text= ilan.M2.ToString();
            txtFiyat.Text = ilan.Fiyat.ToString();
            aciklamaTextBox.Text = ilan.Aciklama;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ilan = new Ilan
            {
                IlanNo = int.Parse(txtIlanNo.Text),
                Tarih = tarihDateTimePicker.Value,
                Fiyat = decimal.Parse(txtFiyat.Text),
                M2 = int.Parse(txtM2.Text),
                Aciklama = aciklamaTextBox.Text
            };
            if (guncelle) DbHelper.UpdateIlan(ilan);
            else DbHelper.AddIlan(ilan);
            Close();
        }
    }
}
