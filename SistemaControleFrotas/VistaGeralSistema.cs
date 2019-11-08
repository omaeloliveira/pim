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

namespace SistemaControleFrotas
{
    public partial class VistaGeralSistema : MetroFramework.Forms.MetroForm
    {
        TelaLogin login = new TelaLogin();
        
        public VistaGeralSistema()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobreSistema aboutSystem = new SobreSistema();
            aboutSystem.Theme = this.Theme;
            aboutSystem.ShowDialog();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVeiculo novoVeiculo = new CadastroVeiculo();
            novoVeiculo.Theme = this.Theme;
            novoVeiculo.ShowDialog();
        }

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMotorista novoMotorista = new CadastroMotorista();
            novoMotorista.Theme = this.Theme;
            novoMotorista.ShowDialog();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TESTE
            this.Close();
            //TESTE
        }

        private void timerDataHora_Tick_1(object sender, EventArgs e)
        {
            toolStripLabelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy --- HH:mm:ss ");
        }

        private void MetroTheme()
        {
            if (msmTelaPrincipal.Theme == MetroFramework.MetroThemeStyle.Dark)
                inicioToolStripMenuItem.ForeColor = Color.White;
            else
                inicioToolStripMenuItem.ForeColor = Color.Black;
        }

        private void inicioToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            MetroTheme();
        }

        private void inicioToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            MetroTheme();
        }

        private void cadastrarToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            MetroTheme();
        }

        private void cadastrarToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            MetroTheme();
        }

        private void RelatorioToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            MetroTheme();
        }

        private void RelatorioToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            MetroTheme();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVeiculos relatorioVeiculos = new RelatorioVeiculos();
            relatorioVeiculos.Theme = this.Theme;
            relatorioVeiculos.ShowDialog();
        }

        private void toolStripRelatorioMotoristas_Click(object sender, EventArgs e)
        {
            RelatorioMotoristas relatorioMotoristas = new RelatorioMotoristas();
            relatorioMotoristas.Theme = this.Theme;
            relatorioMotoristas.ShowDialog();
        }

        private void abastecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abastecimento abastecimentoVeiculos = new Abastecimento();
            abastecimentoVeiculos.Theme = this.Theme;
            abastecimentoVeiculos.ShowDialog();
        }

        private void multasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Multas multas = new Multas();
            multas.Theme = this.Theme;
            multas.ShowDialog();
        }

        private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmpresaFornecedor cadEmpresaFornecedor = new CadastroEmpresaFornecedor();
            cadEmpresaFornecedor.Theme = this.Theme;
            cadEmpresaFornecedor.ShowDialog();
        }

        private void ToolStripEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.Theme = this.Theme;
            estoque.ShowDialog();
        }

        private void NovoUsuarioToolStrip_Click(object sender, EventArgs e)
        {
            NovoUsuario newUser = new NovoUsuario();
            newUser.Theme = this.Theme;
            newUser.ShowDialog();
        }

        private void ToolStripMenuItemAlugar_Click(object sender, EventArgs e)
        {
            AlugarCarro alugarCarro = new AlugarCarro();
            alugarCarro.Theme = this.Theme;
            alugarCarro.ShowDialog();
        }

        private void ToolStripRelatorioEmpresaFornecedor_Click(object sender, EventArgs e)
        {
            RelatorioEmpresaFornecedor relatorioEmpresaFornecedor = new RelatorioEmpresaFornecedor();
            relatorioEmpresaFornecedor.Theme = this.Theme;
            relatorioEmpresaFornecedor.ShowDialog();
        }

        private void VistaGeralSistema_Load(object sender, EventArgs e)
        {
            if(this.msmTelaPrincipal.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                lblPaginaInicial.BringToFront();
                lblPaginaInicial.ForeColor = Color.White;
            }
        }
        
        private void AtalhoCadEmpresa_Click(object sender, EventArgs e)
        {
            CadastroEmpresaFornecedor cadastroEmpresaFornecedor = new CadastroEmpresaFornecedor();
            cadastroEmpresaFornecedor.Theme = this.Theme;
            cadastroEmpresaFornecedor.ShowDialog();
            panelPrincipal.Visible = false;
        }

        private void AtalhoCadVeiculo_Click(object sender, EventArgs e)
        {
            CadastroVeiculo cadastroVeiculo = new CadastroVeiculo();
            cadastroVeiculo.Theme = this.Theme;
            cadastroVeiculo.ShowDialog();
            panelPrincipal.Visible = false;
        }

        private void AtalhoMultas_Click(object sender, EventArgs e)
        {
            Multas multas = new Multas();
            multas.Theme = this.Theme;
            multas.ShowDialog();
            panelPrincipal.Visible = false;
        }

        private void AtalhoRelatorioVeic_Click(object sender, EventArgs e)
        {
            RelatorioVeiculos relatorioVeiculos = new RelatorioVeiculos();
            relatorioVeiculos.Theme = this.Theme;
            relatorioVeiculos.ShowDialog();
            panelPrincipal.Visible = false;
        }

        private void AtalhoRelatorioMotoristas_Click(object sender, EventArgs e)
        {
            RelatorioMotoristas relatorioMotoristas = new RelatorioMotoristas();
            relatorioMotoristas.Theme = this.Theme;
            relatorioMotoristas.ShowDialog();
            panelPrincipal.Visible = false;
        }
    }
}
