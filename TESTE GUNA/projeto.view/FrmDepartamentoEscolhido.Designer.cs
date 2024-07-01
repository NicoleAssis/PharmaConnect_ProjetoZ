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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.panelDep = new System.Windows.Forms.Panel();
            this.dataGridDep = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.White;
            this.lblDepartamento.Location = new System.Drawing.Point(8, 4);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(239, 24);
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
            // panelDep
            // 
            this.panelDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(156)))));
            this.panelDep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDep.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDep.ForeColor = System.Drawing.Color.DarkCyan;
            this.panelDep.Location = new System.Drawing.Point(0, 0);
            this.panelDep.Name = "panelDep";
            this.panelDep.Size = new System.Drawing.Size(777, 35);
            this.panelDep.TabIndex = 32;
            this.panelDep.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDep_Paint);
            // 
            // dataGridDep
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridDep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDep.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDep.ColumnHeadersHeight = 4;
            this.dataGridDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDep.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridDep.Location = new System.Drawing.Point(12, 41);
            this.dataGridDep.Name = "dataGridDep";
            this.dataGridDep.RowHeadersVisible = false;
            this.dataGridDep.Size = new System.Drawing.Size(753, 486);
            this.dataGridDep.TabIndex = 56;
            this.dataGridDep.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridDep.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridDep.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridDep.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridDep.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridDep.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dataGridDep.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridDep.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridDep.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridDep.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDep.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridDep.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridDep.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridDep.ThemeStyle.ReadOnly = false;
            this.dataGridDep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridDep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridDep.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridDep.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridDep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridDep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridDep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDep_CellClick);
            // 
            // FrmDepartamentoEscolhido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 550);
            this.Controls.Add(this.dataGridDep);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.btnX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 0);
            this.Name = "FrmDepartamentoEscolhido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDepartamentoEscolhido";
            this.Load += new System.EventHandler(this.FrmDepartamentoEscolhido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnX;
        public System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Panel panelDep;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridDep;
    }
}