using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butce
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
            VeriAl();
        }

        private void VeriAl()
        {
            var harcamaList = DbHelper.GetHarcamaList();
            bsHarcama.DataSource = harcamaList;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var frm = new FrmHarcamaDetay();
            frm.ShowDialog();
            VeriAl(); 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Satırı Silmeye eminmisin?","Satır Silme", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["HarcamaId"].Value);
                    string query = "DELETE FROM Harcama WHERE HarcamaId=@HarcamaId"; 
                    using (SqlConnection conn = new SqlConnection("connectionString")) // Veritabanı bağlantısı oluştur
                    using (SqlCommand cmd = new SqlCommand(query, conn)) // SQL sorgusu için komut oluştur
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@HarcamadId", id); 
                        cmd.ExecuteNonQuery(); 
                    }
                    dataGridView1.Rows.Remove(row);
                }


            }
            else
            {
                //No ise yapmasını istediğiniz...
            }
        }

        private void bsHarcama_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
