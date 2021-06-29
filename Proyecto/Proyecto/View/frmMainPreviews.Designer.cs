
namespace Proyecto.View
{
    partial class frmMainPreviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPreviews));
            this.checkappbttn = new System.Windows.Forms.Button();
            this.waitlinebttn = new System.Windows.Forms.Button();
            this.appRegbttn = new System.Windows.Forms.Button();
            this.VaccPbttn = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkappbttn
            // 
            this.checkappbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkappbttn.Location = new System.Drawing.Point(194, 282);
            this.checkappbttn.Name = "checkappbttn";
            this.checkappbttn.Size = new System.Drawing.Size(172, 42);
            this.checkappbttn.TabIndex = 0;
            this.checkappbttn.Text = "Vaccination History";
            this.checkappbttn.UseVisualStyleBackColor = true;
            this.checkappbttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // waitlinebttn
            // 
            this.waitlinebttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waitlinebttn.Location = new System.Drawing.Point(314, 175);
            this.waitlinebttn.Name = "waitlinebttn";
            this.waitlinebttn.Size = new System.Drawing.Size(177, 42);
            this.waitlinebttn.TabIndex = 1;
            this.waitlinebttn.Text = "Wait Line";
            this.waitlinebttn.UseVisualStyleBackColor = true;
            this.waitlinebttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // appRegbttn
            // 
            this.appRegbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appRegbttn.Location = new System.Drawing.Point(71, 174);
            this.appRegbttn.Name = "appRegbttn";
            this.appRegbttn.Size = new System.Drawing.Size(172, 42);
            this.appRegbttn.TabIndex = 4;
            this.appRegbttn.Text = "Appointment Registration";
            this.appRegbttn.UseVisualStyleBackColor = true;
            this.appRegbttn.Click += new System.EventHandler(this.button5_Click);
            // 
            // VaccPbttn
            // 
            this.VaccPbttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VaccPbttn.Location = new System.Drawing.Point(539, 175);
            this.VaccPbttn.Name = "VaccPbttn";
            this.VaccPbttn.Size = new System.Drawing.Size(177, 42);
            this.VaccPbttn.TabIndex = 3;
            this.VaccPbttn.Tag = "weqweqweqwe";
            this.VaccPbttn.Text = "Vaccination Process";
            this.VaccPbttn.UseVisualStyleBackColor = true;
            this.VaccPbttn.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(437, 283);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(179, 41);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "Employee History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // frmMainPreviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.appRegbttn);
            this.Controls.Add(this.VaccPbttn);
            this.Controls.Add(this.waitlinebttn);
            this.Controls.Add(this.checkappbttn);
            this.DoubleBuffered = true;
            this.Name = "frmMainPreviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " -  ";
            this.Load += new System.EventHandler(this.frmMainPreviews_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkappbttn;
        private System.Windows.Forms.Button waitlinebttn;
        private System.Windows.Forms.Button appRegbttn;
        private System.Windows.Forms.Button VaccPbttn;
        private System.Windows.Forms.Button btnHistory;
    }
}