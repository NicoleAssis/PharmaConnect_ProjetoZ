namespace TESTE_GUNA.projeto.view
{
    partial class FrmComprasConcluidas
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
            this.panel14 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrollComprasFinalizadas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Controls.Add(this.label1);
            this.panel14.Controls.Add(this.btnX);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel14.Location = new System.Drawing.Point(5, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(384, 48);
            this.panel14.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 74;
            this.label1.Text = "Compras Finalizadas";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.Location = new System.Drawing.Point(356, 3);
            this.btnX.Name = "btnX";
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(28, 29);
            this.btnX.TabIndex = 73;
            this.btnX.Text = "x";
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(144, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 26);
            this.label6.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel3.Location = new System.Drawing.Point(5, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 440);
            this.panel2.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel1.Location = new System.Drawing.Point(389, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 440);
            this.panel1.TabIndex = 85;
            // 
            // scrollComprasFinalizadas
            // 
            this.scrollComprasFinalizadas.AutoScroll = true;
            this.scrollComprasFinalizadas.Location = new System.Drawing.Point(29, 54);
            this.scrollComprasFinalizadas.Margin = new System.Windows.Forms.Padding(40);
            this.scrollComprasFinalizadas.Name = "scrollComprasFinalizadas";
            this.scrollComprasFinalizadas.Size = new System.Drawing.Size(347, 374);
            this.scrollComprasFinalizadas.TabIndex = 88;
            this.scrollComprasFinalizadas.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelCompras_Paint_1);
            // 
            // FrmComprasConcluidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 440);
            this.Controls.Add(this.scrollComprasFinalizadas);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmComprasConcluidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmComprasConcluidas";
            this.Load += new System.EventHandler(this.FrmComprasConcluidas_Load);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel scrollComprasFinalizadas;
    }
}