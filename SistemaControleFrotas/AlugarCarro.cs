using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SistemaControleFrotas
{
    public partial class AlugarCarro : MetroForm
    {
        public AlugarCarro()
        {
            InitializeComponent();
        }

        private void AlugarCarro_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnLimpar.ForeColor = btnAlugar.ForeColor = Color.White;
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar(this.Controls);
        }

        private void Limpar (Control.ControlCollection control)
        {
            foreach(Control ctrl in control)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is Label)
                    ((Label)(ctrl)).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = string.Empty;
            }
        }
    }
}
