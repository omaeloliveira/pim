using System;
using System.Drawing;

namespace SistemaControleFrotas
{
    public partial class NovoUsuario : MetroFramework.Forms.MetroForm
    {
        public string usuario;
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                lblNomeUsuario.ForeColor = lblDefinirSenha.ForeColor = lblRepetirSenha.ForeColor = groupBoxPermissoes.ForeColor = Color.White;
                btnLimpar.ForeColor = btnCadastrar.ForeColor = checkBoxMostrarSenha.ForeColor = Color.White;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = txtDefinirSenha.Text = lblMensagem.Text = "";
            checkBoxMostrarSenha.Checked = checkBoxPermissaoAbastecimento.Checked = checkBoxPermissaoCadastros.Checked = checkBoxPermissaoMultas.Checked = checkBoxPermissaoNovoUsuario.Checked = checkBoxPermissaoRelatórios.Checked = false;
        }
    }
}
