namespace SistemaControleFrotas
{
    partial class RelatorioMotoristas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioMotoristas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMotoristas = new System.Windows.Forms.DataGridView();
            this.NomeMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNHMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VencimentoCNHMotorista = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoriaCNHmotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelularMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msmRelatorioMotorista = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblMotorista = new System.Windows.Forms.Label();
            this.btnSearchMotoristas = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtMotoristas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotoristas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmRelatorioMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMotoristas
            // 
            this.dataGridViewMotoristas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMotoristas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMotoristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeMotorista,
            this.CPFMotorista,
            this.CNHMotorista,
            this.VencimentoCNHMotorista,
            this.CategoriaCNHmotorista,
            this.TelefoneMotorista,
            this.CelularMotorista,
            this.EnderecoMotorista});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMotoristas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMotoristas.Location = new System.Drawing.Point(21, 143);
            this.dataGridViewMotoristas.Name = "dataGridViewMotoristas";
            this.dataGridViewMotoristas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMotoristas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMotoristas.RowHeadersVisible = false;
            this.dataGridViewMotoristas.Size = new System.Drawing.Size(754, 316);
            this.dataGridViewMotoristas.TabIndex = 6;
            // 
            // NomeMotorista
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeMotorista.DefaultCellStyle = dataGridViewCellStyle2;
            this.NomeMotorista.HeaderText = "Nome";
            this.NomeMotorista.MaxInputLength = 50;
            this.NomeMotorista.MinimumWidth = 100;
            this.NomeMotorista.Name = "NomeMotorista";
            this.NomeMotorista.ReadOnly = true;
            this.NomeMotorista.Width = 180;
            // 
            // CPFMotorista
            // 
            this.CPFMotorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPFMotorista.HeaderText = "CPF";
            this.CPFMotorista.MinimumWidth = 120;
            this.CPFMotorista.Name = "CPFMotorista";
            this.CPFMotorista.ReadOnly = true;
            this.CPFMotorista.Width = 120;
            // 
            // CNHMotorista
            // 
            this.CNHMotorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CNHMotorista.HeaderText = "CNH";
            this.CNHMotorista.MinimumWidth = 120;
            this.CNHMotorista.Name = "CNHMotorista";
            this.CNHMotorista.ReadOnly = true;
            this.CNHMotorista.Width = 120;
            // 
            // VencimentoCNHMotorista
            // 
            this.VencimentoCNHMotorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VencimentoCNHMotorista.HeaderText = "Imagem";
            this.VencimentoCNHMotorista.Image = ((System.Drawing.Image)(resources.GetObject("VencimentoCNHMotorista.Image")));
            this.VencimentoCNHMotorista.MinimumWidth = 100;
            this.VencimentoCNHMotorista.Name = "VencimentoCNHMotorista";
            this.VencimentoCNHMotorista.ReadOnly = true;
            this.VencimentoCNHMotorista.Visible = false;
            // 
            // CategoriaCNHmotorista
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaCNHmotorista.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoriaCNHmotorista.HeaderText = "Categoria";
            this.CategoriaCNHmotorista.MaxInputLength = 1;
            this.CategoriaCNHmotorista.MinimumWidth = 90;
            this.CategoriaCNHmotorista.Name = "CategoriaCNHmotorista";
            this.CategoriaCNHmotorista.ReadOnly = true;
            this.CategoriaCNHmotorista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriaCNHmotorista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CategoriaCNHmotorista.Width = 90;
            // 
            // TelefoneMotorista
            // 
            this.TelefoneMotorista.HeaderText = "Telefone";
            this.TelefoneMotorista.MinimumWidth = 110;
            this.TelefoneMotorista.Name = "TelefoneMotorista";
            this.TelefoneMotorista.ReadOnly = true;
            this.TelefoneMotorista.Width = 120;
            // 
            // CelularMotorista
            // 
            this.CelularMotorista.HeaderText = "Celular";
            this.CelularMotorista.MinimumWidth = 110;
            this.CelularMotorista.Name = "CelularMotorista";
            this.CelularMotorista.ReadOnly = true;
            this.CelularMotorista.Width = 120;
            // 
            // EnderecoMotorista
            // 
            this.EnderecoMotorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoMotorista.DefaultCellStyle = dataGridViewCellStyle4;
            this.EnderecoMotorista.HeaderText = "Endereço";
            this.EnderecoMotorista.MaxInputLength = 50;
            this.EnderecoMotorista.MinimumWidth = 100;
            this.EnderecoMotorista.Name = "EnderecoMotorista";
            this.EnderecoMotorista.ReadOnly = true;
            this.EnderecoMotorista.Visible = false;
            // 
            // msmRelatorioMotorista
            // 
            this.msmRelatorioMotorista.Owner = this;
            // 
            // lblMotorista
            // 
            this.lblMotorista.AutoSize = true;
            this.lblMotorista.BackColor = System.Drawing.Color.Transparent;
            this.lblMotorista.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorista.Location = new System.Drawing.Point(18, 89);
            this.lblMotorista.Name = "lblMotorista";
            this.lblMotorista.Size = new System.Drawing.Size(72, 18);
            this.lblMotorista.TabIndex = 7;
            this.lblMotorista.Text = "Motorista:";
            // 
            // btnSearchMotoristas
            // 
            this.btnSearchMotoristas.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchMotoristas.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMotoristas.Image")));
            this.btnSearchMotoristas.Location = new System.Drawing.Point(286, 86);
            this.btnSearchMotoristas.Name = "btnSearchMotoristas";
            this.btnSearchMotoristas.Size = new System.Drawing.Size(34, 24);
            this.btnSearchMotoristas.TabIndex = 9;
            this.btnSearchMotoristas.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(660, 86);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(115, 39);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.TabStop = false;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // txtMotoristas
            // 
            this.txtMotoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotoristas.Location = new System.Drawing.Point(95, 87);
            this.txtMotoristas.Name = "txtMotoristas";
            this.txtMotoristas.Size = new System.Drawing.Size(185, 22);
            this.txtMotoristas.TabIndex = 11;
            // 
            // RelatorioMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(794, 497);
            this.Controls.Add(this.txtMotoristas);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSearchMotoristas);
            this.Controls.Add(this.lblMotorista);
            this.Controls.Add(this.dataGridViewMotoristas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioMotoristas";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Relatório de Motoristas";
            this.Load += new System.EventHandler(this.RelatorioMotoristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotoristas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmRelatorioMotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMotoristas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNHMotorista;
        private System.Windows.Forms.DataGridViewImageColumn VencimentoCNHMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaCNHmotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelularMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoMotorista;
        private MetroFramework.Components.MetroStyleManager msmRelatorioMotorista;
        private System.Windows.Forms.Label lblMotorista;
        private System.Windows.Forms.Button btnSearchMotoristas;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtMotoristas;
    }
}