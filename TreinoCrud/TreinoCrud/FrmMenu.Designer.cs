namespace TreinoCrud
{
    partial class FrmMenu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadastraCategoria = new System.Windows.Forms.Button();
            this.btnCadatrarProduto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(37, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Seja bem-vindo ";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnCadastraCategoria
            // 
            this.btnCadastraCategoria.Location = new System.Drawing.Point(160, 115);
            this.btnCadastraCategoria.Name = "btnCadastraCategoria";
            this.btnCadastraCategoria.Size = new System.Drawing.Size(251, 54);
            this.btnCadastraCategoria.TabIndex = 1;
            this.btnCadastraCategoria.Text = "Cadastrar Categoria";
            this.btnCadastraCategoria.UseVisualStyleBackColor = true;
            this.btnCadastraCategoria.Click += new System.EventHandler(this.btnCadastraCategoria_Click);
            // 
            // btnCadatrarProduto
            // 
            this.btnCadatrarProduto.Location = new System.Drawing.Point(160, 175);
            this.btnCadatrarProduto.Name = "btnCadatrarProduto";
            this.btnCadatrarProduto.Size = new System.Drawing.Size(251, 54);
            this.btnCadatrarProduto.TabIndex = 2;
            this.btnCadatrarProduto.Text = "Cadastrar Produto";
            this.btnCadatrarProduto.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(465, 307);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 32);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 351);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadatrarProduto);
            this.Controls.Add(this.btnCadastraCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroProduto";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadastraCategoria;
        private System.Windows.Forms.Button btnCadatrarProduto;
        private System.Windows.Forms.Button btnSair;
    }
}