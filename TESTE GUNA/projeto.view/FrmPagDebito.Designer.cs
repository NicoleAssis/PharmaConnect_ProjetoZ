namespace TESTE_GUNA.projeto.view
{
    partial class FrmPagDebito
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnX = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBase = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeCartao = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBase2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.MaskedTextBox();
            this.txtCVV = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarInfo = new Guna.UI2.WinForms.Guna2Button();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(144, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 39;
            this.label6.Text = "Débito";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Controls.Add(this.pictureBox3);
            this.panel14.Controls.Add(this.btnX);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(327, 48);
            this.panel14.TabIndex = 80;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TESTE_GUNA.Properties.Resources.iconDebito;
            this.pictureBox3.Location = new System.Drawing.Point(101, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.Location = new System.Drawing.Point(301, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(28, 29);
            this.btnX.TabIndex = 73;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel3.Location = new System.Drawing.Point(0, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 5);
            this.panel3.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel2.Location = new System.Drawing.Point(0, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 401);
            this.panel2.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel1.Location = new System.Drawing.Point(327, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 379);
            this.panel1.TabIndex = 81;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBase.BorderRadius = 13;
            this.txtBase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBase.DefaultText = "";
            this.txtBase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase.Enabled = false;
            this.txtBase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBase.ForeColor = System.Drawing.Color.DimGray;
            this.txtBase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase.Location = new System.Drawing.Point(80, 77);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBase.Name = "txtBase";
            this.txtBase.PasswordChar = '\0';
            this.txtBase.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBase.PlaceholderText = "";
            this.txtBase.SelectedText = "";
            this.txtBase.Size = new System.Drawing.Size(177, 32);
            this.txtBase.TabIndex = 85;
            this.txtBase.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label8.Location = new System.Drawing.Point(76, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 84;
            this.label8.Text = "Número Cartão:";
            // 
            // txtNomeCartao
            // 
            this.txtNomeCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNomeCartao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNomeCartao.BorderRadius = 13;
            this.txtNomeCartao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCartao.DefaultText = "Nome no Cartão";
            this.txtNomeCartao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeCartao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeCartao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeCartao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeCartao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeCartao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNomeCartao.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomeCartao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeCartao.Location = new System.Drawing.Point(80, 144);
            this.txtNomeCartao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCartao.Name = "txtNomeCartao";
            this.txtNomeCartao.PasswordChar = '\0';
            this.txtNomeCartao.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNomeCartao.PlaceholderText = "";
            this.txtNomeCartao.SelectedText = "";
            this.txtNomeCartao.Size = new System.Drawing.Size(177, 32);
            this.txtNomeCartao.TabIndex = 87;
            this.txtNomeCartao.Click += new System.EventHandler(this.txtNomeCartao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(76, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 86;
            this.label1.Text = "Nome no cartão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(76, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 88;
            this.label2.Text = "Data de expiração:";
            // 
            // txtMes
            // 
            this.txtMes.BackColor = System.Drawing.Color.Transparent;
            this.txtMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtMes.ItemHeight = 30;
            this.txtMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtMes.Location = new System.Drawing.Point(80, 213);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(77, 36);
            this.txtMes.TabIndex = 89;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.Transparent;
            this.txtAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtAno.ItemHeight = 30;
            this.txtAno.Items.AddRange(new object[] {
            "2024  ",
            "2025  ",
            "2026  ",
            "2027  ",
            "2028  ",
            "2029  ",
            "2030  ",
            "2031  ",
            "2032  ",
            "2033  ",
            "2034  ",
            "2035  ",
            "2036  ",
            "2037  ",
            "2038  ",
            "2039  ",
            "2040  ",
            "2041  ",
            "2042  ",
            "2043  ",
            "2044  ",
            "2045  ",
            "2046  ",
            "2047  ",
            "2048  ",
            "2049  ",
            "2050"});
            this.txtAno.Location = new System.Drawing.Point(163, 213);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(94, 36);
            this.txtAno.TabIndex = 90;
            // 
            // txtBase2
            // 
            this.txtBase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBase2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBase2.BorderRadius = 13;
            this.txtBase2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBase2.DefaultText = "";
            this.txtBase2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBase2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBase2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBase2.Enabled = false;
            this.txtBase2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBase2.ForeColor = System.Drawing.Color.DimGray;
            this.txtBase2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBase2.Location = new System.Drawing.Point(120, 278);
            this.txtBase2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.PasswordChar = '\0';
            this.txtBase2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBase2.PlaceholderText = "";
            this.txtBase2.SelectedText = "";
            this.txtBase2.Size = new System.Drawing.Size(96, 32);
            this.txtBase2.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(76, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "CVV:";
            // 
            // txtCartao
            // 
            this.txtCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCartao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCartao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCartao.ForeColor = System.Drawing.Color.DimGray;
            this.txtCartao.Location = new System.Drawing.Point(89, 82);
            this.txtCartao.Mask = "0000-0000-0000-0000";
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(158, 22);
            this.txtCartao.TabIndex = 105;
            // 
            // txtCVV
            // 
            this.txtCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCVV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCVV.ForeColor = System.Drawing.Color.DimGray;
            this.txtCVV.Location = new System.Drawing.Point(132, 283);
            this.txtCVV.Mask = "000";
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(50, 22);
            this.txtCVV.TabIndex = 106;
            // 
            // btnSalvarInfo
            // 
            this.btnSalvarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvarInfo.BorderRadius = 20;
            this.btnSalvarInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvarInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvarInfo.FillColor = System.Drawing.Color.Teal;
            this.btnSalvarInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvarInfo.Image = global::TESTE_GUNA.Properties.Resources.iconDinheiro1;
            this.btnSalvarInfo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSalvarInfo.Location = new System.Drawing.Point(50, 329);
            this.btnSalvarInfo.Name = "btnSalvarInfo";
            this.btnSalvarInfo.Size = new System.Drawing.Size(232, 38);
            this.btnSalvarInfo.TabIndex = 107;
            this.btnSalvarInfo.Text = "SALVAR INFORMAÇÕES";
            this.btnSalvarInfo.Click += new System.EventHandler(this.btnSalvarInfo_Click);
            // 
            // FrmPagDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(332, 379);
            this.Controls.Add(this.btnSalvarInfo);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCartao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagDebito";
            this.Load += new System.EventHandler(this.FrmPagDebito_Load);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtBase;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeCartao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txtMes;
        private Guna.UI2.WinForms.Guna2ComboBox txtAno;
        private Guna.UI2.WinForms.Guna2TextBox txtBase2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCartao;
        private System.Windows.Forms.MaskedTextBox txtCVV;
        private Guna.UI2.WinForms.Guna2Button btnSalvarInfo;
    }
}