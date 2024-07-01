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
            this.labelsub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqtd = new Guna.UI2.WinForms.Guna2TextBox();
            this.llabeltotal = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.PictureBox();
            this.btnMais = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagemProduto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
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
            this.panel10.Controls.Add(this.labelsub);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.txtqtd);
            this.panel10.Controls.Add(this.llabeltotal);
            this.panel10.Controls.Add(this.btnMenos);
            this.panel10.Controls.Add(this.btnMais);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Controls.Add(this.imagemProduto);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.lblDescricao);
            this.panel10.Controls.Add(this.lblNome);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel10.Location = new System.Drawing.Point(0, -2);
            this.panel10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(721, 84);
            this.panel10.TabIndex = 33;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // labelsub
            // 
            this.labelsub.AutoSize = true;
            this.labelsub.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.labelsub.Location = new System.Drawing.Point(413, 32);
            this.labelsub.Name = "labelsub";
            this.labelsub.Size = new System.Drawing.Size(51, 20);
            this.labelsub.TabIndex = 52;
            this.labelsub.Text = "135,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(381, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(639, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "R$";
            // 
            // txtqtd
            // 
            this.txtqtd.AutoRoundedCorners = true;
            this.txtqtd.BorderRadius = 11;
            this.txtqtd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqtd.DefaultText = "";
            this.txtqtd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtqtd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtqtd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqtd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqtd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqtd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtqtd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqtd.Location = new System.Drawing.Point(557, 28);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.PasswordChar = '\0';
            this.txtqtd.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtqtd.PlaceholderText = "";
            this.txtqtd.SelectedText = "";
            this.txtqtd.Size = new System.Drawing.Size(24, 24);
            this.txtqtd.TabIndex = 49;
            // 
            // llabeltotal
            // 
            this.llabeltotal.AutoSize = true;
            this.llabeltotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.llabeltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.llabeltotal.Location = new System.Drawing.Point(667, 32);
            this.llabeltotal.Name = "llabeltotal";
            this.llabeltotal.Size = new System.Drawing.Size(51, 20);
            this.llabeltotal.TabIndex = 48;
            this.llabeltotal.Text = "135,00";
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenos.BackgroundImage")));
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenos.Location = new System.Drawing.Point(518, 28);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(24, 24);
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
            this.btnMais.Size = new System.Drawing.Size(24, 24);
            this.btnMais.TabIndex = 46;
            this.btnMais.TabStop = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
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
            this.imagemProduto.BackgroundImage = global::TESTE_GUNA.Properties.Resources.imagemProdutooficial;
            this.imagemProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemProduto.Location = new System.Drawing.Point(0, 0);
            this.imagemProduto.Margin = new System.Windows.Forms.Padding(7);
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.Size = new System.Drawing.Size(99, 82);
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
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
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
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox imagemProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txtqtd;
        public System.Windows.Forms.Label labelsub;
        public System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.PictureBox btnMais;
        public System.Windows.Forms.PictureBox btnMenos;
        public System.Windows.Forms.Label llabeltotal;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}
