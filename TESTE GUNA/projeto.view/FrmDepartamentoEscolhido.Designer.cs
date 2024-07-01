namespace TESTE_GUNA.projeto.view
{
    partial class FrmDepartamentoEscolhido
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
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlProduto1 = new TESTE_GUNA.projeto.view.UserControlProduto();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.lblDepartamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.White;
            this.lblDepartamento.Location = new System.Drawing.Point(8, 4);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(238, 23);
            this.lblDepartamento.TabIndex = 1;
            this.lblDepartamento.Text = "Departamento Escolhido";
            this.lblDepartamento.Click += new System.EventHandler(this.lblDepartamento_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.Location = new System.Drawing.Point(1271, -2);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(28, 29);
            this.btnX.TabIndex = 21;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.userControlProduto1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1031, 529);
            this.flowLayoutPanel1.TabIndex = 22;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // userControlProduto1
            // 
            this.userControlProduto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.userControlProduto1.Dep = null;
            this.userControlProduto1.Desc = null;
            this.userControlProduto1.Location = new System.Drawing.Point(5, 5);
            this.userControlProduto1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlProduto1.Name = "userControlProduto1";
            this.userControlProduto1.NomeProduto = null;
            this.userControlProduto1.Preco = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.userControlProduto1.Size = new System.Drawing.Size(329, 149);
            this.userControlProduto1.TabIndex = 0;
            this.userControlProduto1.Load += new System.EventHandler(this.userControlProduto1_Load_2);
            // 
            // FrmDepartamentoEscolhido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 629);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.btnX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 0);
            this.Name = "FrmDepartamentoEscolhido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDepartamentoEscolhido";
            this.Load += new System.EventHandler(this.FrmDepartamentoEscolhido_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnX;
        public System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControlProduto userControlProduto1;
    }
}