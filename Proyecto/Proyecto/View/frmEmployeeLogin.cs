using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Context;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Proyecto.View
{
    public partial class frmEmployeeLogin : Form
    {
        public frmEmployeeLogin()
        {
            InitializeComponent();
        }

        //LOG IN BUTTON DECLARATION
        private void button2_Click(object sender, EventArgs e)
        {
            //SQL CONECTION VARIABLE 
            SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");
            sqlc.Open();
            //Comparison of data from the text boxes with data registered in the database
            SqlCommand comando = new SqlCommand("SELECT usuario, contrasena FROM GESTOR WHERE usuario = @user AND contrasena = @contra",sqlc);
            comando.Parameters.AddWithValue("@user", txtUsername.Text);
            comando.Parameters.AddWithValue("@contra", txtPassword.Text);

            SqlDataReader lector = comando.ExecuteReader();

            //used so that the program does not close until one of the parameters is met
            try
            {
                //Conditions with an if, which allow entry if the data matches and throw their respective message if they do not match
                if (lector.Read())
                {

                    
                    frmMainPreviews mainwindow = new frmMainPreviews();
                    mainwindow.Show();
                    this.Hide();
                    sqlc.Close();
                   

                }
                else if (lector.Read() == false)
                {

                    MessageBox.Show("Incorrect user or password", "Vaccination");
                    

                }

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            //process that saves the data of the users who enter the platform for the history
            var Date = DateTime.Now;
            string description = "Initial login from the employees ";

            SqlConnection sqlc1 = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");

            string query = "insert into HISTORIAL_LOGIN(fecha_hora,usuario,descripcion) VALUES (@fecha_hora,@usuario,@descripcion)";

            SqlCommand command = new SqlCommand(query, sqlc1);
            sqlc1.Open();
            command.Parameters.AddWithValue("@fecha_hora", Date);
            command.Parameters.AddWithValue("@usuario", txtUsername.Text);
            command.Parameters.AddWithValue("@descripcion", description);
            command.ExecuteNonQuery();
            
            sqlc1.Close();

        }

        private void frmEmployeeLogin_Load(object sender, EventArgs e)
        {

        }
    }
}