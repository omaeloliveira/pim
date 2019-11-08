using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class CadastroVeiculo : MetroFramework.Forms.MetroForm
    {
        string imagem = @"C:\...";
        
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void txtAnoVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtKmVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnCadastroVeiculoLimpar_Click(object sender, EventArgs e)
        {
            limparTextBox(this.Controls);
        }

        private void limparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is Label)
                    ((Label)ctrl).Text = string.Empty;
                if (ctrl is MaskedTextBox)
                    ((MaskedTextBox)ctrl).Text = string.Empty;
                if (ctrl is RadioButton)
                    ((RadioButton)ctrl).Checked = false;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = -1;

                pictureBoxCadastroVeiculo.Image = Image.FromFile(imagem);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //vai ler o tamanho do arquivo selecionado
                FileInfo file = new FileInfo(openFileDialog1.FileName);

                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (file.Length <= 1048576)
                    pictureBoxCadastroVeiculo.ImageLocation = openFileDialog1.FileName;
                else
                    lblExcecao.Text = "Impossível adicionar imagem, arquivo maior que 1 MB.";
                    lblExcecao.Location = new Point(36, 320);
                    lblExcecao.Font = new Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                    lblExcecao.ForeColor = Color.Red;
            }
        }

        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                modoEscuro(this.Controls);
                btnAdicionarInfos.ForeColor = btnCadastroVeiculoLimpar.ForeColor = btnCadastroVeiculoCadastrar.ForeColor = Color.White;
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
