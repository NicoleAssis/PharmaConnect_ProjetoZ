namespace TESTE_GUNA.projeto.window
{
    partial class TelaMessageBox
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
            this.btnX = new System.Windows.Forms.Button();
            this.btnNao = new Guna.UI2.WinForms.Guna2Button();
            this.btnSim = new Guna.UI2.WinForms.Guna2Button();
            this.txtMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14F);
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(394, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(25, 29);
            this.btnX.TabIndex = 27;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click_1);
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
            this.btnNao.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnNao.ForeColor = System.Drawing.Color.White;
            this.btnNao.Location = new System.Drawing.Point(205, 122);
            this.btnNao.Name = "btnNao";
            this.btnNao.PressedColor = System.Drawing.Color.Indigo;
            this.btnNao.Size = new System.Drawing.Size(114, 45);
            this.btnNao.TabIndex = 25;
            this.btnNao.Text = "Não";
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click_1);
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
            this.btnSim.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnSim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.btnSim.Location = new System.Drawing.Point(85, 122);
            this.btnSim.Name = "btnSim";
            this.btnSim.PressedColor = System.Drawing.Color.Indigo;
            this.btnSim.Size = new System.Drawing.Size(114, 45);
            this.btnSim.TabIndex = 24;
            this.btnSim.Text = "Sim";
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click_1);
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.Transparent;
            this.txtMensagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMensagem.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.txtMensagem.ForeColor = System.Drawing.Color.White;
            this.txtMensagem.Location = new System.Drawing.Point(0, 0);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(405, 99);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.Text = "Mensagem Aqui";
            this.txtMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.btnNao);
            this.panel1.Controls.Add(this.btnSim);
            this.panel1.Controls.Add(this.txtMensagem);
            this.panel1.Location = new System.Drawing.Point(9, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 187);
            this.panel1.TabIndex = 26;
            // 
            // TelaMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(422, 230);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMessageBox";
            this.Load += new System.EventHandler(this.TelaMessageBox_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        public Guna.UI2.WinForms.Guna2Button btnNao;
        public Guna.UI2.WinForms.Guna2Button btnSim;
        private System.Windows.Forms.Label txtMensagem;
        private System.Windows.Forms.Panel panel1;
    }
}