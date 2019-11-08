using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaControleFrotas
{
    public partial class TelaLogin : MetroFramework.Forms.MetroForm
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        
        private void TelaLogin_Load(object sender, EventArgs e)
        {
            cmbUsuario.SelectedIndex = -1;
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                lblLogUsuario.ForeColor = lblUserSenha.ForeColor = Color.White;
                btnConnect.ForeColor = Color.White;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //VistaGeralSistema vista = new VistaGeralSistema(cmbUsuario.Text);
        }

        private void deslogar(object sender, FormClosedEventArgs e)
        {
            cmbUsuario.Text = "";
            txtSenha.Clear();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            Local();
        }

        private void Local()
        {
            var location1 = new Point(26, 221);
            var location2 = new Point(47, 221);

            if (this.btnTema.Location == location1)
            {
                this.btnTema.Location = location2;
                btnTema.BackColor = Color.Teal;
                button1.BackColor = Color.Gainsboro;
                this.msmLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
                btnExit.ForeColor = btnConnect.ForeColor = lblLogUsuario.ForeColor = lblUserSenha.ForeColor = Color.White;
            }
            else
            {
                this.btnTema.Location = location1;
                btnTema.BackColor = Color.Silver;
                button1.BackColor = Color.Black;
                this.msmLogin.Theme = MetroFramework.MetroThemeStyle.Light;
                btnExit.ForeColor = btnConnect.ForeColor = lblLogUsuario.ForeColor = lblUserSenha.ForeColor = Color.Black;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, btnTema.Width, btnTema.Height);
            btnTema.Region = new Region(graphics);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Cria um objeto do tipo GraphicsPath que modifica a forma do botão em questão
            GraphicsPath graphics = new GraphicsPath();

            // Define como uma elipse o formato do objeto criado atribuindo valores para os parâmetros de posição e tamanho
            graphics.AddEllipse(0, 0, button1.Width, button1.Height);

            // Define a região do botão a ser arredondado, ou seja, o botão em si
            button1.Region = new Region(graphics);
        }
    }
}
