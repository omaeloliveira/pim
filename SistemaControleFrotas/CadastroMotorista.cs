using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaControleFrotas
{
    public partial class CadastroMotorista : MetroFramework.Forms.MetroForm
    {
        readonly string imagem = @"C:\...";
        VistaGeralSistema vistaGeral = new VistaGeralSistema();

        public CadastroMotorista()
        {
            InitializeComponent();
        }

        private void CadastroMotorista_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnAdicionarInfos.ForeColor = btnCadastroMotoristaLimpar.ForeColor = btnCadastroMotoristaAdicionar.ForeColor = Color.White;
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

        private void btnCadastroMotoristaLimpar_Click(object sender, EventArgs e)
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
                if (ctrl is Label)
                    ((Label)ctrl).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;

                pictureBoxCadastroMotorista.Image = Image.FromFile(imagem);
            }
        }

        private void PictureBoxCadastroMotorista_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //vai ler o tamanho do arquivo selecionado
                FileInfo file = new FileInfo(openFileDialog1.FileName);

                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (file.Length <= 1048576)
                    pictureBoxCadastroMotorista.ImageLocation = openFileDialog1.FileName;
                else
                    //MessageBox.Show("Arquivo Maior que 1MB!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblExcecao.Text = "Impossível adicionar imagem, arquivo maior que 1 MB.";
                    lblExcecao.ForeColor = Color.Red;
            }
        }
    }
}
