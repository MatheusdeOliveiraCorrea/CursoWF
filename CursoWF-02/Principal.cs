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

namespace CursoWF_02
{
    public partial class formularioPrincipal : Form
    {
        public formularioPrincipal()
        {
            InitializeComponent();
        }

        public static string NomeUsuario = string.Empty; 

        private void AoClicarLogin(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("admin") && txtSenha.Text.Equals("12345"))
            {
                BemVindoTela bemVindoTela = new BemVindoTela();
                NomeUsuario = txtNome.Text;
                bemVindoTela.Show();
            } 
            else
            {
                MessageBox.Show("Usuário/Senha inválido(s)");
            }
        }

        private void AoDigitarSenha(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;

            var backspaceAscii = 08;
            var delAscii = 127;

            if(!Char.IsDigit(e.KeyChar) && asc != backspaceAscii && asc != delAscii)
            {
                e.Handled = true;

                if (txtSenha.Text.Length > 0)
                    txtSenha.Text.Remove(txtSenha.Text.Length - 1);
                else
                    txtSenha.Text = String.Empty;

                txtSenha.Focus();
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text == String.Empty)
                provedorErros.SetError(this.txtNome, "Informe o nome do usuário");
            else
                provedorErros.Clear();
        }

        private void AoClicarEnter(object sender, KeyPressEventArgs e)
        {
            var enterKey = 13; 

            if (e.KeyChar == Convert.ToChar((char)enterKey))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (txtSenha.Text == String.Empty)
                provedorErros.SetError(this.txtSenha, "Informe a senha do usuário");
            else
                provedorErros.Clear();
        }

        private void ValidarEmail(object sender, CancelEventArgs e)
        {
            var regex = new Regex("^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$");
            if (!regex.IsMatch(this.txtEmail.Text))
            {
                provedorErros.SetError(txtEmail, "email inválido");
            }
        }
    }
}
