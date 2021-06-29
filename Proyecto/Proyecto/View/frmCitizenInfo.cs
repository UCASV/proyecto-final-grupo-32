using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;


namespace Proyecto.View
{
    public partial class frmCitizenInfo : Form
    {
        
        
        public frmCitizenInfo()
        {
            InitializeComponent();

            radioButton1.Checked = true;
        }

        
        //BUTTON WHERE CITIZENS REGISTER TO ENTER THE WAITING LIST
       private void button1_Click(object sender, EventArgs e)
        {
            //SQL CONNECTION
            SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");

            
            //Data input that is written in the text boxes so that they are saved in their respective column of the database
            string query = "insert into CIUDADANO(dui,nombre,direccion,correo,edad,telefono,institucion,enfermedad) VALUES (@dui,@name,@address,@email,@age,@telefono,@institucion,@enfermedad)";
            string enfermedad = "No chronic diseases";
           
                sqlc.Open();
            SqlCommand referencecommand = new SqlCommand(query, sqlc);

            referencecommand.Parameters.AddWithValue("@dui", txtdui.Text);
            referencecommand.Parameters.AddWithValue("@name", txtname.Text);
            referencecommand.Parameters.AddWithValue("@address", txtAddress.Text);
            referencecommand.Parameters.AddWithValue("@email", txtEmail.Text);
            referencecommand.Parameters.AddWithValue("@age", txtAge.Text);
            referencecommand.Parameters.AddWithValue("@telefono", txtPhone.Text);
            referencecommand.Parameters.AddWithValue("@institucion", cmbInstitutiton.SelectedItem);

            //Combo box condition, to save in the database the respective disease
            if (radioButton1.Checked == Enabled)

            {
                referencecommand.Parameters.AddWithValue("@enfermedad", cmbCondition.SelectedItem);
            }

            else
            {
                referencecommand.Parameters.AddWithValue("@enfermedad", enfermedad);
            } 
            
                
            referencecommand.ExecuteNonQuery();
            sqlc.Close();

            MessageBox.Show("Usuario Registrado");

            var MainPreviews = new frmMainPreviews();

            MainPreviews.Show();
            Hide();

        }
        //GO BACK BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var mainmenu = new frmMainPreviews();
            mainmenu.Show();
        }   

        
        // Class      

        //BUTTON USED TO ACTIVATE THE COMBO BOX OF DISEASES
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                cmbCondition.Enabled = false;
            }
            else
            {
                cmbCondition.Enabled = true;
            }
        }

        private void frmCitizenInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtdui_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
