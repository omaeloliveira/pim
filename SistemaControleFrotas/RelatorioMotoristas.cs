using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class RelatorioMotoristas : MetroFramework.Forms.MetroForm
    {
        public RelatorioMotoristas()
        {
            InitializeComponent();
        }

        private void RelatorioMotoristas_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnSearchMotoristas.BackColor = Color.White;
                btnApagar.ForeColor = Color.White;
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
    }
}
