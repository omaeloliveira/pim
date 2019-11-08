using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class Multas : MetroFramework.Forms.MetroForm
    {
        public Multas()
        {
            InitializeComponent();
        }

        string valor;
        bool vencimento = false;

        private void txtMultaValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtMultaValor.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtMultaValor_Leave(object sender, EventArgs e)
        {
            try
            {
                valor = txtMultaValor.Text.Replace("R$", "");
                txtMultaValor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            }
            catch (Exception)
            {
            }
        }

        private void txtMultaValor_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtMultaValor.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtMultaValor.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtMultaValor.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtMultaValor.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtMultaValor.Text.StartsWith("0,"))
                {
                    txtMultaValor.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtMultaValor.Text.Contains("00,"))
                {
                    txtMultaValor.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtMultaValor.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtMultaValor.Text;
            txtMultaValor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtMultaValor.Select(txtMultaValor.Text.Length, 0);
        }

        private void BtnMultaLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                limparTextBox(this.Controls);
                lblExcecao.Text = "";
                datePickerMultaData.Value = Convert.ToDateTime(DateTime.Today);
                datePickerMultaVencimento.Value = Convert.ToDateTime(DateTime.Today);
            }
            catch (Exception)
            {

            }
        }

        private void limparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = String.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
            }
        }

        private void Multas_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnMultaLimpar.ForeColor = btnMultaAdicionar.ForeColor = Color.White;
            }
        }

        private void modoEscuro(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Label)
                {
                    ((Label)control).ForeColor = Color.White;
                }
            }
        }
    }
}
