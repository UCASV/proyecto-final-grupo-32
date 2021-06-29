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
    public partial class frmEffects : Form
    {
        public frmEffects()
        {
            InitializeComponent();
            radioButton1.Checked = false;
        }

        //RADIO BUTTON THAT PERFORMS THE ACTIVATION OF THE SIDE EFFECTS COMBO BOX

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        //BUTTON USED TO PUSH THE INFORMATION OF THE SIDE EFFECTS TO THE DATABASE
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");

            string sideEffects = "No side effects were presented";
            string query = "insert into EFECTO_SECUNDARIO(descripcion) VALUES (@descripcion)";
            sqlc.Open();
            SqlCommand referencecommand = new SqlCommand(query, sqlc);
           
            if (radioButton1.Checked == Enabled)

            {
                referencecommand.Parameters.AddWithValue("@descripcion", comboBox1.SelectedItem);
            }

            else
            {
                referencecommand.Parameters.AddWithValue("@descripcion", sideEffects);
            }

            referencecommand.ExecuteNonQuery();
            this.Close();

        }

        private void frmEffects_Load(object sender, EventArgs e)
        {

        }
    }
}
