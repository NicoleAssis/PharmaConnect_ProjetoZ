namespace TESTE_GUNA.projeto.view
{
    partial class UserControlComprasProdutos
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlComprasProdutos));
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.PictureBox();
            this.btnMais = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagemProduto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblPreco = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Controls.Add(this.lblSubtotal);
            this.panel10.Controls.Add(this.btnMenos);
            this.panel10.Controls.Add(this.btnMais);
            this.panel10.Controls.Add(this.txtQuantidade);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Controls.Add(this.imagemProduto);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.lblDescricao);
            this.panel10.Controls.Add(this.lblNome);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.lblPreco);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel10.Location = new System.Drawing.Point(0, -2);
            this.panel10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(721, 84);
            this.panel10.TabIndex = 33;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblSubtotal.Location = new System.Drawing.Point(637, 32);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(76, 20);
            this.lblSubtotal.TabIndex = 48;
            this.lblSubtotal.Text = "RS: 135,50";
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenos.BackgroundImage")));
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenos.Location = new System.Drawing.Point(518, 27);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(32, 31);
            this.btnMenos.TabIndex = 47;
            this.btnMenos.TabStop = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMais.BackgroundImage")));
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMais.Location = new System.Drawing.Point(598, 28);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(28, 28);
            this.btnMais.TabIndex = 46;
            this.btnMais.TabStop = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.Location = new System.Drawing.Point(556, 28);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(36, 29);
            this.txtQuantidade.TabIndex = 45;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(97, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 100);
            this.panel1.TabIndex = 44;
            // 
            // imagemProduto
            // 
            this.imagemProduto.BackColor = System.Drawing.Color.White;
            this.imagemProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagemProduto.BackgroundImage")));
            this.imagemProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemProduto.Location = new System.Drawing.Point(0, 0);
            this.imagemProduto.Margin = new System.Windows.Forms.Padding(7);
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.Size = new System.Drawing.Size(99, 88);
            this.imagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemProduto.TabIndex = 42;
            this.imagemProduto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(98, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 100);
            this.panel2.TabIndex = 43;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblDescricao.Location = new System.Drawing.Point(101, 51);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(265, 37);
            this.lblDescricao.TabIndex = 41;
            this.lblDescricao.Text = "10 Comprimidos de 5mg";
            this.lblDescricao.Click += new System.EventHandler(this.labelDescricao_Click);
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblNome.Location = new System.Drawing.Point(101, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(265, 50);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "Cloridrato de Naratriptana";
            this.lblNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkCyan;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel13.Location = new System.Drawing.Point(372, -1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 100);
            this.panel13.TabIndex = 38;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkCyan;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel11.Location = new System.Drawing.Point(509, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(3, 100);
            this.panel11.TabIndex = 37;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblPreco.Location = new System.Drawing.Point(404, 32);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(70, 20);
            this.lblPreco.TabIndex = 36;
            this.lblPreco.Text = "RS: 35,50";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkCyan;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel12.Location = new System.Drawing.Point(630, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(3, 100);
            this.panel12.TabIndex = 34;
            // 
            // UserControlComprasProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel10);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Name = "UserControlComprasProdutos";
            this.Size = new System.Drawing.Size(721, 80);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox imagemProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.PictureBox btnMais;
        private System.Windows.Forms.PictureBox btnMenos;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Panel panel1;
    }
}
