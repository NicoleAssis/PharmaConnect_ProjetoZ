namespace TESTE_GUNA.projeto.view
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.imagemProduto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(101, 7);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(132, 46);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Cloridrato de Naratriptana";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelDescricao
            // 
            this.labelDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelDescricao.Location = new System.Drawing.Point(104, 59);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(129, 36);
            this.labelDescricao.TabIndex = 1;
            this.labelDescricao.Text = "10 Comprimidos de 5mg";
            this.labelDescricao.Click += new System.EventHandler(this.labelDescricao_Click);
            // 
            // labelPreco
            // 
            this.labelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.ForeColor = System.Drawing.Color.White;
            this.labelPreco.Location = new System.Drawing.Point(160, 92);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(70, 20);
            this.labelPreco.TabIndex = 2;
            this.labelPreco.Text = "RS: 10,99";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.imagemProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 117);
            this.panel1.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 113);
            this.panel8.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(98, 2);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(98, 2);
            this.panel6.TabIndex = 9;
            // 
            // imagemProduto
            // 
            this.imagemProduto.BackColor = System.Drawing.Color.White;
            this.imagemProduto.BackgroundImage = global::TESTE_GUNA.Properties.Resources.imagemProdutooficial1;
            this.imagemProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagemProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagemProduto.Location = new System.Drawing.Point(0, 0);
            this.imagemProduto.Margin = new System.Windows.Forms.Padding(7);
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.Size = new System.Drawing.Size(98, 117);
            this.imagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemProduto.TabIndex = 3;
            this.imagemProduto.TabStop = false;
            this.imagemProduto.Click += new System.EventHandler(this.imagemProduto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(98, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 117);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(231, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 117);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(101, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 2);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(101, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 2);
            this.panel5.TabIndex = 8;
            // 
            // UserControlProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelNome);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControlProduto";
            this.Size = new System.Drawing.Size(233, 117);
            this.Load += new System.EventHandler(this.UserControlProduto_Load);
            this.Click += new System.EventHandler(this.UserControlProduto_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.PictureBox imagemProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
