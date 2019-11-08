using System;
using System.Drawing;

namespace SistemaControleFrotas
{
    public partial class RelatorioEmpresaFornecedor : MetroFramework.Forms.MetroForm
    {
        public RelatorioEmpresaFornecedor()
        {
            InitializeComponent();
        }

        private void RelatorioEmpresaFornecedor_Load(object sender, EventArgs e)
        {
            if(this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                lblCPFCNPJ.ForeColor = btnApagar.ForeColor = Color.White;
            }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
