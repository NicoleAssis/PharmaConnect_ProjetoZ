namespace TESTE_GUNA.projeto.view
{
    partial class FrmPagFinalizar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEfetuarPagamento = new Guna.UI2.WinForms.Guna2Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridCarrinho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.Location = new System.Drawing.Point(389, 3);
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
            this.label6.Location = new System.Drawing.Point(95, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 26);
            this.label6.TabIndex = 39;
            this.label6.Text = "Finalizar Pagamento";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Controls.Add(this.btnX);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(420, 48);
            this.panel14.TabIndex = 87;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel3.Location = new System.Drawing.Point(0, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 5);
            this.panel3.TabIndex = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel2.Location = new System.Drawing.Point(0, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 401);
            this.panel2.TabIndex = 89;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(106)))), ((int)(((byte)(110)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel1.Location = new System.Drawing.Point(420, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 379);
            this.panel1.TabIndex = 88;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.DarkCyan;
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel16.Controls.Add(this.label8);
            this.panel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel16.Location = new System.Drawing.Point(79, 286);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(110, 27);
            this.panel16.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "TOTAL";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel19.Controls.Add(this.lblTotal);
            this.panel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.panel19.Location = new System.Drawing.Point(191, 286);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(155, 27);
            this.panel19.TabIndex = 101;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Teal;
            this.lblTotal.Location = new System.Drawing.Point(52, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 21);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "RS: 35,00";
            // 
            // btnEfetuarPagamento
            // 
            this.btnEfetuarPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEfetuarPagamento.BorderRadius = 20;
            this.btnEfetuarPagamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEfetuarPagamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEfetuarPagamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEfetuarPagamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEfetuarPagamento.FillColor = System.Drawing.Color.Teal;
            this.btnEfetuarPagamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarPagamento.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEfetuarPagamento.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEfetuarPagamento.Image = global::TESTE_GUNA.Properties.Resources.iconDinheiro2;
            this.btnEfetuarPagamento.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEfetuarPagamento.Location = new System.Drawing.Point(95, 329);
            this.btnEfetuarPagamento.Name = "btnEfetuarPagamento";
            this.btnEfetuarPagamento.Size = new System.Drawing.Size(234, 38);
            this.btnEfetuarPagamento.TabIndex = 91;
            this.btnEfetuarPagamento.Text = "EFETUAR PAGAMENTO";
            this.btnEfetuarPagamento.Click += new System.EventHandler(this.btnSalvarAlteracoes_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridCarrinho
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridCarrinho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCarrinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCarrinho.ColumnHeadersHeight = 4;
            this.dataGridCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCarrinho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCarrinho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridCarrinho.Location = new System.Drawing.Point(12, 54);
            this.dataGridCarrinho.Name = "dataGridCarrinho";
            this.dataGridCarrinho.RowHeadersVisible = false;
            this.dataGridCarrinho.RowTemplate.Height = 50;
            this.dataGridCarrinho.Size = new System.Drawing.Size(401, 219);
            this.dataGridCarrinho.TabIndex = 102;
            this.dataGridCarrinho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCarrinho.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridCarrinho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridCarrinho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridCarrinho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridCarrinho.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCarrinho.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridCarrinho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridCarrinho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCarrinho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridCarrinho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridCarrinho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridCarrinho.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridCarrinho.ThemeStyle.ReadOnly = false;
            this.dataGridCarrinho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCarrinho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCarrinho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridCarrinho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridCarrinho.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridCarrinho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridCarrinho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FrmPagFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(425, 379);
            this.Controls.Add(this.dataGridCarrinho);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.btnEfetuarPagamento);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagFinalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagFinalizar";
            this.Load += new System.EventHandler(this.FrmPagFinalizar_Load);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnEfetuarPagamento;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblTotal;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridCarrinho;
    }
}