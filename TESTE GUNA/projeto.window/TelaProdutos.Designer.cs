namespace TESTE_GUNA.projeto.window
{
    partial class TelaProdutos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrParaCarrinho = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TESTE_GUNA.Properties.Resources.produtos__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(360, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIrParaCarrinho
            // 
            this.btnIrParaCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrParaCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.btnIrParaCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIrParaCarrinho.BorderRadius = 20;
            this.btnIrParaCarrinho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIrParaCarrinho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIrParaCarrinho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIrParaCarrinho.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIrParaCarrinho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIrParaCarrinho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(89)))), ((int)(((byte)(241)))));
            this.btnIrParaCarrinho.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(140)))));
            this.btnIrParaCarrinho.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnIrParaCarrinho.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(140)))));
            this.btnIrParaCarrinho.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(89)))), ((int)(((byte)(241)))));
            this.btnIrParaCarrinho.Image = global::TESTE_GUNA.Properties.Resources.Sair__2_;
            this.btnIrParaCarrinho.ImageSize = new System.Drawing.Size(40, 40);
            this.btnIrParaCarrinho.Location = new System.Drawing.Point(702, 12);
            this.btnIrParaCarrinho.Name = "btnIrParaCarrinho";
            this.btnIrParaCarrinho.Size = new System.Drawing.Size(303, 55);
            this.btnIrParaCarrinho.TabIndex = 1;
            this.btnIrParaCarrinho.Text = "IR PARA O CARRINHO";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtPesquisa.BorderRadius = 20;
            this.txtPesquisa.BorderThickness = 3;
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.DefaultText = "";
            this.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(69)))));
            this.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.IconLeft = global::TESTE_GUNA.Properties.Resources.Perfil__2_;
            this.txtPesquisa.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPesquisa.IconLeftSize = new System.Drawing.Size(33, 33);
            this.txtPesquisa.Location = new System.Drawing.Point(248, 78);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPesquisa.MaximumSize = new System.Drawing.Size(558, 48);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(69)))));
            this.txtPesquisa.PlaceholderText = "Pesquisar";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.Size = new System.Drawing.Size(558, 48);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1035, 557);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesquisar.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Location = new System.Drawing.Point(248, 78);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(53, 48);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "guna2Button1";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // TelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTE_GUNA.Properties.Resources._7_Sem_Título_20240714171925__1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 709);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnIrParaCarrinho);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaProdutos";
            this.Text = "TelaProdutos";
            this.Load += new System.EventHandler(this.TelaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnIrParaCarrinho;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
    }
}