namespace SistemaControleFrotas
{
    partial class RelatorioEmpresaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioEmpresaFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msmRelatorioEmpresaFornecedor = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSearchVeiculos = new System.Windows.Forms.Button();
            this.dataGridViewVeiculos = new System.Windows.Forms.DataGridView();
            this.CPFCNPJEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEmpresaFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsavelEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCPFCNPJ = new System.Windows.Forms.Label();
            this.mskCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.msmRelatorioEmpresaFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // msmRelatorioEmpresaFornecedor
            // 
            this.msmRelatorioEmpresaFornecedor.Owner = this;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(725, 91);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(115, 39);
            this.btnApagar.TabIndex = 16;
            this.btnApagar.TabStop = false;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // btnSearchVeiculos
            // 
            this.btnSearchVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchVeiculos.Image")));
            this.btnSearchVeiculos.Location = new System.Drawing.Point(256, 90);
            this.btnSearchVeiculos.Name = "btnSearchVeiculos";
            this.btnSearchVeiculos.Size = new System.Drawing.Size(34, 24);
            this.btnSearchVeiculos.TabIndex = 15;
            this.btnSearchVeiculos.UseVisualStyleBackColor = false;
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
            this.CPFCNPJEmpresa,
            this.NomeEmpresaFornecedor,
            this.EnderecoEmpresa,
            this.ResponsavelEmpresa,
            this.TelefoneResponsavel});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVeiculos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewVeiculos.Location = new System.Drawing.Point(21, 144);
            this.dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            this.dataGridViewVeiculos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVeiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewVeiculos.RowHeadersVisible = false;
            this.dataGridViewVeiculos.Size = new System.Drawing.Size(819, 316);
            this.dataGridViewVeiculos.TabIndex = 13;
            this.dataGridViewVeiculos.TabStop = false;
            // 
            // CPFCNPJEmpresa
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "AAA-0";
            dataGridViewCellStyle2.NullValue = null;
            this.CPFCNPJEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.CPFCNPJEmpresa.Frozen = true;
            this.CPFCNPJEmpresa.HeaderText = "CPF/CNPJ";
            this.CPFCNPJEmpresa.MaxInputLength = 8;
            this.CPFCNPJEmpresa.MinimumWidth = 135;
            this.CPFCNPJEmpresa.Name = "CPFCNPJEmpresa";
            this.CPFCNPJEmpresa.ReadOnly = true;
            this.CPFCNPJEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CPFCNPJEmpresa.Width = 135;
            // 
            // NomeEmpresaFornecedor
            // 
            this.NomeEmpresaFornecedor.Frozen = true;
            this.NomeEmpresaFornecedor.HeaderText = "Nome/Razão Social";
            this.NomeEmpresaFornecedor.MinimumWidth = 190;
            this.NomeEmpresaFornecedor.Name = "NomeEmpresaFornecedor";
            this.NomeEmpresaFornecedor.ReadOnly = true;
            this.NomeEmpresaFornecedor.Width = 190;
            // 
            // EnderecoEmpresa
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.EnderecoEmpresa.DefaultCellStyle = dataGridViewCellStyle3;
            this.EnderecoEmpresa.Frozen = true;
            this.EnderecoEmpresa.HeaderText = "Endereço";
            this.EnderecoEmpresa.MaxInputLength = 30;
            this.EnderecoEmpresa.MinimumWidth = 230;
            this.EnderecoEmpresa.Name = "EnderecoEmpresa";
            this.EnderecoEmpresa.ReadOnly = true;
            this.EnderecoEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EnderecoEmpresa.Width = 230;
            // 
            // ResponsavelEmpresa
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsavelEmpresa.DefaultCellStyle = dataGridViewCellStyle4;
            this.ResponsavelEmpresa.HeaderText = "Responsável";
            this.ResponsavelEmpresa.MaxInputLength = 30;
            this.ResponsavelEmpresa.MinimumWidth = 142;
            this.ResponsavelEmpresa.Name = "ResponsavelEmpresa";
            this.ResponsavelEmpresa.ReadOnly = true;
            this.ResponsavelEmpresa.Width = 142;
            // 
            // TelefoneResponsavel
            // 
            this.TelefoneResponsavel.HeaderText = "Telefone";
            this.TelefoneResponsavel.MaxInputLength = 30;
            this.TelefoneResponsavel.MinimumWidth = 120;
            this.TelefoneResponsavel.Name = "TelefoneResponsavel";
            this.TelefoneResponsavel.ReadOnly = true;
            this.TelefoneResponsavel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TelefoneResponsavel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TelefoneResponsavel.Width = 120;
            // 
            // lblCPFCNPJ
            // 
            this.lblCPFCNPJ.AutoSize = true;
            this.lblCPFCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFCNPJ.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCNPJ.Location = new System.Drawing.Point(18, 93);
            this.lblCPFCNPJ.Name = "lblCPFCNPJ";
            this.lblCPFCNPJ.Size = new System.Drawing.Size(71, 18);
            this.lblCPFCNPJ.TabIndex = 12;
            this.lblCPFCNPJ.Text = "CPF/CNPJ:";
            // 
            // mskCPFCNPJ
            // 
            this.mskCPFCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPFCNPJ.Location = new System.Drawing.Point(95, 91);
            this.mskCPFCNPJ.Name = "mskCPFCNPJ";
            this.mskCPFCNPJ.Size = new System.Drawing.Size(155, 22);
            this.mskCPFCNPJ.TabIndex = 17;
            // 
            // RelatorioEmpresaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(863, 497);
            this.Controls.Add(this.mskCPFCNPJ);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSearchVeiculos);
            this.Controls.Add(this.dataGridViewVeiculos);
            this.Controls.Add(this.lblCPFCNPJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioEmpresaFornecedor";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Relatório Empresa/Fornecedor";
            this.Load += new System.EventHandler(this.RelatorioEmpresaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmRelatorioEmpresaFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmRelatorioEmpresaFornecedor;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSearchVeiculos;
        private System.Windows.Forms.DataGridView dataGridViewVeiculos;
        private System.Windows.Forms.Label lblCPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEmpresaFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsavelEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneResponsavel;
        private System.Windows.Forms.MaskedTextBox mskCPFCNPJ;
    }
}