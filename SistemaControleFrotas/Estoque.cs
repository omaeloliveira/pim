using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class Estoque : MetroFramework.Forms.MetroForm
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            dateTimePickerDataEntrada.Focus();

            if(this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnApagar.ForeColor = btnLimpar.ForeColor = btnAdicionar.ForeColor = Color.White;
            }
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dateTimePickerDataEntrada.Value = Convert.ToDateTime("01/01/2019");
            txtItem.Text = "";
            txtQuantidade.Text = "";
            lblExcecao.Text = "";
        }

        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
