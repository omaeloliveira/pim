namespace SistemaControleFrotas
{
    partial class Multas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multas));
            this.cmbMultaPlaca = new System.Windows.Forms.ComboBox();
            this.datePickerMultaData = new System.Windows.Forms.DateTimePicker();
            this.lblMultaNatureza = new System.Windows.Forms.Label();
            this.cmbMultaNatureza = new System.Windows.Forms.ComboBox();
            this.lblMultaCondutor = new System.Windows.Forms.Label();
            this.cmbMultaCondutor = new System.Windows.Forms.ComboBox();
            this.lblMultaPlaca = new System.Windows.Forms.Label();
            this.lblMultaData = new System.Windows.Forms.Label();
            this.lblMultaValor = new System.Windows.Forms.Label();
            this.datePickerMultaVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblMultaVencimento = new System.Windows.Forms.Label();
            this.lblMultaStatus = new System.Windows.Forms.Label();
            this.cmbMultaStatus = new System.Windows.Forms.ComboBox();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.pictureBoxMultaAnexo = new System.Windows.Forms.PictureBox();
            this.txtMultaValor = new System.Windows.Forms.TextBox();
            this.msmMulta = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnMultaLimpar = new System.Windows.Forms.Button();
            this.btnMultaAdicionar = new System.Windows.Forms.Button();
            this.lblExcecao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMultaAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMultaPlaca
            // 
            this.cmbMultaPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMultaPlaca.FormattingEnabled = true;
            this.cmbMultaPlaca.Location = new System.Drawing.Point(103, 87);
            this.cmbMultaPlaca.Name = "cmbMultaPlaca";
            this.cmbMultaPlaca.Size = new System.Drawing.Size(154, 24);
            this.cmbMultaPlaca.TabIndex = 1;
            // 
            // datePickerMultaData
            // 
            this.datePickerMultaData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerMultaData.CustomFormat = "";
            this.datePickerMultaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerMultaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerMultaData.Location = new System.Drawing.Point(103, 121);
            this.datePickerMultaData.Name = "datePickerMultaData";
            this.datePickerMultaData.Size = new System.Drawing.Size(111, 22);
            this.datePickerMultaData.TabIndex = 2;
            // 
            // lblMultaNatureza
            // 
            this.lblMultaNatureza.AutoSize = true;
            this.lblMultaNatureza.BackColor = System.Drawing.Color.Transparent;
            this.lblMultaNatureza.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaNatureza.Location = new System.Drawing.Point(28, 161);
            this.lblMultaNatureza.Name = "lblMultaNatureza";
            this.lblMultaNatureza.Size = new System.Drawing.Size(69, 18);
            this.lblMultaNatureza.TabIndex = 5;
            this.lblMultaNatureza.Text = "Natureza:";
            // 
            // cmbMultaNatureza
            // 
            this.cmbMultaNatureza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMultaNatureza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMultaNatureza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMultaNatureza.FormattingEnabled = true;
            this.cmbMultaNatureza.Items.AddRange(new object[] {
            "Leve",
            "Média",
            "Grave",
            "Gravíssima"});
            this.cmbMultaNatureza.Location = new System.Drawing.Point(103, 159);
            this.cmbMultaNatureza.Name = "cmbMultaNatureza";
            this.cmbMultaNatureza.Size = new System.Drawing.Size(121, 24);
            this.cmbMultaNatureza.TabIndex = 4;
            // 
            // lblMultaCondutor
            // 
            this.lblMultaCondutor.AutoSize = true;
            this.lblMultaCondutor.BackColor = System.Drawing.Color.Transparent;
            this.lblMultaCondutor.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaCondutor.Location = new System.Drawing.Point(28, 232);
            this.lblMultaCondutor.Name = "lblMultaCondutor";
            this.lblMultaCondutor.Size = new System.Drawing.Size(70, 18);
            this.lblMultaCondutor.TabIndex = 5;
            this.lblMultaCondutor.Text = "Condutor:";
            // 
            // cmbMultaCondutor
            // 
            this.cmbMultaCondutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMultaCondutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMultaCondutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMultaCondutor.FormattingEnabled = true;
            this.cmbMultaCondutor.Location = new System.Drawing.Point(104, 230);
            this.cmbMultaCondutor.Name = "cmbMultaCondutor";
            this.cmbMultaCondutor.Size = new System.Drawing.Size(121, 24);
            this.cmbMultaCondutor.TabIndex = 7;
            // 
            // lblMultaPlaca
            // 
            this.lblMultaPlaca.AutoSize = true;
            this.lblMultaPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblMultaPlaca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaPlaca.Location = new System.Drawing.Point(28, 89);
            this.lblMultaPlaca.Name = "lblMultaPlaca";
            this.lblMultaPlaca.Size = new System.Drawing.Size(44, 18);
            this.lblMultaPlaca.TabIndex = 5;
            this.lblMultaPlaca.Text = "Placa:";
            // 
            // lblMultaData
            // 
            this.lblMultaData.AutoSize = true;
            this.lblMultaData.BackColor = System.Drawing.Color.Transparent;
            this.lblMultaData.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaData.Location = new System.Drawing.Point(28, 125);
            this.lblMultaData.Name = "lblMultaData";
            this.lblMultaData.Size = new System.Drawing.Size(41, 18);
            this.lblMultaData.TabIndex = 5;
            this.lblMultaData.Text = "Data:";
            // 
            // lblMultaValor
            // 
            this.lblMultaValor.AutoSize = true;
            this.lblMultaValor.BackColor = System.Drawing.Color.Transparent;
            this.lblMultaValor.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaValor.Location = new System.Drawing.Point(28, 197);
            this.lblMultaValor.Name = "lblMultaValor";
            this.lblMultaValor.Size = new System.Drawing.Size(43, 18);
            this.lblMultaValor.TabIndex = 5;
            this.lblMultaValor.Text = "Valor:";
            // 
            // datePickerMultaVencimento
            // 
            this.datePickerMultaVencimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerMultaVencimento.CustomFormat = "";
            this.datePickerMultaVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerMultaVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerMultaVencimento.Location = new System.Drawing.Point(332, 157);
            this.datePickerMultaVencimento.Name = "datePickerMultaVencimento";
            this.datePickerMultaVencimento.Size = new System.Drawing.Size(113, 22);
            this.datePickerMultaVencimento.TabIndex = 6;
            // 
            // lblMultaVencimento
            // 
            this.lblMultaVencimento.AutoSize = true;
            this.lblMultaVencimento.BackColor = System.Drawing.Color.Transparent;
            this.lblMultaVencimento.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaVencimento.Location = new System.Drawing.Point(239, 161);
            this.lblMultaVencimento.Name = "lblMultaVencimento";
            this.lblMultaVencimento.Size = new System.Drawing.Size(87, 18);
            this.lblMultaVencimento.TabIndex = 5;
            this.lblMultaVencimento.Text = "Vencimento:";
            // 
            // lblMultaStatus
            // 
            this.lblMultaStatus.AutoSize = true;
            this.lblMultaStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblMultaStatus.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaStatus.Location = new System.Drawing.Point(239, 197);
            this.lblMultaStatus.Name = "lblMultaStatus";
            this.lblMultaStatus.Size = new System.Drawing.Size(51, 18);
            this.lblMultaStatus.TabIndex = 5;
            this.lblMultaStatus.Text = "Status:";
            // 
            // cmbMultaStatus
            // 
            this.cmbMultaStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbMultaStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMultaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMultaStatus.FormattingEnabled = true;
            this.cmbMultaStatus.Items.AddRange(new object[] {
            "Em Aberto",
            "Paga"});
            this.cmbMultaStatus.Location = new System.Drawing.Point(316, 195);
            this.cmbMultaStatus.Name = "cmbMultaStatus";
            this.cmbMultaStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbMultaStatus.TabIndex = 8;
            // 
            // lblAnexo
            // 
            this.lblAnexo.AutoSize = true;
            this.lblAnexo.BackColor = System.Drawing.Color.Transparent;
            this.lblAnexo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnexo.Location = new System.Drawing.Point(449, 36);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(59, 18);
            this.lblAnexo.TabIndex = 5;
            this.lblAnexo.Text = "Anexos:";
            // 
            // pictureBoxMultaAnexo
            // 
            this.pictureBoxMultaAnexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMultaAnexo.Location = new System.Drawing.Point(452, 63);
            this.pictureBoxMultaAnexo.Name = "pictureBoxMultaAnexo";
            this.pictureBoxMultaAnexo.Size = new System.Drawing.Size(99, 90);
            this.pictureBoxMultaAnexo.TabIndex = 9;
            this.pictureBoxMultaAnexo.TabStop = false;
            // 
            // txtMultaValor
            // 
            this.txtMultaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultaValor.Location = new System.Drawing.Point(103, 195);
            this.txtMultaValor.MaxLength = 12;
            this.txtMultaValor.Name = "txtMultaValor";
            this.txtMultaValor.Size = new System.Drawing.Size(100, 22);
            this.txtMultaValor.TabIndex = 5;
            this.txtMultaValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMultaValor_KeyPress);
            this.txtMultaValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMultaValor_KeyUp);
            this.txtMultaValor.Leave += new System.EventHandler(this.txtMultaValor_Leave);
            // 
            // msmMulta
            // 
            this.msmMulta.Owner = this;
            // 
            // btnMultaLimpar
            // 
            this.btnMultaLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMultaLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultaLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultaLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnMultaLimpar.Image")));
            this.btnMultaLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultaLimpar.Location = new System.Drawing.Point(31, 300);
            this.btnMultaLimpar.Name = "btnMultaLimpar";
            this.btnMultaLimpar.Size = new System.Drawing.Size(115, 39);
            this.btnMultaLimpar.TabIndex = 15;
            this.btnMultaLimpar.Text = "Limpar";
            this.btnMultaLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultaLimpar.UseVisualStyleBackColor = true;
            this.btnMultaLimpar.Click += new System.EventHandler(this.BtnMultaLimpar_Click);
            // 
            // btnMultaAdicionar
            // 
            this.btnMultaAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMultaAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultaAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultaAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnMultaAdicionar.Image")));
            this.btnMultaAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultaAdicionar.Location = new System.Drawing.Point(162, 300);
            this.btnMultaAdicionar.Name = "btnMultaAdicionar";
            this.btnMultaAdicionar.Size = new System.Drawing.Size(115, 39);
            this.btnMultaAdicionar.TabIndex = 15;
            this.btnMultaAdicionar.Text = "Adicionar";
            this.btnMultaAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMultaAdicionar.UseVisualStyleBackColor = true;
            // 
            // lblExcecao
            // 
            this.lblExcecao.AutoSize = true;
            this.lblExcecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcecao.Location = new System.Drawing.Point(28, 277);
            this.lblExcecao.Name = "lblExcecao";
            this.lblExcecao.Size = new System.Drawing.Size(0, 16);
            this.lblExcecao.TabIndex = 16;
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(565, 362);
            this.Controls.Add(this.lblExcecao);
            this.Controls.Add(this.btnMultaLimpar);
            this.Controls.Add(this.btnMultaAdicionar);
            this.Controls.Add(this.txtMultaValor);
            this.Controls.Add(this.pictureBoxMultaAnexo);
            this.Controls.Add(this.cmbMultaStatus);
            this.Controls.Add(this.cmbMultaCondutor);
            this.Controls.Add(this.lblMultaVencimento);
            this.Controls.Add(this.lblMultaData);
            this.Controls.Add(this.lblMultaStatus);
            this.Controls.Add(this.lblMultaValor);
            this.Controls.Add(this.lblMultaCondutor);
            this.Controls.Add(this.cmbMultaNatureza);
            this.Controls.Add(this.lblAnexo);
            this.Controls.Add(this.lblMultaPlaca);
            this.Controls.Add(this.lblMultaNatureza);
            this.Controls.Add(this.datePickerMultaVencimento);
            this.Controls.Add(this.datePickerMultaData);
            this.Controls.Add(this.cmbMultaPlaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Multas";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Multas";
            this.Load += new System.EventHandler(this.Multas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMultaAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMultaPlaca;
        private System.Windows.Forms.DateTimePicker datePickerMultaData;
        private System.Windows.Forms.Label lblMultaNatureza;
        private System.Windows.Forms.ComboBox cmbMultaNatureza;
        private System.Windows.Forms.Label lblMultaCondutor;
        private System.Windows.Forms.ComboBox cmbMultaCondutor;
        private System.Windows.Forms.Label lblMultaPlaca;
        private System.Windows.Forms.Label lblMultaData;
        private System.Windows.Forms.Label lblMultaValor;
        private System.Windows.Forms.DateTimePicker datePickerMultaVencimento;
        private System.Windows.Forms.Label lblMultaVencimento;
        private System.Windows.Forms.Label lblMultaStatus;
        private System.Windows.Forms.ComboBox cmbMultaStatus;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.PictureBox pictureBoxMultaAnexo;
        private System.Windows.Forms.TextBox txtMultaValor;
        private MetroFramework.Components.MetroStyleManager msmMulta;
        private System.Windows.Forms.Button btnMultaLimpar;
        private System.Windows.Forms.Button btnMultaAdicionar;
        private System.Windows.Forms.Label lblExcecao;
    }
}