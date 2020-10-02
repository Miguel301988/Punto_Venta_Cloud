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
            this.BtnSLogeo = new System.Windows.Forms.Button();
            this.BtnGLogeo = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblTelefonoR = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.TxtTelefonoA = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblTelefonoA = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.TCPerfil.Size = new System.Drawing.Size(389, 222);
            this.TCPerfil.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSLogeo);
            this.tabPage1.Controls.Add(this.BtnGLogeo);
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
            this.tabPage1.Size = new System.Drawing.Size(381, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logeo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnSLogeo
            // 
            this.BtnSLogeo.Location = new System.Drawing.Point(123, 167);
            this.BtnSLogeo.Name = "BtnSLogeo";
            this.BtnSLogeo.Size = new System.Drawing.Size(75, 23);
            this.BtnSLogeo.TabIndex = 8;
            this.BtnSLogeo.Text = "Salir";
            this.BtnSLogeo.UseVisualStyleBackColor = true;
            // 
            // BtnGLogeo
            // 
            this.BtnGLogeo.Location = new System.Drawing.Point(9, 167);
            this.BtnGLogeo.Name = "BtnGLogeo";
            this.BtnGLogeo.Size = new System.Drawing.Size(75, 23);
            this.BtnGLogeo.TabIndex = 7;
            this.BtnGLogeo.Text = "Guardar";
            this.BtnGLogeo.UseVisualStyleBackColor = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(6, 76);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(108, 13);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña (Max.20):";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(6, 119);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(110, 13);
            this.lblConfirmar.TabIndex = 6;
            this.lblConfirmar.Text = "Confirmar contraseña:";
            // 
            // lblTelefonoR
            // 
            this.lblTelefonoR.AutoSize = true;
            this.lblTelefonoR.Location = new System.Drawing.Point(6, 9);
            this.lblTelefonoR.Name = "lblTelefonoR";
            this.lblTelefonoR.Size = new System.Drawing.Size(164, 13);
            this.lblTelefonoR.TabIndex = 0;
            this.lblTelefonoR.Text = "Teléfono registrado: 9999999999";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(9, 135);
            this.txtConfirmar.MaxLength = 20;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmar.TabIndex = 5;
            // 
            // TxtTelefonoA
            // 
            this.TxtTelefonoA.Location = new System.Drawing.Point(9, 53);
            this.TxtTelefonoA.MaxLength = 10;
            this.TxtTelefonoA.Name = "TxtTelefonoA";
            this.TxtTelefonoA.Size = new System.Drawing.Size(178, 20);
            this.TxtTelefonoA.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(9, 93);
            this.txtContraseña.MaxLength = 20;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 4;
            // 
            // lblTelefonoA
            // 
            this.lblTelefonoA.AutoSize = true;
            this.lblTelefonoA.Location = new System.Drawing.Point(6, 37);
            this.lblTelefonoA.Name = "lblTelefonoA";
            this.lblTelefonoA.Size = new System.Drawing.Size(142, 13);
            this.lblTelefonoA.TabIndex = 2;
            this.lblTelefonoA.Text = "*Teléfono actual (10 digitos):";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(381, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Perfil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Empresa:";
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 396);
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
        private System.Windows.Forms.Button BtnSLogeo;
        private System.Windows.Forms.Button BtnGLogeo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblTelefonoR;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox TxtTelefonoA;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblTelefonoA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}