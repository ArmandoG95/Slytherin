namespace Slytherin
{
    partial class FrmSlytherin
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
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.lblTextoFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFondo
            // 
            this.pbFondo.BackColor = System.Drawing.Color.Gray;
            this.pbFondo.Location = new System.Drawing.Point(13, 13);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(541, 560);
            this.pbFondo.TabIndex = 0;
            this.pbFondo.TabStop = false;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(600, 137);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(108, 29);
            this.lblPuntaje.TabIndex = 1;
            this.lblPuntaje.Text = "Puntaje:";
            this.lblPuntaje.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.Location = new System.Drawing.Point(714, 137);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(41, 29);
            this.lblMarcador.TabIndex = 2;
            this.lblMarcador.Text = "00";
            // 
            // lblTextoFinal
            // 
            this.lblTextoFinal.AutoSize = true;
            this.lblTextoFinal.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTextoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTextoFinal.Location = new System.Drawing.Point(208, 168);
            this.lblTextoFinal.Name = "lblTextoFinal";
            this.lblTextoFinal.Size = new System.Drawing.Size(135, 29);
            this.lblTextoFinal.TabIndex = 3;
            this.lblTextoFinal.Text = "Texto final";
            // 
            // FrmSlytherin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 623);
            this.Controls.Add(this.lblTextoFinal);
            this.Controls.Add(this.lblMarcador);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.pbFondo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSlytherin";
            this.Text = "Slytherin";
            this.Load += new System.EventHandler(this.FrmSlytherin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Label lblTextoFinal;
    }
}

