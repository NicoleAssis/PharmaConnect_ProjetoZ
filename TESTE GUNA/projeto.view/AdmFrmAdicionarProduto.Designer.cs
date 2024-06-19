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
            this.txtNomeProduto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDepartamentos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.btnCriarProduto.Location = new System.Drawing.Point(210, 370);
            this.btnCriarProduto.Name = "btnCriarProduto";
            this.btnCriarProduto.Size = new System.Drawing.Size(201, 42);
            this.btnCriarProduto.TabIndex = 99;
            this.btnCriarProduto.Text = "CADASTRAR PRODUTO";
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
            this.txtQuantidade.DefaultText = "";
            this.txtQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.Location = new System.Drawing.Point(275, 241);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.PlaceholderText = "Quantidade";
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
            this.label3.Location = new System.Drawing.Point(157, 254);
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
            this.txtPreco.DefaultText = "";
            this.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPreco.ForeColor = System.Drawing.Color.DimGray;
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Location = new System.Drawing.Point(275, 188);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPreco.PlaceholderText = "Preço";
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
            this.label2.Location = new System.Drawing.Point(206, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = "Preço:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.txtNomeProduto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.txtNomeProduto.BorderRadius = 13;
            this.txtNomeProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeProduto.DefaultText = "";
            this.txtNomeProduto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeProduto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeProduto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNomeProduto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomeProduto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeProduto.Location = new System.Drawing.Point(275, 88);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.PasswordChar = '\0';
            this.txtNomeProduto.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNomeProduto.PlaceholderText = "Nome do Produto";
            this.txtNomeProduto.SelectedText = "";
            this.txtNomeProduto.Size = new System.Drawing.Size(216, 32);
            this.txtNomeProduto.TabIndex = 101;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeCartao_TextChanged);
            this.txtNomeProduto.Click += new System.EventHandler(this.txtNomeCartao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(109, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nome do Produto:";
            // 
            // TxtDesc
            // 
            this.TxtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.TxtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.TxtDesc.BorderRadius = 13;
            this.TxtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDesc.DefaultText = "";
            this.TxtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtDesc.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDesc.Location = new System.Drawing.Point(275, 137);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.PasswordChar = '\0';
            this.TxtDesc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtDesc.PlaceholderText = "Desc";
            this.TxtDesc.SelectedText = "";
            this.TxtDesc.Size = new System.Drawing.Size(216, 32);
            this.TxtDesc.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(170, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "Descriçâo:";
            // 
            // cbDepartamentos
            // 
            this.cbDepartamentos.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartamentos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamentos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartamentos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartamentos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDepartamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDepartamentos.ItemHeight = 30;
            this.cbDepartamentos.Items.AddRange(new object[] {
            "Analgésicos",
            "Anti-inflamatório",
            "Antivirais & Antibióticos",
            "Dermatológicos",
            "Diabéticos",
            "Ginecológicos",
            "Hipertensão",
            "Suplementos & Vitaminas"});
            this.cbDepartamentos.Location = new System.Drawing.Point(275, 299);
            this.cbDepartamentos.Name = "cbDepartamentos";
            this.cbDepartamentos.Size = new System.Drawing.Size(216, 36);
            this.cbDepartamentos.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(130, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 109;
            this.label5.Text = "Departamentos:";
            // 
            // AdmFrmAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDepartamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProduto);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        public Guna.UI2.WinForms.Guna2TextBox txtPreco;
        public Guna.UI2.WinForms.Guna2TextBox txtNomeProduto;
        public Guna.UI2.WinForms.Guna2TextBox TxtDesc;
        public Guna.UI2.WinForms.Guna2ComboBox cbDepartamentos;
    }
}