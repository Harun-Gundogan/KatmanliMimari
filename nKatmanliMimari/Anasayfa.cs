using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace nKatmanliMimari
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            List<EntitiyPersonel> PerList = LogicPersonel.PersonelList();
            dataGridView1.DataSource = PerList;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Name.Text == "" || txt_Surname.Text == "" || txt_City.Text == "" || txt_Mission.Text == "" || txt_Wage.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    EntitiyPersonel ent = new EntitiyPersonel();
                    ent.Name = txt_Name.Text;
                    ent.Surname = txt_Surname.Text;
                    ent.City = txt_City.Text;
                    ent.Mision = txt_Mission.Text;
                    ent.Wage = short.Parse(txt_Wage.Text);

                    LogicPersonel.LPersonelEkle(ent);

                    MessageBox.Show("Personel Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<EntitiyPersonel> PerList = LogicPersonel.PersonelList();
                    dataGridView1.DataSource = PerList;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Name.Text = "";
                txt_Surname.Text = "";
                txt_City.Text = "";
                txt_Mission.Text = "";
                txt_Wage.Text = "";
            }

            
            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Id.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    EntitiyPersonel ent = new EntitiyPersonel();
                    ent.Id = Convert.ToInt32(txt_Id.Text);
                    LogicPersonel.LPersonelSil(ent.Id);

                    MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<EntitiyPersonel> PerList = LogicPersonel.PersonelList();
                    dataGridView1.DataSource = PerList;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Name.Text = "";
                txt_Surname.Text = "";
                txt_City.Text = "";
                txt_Mission.Text = "";
                txt_Wage.Text = "";
            }
        
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Surname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_City.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Mission.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Wage.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Name.Text == "" || txt_Surname.Text == "" || txt_City.Text == "" || txt_Mission.Text == "" || txt_Wage.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    EntitiyPersonel ent = new EntitiyPersonel();
                    ent.Id = Convert.ToInt32(txt_Id.Text);
                    ent.Name = txt_Name.Text;
                    ent.Surname = txt_Surname.Text;
                    ent.City = txt_City.Text;
                    ent.Mision = txt_Mission.Text;
                    ent.Wage = short.Parse(txt_Wage.Text);
                    LogicPersonel.LPersonelGuncelle(ent);

                    MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<EntitiyPersonel> PerList = LogicPersonel.PersonelList();
                    dataGridView1.DataSource = PerList;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Name.Text = "";
                txt_Surname.Text = "";
                txt_City.Text = "";
                txt_Mission.Text = "";
                txt_Wage.Text = "";
            }
        
        }
    }
}
