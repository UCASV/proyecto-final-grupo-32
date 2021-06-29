
namespace Proyecto.View
{
    partial class frmCheckAppointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckAppointments));
            this.dgvdosis = new System.Windows.Forms.DataGridView();
            this.PDFbttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdosis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdosis
            // 
            this.dgvdosis.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdosis.Location = new System.Drawing.Point(12, 95);
            this.dgvdosis.Name = "dgvdosis";
            this.dgvdosis.RowHeadersWidth = 51;
            this.dgvdosis.RowTemplate.Height = 25;
            this.dgvdosis.Size = new System.Drawing.Size(776, 194);
            this.dgvdosis.TabIndex = 2;
            this.dgvdosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheck_CellContentClick);
            // 
            // PDFbttn
            // 
            this.PDFbttn.Location = new System.Drawing.Point(314, 295);
            this.PDFbttn.Name = "PDFbttn";
            this.PDFbttn.Size = new System.Drawing.Size(167, 38);
            this.PDFbttn.TabIndex = 3;
            this.PDFbttn.Text = "Create PDF";
            this.PDFbttn.UseVisualStyleBackColor = true;
            this.PDFbttn.Click += new System.EventHandler(this.PDFbttn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCheckAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PDFbttn);
            this.Controls.Add(this.dgvdosis);
            this.DoubleBuffered = true;
            this.Name = "frmCheckAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckAppointments";
            this.Load += new System.EventHandler(this.frmCheckAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdosis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdosis;
        private System.Windows.Forms.Button PDFbttn;
        private System.Windows.Forms.Button button2;
    }
}