namespace View
{
    partial class PaginaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContaPagar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContaPagar
            // 
            this.btnContaPagar.Location = new System.Drawing.Point(13, 56);
            this.btnContaPagar.Name = "btnContaPagar";
            this.btnContaPagar.Size = new System.Drawing.Size(235, 382);
            this.btnContaPagar.TabIndex = 0;
            this.btnContaPagar.Text = "Contas a Pagar";
            this.btnContaPagar.UseVisualStyleBackColor = true;
            this.btnContaPagar.Click += new System.EventHandler(this.btnContaPagar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(254, 56);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(235, 382);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 382);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnContaPagar);
            this.Name = "PaginaInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContaPagar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button button3;
    }
}

