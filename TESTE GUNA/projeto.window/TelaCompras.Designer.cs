namespace TESTE_GUNA.projeto.window
{
    partial class TelaCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCompras));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrParaCarrinho = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIrParaCarrinho
            // 
            this.btnIrParaCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrParaCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.btnIrParaCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIrParaCarrinho.BorderRadius = 20;
            this.btnIrParaCarrinho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIrParaCarrinho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIrParaCarrinho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIrParaCarrinho.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIrParaCarrinho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIrParaCarrinho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(231)))));
            this.btnIrParaCarrinho.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(34)))), ((int)(((byte)(160)))));
            this.btnIrParaCarrinho.Font = new System.Drawing.Font("Segoe UI", 15.5F, System.Drawing.FontStyle.Bold);
            this.btnIrParaCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnIrParaCarrinho.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(140)))));
            this.btnIrParaCarrinho.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(89)))), ((int)(((byte)(241)))));
            this.btnIrParaCarrinho.Image = global::TESTE_GUNA.Properties.Resources.Sair__2_1;
            this.btnIrParaCarrinho.ImageSize = new System.Drawing.Size(25, 25);
            this.btnIrParaCarrinho.Location = new System.Drawing.Point(12, 642);
            this.btnIrParaCarrinho.Name = "btnIrParaCarrinho";
            this.btnIrParaCarrinho.Size = new System.Drawing.Size(329, 55);
            this.btnIrParaCarrinho.TabIndex = 4;
            this.btnIrParaCarrinho.Text = " CONTINUAR COMPRANDO";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 546);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(525, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 709);
            this.panel1.TabIndex = 6;
            // 
            // TelaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTE_GUNA.Properties.Resources._7_Sem_Título_20240714171925__1_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnIrParaCarrinho);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCompras";
            this.Text = "TelaCompras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnIrParaCarrinho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}