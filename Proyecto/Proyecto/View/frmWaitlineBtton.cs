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
    public partial class frmWaitlineBtton : Form
    {
        //SQL CONECTION
        SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");
        public frmWaitlineBtton()
        {
            InitializeComponent();
        }
        //USED TO LOAD THE RESPECTIVE TABLE (CITIZEN) WHEN THE FORM LOAD
        private void frmWaitlineBtton_Load(object sender, EventArgs e)
        {
            
            sqlc.Open();
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM CIUDADANO ", sqlc);
            DataTable data = new DataTable();
            db.Fill(data);

            dataGridView1.DataSource = data;

            
        }

        //GO BACK
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var maimenu = new frmMainPreviews();
            maimenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
