using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDataTable
{
    public partial class Form1 : Form
    {
        PersonelHelper personelHelper = new PersonelHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personelHelper.GetListAll();
        }

        private void filtrele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personelHelper.GetListByName(araTxt.Text);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            bool result = personelHelper.AddPersonel(Convert.ToInt32(idEkleTxt.Text), isimEkleTxt.Text, soyisimEkleTxt.Text, unvanEkleTxt.Text);
            if (result)
            {
                dataGridView1.DataSource = personelHelper.GetListAll();
            }
            else
            {
                MessageBox.Show("İşlem başarısız.");
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            var selectedID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            bool result = personelHelper.UpdatePersonel(selectedID, isimGunTxt.Text, soyisimTxt.Text);
            if (result)
            {
                dataGridView1.DataSource = personelHelper.GetListAll();
            }
            else
            {
                MessageBox.Show("İşlem başarısız.");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            //var selId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            int selectedID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            bool result = personelHelper.DeletePersonel(selectedID);
            if (result)
            {
                dataGridView1.DataSource = personelHelper.GetListAll();
            }
            else
            {
                MessageBox.Show("İşlem başarısız.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //var selectedID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            //isimGunTxt.Text = selectedID;
            //var selectedID2 = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            //soyisimTxt.Text = selectedID2;

            if (dataGridView1.SelectedRows.Count == 1)
            {
                isimGunTxt.Text = dataGridView1.SelectedRows[0].Cells["Isim"].Value.ToString();
                soyisimTxt.Text = dataGridView1.SelectedRows[0].Cells["Soyisim"].Value.ToString();
            }
        }
    }
}
