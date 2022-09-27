
namespace Ejercicio_V02
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
            this.grpBoxUsuario = new System.Windows.Forms.GroupBox();
            this.lstPaises = new System.Windows.Forms.ListBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.gpBoxCursos = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoNoBianrio = new System.Windows.Forms.RadioButton();
            this.chkCshirp = new System.Windows.Forms.CheckBox();
            this.chckCplusplus = new System.Windows.Forms.CheckBox();
            this.chckJava = new System.Windows.Forms.CheckBox();
            this.lblPaises = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpBoxUsuario.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.gpBoxCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxUsuario
            // 
            this.grpBoxUsuario.Controls.Add(this.nudEdad);
            this.grpBoxUsuario.Controls.Add(this.txtStreet);
            this.grpBoxUsuario.Controls.Add(this.txtName);
            this.grpBoxUsuario.Controls.Add(this.lblEdad);
            this.grpBoxUsuario.Controls.Add(this.lblDireccion);
            this.grpBoxUsuario.Controls.Add(this.lblName);
            this.grpBoxUsuario.Location = new System.Drawing.Point(12, 12);
            this.grpBoxUsuario.Name = "grpBoxUsuario";
            this.grpBoxUsuario.Size = new System.Drawing.Size(237, 127);
            this.grpBoxUsuario.TabIndex = 0;
            this.grpBoxUsuario.TabStop = false;
            this.grpBoxUsuario.Text = "Detalles del usuario";
            // 
            // lstPaises
            // 
            this.lstPaises.FormattingEnabled = true;
            this.lstPaises.ItemHeight = 15;
            this.lstPaises.Location = new System.Drawing.Point(24, 177);
            this.lstPaises.Name = "lstPaises";
            this.lstPaises.Size = new System.Drawing.Size(225, 94);
            this.lstPaises.TabIndex = 1;
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdoNoBianrio);
            this.grpGenero.Controls.Add(this.rdoMasculino);
            this.grpGenero.Controls.Add(this.rdoFemenino);
            this.grpGenero.Location = new System.Drawing.Point(300, 12);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(133, 109);
            this.grpGenero.TabIndex = 2;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // gpBoxCursos
            // 
            this.gpBoxCursos.Controls.Add(this.chckJava);
            this.gpBoxCursos.Controls.Add(this.chckCplusplus);
            this.gpBoxCursos.Controls.Add(this.chkCshirp);
            this.gpBoxCursos.Location = new System.Drawing.Point(300, 127);
            this.gpBoxCursos.Name = "gpBoxCursos";
            this.gpBoxCursos.Size = new System.Drawing.Size(133, 107);
            this.gpBoxCursos.TabIndex = 3;
            this.gpBoxCursos.TabStop = false;
            this.gpBoxCursos.Text = "Cursos";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 57);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 88);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(91, 51);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 23);
            this.txtStreet.TabIndex = 7;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(91, 86);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 4;
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(13, 24);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdoFemenino.TabIndex = 0;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(13, 50);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdoMasculino.TabIndex = 1;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoNoBianrio
            // 
            this.rdoNoBianrio.AutoSize = true;
            this.rdoNoBianrio.Location = new System.Drawing.Point(13, 75);
            this.rdoNoBianrio.Name = "rdoNoBianrio";
            this.rdoNoBianrio.Size = new System.Drawing.Size(81, 19);
            this.rdoNoBianrio.TabIndex = 2;
            this.rdoNoBianrio.TabStop = true;
            this.rdoNoBianrio.Text = "No Binario";
            this.rdoNoBianrio.UseVisualStyleBackColor = true;
            // 
            // chkCshirp
            // 
            this.chkCshirp.AutoSize = true;
            this.chkCshirp.Location = new System.Drawing.Point(13, 26);
            this.chkCshirp.Name = "chkCshirp";
            this.chkCshirp.Size = new System.Drawing.Size(41, 19);
            this.chkCshirp.TabIndex = 0;
            this.chkCshirp.Text = "C#";
            this.chkCshirp.UseVisualStyleBackColor = true;
            // 
            // chckCplusplus
            // 
            this.chckCplusplus.AutoSize = true;
            this.chckCplusplus.Location = new System.Drawing.Point(13, 50);
            this.chckCplusplus.Name = "chckCplusplus";
            this.chckCplusplus.Size = new System.Drawing.Size(50, 19);
            this.chckCplusplus.TabIndex = 1;
            this.chckCplusplus.Text = "C++";
            this.chckCplusplus.UseVisualStyleBackColor = true;
            // 
            // chckJava
            // 
            this.chckJava.AutoSize = true;
            this.chckJava.Location = new System.Drawing.Point(13, 75);
            this.chckJava.Name = "chckJava";
            this.chckJava.Size = new System.Drawing.Size(74, 19);
            this.chckJava.TabIndex = 2;
            this.chckJava.Text = "JavaScrip";
            this.chckJava.UseVisualStyleBackColor = true;
            // 
            // lblPaises
            // 
            this.lblPaises.AutoSize = true;
            this.lblPaises.Location = new System.Drawing.Point(24, 154);
            this.lblPaises.Name = "lblPaises";
            this.lblPaises.Size = new System.Drawing.Size(28, 15);
            this.lblPaises.TabIndex = 4;
            this.lblPaises.Text = "Pais";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(304, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 29);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 289);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPaises);
            this.Controls.Add(this.gpBoxCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.lstPaises);
            this.Controls.Add(this.grpBoxUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxUsuario.ResumeLayout(false);
            this.grpBoxUsuario.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.gpBoxCursos.ResumeLayout(false);
            this.gpBoxCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxUsuario;
        private System.Windows.Forms.ListBox lstPaises;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.GroupBox gpBoxCursos;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rdoNoBianrio;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.CheckBox chckJava;
        private System.Windows.Forms.CheckBox chckCplusplus;
        private System.Windows.Forms.CheckBox chkCshirp;
        private System.Windows.Forms.Label lblPaises;
        private System.Windows.Forms.Button btnAceptar;
    }
}

