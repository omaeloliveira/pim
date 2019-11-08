namespace SistemaControleFrotas
{
    partial class RelatorioVeiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioVeiculos));
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.dataGridViewVeiculos = new System.Windows.Forms.DataGridView();
            this.TipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChassiVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CombustívelVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuilometragemVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusVeiculo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.msmRelatorioVeiculos = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.btnSearchVeiculos = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmRelatorioVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblVeiculo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(18, 92);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(57, 18);
            this.lblVeiculo.TabIndex = 0;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // dataGridViewVeiculos
            // 
            this.dataGridViewVeiculos.AllowUserToOrderColumns = true;
            this.dataGridViewVeiculos.AllowUserToResizeColumns = false;
            this.dataGridViewVeiculos.AllowUserToResizeRows = false;
            this.dataGridViewVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewVeiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewVeiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVeiculos.ColumnHeadersHeight = 25;
            this.dataGridViewVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoVeiculo,
            this.PlacaVeiculo,
            this.ContratoVeiculo,
            this.MarcaVeiculo,
            this.ModeloVeiculo,
            this.AnoVeiculo,
            this.ChassiVeiculo,
            this.CombustívelVeiculo,
            this.QuilometragemVeiculo,
            this.DataSaida,
            this.DataEntrada,
            this.StatusVeiculo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVeiculos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewVeiculos.Location = new System.Drawing.Point(21, 143);
            this.dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVeiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewVeiculos.RowHeadersVisible = false;
            this.dataGridViewVeiculos.Size = new System.Drawing.Size(819, 316);
            this.dataGridViewVeiculos.TabIndex = 3;
            this.dataGridViewVeiculos.TabStop = false;
            // 
            // TipoVeiculo
            // 
            this.TipoVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TipoVeiculo.HeaderText = "Tipo";
            this.TipoVeiculo.MinimumWidth = 110;
            this.TipoVeiculo.Name = "TipoVeiculo";
            this.TipoVeiculo.Visible = false;
            this.TipoVeiculo.Width = 110;
            // 
            // PlacaVeiculo
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "AAA-0";
            dataGridViewCellStyle2.NullValue = null;
            this.PlacaVeiculo.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlacaVeiculo.HeaderText = "Placa";
            this.PlacaVeiculo.MaxInputLength = 8;
            this.PlacaVeiculo.MinimumWidth = 80;
            this.PlacaVeiculo.Name = "PlacaVeiculo";
            this.PlacaVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlacaVeiculo.Width = 90;
            // 
            // ContratoVeiculo
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.ContratoVeiculo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ContratoVeiculo.HeaderText = "Contrato de Aluguel";
            this.ContratoVeiculo.MaxInputLength = 30;
            this.ContratoVeiculo.MinimumWidth = 100;
            this.ContratoVeiculo.Name = "ContratoVeiculo";
            this.ContratoVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ContratoVeiculo.Width = 140;
            // 
            // MarcaVeiculo
            // 
            this.MarcaVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaVeiculo.DefaultCellStyle = dataGridViewCellStyle4;
            this.MarcaVeiculo.HeaderText = "Marca";
            this.MarcaVeiculo.MaxInputLength = 30;
            this.MarcaVeiculo.MinimumWidth = 100;
            this.MarcaVeiculo.Name = "MarcaVeiculo";
            this.MarcaVeiculo.Visible = false;
            // 
            // ModeloVeiculo
            // 
            this.ModeloVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ModeloVeiculo.HeaderText = "Modelo";
            this.ModeloVeiculo.MaxInputLength = 30;
            this.ModeloVeiculo.MinimumWidth = 120;
            this.ModeloVeiculo.Name = "ModeloVeiculo";
            this.ModeloVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ModeloVeiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ModeloVeiculo.Width = 120;
            // 
            // AnoVeiculo
            // 
            this.AnoVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "0";
            dataGridViewCellStyle5.NullValue = null;
            this.AnoVeiculo.DefaultCellStyle = dataGridViewCellStyle5;
            this.AnoVeiculo.HeaderText = "Ano";
            this.AnoVeiculo.MaxInputLength = 4;
            this.AnoVeiculo.MinimumWidth = 70;
            this.AnoVeiculo.Name = "AnoVeiculo";
            this.AnoVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AnoVeiculo.Visible = false;
            this.AnoVeiculo.Width = 70;
            // 
            // ChassiVeiculo
            // 
            this.ChassiVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChassiVeiculo.HeaderText = "Chassi";
            this.ChassiVeiculo.MaxInputLength = 17;
            this.ChassiVeiculo.MinimumWidth = 100;
            this.ChassiVeiculo.Name = "ChassiVeiculo";
            this.ChassiVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChassiVeiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChassiVeiculo.Visible = false;
            // 
            // CombustívelVeiculo
            // 
            this.CombustívelVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombustívelVeiculo.DefaultCellStyle = dataGridViewCellStyle6;
            this.CombustívelVeiculo.HeaderText = "Combustível";
            this.CombustívelVeiculo.MinimumWidth = 130;
            this.CombustívelVeiculo.Name = "CombustívelVeiculo";
            this.CombustívelVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CombustívelVeiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CombustívelVeiculo.Visible = false;
            this.CombustívelVeiculo.Width = 130;
            // 
            // QuilometragemVeiculo
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "0.000";
            dataGridViewCellStyle7.NullValue = null;
            this.QuilometragemVeiculo.DefaultCellStyle = dataGridViewCellStyle7;
            this.QuilometragemVeiculo.HeaderText = "Quilometragem";
            this.QuilometragemVeiculo.MaxInputLength = 8;
            this.QuilometragemVeiculo.MinimumWidth = 110;
            this.QuilometragemVeiculo.Name = "QuilometragemVeiculo";
            this.QuilometragemVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuilometragemVeiculo.Width = 110;
            // 
            // DataSaida
            // 
            this.DataSaida.HeaderText = "Data de Saída";
            this.DataSaida.MaxInputLength = 10;
            this.DataSaida.MinimumWidth = 110;
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.Width = 115;
            // 
            // DataEntrada
            // 
            this.DataEntrada.HeaderText = "Data de Entrada";
            this.DataEntrada.MaxInputLength = 10;
            this.DataEntrada.MinimumWidth = 110;
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.Width = 115;
            // 
            // StatusVeiculo
            // 
            this.StatusVeiculo.HeaderText = "Status";
            this.StatusVeiculo.Items.AddRange(new object[] {
            "Alugado",
            "Disponível"});
            this.StatusVeiculo.MinimumWidth = 110;
            this.StatusVeiculo.Name = "StatusVeiculo";
            this.StatusVeiculo.Width = 127;
            // 
            // msmRelatorioVeiculos
            // 
            this.msmRelatorioVeiculos.Owner = this;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(81, 90);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(131, 24);
            this.cmbVeiculos.TabIndex = 4;
            // 
            // btnSearchVeiculos
            // 
            this.btnSearchVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchVeiculos.Image")));
            this.btnSearchVeiculos.Location = new System.Drawing.Point(218, 90);
            this.btnSearchVeiculos.Name = "btnSearchVeiculos";
            this.btnSearchVeiculos.Size = new System.Drawing.Size(34, 24);
            this.btnSearchVeiculos.TabIndex = 5;
            this.btnSearchVeiculos.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(725, 90);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(115, 39);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.TabStop = false;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // RelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(863, 497);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSearchVeiculos);
            this.Controls.Add(this.cmbVeiculos);
            this.Controls.Add(this.dataGridViewVeiculos);
            this.Controls.Add(this.lblVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioVeiculos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Relatório de Veículos";
            this.Load += new System.EventHandler(this.RelatorioVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmRelatorioVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.DataGridView dataGridViewVeiculos;
        private MetroFramework.Components.MetroStyleManager msmRelatorioVeiculos;
        private System.Windows.Forms.Button btnSearchVeiculos;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContratoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChassiVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CombustívelVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuilometragemVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusVeiculo;
        private System.Windows.Forms.Button btnApagar;
    }
}