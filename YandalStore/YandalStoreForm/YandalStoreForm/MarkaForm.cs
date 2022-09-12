using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YandalStoreForm
{
    public partial class MarkaForm : Form
    {
        YandalStoreForm_DBEntities db = new YandalStoreForm_DBEntities();
        int secilen;
        public MarkaForm()
        {
            InitializeComponent();
        }
        private void GridDoldur()
        {
            dataGridView1.DataSource = (from b in db.Brand
                                        select new
                                        {
                                            MarkaID = b.ID.ToString(),
                                            MarkaIsim = b.Name,
                                            Durum = b.Status == true ? "Aktif" : "Aktif Değil"
                                        }).ToList();
        }

        private void MarkaForm_Load(object sender, EventArgs e)
        {
             GridDoldur();
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            Brand b = new Brand()
            {
                Name = tb_isim.Text,
                Status = CB_durum.Checked

            };
            try
            {
                db.Brand.Add(b);
                db.SaveChanges();
                MessageBox.Show("Kategori " + b.ID + " id ile başarıyla eklenmiştir", "Eklendi");
            }
            catch
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                if(hit.RowIndex != 1)
                {
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                    secilen = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

        private void TSMI_guncelle_Click_1(object sender, EventArgs e)
        {
            Brand b = db.Brand.Find(secilen);
            tb_ID.Text = b.ID.ToString();
            tb_isim.Text = b.Name;
            CB_durum.Checked = false;
            btn_Ekle.Enabled = false;
            btn_Guncelle.Enabled = true;
        }

        private void btn_Guncelle_Click_1(object sender, EventArgs e)
        {
            Brand b = db.Brand.Find(secilen);
            b.Name = tb_isim.Text;
            b.Status = CB_durum.Checked;
            try
            {
                db.SaveChanges();
                btn_Ekle.Enabled = true;
                btn_Guncelle.Enabled = false;
            }
            catch
            {

                MessageBox.Show("Ürün güncellenirken bir hat oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                   

        private void TSMI_sil_Click_1(object sender, EventArgs e)
        {
            try
            {
                Brand b = db.Brand.Find(secilen);
                db.Brand.Remove(b);
                db.SaveChanges();
            }
            catch
            {

                MessageBox.Show("Hata oluştu", "Hata");
            }
            GridDoldur();
        }
    }
}
    