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

                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
    }

    
}
