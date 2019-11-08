namespace SistemaControleFrotas
{
    partial class CadastroMotorista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMotorista));
            this.mskTelefoneMotorista = new System.Windows.Forms.MaskedTextBox();
            this.mskCelularMotorista = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategoriaCnh = new System.Windows.Forms.ComboBox();
            this.mskCpfMotorista = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.txtCnhMotorista = new System.Windows.Forms.TextBox();
            this.txtEnderecoMotorista = new System.Windows.Forms.TextBox();
            this.lblCadMotoristaNome = new System.Windows.Forms.Label();
            this.lblCadMotoristaCPF = new System.Windows.Forms.Label();
            this.lblCadMotoristaCNH = new System.Windows.Forms.Label();
            this.lblCadMotoristaCategoria = new System.Windows.Forms.Label();
            this.lblCadMotoristaTelefone = new System.Windows.Forms.Label();
            this.lblCadMotoristaCelular = new System.Windows.Forms.Label();
            this.lblCadMotoristaEndereco = new System.Windows.Forms.Label();
            this.btnCadastroMotoristaAdicionar = new System.Windows.Forms.Button();
            this.btnCadastroMotoristaLimpar = new System.Windows.Forms.Button();
            this.pictureBoxCadastroMotorista = new System.Windows.Forms.PictureBox();
            this.lblExcecao = new System.Windows.Forms.Label();
            this.msmCadMotorista = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroMotorista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmCadMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // mskTelefoneMotorista
            // 
            this.mskTelefoneMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefoneMotorista.Location = new System.Drawing.Point(97, 208);
            this.mskTelefoneMotorista.Mask = "(00) 0000-0000";
            this.mskTelefoneMotorista.Name = "mskTelefoneMotorista";
            this.mskTelefoneMotorista.Size = new System.Drawing.Size(116, 22);
            this.mskTelefoneMotorista.TabIndex = 5;
            // 
            // mskCelularMotorista
            // 
            this.mskCelularMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCelularMotorista.Location = new System.Drawing.Point(256, 208);
            this.mskCelularMotorista.Mask = "(00) 00000-0000";
            this.mskCelularMotorista.Name = "mskCelularMotorista";
            this.mskCelularMotorista.Size = new System.Drawing.Size(122, 22);
            this.mskCelularMotorista.TabIndex = 6;
            // 
            // cmbCategoriaCnh
            // 
            this.cmbCategoriaCnh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCategoriaCnh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoriaCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaCnh.FormattingEnabled = true;
            this.cmbCategoriaCnh.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbCategoriaCnh.Location = new System.Drawing.Point(97, 174);
            this.cmbCategoriaCnh.Name = "cmbCategoriaCnh";
            this.cmbCategoriaCnh.Size = new System.Drawing.Size(53, 24);
            this.cmbCategoriaCnh.TabIndex = 4;
            // 
            // mskCpfMotorista
            // 
            this.mskCpfMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpfMotorista.Location = new System.Drawing.Point(97, 110);
            this.mskCpfMotorista.Mask = "000000000-00";
            this.mskCpfMotorista.Name = "mskCpfMotorista";
            this.mskCpfMotorista.Size = new System.Drawing.Size(104, 22);
            this.mskCpfMotorista.TabIndex = 2;
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMotorista.Location = new System.Drawing.Point(97, 76);
            this.txtNomeMotorista.MaxLength = 75;
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(282, 22);
            this.txtNomeMotorista.TabIndex = 1;
            // 
            // txtCnhMotorista
            // 
            this.txtCnhMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnhMotorista.Location = new System.Drawing.Point(97, 142);
            this.txtCnhMotorista.MaxLength = 17;
            this.txtCnhMotorista.Name = "txtCnhMotorista";
            this.txtCnhMotorista.Size = new System.Drawing.Size(181, 22);
            this.txtCnhMotorista.TabIndex = 3;
            // 
            // txtEnderecoMotorista
            // 
            this.txtEnderecoMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoMotorista.Location = new System.Drawing.Point(96, 242);
            this.txtEnderecoMotorista.MaxLength = 75;
            this.txtEnderecoMotorista.Name = "txtEnderecoMotorista";
            this.txtEnderecoMotorista.Size = new System.Drawing.Size(282, 22);
            this.txtEnderecoMotorista.TabIndex = 7;
            // 
            // lblCadMotoristaNome
            // 
            this.lblCadMotoristaNome.AutoSize = true;
            this.lblCadMotoristaNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMotoristaNome.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMotoristaNome.Location = new System.Drawing.Point(23, 78);
            this.lblCadMotoristaNome.Name = "lblCadMotoristaNome";
            this.lblCadMotoristaNome.Size = new System.Drawing.Size(50, 18);
            this.lblCadMotoristaNome.TabIndex = 9;
            this.lblCadMotoristaNome.Text = "Nome:";
            // 
            // lblCadMotoristaCPF
            // 
            this.lblCadMotoristaCPF.AutoSize = true;
            this.lblCadMotoristaCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMotoristaCPF.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMotoristaCPF.Location = new System.Drawing.Point(23, 112);
            this.lblCadMotoristaCPF.Name = "lblCadMotoristaCPF";
            this.lblCadMotoristaCPF.Size = new System.Drawing.Size(35, 18);
            this.lblCadMotoristaCPF.TabIndex = 10;
            this.lblCadMotoristaCPF.Text = "CPF:";
            // 
            // lblCadMotoristaCNH
            // 
            this.lblCadMotoristaCNH.AutoSize = true;
            this.lblCadMotoristaCNH.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMotoristaCNH.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMotoristaCNH.Location = new System.Drawing.Point(23, 144);
            this.lblCadMotoristaCNH.Name = "lblCadMotoristaCNH";
            this.lblCadMotoristaCNH.Size = new System.Drawing.Size(40, 18);
            this.lblCadMotoristaCNH.TabIndex = 11;
            this.lblCadMotoristaCNH.Text = "CNH:";
            // 
            // lblCadMotoristaCategoria
            // 
            this.lblCadMotoristaCategoria.AutoSize = true;
            this.lblCadMotoristaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMotoristaCategoria.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMotoristaCategoria.Location = new System.Drawing.Point(23, 176);
            this.lblCadMotoristaCategoria.Name = "lblCadMotoristaCategoria";
            this.lblCadMotoristaCategoria.Size = new System.Drawing.Size(71, 18);
            this.lblCadMotoristaCategoria.TabIndex = 12;
            this.lblCadMotoristaCategoria.Text = "Categoria:";
            // 
            // lblCadMotoristaTelefone
            // 
            this.lblCadMotoristaTelefone.AutoSize = true;
            this.lblCadMotoristaTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMotoristaTelefone.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMotoristaTelefone.Location = new System.Drawing.Point(23, 210);
            this.lblCadMotoristaTelefone.Name = "lblCadMotoristaTelefone";
            this.lblCadMotoristaTelefone.Size = new System.Drawing.Size(67, 18);
            this.lblCadMotoristaTelefone.TabIndex = 13;
            this.lblCadMotoristaTelefone.Text = "Telefone:";
            // 
            // lblCadMotoristaCelular
            // 
            this.lblCadMotoristaCelular.AutoSize = true;
            this.lblCadMotoristaCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMotoristaCelular.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMotoristaCelular.Location = new System.Drawing.Point(219, 210);
            this.lblCadMotoristaCelular.Name = "lblCadMotoristaCelular";
            this.lblCadMotoristaCelular.Size = new System.Drawing.Size(31, 18);
            this.lblCadMotoristaCelular.TabIndex = 14;
            this.lblCadMotoristaCelular.Text = "Cel:";
            // 
            // lblCadMotoristaEndereco
            // 
            this.lblCadMotoristaEndereco.AutoSize = true;
            this.lblCadMotoristaEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblCadMotoristaEndereco.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMotoristaEndereco.Location = new System.Drawing.Point(23, 246);
            this.lblCadMotoristaEndereco.Name = "lblCadMotoristaEndereco";
            this.lblCadMotoristaEndereco.Size = new System.Drawing.Size(72, 18);
            this.lblCadMotoristaEndereco.TabIndex = 15;
            this.lblCadMotoristaEndereco.Text = "Endereço:";
            // 
            // btnCadastroMotoristaAdicionar
            // 
            this.btnCadastroMotoristaAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroMotoristaAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroMotoristaAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroMotoristaAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroMotoristaAdicionar.Image")));
            this.btnCadastroMotoristaAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroMotoristaAdicionar.Location = new System.Drawing.Point(163, 342);
            this.btnCadastroMotoristaAdicionar.Name = "btnCadastroMotoristaAdicionar";
            this.btnCadastroMotoristaAdicionar.Size = new System.Drawing.Size(115, 39);
            this.btnCadastroMotoristaAdicionar.TabIndex = 16;
            this.btnCadastroMotoristaAdicionar.TabStop = false;
            this.btnCadastroMotoristaAdicionar.Text = "Adicionar";
            this.btnCadastroMotoristaAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroMotoristaAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnCadastroMotoristaLimpar
            // 
            this.btnCadastroMotoristaLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastroMotoristaLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroMotoristaLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroMotoristaLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroMotoristaLimpar.Image")));
            this.btnCadastroMotoristaLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroMotoristaLimpar.Location = new System.Drawing.Point(35, 342);
            this.btnCadastroMotoristaLimpar.Name = "btnCadastroMotoristaLimpar";
            this.btnCadastroMotoristaLimpar.Size = new System.Drawing.Size(115, 39);
            this.btnCadastroMotoristaLimpar.TabIndex = 16;
            this.btnCadastroMotoristaLimpar.TabStop = false;
            this.btnCadastroMotoristaLimpar.Text = "Limpar";
            this.btnCadastroMotoristaLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroMotoristaLimpar.UseVisualStyleBackColor = true;
            this.btnCadastroMotoristaLimpar.Click += new System.EventHandler(this.btnCadastroMotoristaLimpar_Click);
            // 
            // pictureBoxCadastroMotorista
            // 
            this.pictureBoxCadastroMotorista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCadastroMotorista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCadastroMotorista.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadastroMotorista.ErrorImage")));
            this.pictureBoxCadastroMotorista.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadastroMotorista.Image")));
            this.pictureBoxCadastroMotorista.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadastroMotorista.InitialImage")));
            this.pictureBoxCadastroMotorista.Location = new System.Drawing.Point(439, 51);
            this.pictureBoxCadastroMotorista.Name = "pictureBoxCadastroMotorista";
            this.pictureBoxCadastroMotorista.Size = new System.Drawing.Size(234, 239);
            this.pictureBoxCadastroMotorista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCadastroMotorista.TabIndex = 5;
            this.pictureBoxCadastroMotorista.TabStop = false;
            this.pictureBoxCadastroMotorista.DoubleClick += new System.EventHandler(this.PictureBoxCadastroMotorista_DoubleClick);
            // 
            // lblExcecao
            // 
            this.lblExcecao.AutoSize = true;
            this.lblExcecao.BackColor = System.Drawing.Color.Transparent;
            this.lblExcecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcecao.Location = new System.Drawing.Point(23, 298);
            this.lblExcecao.Name = "lblExcecao";
            this.lblExcecao.Size = new System.Drawing.Size(0, 16);
            this.lblExcecao.TabIndex = 18;
            // 
            // msmCadMotorista
            // 
            this.msmCadMotorista.Owner = this;
            // 
            // CadastroMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(696, 404);
            this.Controls.Add(this.lblExcecao);
            this.Controls.Add(this.btnCadastroMotoristaLimpar);
            this.Controls.Add(this.btnCadastroMotoristaAdicionar);
            this.Controls.Add(this.lblCadMotoristaEndereco);
            this.Controls.Add(this.lblCadMotoristaCelular);
            this.Controls.Add(this.lblCadMotoristaTelefone);
            this.Controls.Add(this.lblCadMotoristaCategoria);
            this.Controls.Add(this.lblCadMotoristaCNH);
            this.Controls.Add(this.lblCadMotoristaCPF);
            this.Controls.Add(this.lblCadMotoristaNome);
            this.Controls.Add(this.txtCnhMotorista);
            this.Controls.Add(this.txtEnderecoMotorista);
            this.Controls.Add(this.txtNomeMotorista);
            this.Controls.Add(this.pictureBoxCadastroMotorista);
            this.Controls.Add(this.cmbCategoriaCnh);
            this.Controls.Add(this.mskCelularMotorista);
            this.Controls.Add(this.mskCpfMotorista);
            this.Controls.Add(this.mskTelefoneMotorista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroMotorista";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastro de Motoristas";
            this.Load += new System.EventHandler(this.CadastroMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroMotorista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmCadMotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mskTelefoneMotorista;
        private System.Windows.Forms.MaskedTextBox mskCelularMotorista;
        private System.Windows.Forms.ComboBox cmbCategoriaCnh;
        private System.Windows.Forms.MaskedTextBox mskCpfMotorista;
        private System.Windows.Forms.TextBox txtNomeMotorista;
        private System.Windows.Forms.TextBox txtCnhMotorista;
        private System.Windows.Forms.TextBox txtEnderecoMotorista;
        private System.Windows.Forms.Label lblCadMotoristaNome;
        private System.Windows.Forms.Label lblCadMotoristaCPF;
        private System.Windows.Forms.Label lblCadMotoristaCNH;
        private System.Windows.Forms.Label lblCadMotoristaCategoria;
        private System.Windows.Forms.Label lblCadMotoristaTelefone;
        private System.Windows.Forms.Label lblCadMotoristaCelular;
        private System.Windows.Forms.Label lblCadMotoristaEndereco;
        private System.Windows.Forms.Button btnCadastroMotoristaAdicionar;
        private System.Windows.Forms.Button btnCadastroMotoristaLimpar;
        private System.Windows.Forms.PictureBox pictureBoxCadastroMotorista;
        private System.Windows.Forms.Label lblExcecao;
        private MetroFramework.Components.MetroStyleManager msmCadMotorista;
    }
}