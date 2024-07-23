namespace TESTE_GUNA.projeto.window
{
    partial class AdmTelaAdicionarProduto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalvarAlteracoes = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 123);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::TESTE_GUNA.Properties.Resources.Departamentos__13_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TESTE_GUNA.Properties.Resources.Rectangle_33__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 600);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1050, 109);
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalvarAlteracoes
            // 
            this.btnSalvarAlteracoes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvarAlteracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(62)))), ((int)(((byte)(250)))));
            this.btnSalvarAlteracoes.BorderRadius = 15;
            this.btnSalvarAlteracoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarAlteracoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarAlteracoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvarAlteracoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvarAlteracoes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.btnSalvarAlteracoes.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.btnSalvarAlteracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(62)))), ((int)(((byte)(250)))));
            this.btnSalvarAlteracoes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnSalvarAlteracoes.Location = new System.Drawing.Point(341, 634);
            this.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            this.btnSalvarAlteracoes.Size = new System.Drawing.Size(369, 47);
            this.btnSalvarAlteracoes.TabIndex = 85;
            this.btnSalvarAlteracoes.Text = "ADICIONAR PRODUTO";
            // 
            // AdmTelaAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TESTE_GUNA.Properties.Resources._7_Sem_Título_20240714171925__1_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 709);
            this.Controls.Add(this.btnSalvarAlteracoes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmTelaAdicionarProduto";
            this.Text = "AdmTelaAdicionarProduto";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnSalvarAlteracoes;
    }
}