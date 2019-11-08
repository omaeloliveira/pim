namespace SistemaControleFrotas
{
    partial class Abastecimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abastecimento));
            this.datePickerAbastecimentoData = new System.Windows.Forms.DateTimePicker();
            this.txtAbastecimentoLitros = new System.Windows.Forms.TextBox();
            this.txtAbastecimentoCombustivel = new System.Windows.Forms.TextBox();
            this.txtAbastecimentoKmAtual = new System.Windows.Forms.TextBox();
            this.dataGridViewAbastecimento = new System.Windows.Forms.DataGridView();
            this.PlacaVeiculoAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LitrosAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmInicialAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmFinalAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmPercorridosAbastecimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmTheme = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblAbastecimentoCombustivel = new System.Windows.Forms.Label();
            this.lblAbastecimentoData = new System.Windows.Forms.Label();
            this.lblAbastecimentoLitros = new System.Windows.Forms.Label();
            this.lblAbastecimentoKmAtual = new System.Windows.Forms.Label();
            this.lblAbastecimentoPlaca = new System.Windows.Forms.Label();
            this.btnAbastecimentoLimpar = new System.Windows.Forms.Button();
            this.btnAbastecimentoAdicionar = new System.Windows.Forms.Button();
            this.lblExcecao = new System.Windows.Forms.Label();
            this.cmbAbastecimentoPlaca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbastecimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // datePickerAbastecimentoData
            // 
            this.datePickerAbastecimentoData.Checked = false;
            this.datePickerAbastecimentoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerAbastecimentoData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerAbastecimentoData.Location = new System.Drawing.Point(114, 144);
            this.datePickerAbastecimentoData.Name = "datePickerAbastecimentoData";
            this.datePickerAbastecimentoData.Size = new System.Drawing.Size(104, 22);
            this.datePickerAbastecimentoData.TabIndex = 2;
            // 
            // txtAbastecimentoLitros
            // 
            this.txtAbastecimentoLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbastecimentoLitros.Location = new System.Drawing.Point(114, 180);
            this.txtAbastecimentoLitros.MaxLength = 3;
            this.txtAbastecimentoLitros.Name = "txtAbastecimentoLitros";
            this.txtAbastecimentoLitros.Size = new System.Drawing.Size(65, 22);
            this.txtAbastecimentoLitros.TabIndex = 3;
            this.txtAbastecimentoLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbastecimentoLitros_KeyPress);
            // 
            // txtAbastecimentoCombustivel
            // 
            this.txtAbastecimentoCombustivel.Cursor = System.Windows.Forms.Cursors.No;
            this.txtAbastecimentoCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbastecimentoCombustivel.Location = new System.Drawing.Point(114, 112);
            this.txtAbastecimentoCombustivel.Name = "txtAbastecimentoCombustivel";
            this.txtAbastecimentoCombustivel.ReadOnly = true;
            this.txtAbastecimentoCombustivel.Size = new System.Drawing.Size(146, 22);
            this.txtAbastecimentoCombustivel.TabIndex = 5;
            this.txtAbastecimentoCombustivel.TabStop = false;
            // 
            // txtAbastecimentoKmAtual
            // 
            this.txtAbastecimentoKmAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbastecimentoKmAtual.Location = new System.Drawing.Point(288, 178);
            this.txtAbastecimentoKmAtual.MaxLength = 6;
            this.txtAbastecimentoKmAtual.Name = "txtAbastecimentoKmAtual";
            this.txtAbastecimentoKmAtual.Size = new System.Drawing.Size(78, 22);
            this.txtAbastecimentoKmAtual.TabIndex = 4;
            this.txtAbastecimentoKmAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbastecimentoKmAtual_KeyPress);
            // 
            // dataGridViewAbastecimento
            // 
            this.dataGridViewAbastecimento.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAbastecimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAbastecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbastecimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlacaVeiculoAbastecimento,
            this.DataAbastecimento,
            this.LitrosAbastecimento,
            this.KmInicialAbastecimento,
            this.KmFinalAbastecimento,
            this.KmPercorridosAbastecimento});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAbastecimento.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAbastecimento.Location = new System.Drawing.Point(26, 219);
            this.dataGridViewAbastecimento.Name = "dataGridViewAbastecimento";
            this.dataGridViewAbastecimento.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAbastecimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAbastecimento.RowHeadersVisible = false;
            this.dataGridViewAbastecimento.Size = new System.Drawing.Size(650, 163);
            this.dataGridViewAbastecimento.TabIndex = 6;
            this.dataGridViewAbastecimento.TabStop = false;
            // 
            // PlacaVeiculoAbastecimento
            // 
            this.PlacaVeiculoAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacaVeiculoAbastecimento.DefaultCellStyle = dataGridViewCellStyle6;
            this.PlacaVeiculoAbastecimento.Frozen = true;
            this.PlacaVeiculoAbastecimento.HeaderText = "Placa";
            this.PlacaVeiculoAbastecimento.MaxInputLength = 8;
            this.PlacaVeiculoAbastecimento.MinimumWidth = 105;
            this.PlacaVeiculoAbastecimento.Name = "PlacaVeiculoAbastecimento";
            this.PlacaVeiculoAbastecimento.ReadOnly = true;
            this.PlacaVeiculoAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PlacaVeiculoAbastecimento.Width = 105;
            // 
            // DataAbastecimento
            // 
            this.DataAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataAbastecimento.HeaderText = "Data";
            this.DataAbastecimento.MaxInputLength = 10;
            this.DataAbastecimento.MinimumWidth = 102;
            this.DataAbastecimento.Name = "DataAbastecimento";
            this.DataAbastecimento.ReadOnly = true;
            this.DataAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataAbastecimento.Width = 102;
            // 
            // LitrosAbastecimento
            // 
            this.LitrosAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LitrosAbastecimento.HeaderText = "Litros";
            this.LitrosAbastecimento.MaxInputLength = 4;
            this.LitrosAbastecimento.MinimumWidth = 100;
            this.LitrosAbastecimento.Name = "LitrosAbastecimento";
            this.LitrosAbastecimento.ReadOnly = true;
            this.LitrosAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KmInicialAbastecimento
            // 
            this.KmInicialAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KmInicialAbastecimento.HeaderText = "Km Atual";
            this.KmInicialAbastecimento.MaxInputLength = 6;
            this.KmInicialAbastecimento.MinimumWidth = 100;
            this.KmInicialAbastecimento.Name = "KmInicialAbastecimento";
            this.KmInicialAbastecimento.ReadOnly = true;
            this.KmInicialAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KmInicialAbastecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KmFinalAbastecimento
            // 
            this.KmFinalAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KmFinalAbastecimento.HeaderText = "Km Final";
            this.KmFinalAbastecimento.MaxInputLength = 6;
            this.KmFinalAbastecimento.MinimumWidth = 100;
            this.KmFinalAbastecimento.Name = "KmFinalAbastecimento";
            this.KmFinalAbastecimento.ReadOnly = true;
            this.KmFinalAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KmFinalAbastecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KmPercorridosAbastecimento
            // 
            this.KmPercorridosAbastecimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KmPercorridosAbastecimento.HeaderText = "Km Percorridos";
            this.KmPercorridosAbastecimento.MaxInputLength = 4;
            this.KmPercorridosAbastecimento.MinimumWidth = 120;
            this.KmPercorridosAbastecimento.Name = "KmPercorridosAbastecimento";
            this.KmPercorridosAbastecimento.ReadOnly = true;
            this.KmPercorridosAbastecimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KmPercorridosAbastecimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KmPercorridosAbastecimento.Width = 140;
            // 
            // msmTheme
            // 
            this.msmTheme.Owner = this;
            this.msmTheme.Style = MetroFramework.MetroColorStyle.Blue;
            this.msmTheme.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblAbastecimentoCombustivel
            // 
            this.lblAbastecimentoCombustivel.AutoSize = true;
            this.lblAbastecimentoCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoCombustivel.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoCombustivel.Location = new System.Drawing.Point(21, 116);
            this.lblAbastecimentoCombustivel.Name = "lblAbastecimentoCombustivel";
            this.lblAbastecimentoCombustivel.Size = new System.Drawing.Size(88, 18);
            this.lblAbastecimentoCombustivel.TabIndex = 7;
            this.lblAbastecimentoCombustivel.Text = "Combustível:";
            // 
            // lblAbastecimentoData
            // 
            this.lblAbastecimentoData.AutoSize = true;
            this.lblAbastecimentoData.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoData.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoData.Location = new System.Drawing.Point(23, 148);
            this.lblAbastecimentoData.Name = "lblAbastecimentoData";
            this.lblAbastecimentoData.Size = new System.Drawing.Size(41, 18);
            this.lblAbastecimentoData.TabIndex = 7;
            this.lblAbastecimentoData.Text = "Data:";
            // 
            // lblAbastecimentoLitros
            // 
            this.lblAbastecimentoLitros.AutoSize = true;
            this.lblAbastecimentoLitros.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoLitros.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoLitros.Location = new System.Drawing.Point(23, 180);
            this.lblAbastecimentoLitros.Name = "lblAbastecimentoLitros";
            this.lblAbastecimentoLitros.Size = new System.Drawing.Size(46, 18);
            this.lblAbastecimentoLitros.TabIndex = 7;
            this.lblAbastecimentoLitros.Text = "Litros:";
            // 
            // lblAbastecimentoKmAtual
            // 
            this.lblAbastecimentoKmAtual.AutoSize = true;
            this.lblAbastecimentoKmAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoKmAtual.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoKmAtual.Location = new System.Drawing.Point(214, 180);
            this.lblAbastecimentoKmAtual.Name = "lblAbastecimentoKmAtual";
            this.lblAbastecimentoKmAtual.Size = new System.Drawing.Size(68, 18);
            this.lblAbastecimentoKmAtual.TabIndex = 7;
            this.lblAbastecimentoKmAtual.Text = "Km Atual:";
            // 
            // lblAbastecimentoPlaca
            // 
            this.lblAbastecimentoPlaca.AutoSize = true;
            this.lblAbastecimentoPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblAbastecimentoPlaca.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbastecimentoPlaca.Location = new System.Drawing.Point(21, 88);
            this.lblAbastecimentoPlaca.Name = "lblAbastecimentoPlaca";
            this.lblAbastecimentoPlaca.Size = new System.Drawing.Size(44, 18);
            this.lblAbastecimentoPlaca.TabIndex = 7;
            this.lblAbastecimentoPlaca.Text = "Placa:";
            // 
            // btnAbastecimentoLimpar
            // 
            this.btnAbastecimentoLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbastecimentoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecimentoLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbastecimentoLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnAbastecimentoLimpar.Image")));
            this.btnAbastecimentoLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbastecimentoLimpar.Location = new System.Drawing.Point(561, 106);
            this.btnAbastecimentoLimpar.Name = "btnAbastecimentoLimpar";
            this.btnAbastecimentoLimpar.Size = new System.Drawing.Size(115, 39);
            this.btnAbastecimentoLimpar.TabIndex = 9;
            this.btnAbastecimentoLimpar.Text = "Limpar";
            this.btnAbastecimentoLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbastecimentoLimpar.UseVisualStyleBackColor = true;
            this.btnAbastecimentoLimpar.Click += new System.EventHandler(this.BtnAbastecimentoLimpar_Click);
            // 
            // btnAbastecimentoAdicionar
            // 
            this.btnAbastecimentoAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbastecimentoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecimentoAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbastecimentoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAbastecimentoAdicionar.Image")));
            this.btnAbastecimentoAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbastecimentoAdicionar.Location = new System.Drawing.Point(561, 159);
            this.btnAbastecimentoAdicionar.Name = "btnAbastecimentoAdicionar";
            this.btnAbastecimentoAdicionar.Size = new System.Drawing.Size(115, 39);
            this.btnAbastecimentoAdicionar.TabIndex = 10;
            this.btnAbastecimentoAdicionar.Text = "Adicionar";
            this.btnAbastecimentoAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbastecimentoAdicionar.UseVisualStyleBackColor = true;
            // 
            // lblExcecao
            // 
            this.lblExcecao.AutoSize = true;
            this.lblExcecao.Location = new System.Drawing.Point(45, 219);
            this.lblExcecao.Name = "lblExcecao";
            this.lblExcecao.Size = new System.Drawing.Size(0, 13);
            this.lblExcecao.TabIndex = 11;
            // 
            // cmbAbastecimentoPlaca
            // 
            this.cmbAbastecimentoPlaca.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAbastecimentoPlaca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbAbastecimentoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAbastecimentoPlaca.FormattingEnabled = true;
            this.cmbAbastecimentoPlaca.Location = new System.Drawing.Point(114, 82);
            this.cmbAbastecimentoPlaca.Name = "cmbAbastecimentoPlaca";
            this.cmbAbastecimentoPlaca.Size = new System.Drawing.Size(104, 24);
            this.cmbAbastecimentoPlaca.TabIndex = 12;
            this.cmbAbastecimentoPlaca.TabStop = false;
            // 
            // Abastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(690, 399);
            this.Controls.Add(this.cmbAbastecimentoPlaca);
            this.Controls.Add(this.lblExcecao);
            this.Controls.Add(this.btnAbastecimentoAdicionar);
            this.Controls.Add(this.btnAbastecimentoLimpar);
            this.Controls.Add(this.lblAbastecimentoPlaca);
            this.Controls.Add(this.lblAbastecimentoKmAtual);
            this.Controls.Add(this.lblAbastecimentoLitros);
            this.Controls.Add(this.lblAbastecimentoData);
            this.Controls.Add(this.lblAbastecimentoCombustivel);
            this.Controls.Add(this.dataGridViewAbastecimento);
            this.Controls.Add(this.txtAbastecimentoCombustivel);
            this.Controls.Add(this.txtAbastecimentoKmAtual);
            this.Controls.Add(this.txtAbastecimentoLitros);
            this.Controls.Add(this.datePickerAbastecimentoData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Abastecimento";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Abastecimento";
            this.Load += new System.EventHandler(this.Abastecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbastecimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePickerAbastecimentoData;
        private System.Windows.Forms.TextBox txtAbastecimentoLitros;
        private System.Windows.Forms.TextBox txtAbastecimentoCombustivel;
        private System.Windows.Forms.TextBox txtAbastecimentoKmAtual;
        private System.Windows.Forms.DataGridView dataGridViewAbastecimento;
        private MetroFramework.Components.MetroStyleManager msmTheme;
        private System.Windows.Forms.Label lblAbastecimentoPlaca;
        private System.Windows.Forms.Label lblAbastecimentoKmAtual;
        private System.Windows.Forms.Label lblAbastecimentoLitros;
        private System.Windows.Forms.Label lblAbastecimentoData;
        private System.Windows.Forms.Label lblAbastecimentoCombustivel;
        private System.Windows.Forms.Label lblExcecao;
        private System.Windows.Forms.Button btnAbastecimentoAdicionar;
        private System.Windows.Forms.Button btnAbastecimentoLimpar;
        private System.Windows.Forms.ComboBox cmbAbastecimentoPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVeiculoAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn LitrosAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmInicialAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmFinalAbastecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmPercorridosAbastecimento;
    }
}