namespace TESTE_GUNA.projeto.window
{
    partial class UserControlProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProduto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.Label();
            this.RSMoeda = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.Label();
            this.btnAdicionarCarrinho = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.txtNome.Location = new System.Drawing.Point(97, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 52);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome Completo do Remédio";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.txtDescricao.Location = new System.Drawing.Point(99, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(213, 23);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "5mg";
            // 
            // RSMoeda
            // 
            this.RSMoeda.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.RSMoeda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.RSMoeda.Location = new System.Drawing.Point(203, 79);
            this.RSMoeda.Name = "RSMoeda";
            this.RSMoeda.Size = new System.Drawing.Size(43, 27);
            this.RSMoeda.TabIndex = 3;
            this.RSMoeda.Text = "R$:";
            this.RSMoeda.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.txtPreco.Location = new System.Drawing.Point(235, 79);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(85, 27);
            this.txtPreco.TabIndex = 4;
            this.txtPreco.Text = "1200,00";
            // 
            // btnAdicionarCarrinho
            // 
            this.btnAdicionarCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionarCarrinho.BorderRadius = 23;
            this.btnAdicionarCarrinho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarCarrinho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarCarrinho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarCarrinho.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarCarrinho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionarCarrinho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(89)))), ((int)(((byte)(241)))));
            this.btnAdicionarCarrinho.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(140)))));
            this.btnAdicionarCarrinho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarCarrinho.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(140)))));
            this.btnAdicionarCarrinho.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(89)))), ((int)(((byte)(241)))));
            this.btnAdicionarCarrinho.Image = global::TESTE_GUNA.Properties.Resources.Sair__1_1;
            this.btnAdicionarCarrinho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdicionarCarrinho.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAdicionarCarrinho.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdicionarCarrinho.Location = new System.Drawing.Point(102, 113);
            this.btnAdicionarCarrinho.Name = "btnAdicionarCarrinho";
            this.btnAdicionarCarrinho.Size = new System.Drawing.Size(208, 53);
            this.btnAdicionarCarrinho.TabIndex = 5;
            this.btnAdicionarCarrinho.Text = "        ADICIONAR AO CARRINHO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(149)))), ((int)(((byte)(190)))));
            this.panel1.Location = new System.Drawing.Point(95, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 170);
            this.panel1.TabIndex = 6;
            // 
            // UserControlProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::TESTE_GUNA.Properties.Resources.Remedio_User_Control__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdicionarCarrinho);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.RSMoeda);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "UserControlProduto";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(320, 182);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtDescricao;
        private System.Windows.Forms.Label RSMoeda;
        private System.Windows.Forms.Label txtPreco;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdicionarCarrinho;
        private System.Windows.Forms.Panel panel1;
    }
}
