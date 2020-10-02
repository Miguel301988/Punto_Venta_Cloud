using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV_Cloud
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = string.Empty;
            txtConfirmar.Text = string.Empty;
            if (BtnCambiar.Text == "Cambiar Contraseña")
            {
                lblContraseña.Visible = true;
                txtContraseña.Visible = true;
                lblConfirmar.Visible = true;
                txtConfirmar.Visible = true;
                BtnCambiar.Text = "Cancelar";
            }
            else
            {
                lblContraseña.Visible = false;
                txtContraseña.Visible = false;          
                lblConfirmar.Visible = false;
                txtConfirmar.Visible = false;         
                BtnCambiar.Text = "Cambiar Contraseña";
            }
        }

        private void BtnGPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado Satisfactoriamente");
        }

        private void BtnSPerfil_Click(object sender, EventArgs e)
        {
            Menu objMenu = new Menu();
            objMenu.Show();
            this.Close();
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void BtnGPerfil2_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtCorreoElectronico.Text) == false)
            {
                MessageBox.Show("Email no valido");
                return;
            }
            MessageBox.Show("Guardado Satisfactoriamente");
        }

        private void BtnSPerfil2_Click(object sender, EventArgs e)
        {
            Menu objMenu = new Menu();
            objMenu.Show();
            this.Close();
        }
    }
}
