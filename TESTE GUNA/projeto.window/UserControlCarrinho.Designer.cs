﻿namespace TESTE_GUNA.projeto.window
{
    partial class UserControlCarrinho
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
            this.txtPreco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtQtd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRemover = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtPreco.ForeColor = System.Drawing.Color.White;
            this.txtPreco.Location = new System.Drawing.Point(182, 29);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(85, 27);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.Text = "1200,00";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidade :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome Completo do Remédio";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 17;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.txtQtd);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.btnMenos);
            this.guna2Panel1.Location = new System.Drawing.Point(330, 57);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(135, 40);
            this.guna2Panel1.TabIndex = 9;
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.txtQtd.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.ForeColor = System.Drawing.Color.White;
            this.txtQtd.Location = new System.Drawing.Point(52, 4);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(38, 29);
            this.txtQtd.TabIndex = 11;
            this.txtQtd.Text = "1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(352, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "R$ :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(393, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "1200,00";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 40;
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(490, 102);
            this.guna2Panel2.TabIndex = 12;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.btnRemover.BorderRadius = 18;
            this.btnRemover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemover.FillColor = System.Drawing.Color.White;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Black", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.btnRemover.Image = global::TESTE_GUNA.Properties.Resources.Sair__7_;
            this.btnRemover.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRemover.Location = new System.Drawing.Point(109, 57);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(133, 36);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "REMOVER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TESTE_GUNA.Properties.Resources.noonbrew_ziCb4_EKmak_unsplash1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::TESTE_GUNA.Properties.Resources.Sair__5_;
            this.guna2Button2.ImageSize = new System.Drawing.Size(27, 27);
            this.guna2Button2.Location = new System.Drawing.Point(90, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(30, 30);
            this.guna2Button2.TabIndex = 10;
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(226)))));
            this.btnMenos.BorderRadius = 20;
            this.btnMenos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenos.FillColor = System.Drawing.Color.Transparent;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenos.ForeColor = System.Drawing.Color.White;
            this.btnMenos.Image = global::TESTE_GUNA.Properties.Resources.Sair__4_2;
            this.btnMenos.ImageSize = new System.Drawing.Size(27, 27);
            this.btnMenos.Location = new System.Drawing.Point(14, 4);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(30, 30);
            this.btnMenos.TabIndex = 0;
            // 
            // UserControlCarrinho
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.guna2Panel2);
            this.DoubleBuffered = true;
            this.Name = "UserControlCarrinho";
            this.Size = new System.Drawing.Size(490, 105);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtUnidade;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnRemover;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnMenos;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label txtQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}