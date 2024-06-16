namespace TESTE_GUNA.projeto.view
{
    partial class AdmFrmAdicionarProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnCriarProduto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCartao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscolherImagem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(60)))), ((int)(((byte)(122)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 39);
            this.panel1.TabIndex = 96;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(178, 7);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(206, 25);
            this.label.TabIndex = 33;
            this.label.Text = "ADICIONAR PRODUTO";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.Location = new System.Drawing.Point(537, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(28, 29);
            this.btnX.TabIndex = 30;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCriarProduto
            // 
            this.btnCriarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarProduto.BorderRadius = 20;
            this.btnCriarProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCriarProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCriarProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCriarProduto.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCriarProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCriarProduto.FillColor = System.Drawing.Color.Navy;
            this.btnCriarProduto.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnCriarProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarProduto.ForeColor = System.Drawing.Color.White;
            this.btnCriarProduto.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCriarProduto.Location = new System.Drawing.Point(186, 389);
            this.btnCriarProduto.Name = "btnCriarProduto";
            this.btnCriarProduto.Size = new System.Drawing.Size(201, 42);
            this.btnCriarProduto.TabIndex = 99;
            this.btnCriarProduto.Text = "CRIAR PRODUTO";
            this.btnCriarProduto.Click += new System.EventHandler(this.btnCriarProduto_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(60)))), ((int)(((byte)(122)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(5, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 5);
            this.panel3.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(60)))), ((int)(((byte)(122)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(568, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 450);
            this.panel2.TabIndex = 97;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(60)))), ((int)(((byte)(122)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 450);
            this.panel4.TabIndex = 95;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.txtQuantidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.txtQuantidade.BorderRadius = 13;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.DefaultText = "Quantidade";
            this.txtQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.Location = new System.Drawing.Point(258, 338);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.PlaceholderText = "";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.Size = new System.Drawing.Size(216, 32);
            this.txtQuantidade.TabIndex = 105;
            this.txtQuantidade.Click += new System.EventHandler(this.txtQuantidade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(147, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 104;
            this.label3.Text = "Quantidade:";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.txtPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.txtPreco.BorderRadius = 13;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.DefaultText = "Preço";
            this.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPreco.ForeColor = System.Drawing.Color.DimGray;
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Location = new System.Drawing.Point(258, 298);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPreco.PlaceholderText = "";
            this.txtPreco.SelectedText = "";
            this.txtPreco.Size = new System.Drawing.Size(216, 32);
            this.txtPreco.TabIndex = 103;
            this.txtPreco.Click += new System.EventHandler(this.txtPreco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(196, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = "Preço:";
            // 
            // txtNomeCartao
            // 
            this.txtNomeCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.txtNomeCartao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.txtNomeCartao.BorderRadius = 13;
            this.txtNomeCartao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCartao.DefaultText = "Nome do Produto";
            this.txtNomeCartao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeCartao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeCartao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeCartao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeCartao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeCartao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNomeCartao.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomeCartao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeCartao.Location = new System.Drawing.Point(258, 258);
            this.txtNomeCartao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCartao.Name = "txtNomeCartao";
            this.txtNomeCartao.PasswordChar = '\0';
            this.txtNomeCartao.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNomeCartao.PlaceholderText = "";
            this.txtNomeCartao.SelectedText = "";
            this.txtNomeCartao.Size = new System.Drawing.Size(216, 32);
            this.txtNomeCartao.TabIndex = 101;
            this.txtNomeCartao.TextChanged += new System.EventHandler(this.txtNomeCartao_TextChanged);
            this.txtNomeCartao.Click += new System.EventHandler(this.txtNomeCartao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(99, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nome do Produto:";
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnEscolherImagem.BorderRadius = 10;
            this.btnEscolherImagem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEscolherImagem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEscolherImagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEscolherImagem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEscolherImagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEscolherImagem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnEscolherImagem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnEscolherImagem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherImagem.ForeColor = System.Drawing.Color.White;
            this.btnEscolherImagem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEscolherImagem.Location = new System.Drawing.Point(195, 207);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(182, 29);
            this.btnEscolherImagem.TabIndex = 107;
            this.btnEscolherImagem.Text = "ESCOLHER IMAGEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(195, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 155);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // AdmFrmAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btnEscolherImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCartao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCriarProduto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmFrmAdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmFrmAdicionarProduto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnX;
        private Guna.UI2.WinForms.Guna2GradientButton btnCriarProduto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnEscolherImagem;
    }
}