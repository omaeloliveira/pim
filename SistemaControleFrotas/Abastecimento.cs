using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class Abastecimento : MetroFramework.Forms.MetroForm 
    {
        public Abastecimento()
        {
            InitializeComponent();
        }

        private void txtAbastecimentoLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtAbastecimentoKmAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Abastecimento_Load(object sender, EventArgs e)
        {
            if(this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnAbastecimentoLimpar.ForeColor = btnAbastecimentoAdicionar.ForeColor = Color.White;
                lblExcecao.Font = new Font("Arial", 9.75F, FontStyle.Regular);
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

        private void BtnAbastecimentoLimpar_Click(object sender, EventArgs e)
        {
            limparTextBox(this.Controls);
            datePickerAbastecimentoData.Value = Convert.ToDateTime(DateTime.Today);
        }

        private void limparTextBox(Control.ControlCollection controles)
        {
            //Faz um laço para cada controle passado no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o controle for um TextBox apaga as informações contidas
                if (ctrl is TextBox)
                    ((TextBox)(ctrl)).Text = string.Empty;
                if (ctrl is Label)
                    ((Label)(ctrl)).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)(ctrl)).SelectedItem = -1;
            }
        }
    }
}
