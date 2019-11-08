namespace SistemaControleFrotas
{
    partial class Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.msmEstoque = new MetroFramework.Components.MetroStyleManager(this.components);
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.DataDeEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDeEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeNoEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDataDeEntrada = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQuantidadeDeEntrada = new System.Windows.Forms.Label();
            this.dateTimePickerDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblExcecao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.msmEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // msmEstoque
            // 
            this.msmEstoque.Owner = this;
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataDeEntrada,
            this.Item,
            this.QuantidadeDeEntrada,
            this.QuantidadeNoEstoque});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(23, 173);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(559, 176);
            this.dataGridViewEstoque.TabIndex = 0;
            this.dataGridViewEstoque.TabStop = false;
            // 
            // DataDeEntrada
            // 
            this.DataDeEntrada.HeaderText = "Data";
            this.DataDeEntrada.MaxInputLength = 10;
            this.DataDeEntrada.MinimumWidth = 110;
            this.DataDeEntrada.Name = "DataDeEntrada";
            this.DataDeEntrada.ReadOnly = true;
            this.DataDeEntrada.Width = 110;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Item.HeaderText = "Item";
            this.Item.MaxInputLength = 20;
            this.Item.MinimumWidth = 135;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 135;
            // 
            // QuantidadeDeEntrada
            // 
            this.QuantidadeDeEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantidadeDeEntrada.HeaderText = "Quant. de Entrada";
            this.QuantidadeDeEntrada.MaxInputLength = 6;
            this.QuantidadeDeEntrada.MinimumWidth = 135;
            this.QuantidadeDeEntrada.Name = "QuantidadeDeEntrada";
            this.QuantidadeDeEntrada.ReadOnly = true;
            this.QuantidadeDeEntrada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuantidadeDeEntrada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QuantidadeDeEntrada.Width = 135;
            // 
            // QuantidadeNoEstoque
            // 
            this.QuantidadeNoEstoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantidadeNoEstoque.HeaderText = "Quant. no Estoque";
            this.QuantidadeNoEstoque.MaxInputLength = 6;
            this.QuantidadeNoEstoque.MinimumWidth = 135;
            this.QuantidadeNoEstoque.Name = "QuantidadeNoEstoque";
            this.QuantidadeNoEstoque.ReadOnly = true;
            this.QuantidadeNoEstoque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuantidadeNoEstoque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QuantidadeNoEstoque.Width = 135;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(267, 377);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 39);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(145, 377);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 39);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDataDeEntrada
            // 
            this.lblDataDeEntrada.AutoSize = true;
            this.lblDataDeEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblDataDeEntrada.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeEntrada.Location = new System.Drawing.Point(23, 82);
            this.lblDataDeEntrada.Name = "lblDataDeEntrada";
            this.lblDataDeEntrada.Size = new System.Drawing.Size(111, 18);
            this.lblDataDeEntrada.TabIndex = 0;
            this.lblDataDeEntrada.Text = "Data de Entrada:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(23, 113);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(41, 18);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item:";
            // 
            // lblQuantidadeDeEntrada
            // 
            this.lblQuantidadeDeEntrada.AutoSize = true;
            this.lblQuantidadeDeEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidadeDeEntrada.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDeEntrada.Location = new System.Drawing.Point(23, 144);
            this.lblQuantidadeDeEntrada.Name = "lblQuantidadeDeEntrada";
            this.lblQuantidadeDeEntrada.Size = new System.Drawing.Size(84, 18);
            this.lblQuantidadeDeEntrada.TabIndex = 0;
            this.lblQuantidadeDeEntrada.Text = "Quantidade:";
            // 
            // dateTimePickerDataEntrada
            // 
            this.dateTimePickerDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataEntrada.Location = new System.Drawing.Point(140, 78);
            this.dateTimePickerDataEntrada.Name = "dateTimePickerDataEntrada";
            this.dateTimePickerDataEntrada.Size = new System.Drawing.Size(104, 22);
            this.dateTimePickerDataEntrada.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(140, 140);
            this.txtQuantidade.MaxLength = 4;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(94, 22);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(140, 111);
            this.txtItem.MaxLength = 15;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(158, 22);
            this.txtItem.TabIndex = 2;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(23, 377);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(115, 39);
            this.btnApagar.TabIndex = 60;
            this.btnApagar.TabStop = false;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // lblExcecao
            // 
            this.lblExcecao.AutoSize = true;
            this.lblExcecao.BackColor = System.Drawing.Color.Transparent;
            this.lblExcecao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcecao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExcecao.Location = new System.Drawing.Point(339, 60);
            this.lblExcecao.Name = "lblExcecao";
            this.lblExcecao.Size = new System.Drawing.Size(0, 16);
            this.lblExcecao.TabIndex = 7;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(605, 427);
            this.Controls.Add(this.lblExcecao);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.dateTimePickerDataEntrada);
            this.Controls.Add(this.lblQuantidadeDeEntrada);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblDataDeEntrada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmEstoque;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Label lblQuantidadeDeEntrada;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblDataDeEntrada;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEntrada;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblExcecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDeEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeNoEstoque;
    }
}