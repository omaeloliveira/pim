namespace SistemaControleFrotas
{
    partial class AlugarCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlugarCarro));
            this.msmAlugarCarro = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblVeículo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblContratoAluguel = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtContratoAluguel = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDataAluguel = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDataEntrega = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.msmAlugarCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // msmAlugarCarro
            // 
            this.msmAlugarCarro.Owner = this;
            // 
            // lblVeículo
            // 
            this.lblVeículo.AutoSize = true;
            this.lblVeículo.BackColor = System.Drawing.Color.Transparent;
            this.lblVeículo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeículo.Location = new System.Drawing.Point(24, 83);
            this.lblVeículo.Name = "lblVeículo";
            this.lblVeículo.Size = new System.Drawing.Size(57, 18);
            this.lblVeículo.TabIndex = 0;
            this.lblVeículo.Text = "Veículo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 115);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(131, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome/Razão Social:";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(23, 146);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(71, 18);
            this.lblCpfCnpj.TabIndex = 3;
            this.lblCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // lblContratoAluguel
            // 
            this.lblContratoAluguel.AutoSize = true;
            this.lblContratoAluguel.BackColor = System.Drawing.Color.Transparent;
            this.lblContratoAluguel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratoAluguel.Location = new System.Drawing.Point(23, 236);
            this.lblContratoAluguel.Name = "lblContratoAluguel";
            this.lblContratoAluguel.Size = new System.Drawing.Size(135, 18);
            this.lblContratoAluguel.TabIndex = 3;
            this.lblContratoAluguel.Text = "Contrato de Aluguel:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(164, 81);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(135, 24);
            this.cmbVeiculo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(164, 113);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 22);
            this.txtNome.TabIndex = 3;
            // 
            // txtContratoAluguel
            // 
            this.txtContratoAluguel.Enabled = false;
            this.txtContratoAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratoAluguel.Location = new System.Drawing.Point(164, 234);
            this.txtContratoAluguel.Name = "txtContratoAluguel";
            this.txtContratoAluguel.Size = new System.Drawing.Size(158, 22);
            this.txtContratoAluguel.TabIndex = 5;
            this.txtContratoAluguel.TabStop = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(23, 207);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(67, 18);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTel.Location = new System.Drawing.Point(164, 205);
            this.mskTel.Mask = "(00) 0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(104, 22);
            this.mskTel.TabIndex = 7;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.BackColor = System.Drawing.Color.Transparent;
            this.lblCel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(291, 207);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(31, 18);
            this.lblCel.TabIndex = 3;
            this.lblCel.Text = "Cel:";
            // 
            // mskCel
            // 
            this.mskCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCel.Location = new System.Drawing.Point(328, 205);
            this.mskCel.Mask = "(00) 0000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(104, 22);
            this.mskCel.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(26, 284);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 39);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnAlugar
            // 
            this.btnAlugar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlugar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlugar.Image")));
            this.btnAlugar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlugar.Location = new System.Drawing.Point(153, 284);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(115, 39);
            this.btnAlugar.TabIndex = 9;
            this.btnAlugar.TabStop = false;
            this.btnAlugar.Text = "Confirmar";
            this.btnAlugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlugar.UseVisualStyleBackColor = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(24, 307);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 10;
            // 
            // mskCpf
            // 
            this.mskCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(164, 144);
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(150, 22);
            this.mskCpf.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data do Aluguel:";
            // 
            // dateTimePickerDataAluguel
            // 
            this.dateTimePickerDataAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataAluguel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataAluguel.Location = new System.Drawing.Point(164, 175);
            this.dateTimePickerDataAluguel.Name = "dateTimePickerDataAluguel";
            this.dateTimePickerDataAluguel.Size = new System.Drawing.Size(104, 22);
            this.dateTimePickerDataAluguel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data de Entrega:";
            // 
            // dateTimePickerDataEntrega
            // 
            this.dateTimePickerDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataEntrega.Location = new System.Drawing.Point(407, 175);
            this.dateTimePickerDataEntrega.Name = "dateTimePickerDataEntrega";
            this.dateTimePickerDataEntrega.Size = new System.Drawing.Size(104, 22);
            this.dateTimePickerDataEntrega.TabIndex = 6;
            // 
            // AlugarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(586, 345);
            this.Controls.Add(this.dateTimePickerDataEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDataAluguel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtContratoAluguel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbVeiculo);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblContratoAluguel);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblVeículo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlugarCarro";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Aluguel de Veículo";
            this.Load += new System.EventHandler(this.AlugarCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmAlugarCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmAlugarCarro;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblVeículo;
        private System.Windows.Forms.Label lblContratoAluguel;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtContratoAluguel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAluguel;
        private System.Windows.Forms.Label label1;
    }
}