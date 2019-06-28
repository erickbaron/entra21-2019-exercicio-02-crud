namespace View
{
    partial class ContaReceberForm
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.mtbValorRecebido = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataRecebimento = new System.Windows.Forms.DateTimePicker();
            this.ckbRecebido = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorRecebido = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvContasReceber = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(13, 62);
            this.mtbValor.Mask = "9999.99";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 20);
            this.mtbValor.TabIndex = 1;
            // 
            // mtbValorRecebido
            // 
            this.mtbValorRecebido.Location = new System.Drawing.Point(12, 101);
            this.mtbValorRecebido.Mask = "9999.99";
            this.mtbValorRecebido.Name = "mtbValorRecebido";
            this.mtbValorRecebido.Size = new System.Drawing.Size(100, 20);
            this.mtbValorRecebido.TabIndex = 2;
            // 
            // dtpDataRecebimento
            // 
            this.dtpDataRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRecebimento.Location = new System.Drawing.Point(13, 140);
            this.dtpDataRecebimento.Name = "dtpDataRecebimento";
            this.dtpDataRecebimento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataRecebimento.TabIndex = 3;
            // 
            // ckbRecebido
            // 
            this.ckbRecebido.AutoSize = true;
            this.ckbRecebido.Location = new System.Drawing.Point(12, 166);
            this.ckbRecebido.Name = "ckbRecebido";
            this.ckbRecebido.Size = new System.Drawing.Size(72, 17);
            this.ckbRecebido.TabIndex = 4;
            this.ckbRecebido.Text = "Recebido";
            this.ckbRecebido.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 4);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 46);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor";
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.Location = new System.Drawing.Point(12, 85);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(80, 13);
            this.lblValorRecebido.TabIndex = 7;
            this.lblValorRecebido.Text = "Valor Recebido";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(12, 124);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataVencimento.TabIndex = 8;
            this.lblDataVencimento.Text = "Data de Vencimento";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(77, 4);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "label5";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 189);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(13, 218);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 247);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvContasReceber
            // 
            this.dgvContasReceber.AllowUserToAddRows = false;
            this.dgvContasReceber.AllowUserToDeleteRows = false;
            this.dgvContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnValor,
            this.ColumnValorRecebido,
            this.ColumnDataVencimento,
            this.ColumnRecebido});
            this.dgvContasReceber.Location = new System.Drawing.Point(119, 49);
            this.dgvContasReceber.Name = "dgvContasReceber";
            this.dgvContasReceber.ReadOnly = true;
            this.dgvContasReceber.Size = new System.Drawing.Size(345, 221);
            this.dgvContasReceber.TabIndex = 13;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Cód.";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnValor
            // 
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.ReadOnly = true;
            // 
            // ColumnValorRecebido
            // 
            this.ColumnValorRecebido.HeaderText = "Valor Recebido";
            this.ColumnValorRecebido.Name = "ColumnValorRecebido";
            this.ColumnValorRecebido.ReadOnly = true;
            // 
            // ColumnDataVencimento
            // 
            this.ColumnDataVencimento.HeaderText = "Vencimento";
            this.ColumnDataVencimento.Name = "ColumnDataVencimento";
            this.ColumnDataVencimento.ReadOnly = true;
            // 
            // ColumnRecebido
            // 
            this.ColumnRecebido.HeaderText = "Recebido";
            this.ColumnRecebido.Name = "ColumnRecebido";
            this.ColumnRecebido.ReadOnly = true;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(119, 4);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(40, 13);
            this.lblBusca.TabIndex = 15;
            this.lblBusca.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(119, 23);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(345, 20);
            this.txtBusca.TabIndex = 14;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // ContaReceberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvContasReceber);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblValorRecebido);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ckbRecebido);
            this.Controls.Add(this.dtpDataRecebimento);
            this.Controls.Add(this.mtbValorRecebido);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.txtNome);
            this.Name = "ContaReceberForm";
            this.Text = "ContaReceber";
            this.Load += new System.EventHandler(this.ContaReceberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.MaskedTextBox mtbValorRecebido;
        private System.Windows.Forms.DateTimePicker dtpDataRecebimento;
        private System.Windows.Forms.CheckBox ckbRecebido;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorRecebido;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvContasReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecebido;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBusca;
    }
}