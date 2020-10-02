namespace TPV_Cloud
{
    partial class Perfil
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
            this.TCPerfil = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.BtnSPerfil = new System.Windows.Forms.Button();
            this.BtnGPerfil = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblTelefonoR = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.TxtTelefonoA = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblTelefonoA = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSPerfil2 = new System.Windows.Forms.Button();
            this.BtnGPerfil2 = new System.Windows.Forms.Button();
            this.TCPerfil.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCPerfil
            // 
            this.TCPerfil.Controls.Add(this.tabPage1);
            this.TCPerfil.Controls.Add(this.tabPage2);
            this.TCPerfil.Location = new System.Drawing.Point(11, 12);
            this.TCPerfil.Name = "TCPerfil";
            this.TCPerfil.SelectedIndex = 0;
            this.TCPerfil.Size = new System.Drawing.Size(389, 425);
            this.TCPerfil.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnCambiar);
            this.tabPage1.Controls.Add(this.BtnSPerfil);
            this.tabPage1.Controls.Add(this.BtnGPerfil);
            this.tabPage1.Controls.Add(this.lblContraseña);
            this.tabPage1.Controls.Add(this.lblConfirmar);
            this.tabPage1.Controls.Add(this.lblTelefonoR);
            this.tabPage1.Controls.Add(this.txtConfirmar);
            this.tabPage1.Controls.Add(this.TxtTelefonoA);
            this.tabPage1.Controls.Add(this.txtContraseña);
            this.tabPage1.Controls.Add(this.lblTelefonoA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(381, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logeo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Location = new System.Drawing.Point(9, 85);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(111, 23);
            this.BtnCambiar.TabIndex = 9;
            this.BtnCambiar.Text = "Cambiar Contraseña";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // BtnSPerfil
            // 
            this.BtnSPerfil.Location = new System.Drawing.Point(95, 371);
            this.BtnSPerfil.Name = "BtnSPerfil";
            this.BtnSPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnSPerfil.TabIndex = 8;
            this.BtnSPerfil.Text = "Salir";
            this.BtnSPerfil.UseVisualStyleBackColor = true;
            this.BtnSPerfil.Click += new System.EventHandler(this.BtnSPerfil_Click);
            // 
            // BtnGPerfil
            // 
            this.BtnGPerfil.Location = new System.Drawing.Point(0, 371);
            this.BtnGPerfil.Name = "BtnGPerfil";
            this.BtnGPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnGPerfil.TabIndex = 7;
            this.BtnGPerfil.Text = "Guardar";
            this.BtnGPerfil.UseVisualStyleBackColor = true;
            this.BtnGPerfil.Click += new System.EventHandler(this.BtnGPerfil_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(6, 127);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(112, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "*Contraseña (Max.20):";
            this.lblContraseña.Visible = false;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(6, 170);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(114, 13);
            this.lblConfirmar.TabIndex = 6;
            this.lblConfirmar.Text = "*Confirmar contraseña:";
            this.lblConfirmar.Visible = false;
            // 
            // lblTelefonoR
            // 
            this.lblTelefonoR.AutoSize = true;
            this.lblTelefonoR.Location = new System.Drawing.Point(6, 15);
            this.lblTelefonoR.Name = "lblTelefonoR";
            this.lblTelefonoR.Size = new System.Drawing.Size(164, 13);
            this.lblTelefonoR.TabIndex = 0;
            this.lblTelefonoR.Text = "Teléfono registrado: 9999999999";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(9, 186);
            this.txtConfirmar.MaxLength = 20;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(178, 20);
            this.txtConfirmar.TabIndex = 5;
            this.txtConfirmar.Visible = false;
            // 
            // TxtTelefonoA
            // 
            this.TxtTelefonoA.Location = new System.Drawing.Point(9, 59);
            this.TxtTelefonoA.MaxLength = 10;
            this.TxtTelefonoA.Name = "TxtTelefonoA";
            this.TxtTelefonoA.Size = new System.Drawing.Size(178, 20);
            this.TxtTelefonoA.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(9, 144);
            this.txtContraseña.MaxLength = 20;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(178, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Visible = false;
            this.txtContraseña.WordWrap = false;
            // 
            // lblTelefonoA
            // 
            this.lblTelefonoA.AutoSize = true;
            this.lblTelefonoA.Location = new System.Drawing.Point(6, 43);
            this.lblTelefonoA.Name = "lblTelefonoA";
            this.lblTelefonoA.Size = new System.Drawing.Size(142, 13);
            this.lblTelefonoA.TabIndex = 2;
            this.lblTelefonoA.Text = "*Teléfono actual (10 digitos):";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnSPerfil2);
            this.tabPage2.Controls.Add(this.BtnGPerfil2);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtCorreoElectronico);
            this.tabPage2.Controls.Add(this.lblCorreo);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lblEncargado);
            this.tabPage2.Controls.Add(this.txtEmpresa);
            this.tabPage2.Controls.Add(this.lblEmpresa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(381, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(9, 44);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(201, 20);
            this.txtEmpresa.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(6, 18);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(102, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "* Empresa (Max.50):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Location = new System.Drawing.Point(6, 79);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(119, 13);
            this.lblEncargado.TabIndex = 2;
            this.lblEncargado.Text = "* Encargado (Max.100):";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(9, 164);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(201, 20);
            this.txtCorreoElectronico.TabIndex = 5;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(6, 138);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(39, 13);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "*Email:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "* Empresa (Max.50):";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 292);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "* Empresa (Max.50):";
            // 
            // BtnSPerfil2
            // 
            this.BtnSPerfil2.Location = new System.Drawing.Point(99, 373);
            this.BtnSPerfil2.Name = "BtnSPerfil2";
            this.BtnSPerfil2.Size = new System.Drawing.Size(75, 23);
            this.BtnSPerfil2.TabIndex = 11;
            this.BtnSPerfil2.Text = "Salir";
            this.BtnSPerfil2.UseVisualStyleBackColor = true;
            this.BtnSPerfil2.Click += new System.EventHandler(this.BtnSPerfil2_Click);
            // 
            // BtnGPerfil2
            // 
            this.BtnGPerfil2.Location = new System.Drawing.Point(4, 373);
            this.BtnGPerfil2.Name = "BtnGPerfil2";
            this.BtnGPerfil2.Size = new System.Drawing.Size(75, 23);
            this.BtnGPerfil2.TabIndex = 10;
            this.BtnGPerfil2.Text = "Guardar";
            this.BtnGPerfil2.UseVisualStyleBackColor = true;
            this.BtnGPerfil2.Click += new System.EventHandler(this.BtnGPerfil2_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 449);
            this.Controls.Add(this.TCPerfil);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.TCPerfil.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCPerfil;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnSPerfil;
        private System.Windows.Forms.Button BtnGPerfil;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblTelefonoR;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox TxtTelefonoA;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblTelefonoA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Button BtnSPerfil2;
        private System.Windows.Forms.Button BtnGPerfil2;
    }
}