using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetrolOtomasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.salesTableAdapter.Fill(this.petrolOtomasyonDBDataSet.Sales);

            
            dgvIslemler.Columns.Add("Plaka", "Plaka");
            dgvIslemler.Columns.Add("Miktar", "Miktar");
            dgvIslemler.Columns.Add("Tutar", "Tutar");
            dgvIslemler.Columns.Add("OdemeTuru", "Ödeme Türü");

            
            cmbPompaTipi.Items.Add("Benzin");
            cmbPompaTipi.Items.Add("Dizel");
            cmbPompaTipi.Items.Add("LPG");

            cmbOdemeTuru.Items.Add("Nakit");
            cmbOdemeTuru.Items.Add("Kredi Kartı");

            
            LoadSubeler();
        }

        #region Şube Yönetimi

        
        private void LoadSubeler()
        {
            lstSubeler.Items.Clear(); 

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();  
                    string query = "SELECT SubeAdi, Il FROM Subeler";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string subeBilgisi = $"{reader["SubeAdi"]} - {reader["Il"]}";
                        lstSubeler.Items.Add(subeBilgisi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSubeAdi.Text) && !string.IsNullOrWhiteSpace(txtIl.Text))
            {
                string subeAdi = txtSubeAdi.Text;
                string il = txtIl.Text;

                
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Subeler (SubeAdi, Il) VALUES (@SubeAdi, @Il)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SubeAdi", subeAdi);
                        cmd.Parameters.AddWithValue("@Il", il);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Şube başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                LoadSubeler();

                txtSubeAdi.Clear();
                txtIl.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen şube adı ve il bilgilerini doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Pompa Yönetimi

        
        private void btnPompaEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPompaAdi.Text) && cmbPompaTipi.SelectedItem != null)
            {
                string pompaAdi = txtPompaAdi.Text;
                string pompaTipi = cmbPompaTipi.SelectedItem.ToString();

                
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Pompalar (PompaAdi, PompaTipi) VALUES (@PompaAdi, @PompaTipi)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@PompaAdi", pompaAdi);
                        cmd.Parameters.AddWithValue("@PompaTipi", pompaTipi);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Pompa başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPompaAdi.Clear();
                cmbPompaTipi.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen pompa adı ve yakıt türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Ödeme İşlemleri

        
        private void btnIslemKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPlaka.Text) && !string.IsNullOrWhiteSpace(txtMiktar.Text) && !string.IsNullOrWhiteSpace(txtTutar.Text) && cmbOdemeTuru.SelectedItem != null)
            {
                string plaka = txtPlaka.Text;
                decimal miktar = Convert.ToDecimal(txtMiktar.Text);
                decimal tutar = Convert.ToDecimal(txtTutar.Text);
                string odemeTuru = cmbOdemeTuru.SelectedItem.ToString();

                
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Islemler (Plaka, Miktar, Tutar, OdemeTuru) VALUES (@Plaka, @Miktar, @Tutar, @OdemeTuru)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Plaka", plaka);
                        cmd.Parameters.AddWithValue("@Miktar", miktar);
                        cmd.Parameters.AddWithValue("@Tutar", tutar);
                        cmd.Parameters.AddWithValue("@OdemeTuru", odemeTuru);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("İşlem başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                dgvIslemler.Rows.Add(plaka, miktar, tutar, odemeTuru);

                txtPlaka.Clear();
                txtMiktar.Clear();
                txtTutar.Clear();
                cmbOdemeTuru.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnIslemTemizle_Click(object sender, EventArgs e)
        {
            txtPlaka.Clear();
            txtMiktar.Clear();
            txtTutar.Clear();
            cmbOdemeTuru.SelectedIndex = -1;
        }

        #endregion

        #region Gün Sonu Raporu

       
        private void btnGunSonu_Click(object sender, EventArgs e)
        {
            decimal toplamSatis = 0;

            foreach (DataGridViewRow row in dgvIslemler.Rows)
            {
                if (row.Cells["Tutar"].Value != null)
                {
                    toplamSatis += Convert.ToDecimal(row.Cells["Tutar"].Value);
                }
            }

            lblToplamSatis.Text = toplamSatis.ToString("C");

            MessageBox.Show("Gün sonu raporu alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
