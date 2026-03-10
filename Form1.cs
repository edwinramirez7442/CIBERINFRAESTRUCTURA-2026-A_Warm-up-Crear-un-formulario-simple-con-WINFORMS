using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciber_Infrestructura_2026_A_HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPassword1.Text) ||  string.IsNullOrEmpty(textPassword2.Text))
            {
                MessageBox.Show("Ambos campos deben contener texto para validar");
                return;
            }
            string contrasena1 = textPassword1.Text;
            string contrasena2 = textPassword2.Text;
            if (!contrasena1.Equals(contrasena2))
            {
                MessageBox.Show("Las contraseñas deben ser iguales.");
                return;
            }
            if (ValidatePasswordComplexity(contrasena1))
            {
                MessageBox.Show("Contraseña valida");
              
            }
            else
            {
                MessageBox.Show("La contraseña no cumple con las especificaciones");
            }
        }
        public bool ValidatePasswordComplexity(string password)
        {
            // Regex: 
            // (?=.*[a-z]) : Al menos una minúscula
            // (?=.*[A-Z]) : Al menos una mayúscula
            // (?=.*\d)    : Al menos un número
            // (?=.*[^\da-zA-Z]) : Al menos un símbolo (no alfanumérico)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
