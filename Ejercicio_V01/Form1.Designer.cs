
namespace Ejercicio_V01
{
    partial class Form1
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lbMateria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(25, 32);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLastName.Location = new System.Drawing.Point(228, 32);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(45, 17);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "label2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(228, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(312, 119);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(105, 23);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "button1";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(25, 120);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 23);
            this.cmbMateria.TabIndex = 5;
            // 
            // lbMateria
            // 
            this.lbMateria.AutoSize = true;
            this.lbMateria.Location = new System.Drawing.Point(25, 96);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(38, 15);
            this.lbMateria.TabIndex = 6;
            this.lbMateria.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 154);
            this.Controls.Add(this.lbMateria);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lbMateria;
    }
}

