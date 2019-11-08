using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class CadastroEmpresaFornecedor : MetroFramework.Forms.MetroForm
    {
        public CadastroEmpresaFornecedor()
        {
            InitializeComponent();
        }

        private void CadastroEmpresaFornecedor_Load(object sender, EventArgs e)
        {
            if(this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnTeste.ForeColor = btnLimpar.ForeColor = btnAdicionar.ForeColor = Color.White;
                lblTipo.ForeColor = lblResponsavelFornecedor.ForeColor = lblTelefoneFornecedor.ForeColor = lblEmailFornecedor.ForeColor = Color.White;
            }

            cmbEmpresaFornecedor.SelectedIndex = 0;
            txtNomeEmpresa.Focus();
            txtNomeEmpresa.Select();
        }

        private void modoEscuro(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Label)
                {
                    ((Label)(control)).ForeColor = Color.White;
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTextBox(this.Controls);
        }

        private void LimparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;
                if (ctrl is Label)
                    ((Label)ctrl).Text = string.Empty;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
        }
    }
}
