namespace TESTE_GUNA.projeto.view
{
    partial class FrmMessageBox
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
            this.btnNao = new Guna.UI2.WinForms.Guna2Button();
            this.btnSim = new Guna.UI2.WinForms.Guna2Button();
            this.txtMensagem = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.btnNao);
            this.panel1.Controls.Add(this.btnSim);
            this.panel1.Controls.Add(this.txtMensagem);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 164);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.Transparent;
            this.btnNao.BorderColor = System.Drawing.Color.White;
            this.btnNao.BorderRadius = 20;
            this.btnNao.BorderThickness = 2;
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNao.FillColor = System.Drawing.Color.Transparent;
            this.btnNao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.ForeColor = System.Drawing.Color.White;
            this.btnNao.Location = new System.Drawing.Point(170, 93);
            this.btnNao.Name = "btnNao";
            this.btnNao.PressedColor = System.Drawing.Color.Indigo;
            this.btnNao.Size = new System.Drawing.Size(114, 45);
            this.btnNao.TabIndex = 25;
            this.btnNao.Text = "Não";
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.Transparent;
            this.btnSim.BorderRadius = 20;
            this.btnSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSim.FillColor = System.Drawing.Color.White;
            this.btnSim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.btnSim.Location = new System.Drawing.Point(50, 93);
            this.btnSim.Name = "btnSim";
            this.btnSim.PressedColor = System.Drawing.Color.Indigo;
            this.btnSim.Size = new System.Drawing.Size(114, 45);
            this.btnSim.TabIndex = 24;
            this.btnSim.Text = "Sim";
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.Transparent;
            this.txtMensagem.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.txtMensagem.ForeColor = System.Drawing.Color.White;
            this.txtMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMensagem.Location = new System.Drawing.Point(3, -6);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(333, 90);
            this.txtMensagem.TabIndex = 23;
            this.txtMensagem.Text = "Mensagem Aqui";
            this.txtMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(334, 1);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(25, 29);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(360, 207);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessageBox";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtMensagem;
        public Guna.UI2.WinForms.Guna2Button btnNao;
        public Guna.UI2.WinForms.Guna2Button btnSim;
        private System.Windows.Forms.Button btnX;
    }
}