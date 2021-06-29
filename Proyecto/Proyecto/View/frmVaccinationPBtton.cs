using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proyecto.Context;
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
    public partial class frmVaccinationPBtton : Form
    {
        


        public frmVaccinationPBtton()
        {
            InitializeComponent();
        }
        //USED TO LOAD THE CITIZEN TABLE, TO APPLY THEIR RESPECTIVE DOSIS
        private void frmVaccinationPBtton_Load(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM CIUDADANO", sqlc);
            DataTable dt = new DataTable();
            db.Fill(dt);
            sqlc.Close();
            dgvAppointment.DataSource = dt;
        }

        //Process that is carried out by double clicking on the name of the citizen, where the consent is accepted
        private void dgvAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //VACCINATION CONSENT FORM 
            var VaccinationConset = new frmVaccinationConsents();
            VaccinationConset.Show();
            this.Hide();

            SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");

            //Process used to update the first dosis to second dosis
            sqlc.Open();
            var nombre = (dgvAppointment.Rows[e.RowIndex].Cells["nombre"].Value.ToString());
            SqlCommand com = new SqlCommand("Delete CIUDADANO where nombre = '" + nombre + "'", sqlc);
            com.ExecuteNonQuery();
           
            sqlc.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
