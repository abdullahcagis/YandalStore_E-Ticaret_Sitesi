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
    public partial class KategoriForm : Form
    {
        YandalStoreForm_DBEntities db = new YandalStoreForm_DBEntities();
        int secilen;
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void GridDoldur()
        {
            dataGridView1.DataSource = (from c in db.Category
                                        select new
                                        {
                                            KategoriID = c.ID,
                                            KategoriAdi = c.Name,
                                            Açıklama = c.Description,
                                            Durum = c.Status == true ? "Aktif" : "Aktif Değildir"
                                        }).ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            {
                c.Name = tb_isim.Text;
                c.Description = tb_aciklama.Text;
                c.Status = cb_durum.Checked;
            };
            try 
            {
                db.Category.Add(c);
                db.SaveChanges();
                MessageBox.Show("Kategori " + c.ID + " id ile başarıyla eklenmiştir.", "Eklendi");
            }
            catch
            {
               MessageBox.Show("Ürün eklerken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    ContextMenuStrip.Show(dataGridView1, new Point(e.X, e.Y));
                    secilen = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            Category c = db.Category.Find(secilen);
            tb_ID.Text = c.ID.ToString();
            tb_isim.Text = c.Name;
            tb_aciklama.Text = c.Description;
            cb_durum.Checked = false;
            btn_ekle.Enabled = false;
            btn_guncelle.Enabled = true;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Category c = db.Category.Find(secilen);
            c.Name = tb_isim.Text;
            c.Description = tb_aciklama.Text;
            c.Status = cb_durum.Checked;
            try
            {
                db.SaveChanges();
                btn_ekle.Enabled = true;
                btn_guncelle.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ürün güncellenirken bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            tb_ID.Text = "";
            tb_isim.Text = "";
            tb_aciklama.Text = "";
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            try
            {
                Category c = db.Category.Find(secilen);
                db.Category.Remove(c);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Silinirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
        }
    }
}
