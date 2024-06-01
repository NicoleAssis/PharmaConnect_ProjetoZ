namespace TESTE_GUNA.projeto.view
{
    partial class AdmFrmAlterarProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmFrmAlterarProdutos));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGridViewVendas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtNomeCartao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarAlteracoes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVendas)).BeginInit();
            this.SuspendLayout();
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
            this.panel4.TabIndex = 29;
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
            this.panel1.Size = new System.Drawing.Size(568, 39);
            this.panel1.TabIndex = 30;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(193, 7);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(183, 25);
            this.label.TabIndex = 33;
            this.label.Text = "ALTERAR PRODUTO";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(60)))), ((int)(((byte)(122)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(568, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 411);
            this.panel2.TabIndex = 31;
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
            this.panel3.TabIndex = 32;
            // 
            // DataGridViewVendas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewVendas.ColumnHeadersHeight = 4;
            this.DataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVendas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewVendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVendas.Location = new System.Drawing.Point(11, 81);
            this.DataGridViewVendas.Name = "DataGridViewVendas";
            this.DataGridViewVendas.RowHeadersVisible = false;
            this.DataGridViewVendas.Size = new System.Drawing.Size(550, 158);
            this.DataGridViewVendas.TabIndex = 33;
            this.DataGridViewVendas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVendas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewVendas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewVendas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewVendas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewVendas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVendas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVendas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewVendas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewVendas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewVendas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewVendas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewVendas.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewVendas.ThemeStyle.ReadOnly = false;
            this.DataGridViewVendas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVendas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewVendas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewVendas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewVendas.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewVendas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVendas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txtNomeCartao.Location = new System.Drawing.Point(258, 255);
            this.txtNomeCartao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCartao.Name = "txtNomeCartao";
            this.txtNomeCartao.PasswordChar = '\0';
            this.txtNomeCartao.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNomeCartao.PlaceholderText = "";
            this.txtNomeCartao.SelectedText = "";
            this.txtNomeCartao.Size = new System.Drawing.Size(216, 32);
            this.txtNomeCartao.TabIndex = 89;
            this.txtNomeCartao.TextChanged += new System.EventHandler(this.txtNomeCartao_TextChanged);
            this.txtNomeCartao.Click += new System.EventHandler(this.txtNomeCartao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(99, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nome do Produto:";
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
            this.txtPreco.Location = new System.Drawing.Point(258, 295);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPreco.PlaceholderText = "";
            this.txtPreco.SelectedText = "";
            this.txtPreco.Size = new System.Drawing.Size(216, 32);
            this.txtPreco.TabIndex = 91;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            this.txtPreco.Click += new System.EventHandler(this.txtPreco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(196, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 90;
            this.label2.Text = "Preço:";
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
            this.txtQuantidade.Location = new System.Drawing.Point(258, 335);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.PlaceholderText = "";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.Size = new System.Drawing.Size(216, 32);
            this.txtQuantidade.TabIndex = 93;
            this.txtQuantidade.Click += new System.EventHandler(this.txtQuantidade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(147, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "Quantidade:";
            // 
            // btnSalvarAlteracoes
            // 
            this.btnSalvarAlteracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarAlteracoes.BorderRadius = 20;
            this.btnSalvarAlteracoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarAlteracoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarAlteracoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvarAlteracoes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvarAlteracoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvarAlteracoes.FillColor = System.Drawing.Color.Navy;
            this.btnSalvarAlteracoes.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.btnSalvarAlteracoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlteracoes.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAlteracoes.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSalvarAlteracoes.Location = new System.Drawing.Point(179, 389);
            this.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            this.btnSalvarAlteracoes.Size = new System.Drawing.Size(215, 42);
            this.btnSalvarAlteracoes.TabIndex = 94;
            this.btnSalvarAlteracoes.Text = "SALVAR ALTERAÇÕES";
            this.btnSalvarAlteracoes.Click += new System.EventHandler(this.btnSalvarAlteracoes_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.txtPesquisa.BorderRadius = 15;
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.DefaultText = "Pesquisar";
            this.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.IconLeft")));
            this.txtPesquisa.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtPesquisa.Location = new System.Drawing.Point(128, 45);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPesquisa.PlaceholderText = "";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.Size = new System.Drawing.Size(316, 29);
            this.txtPesquisa.TabIndex = 29;
            this.txtPesquisa.Click += new System.EventHandler(this.txtPesquisa_Click);
            // 
            // AdmFrmAlterarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btnSalvarAlteracoes);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCartao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewVendas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmFrmAlterarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmFrmAlterarProdutos";
            this.Load += new System.EventHandler(this.AdmFrmAlterarProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnX;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewVendas;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeCartao;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnSalvarAlteracoes;
    }
}