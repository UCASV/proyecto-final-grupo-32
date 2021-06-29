using Proyecto.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }
        //PROCESS THAT LOADS THE PROGRESS BAR AFTER ACCEPTING THE VACCINATION

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            progressBar1.Maximum = 65; 

            
        }
        //Message displayed when the progress bar completes

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (progressBar1.Value == progressBar1.Maximum)
            {
                var window = new frmEffects();
                timer1.Stop();
                MessageBox.Show("THE PACIENT HAS BEEN VACCINATED");
                window.Show();
                this.Hide();

            
            }
            else
                progressBar1.Value += 1;
            
         

        }

       
    }
}
