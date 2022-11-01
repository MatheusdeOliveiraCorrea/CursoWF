using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (txtNome.Text.Equals("admin") && txtSenha.Text.Equals("admin"))
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

            if(!Char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {
                e.Handled = true;

                if (txtSenha.Text.Length > 0)
                    txtSenha.Text.Remove(txtSenha.Text.Length - 1);
                else
                    txtSenha.Text = String.Empty;

                txtSenha.Focus();
            }
        }
    }
}
