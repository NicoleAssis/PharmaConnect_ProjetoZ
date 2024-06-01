namespace TESTE_GUNA.projeto.view
{
    partial class UserControlPagItensEscolhidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblDescricao.Location = new System.Drawing.Point(0, 36);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(169, 37);
            this.lblDescricao.TabIndex = 44;
            this.lblDescricao.Text = "10 Comprimidos de 5mg";
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblNome.Location = new System.Drawing.Point(-1, 5);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(233, 33);
            this.lblNome.TabIndex = 43;
            this.lblNome.Text = "Cloridrato de Naratriptana";
            this.lblNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblSubtotal.Location = new System.Drawing.Point(226, 32);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(61, 20);
            this.lblSubtotal.TabIndex = 45;
            this.lblSubtotal.Text = "135,00";
            this.lblSubtotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblQtd.Location = new System.Drawing.Point(261, 6);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(28, 20);
            this.lblQtd.TabIndex = 46;
            this.lblQtd.Text = "1";
            this.lblQtd.Click += new System.EventHandler(this.labelQtd_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(162, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Subtotal: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(226, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Qtd: ";
            // 
            // UserControlPagItensEscolhidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Name = "UserControlPagItensEscolhidos";
            this.Size = new System.Drawing.Size(287, 60);
            this.Load += new System.EventHandler(this.UserControlPagItensEscolhidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
