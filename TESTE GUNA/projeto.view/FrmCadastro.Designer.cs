namespace TESTE_GUNA.projeto.view
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.btnX = new System.Windows.Forms.Button();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBase = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.Location = new System.Drawing.Point(931, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(28, 29);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtSenha.BorderRadius = 10;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSenha.IconLeft")));
            this.txtSenha.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSenha.Location = new System.Drawing.Point(73, 289);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(2);
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(330, 38);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.WordWrap = false;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtEmail.IconLeft")));
            this.txtEmail.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtEmail.Location = new System.Drawing.Point(73, 243);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(2);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(330, 38);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(169, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cadastro";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Transparent;
            this.txtNome.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtNome.BorderRadius = 10;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNome.IconLeft")));
            this.txtNome.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtNome.Location = new System.Drawing.Point(73, 151);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(2);
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(330, 38);
            this.txtNome.TabIndex = 26;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.Color.Transparent;
            this.txtBase.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase.BorderRadius = 10;
            this.txtBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBase.DefaultText = "";
            this.txtBase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBase.IconLeft")));
            this.txtBase.IconLeftSize = new System.Drawing.Size(28, 28);
            this.txtBase.Location = new System.Drawing.Point(73, 197);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.txtBase.PasswordChar = '\0';
            this.txtBase.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase.PlaceholderText = "CPF";
            this.txtBase.SelectedText = "";
            this.txtBase.Size = new System.Drawing.Size(330, 38);
            this.txtBase.TabIndex = 27;
            this.txtBase.Click += new System.EventHandler(this.guna2TextBox2_Click);
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMostrarSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(288, 349);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(12, 11);
            this.checkBoxMostrarSenha.TabIndex = 28;
            this.checkBoxMostrarSenha.UseVisualStyleBackColor = false;
            this.checkBoxMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBoxMostrarSenha_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(299, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mostrar Senha";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCPF.Location = new System.Drawing.Point(110, 205);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(110, 22);
            this.txtCPF.TabIndex = 31;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCPF.Visible = false;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.Click += new System.EventHandler(this.txtCPF_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrar.BorderRadius = 20;
            this.btnCadastrar.BorderThickness = 2;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrar.Location = new System.Drawing.Point(237, 404);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.PressedColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.Size = new System.Drawing.Size(110, 45);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "Cadastrar";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BorderRadius = 20;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEntrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEntrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEntrar.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(110, 404);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.PressedColor = System.Drawing.Color.Indigo;
            this.btnEntrar.Size = new System.Drawing.Size(110, 45);
            this.btnEntrar.TabIndex = 32;
            this.btnEntrar.Text = "Entrar";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 550);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMostrarSenha);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtBase;
        private System.Windows.Forms.CheckBox checkBoxMostrarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        public Guna.UI2.WinForms.Guna2Button btnCadastrar;
        public Guna.UI2.WinForms.Guna2Button btnEntrar;
    }
}