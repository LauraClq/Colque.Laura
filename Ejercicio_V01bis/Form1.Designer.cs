
namespace Ejercicio_V01bis
{
    partial class FrmSaludo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(37, 63);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(320, 32);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "¡¡¡Hola mundo WinForm!!!";
            this.lblSaludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(126, 161);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(111, 45);
            this.btnSaludo.TabIndex = 1;
            this.btnSaludo.Text = "Haga click aqui";
            this.btnSaludo.UseVisualStyleBackColor = false;
            this.btnSaludo.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSaludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 253);
            this.Controls.Add(this.btnSaludo);
            this.Controls.Add(this.lblSaludo);
            this.Name = "FrmSaludo";
            this.Text = "Saludo desde un Form";
            this.Load += new System.EventHandler(this.FrmSaludo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnSaludo;
    }
}

