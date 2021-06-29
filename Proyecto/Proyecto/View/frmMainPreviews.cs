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
    public partial class frmMainPreviews : Form
    {
        public frmMainPreviews()
        {
            InitializeComponent();
        }
        //BUTTON USED TO VIEW THE CITIZENS WITH THEIR RESPECTIVE DOSIS
        private void button1_Click(object sender, EventArgs e)
        {
            var CheckAppointments = new frmCheckAppointments();
            CheckAppointments.Show();
            this.Hide();
        }
        //BUTTON USED TO VIEW THE WAIT LIST
        private void button2_Click(object sender, EventArgs e)
        {
            var WaitlineBtton = new frmWaitlineBtton();
            WaitlineBtton.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        //BUTTON USED TO VACCINE A CITIZEN
        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new frmVaccinationPBtton();
            frm.Show();
            
        }
        //BUTTON USED TO CREATE A NEW APPOINTMENT 
        private void button5_Click(object sender, EventArgs e)
        {
            var infoC = new frmCitizenInfo();
            infoC.Show();
            this.Hide();

        }
        //BUTTON USED TO VIEW THE LOG IN HISTORY
        private void btnHistory_Click(object sender, EventArgs e)
        {
            var history = new frmHistory();
            history.Show();
            this.Hide();
        }

        private void frmMainPreviews_Load(object sender, EventArgs e)
        {

        }
    }
}
