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
    public partial class BemVindoTela : Form
    {
        public BemVindoTela()
        {
            InitializeComponent();
        }

        private void BemVindoTela_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = formularioPrincipal.NomeUsuario;
        }
    }
}
