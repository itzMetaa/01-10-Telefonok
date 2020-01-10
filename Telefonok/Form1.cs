using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Telefonok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewAdatok.ColumnCount = 4;
            dataGridViewAdatok.Columns[0].Name = "id";
            dataGridViewAdatok.Columns[1].Name = "marka";
            dataGridViewAdatok.Columns[1].HeaderText = "Márka";
            dataGridViewAdatok.Columns[2].Name = "tipus";
            dataGridViewAdatok.Columns[2].HeaderText = "Típus";
            dataGridViewAdatok.Columns[3].Name = "ar";
            dataGridViewAdatok.Columns[3].HeaderText = "Ár";
            adatokUpdate();
        }

        private void adatokUpdate()
        {
            dataGridViewAdatok.Rows.Clear();
            Program.sql.CommandText = "SELECT id, marka, tipus, ar FROM telefon";
            try
            {
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int sorIndex = dataGridViewAdatok.Rows.Add();
                        dataGridViewAdatok.Rows[sorIndex].Cells["id"].Value = dr.GetInt32("id");
                        dataGridViewAdatok.Rows[sorIndex].Cells["marka"].Value = dr.GetString("marka");
                        dataGridViewAdatok.Rows[sorIndex].Cells["tipus"].Value = dr.GetString("tipus");
                        dataGridViewAdatok.Rows[sorIndex].Cells["ar"].Value = dr.GetInt32("ar");
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        private void buttonFelvetel_Click(object sender, EventArgs e)
        {



            Program.sql.CommandText = "INSERT INTO telefon (marka, tipus, ar) values (@marka,@tipus,@ar)";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            Program.sql.Parameters.AddWithValue("@tipus", textBoxTipus.Text);
            Program.sql.Parameters.AddWithValue("@ar", numericUpDownAr.Value);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException e2)
            {
                MessageBox.Show(e2.Message);
                return;
            }
            dataGridViewAdatok.Update();

        }

        private void dataGridViewAdatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kivalasztottSorIndex = dataGridViewAdatok.SelectedRows[0].Index;
            textBoxMarka.Text = dataGridViewAdatok.Rows[kivalasztottSorIndex].Cells["marka"].Value.ToString();
            textBoxTipus.Text = dataGridViewAdatok.Rows[kivalasztottSorIndex].Cells["tipus"].Value.ToString();
            numericUpDownAr.Value = (int)dataGridViewAdatok.Rows[kivalasztottSorIndex].Cells["ar"].Value;

        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {
            Program.sql.CommandText = "UPDATE telefon SET marka=@marka, tipus=@tipus, ar=@ar WHERE id=@id";
            Program.sql.Parameters.Clear();
            int sorIndex = dataGridViewAdatok.SelectedRows[0].Index;
            Program.sql.Parameters.AddWithValue("@id", (int)dataGridViewAdatok.Rows[sorIndex].Cells["id"].Value);
            Program.sql.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            Program.sql.Parameters.AddWithValue("@tipus", textBoxMarka.Text);
            Program.sql.Parameters.AddWithValue("@marka", numericUpDownAr.Value);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException e3)
            {
                MessageBox.Show(e3.Message);
                return;
            }
            dataGridViewAdatok.Update();
        }
    }

    
}
