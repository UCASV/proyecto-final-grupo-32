using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.View
{
    public partial class frmHistory : Form
    {
        //sql conection
        SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");

        public frmHistory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //class used to view login history
        private void frmHistory_Load(object sender, EventArgs e)
        {
            sqlc.Open();
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM HISTORIAL_LOGIN", sqlc);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dgvHistory.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new frmMainPreviews();
            menu.Show();
        }
    }
}
