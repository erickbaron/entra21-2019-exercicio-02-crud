namespace View
{
    partial class FormContasPagar
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
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvContasPagar = new System.Windows.Forms.DataGridView();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(101, 20);
            this.txtNome.TabIndex = 0;
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(13, 85);
            this.mtbValor.Mask = "0000.00";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(101, 20);
            this.mtbValor.TabIndex = 1;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Estudos",
            "Luz",
            "Água",
            "Internet",
            "Netflix",
            "Spotify",
            "Cartão"});
            this.cbTipo.Location = new System.Drawing.Point(13, 135);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(101, 21);
            this.cbTipo.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 214);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(13, 243);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(101, 23);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 272);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 69);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 119);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(10, 172);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataVencimento.TabIndex = 10;
            this.lblDataVencimento.Text = "Data de Vencimento";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(79, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 11;
            // 
            // dgvContasPagar
            // 
            this.dgvContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasPagar.Location = new System.Drawing.Point(120, 32);
            this.dgvContasPagar.Name = "dgvContasPagar";
            this.dgvContasPagar.Size = new System.Drawing.Size(342, 263);
            this.dgvContasPagar.TabIndex = 12;
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(13, 188);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(101, 20);
            this.dtpDataVencimento.TabIndex = 13;
            // 
            // FormContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.dgvContasPagar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.txtNome);
            this.Name = "FormContasPagar";
            this.Text = "ContasPagar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbValor;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvContasPagar;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
    }
}