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
    public partial class frmVaccinationConsents : Form
    {
        public frmVaccinationConsents()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Vaccine button 
        {
            //VARIABLES USED TO MAKE THE APPOINTMENTS
            string place = Place();
            string status = "First dosis applied";
            string vaccine = Vaccine();
            DateTime date = RandomDay();
            
            string aprovement = "Approved";
            string dosis = "First dosis";

            SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");

            // Sending Data to our Vaccination History
            string query = "insert into CITA(estado,tipo_vacuna,fecha,lugar,consentimiento,dosis) VALUES (@estado,@vacuna,@fecha,@lugar,@consentimiento,@dosis)";
            
            
            sqlc.Open();
            SqlCommand referencecommand = new SqlCommand(query, sqlc);
            referencecommand.Parameters.AddWithValue("@estado", status);
            referencecommand.Parameters.AddWithValue("@vacuna", vaccine);
            referencecommand.Parameters.AddWithValue("@fecha", date);
            referencecommand.Parameters.AddWithValue("@lugar", place);
            referencecommand.Parameters.AddWithValue("@consentimiento", aprovement);
            referencecommand.Parameters.AddWithValue("@dosis", dosis);
            referencecommand.ExecuteNonQuery();


            // Sending Data to our Vaccination History Second Dose

            string place2 = PlaceSeconDose();
            string status2 = "Second dosis appointment agended";
            string vaccine2 = VaccineSecondDose();
            DateTime date2 = RandomDaySecondDose();
            string aprovement2 = "Approved";
            string dosis2 = "Second dosis";

            string query2 = "insert into CITA(estado,tipo_vacuna, fecha, lugar, consentimiento, dosis) VALUES (@estado,@vacuna,@fecha,@lugar,@consentimiento,@dosis)";

            SqlCommand referencecommand2 = new SqlCommand(query2, sqlc);

            referencecommand2.Parameters.AddWithValue("@estado", status2);
            referencecommand2.Parameters.AddWithValue("@vacuna", vaccine2);
            referencecommand2.Parameters.AddWithValue("@fecha", date2);
            referencecommand2.Parameters.AddWithValue("@lugar", place2);
            referencecommand2.Parameters.AddWithValue("@consentimiento", aprovement2);
            referencecommand2.Parameters.AddWithValue("@dosis", dosis2);
            referencecommand2.ExecuteNonQuery();
            sqlc.Close();



            if (checkBox1.Checked == true)
            {
                var form1 = new Form1();
                form1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please check the box to continue");
                {


                }
            }
        }
        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CLASS THAT GIVES THE TYPE OF VACCINE THAT THE CITIZEN WILL GET
        private string Vaccine()
        {

            var random = new Random();
            var list = new List<string> { "SINOVAC", "SPUTNIK", "PFIZER", "MODERNA", "ASTRAZENECA", "JOHNSON&JOHNSON" };
            int index = random.Next(list.Count);
            var date = list[index];



            return date;
        }

        //CLASS THAT WILL GENERATE THE DATE OF THE CITIZEN'S APPOINTMENT

        private DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2021, 6, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        //CLASS THAT WILL GENERATE THE CABIN WHERE THE CITIZEN WILL BE VACCINATED

        private string Place()
        {
            var random = new Random();
            var list = new List<string> { "Cabin1", "Cabin2", "Cabin3", "Cabin4", "Cabin5" };
            int index = random.Next(list.Count);
            var date = list[index];



            return date;
        }
        //SECOND DOSE VACCINE
        private string VaccineSecondDose()
        {

            var random = new Random();
            var list = new List<string> { "SINOVAC", "SPUTNIK", "PFIZER", "MODERNA", "ASTRAZENECA", "JOHNSON&JOHNSON" };
            int index = random.Next(list.Count);
            var date = list[index];



            return date;
        }

        //SECOND APPOINTMENT DATE
        private DateTime RandomDaySecondDose()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2021, 7, 12);
            DateTime end = new DateTime(2021, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(gen.Next(range));
        }

        //PLACE WHERE THE SECOND DOSE WILL BE PLACED

        private static string PlaceSeconDose()
        {
            var random = new Random();
            var list = new List<string> { "Cabin6", "Cabin7", "Cabin8", "Cabin9", "Cabin10" };
            int index = random.Next(list.Count);
            var date = list[index];

            return date;

        }

        private void frmVaccinationConsents_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }           






                

        
    
