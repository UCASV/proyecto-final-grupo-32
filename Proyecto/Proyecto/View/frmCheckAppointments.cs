using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.View
{
    public partial class frmCheckAppointments : Form
    {
        //SQL CONNECTION
        SqlConnection sqlc = new SqlConnection("Server=DESKTOP-MVLOGJ6;Database=PROYECTOPOO1;Trusted_Connection=True;");
        public frmCheckAppointments()
        {
            InitializeComponent();
        }

        //PROCESS TO VIEW THE APPOINTMENTS WHEN THE FORM LOADS
        private void frmCheckAppointments_Load(object sender, EventArgs e)
        {
            sqlc.Open();
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM CITA", sqlc);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dgvdosis.DataSource = dt;
        }

        private void dgvCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //PROCESS TO PRINT THE INFORMATION OF THE APPOINTMENTS TABLE IN PDF FORMAT
        private void PDFbttn_Click(object sender, EventArgs e)
        {
            {
                if (dgvdosis.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "file.pdf";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("Error saving the data" + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dgvdosis.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dgvdosis.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgvdosis.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value?.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("PDF Created successfully", "PDF SAVER");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data available to create PDF", "PDF SAVER");
                }

        }   }
        //GO BACK BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            var maimenu = new frmMainPreviews();
            maimenu.Show();
        }
    }
}
