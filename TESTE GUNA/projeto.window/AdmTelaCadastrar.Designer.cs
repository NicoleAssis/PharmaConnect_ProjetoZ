namespace TESTE_GUNA.projeto.window
{
    partial class AdmTelaCadastrar
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
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtBase3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtBase2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtBase = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCelular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCelular.Location = new System.Drawing.Point(556, 317);
            this.txtCelular.Mask = "00 0 0000-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(178, 25);
            this.txtCelular.TabIndex = 61;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Visible = false;
            // 
            // txtBase3
            // 
            this.txtBase3.BackColor = System.Drawing.Color.Transparent;
            this.txtBase3.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase3.BorderRadius = 10;
            this.txtBase3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBase3.DefaultText = "";
            this.txtBase3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBase3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBase3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBase3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase3.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBase3.Location = new System.Drawing.Point(550, 310);
            this.txtBase3.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase3.Name = "txtBase3";
            this.txtBase3.Padding = new System.Windows.Forms.Padding(2);
            this.txtBase3.PasswordChar = '\0';
            this.txtBase3.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase3.PlaceholderText = "Celular";
            this.txtBase3.SelectedText = "";
            this.txtBase3.Size = new System.Drawing.Size(330, 42);
            this.txtBase3.TabIndex = 60;
            this.txtBase3.Click += new System.EventHandler(this.txtBase3_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.Location = new System.Drawing.Point(929, 6);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(28, 29);
            this.btnX.TabIndex = 59;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTelefone.Location = new System.Drawing.Point(556, 267);
            this.txtTelefone.Mask = "0000-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(178, 25);
            this.txtTelefone.TabIndex = 58;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Visible = false;
            // 
            // txtBase2
            // 
            this.txtBase2.BackColor = System.Drawing.Color.Transparent;
            this.txtBase2.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase2.BorderRadius = 10;
            this.txtBase2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBase2.DefaultText = "";
            this.txtBase2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBase2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBase2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBase2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase2.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtBase2.Location = new System.Drawing.Point(550, 260);
            this.txtBase2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Padding = new System.Windows.Forms.Padding(2);
            this.txtBase2.PasswordChar = '\0';
            this.txtBase2.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase2.PlaceholderText = "Telefone";
            this.txtBase2.SelectedText = "";
            this.txtBase2.Size = new System.Drawing.Size(330, 42);
            this.txtBase2.TabIndex = 57;
            this.txtBase2.Click += new System.EventHandler(this.txtBase2_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCNPJ.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCNPJ.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCNPJ.Location = new System.Drawing.Point(554, 168);
            this.txtCNPJ.Mask = "00.000.000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(183, 25);
            this.txtCNPJ.TabIndex = 56;
            this.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCNPJ.Visible = false;
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
            this.btnCadastrar.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.btnCadastrar.Location = new System.Drawing.Point(648, 457);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.PressedColor = System.Drawing.Color.Indigo;
            this.btnCadastrar.Size = new System.Drawing.Size(138, 45);
            this.btnCadastrar.TabIndex = 55;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(778, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mostrar Senha";
            // 
            // checkBoxMostrarSenha
            // 
            this.checkBoxMostrarSenha.AutoSize = true;
            this.checkBoxMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMostrarSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxMostrarSenha.Location = new System.Drawing.Point(765, 425);
            this.checkBoxMostrarSenha.Name = "checkBoxMostrarSenha";
            this.checkBoxMostrarSenha.Size = new System.Drawing.Size(12, 11);
            this.checkBoxMostrarSenha.TabIndex = 53;
            this.checkBoxMostrarSenha.UseVisualStyleBackColor = false;
            this.checkBoxMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBoxMostrarSenha_CheckedChanged);
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
            this.txtBase.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBase.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase.IconLeftSize = new System.Drawing.Size(28, 28);
            this.txtBase.Location = new System.Drawing.Point(550, 160);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.txtBase.PasswordChar = '\0';
            this.txtBase.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBase.PlaceholderText = "CNPJ";
            this.txtBase.SelectedText = "";
            this.txtBase.Size = new System.Drawing.Size(330, 42);
            this.txtBase.TabIndex = 52;
            this.txtBase.Click += new System.EventHandler(this.txtBase_Click);
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
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtNome.Location = new System.Drawing.Point(550, 110);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(2);
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(330, 42);
            this.txtNome.TabIndex = 51;
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
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSenha.Location = new System.Drawing.Point(550, 360);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(2);
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSenha.PlaceholderText = "Senha";
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(330, 42);
            this.txtSenha.TabIndex = 50;
            this.txtSenha.WordWrap = false;
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
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtEmail.Location = new System.Drawing.Point(550, 210);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(2);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(330, 42);
            this.txtEmail.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(498, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 37);
            this.label4.TabIndex = 48;
            this.label4.Text = "CADASTRO DE ADMINISTRADOR";
            // 
            // AdmTelaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TESTE_GUNA.Properties.Resources.telaAdm22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 550);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtBase3);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMostrarSenha);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmTelaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmTelaCadastrarF1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCelular;
        private Guna.UI2.WinForms.Guna2TextBox txtBase3;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private Guna.UI2.WinForms.Guna2TextBox txtBase2;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        public Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMostrarSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtBase;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label4;
    }
}