namespace TESTE_GUNA.projeto.window
{
    partial class AdmTelaCategoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridViewProdutos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.boxCategoria);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 123);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(630, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 113;
            this.label1.Text = "Selecione a Categoria:";
            // 
            // boxCategoria
            // 
            this.boxCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxCategoria.BackColor = System.Drawing.Color.Transparent;
            this.boxCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.boxCategoria.BorderRadius = 20;
            this.boxCategoria.BorderThickness = 3;
            this.boxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.boxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.boxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.boxCategoria.ItemHeight = 40;
            this.boxCategoria.Items.AddRange(new object[] {
            "ANALGESICO  ",
            "DIABETICOS  ",
            "SUPLEMENTOS E VITAMINAS  ",
            "HIPERTENSAO  ",
            "DERMATOLOGICOS  ",
            "GINECOLOGICOS  ",
            "ANTIVIRAIS E ANTIBIOTICOS  ",
            "ANTINFLAMATORIO"});
            this.boxCategoria.Location = new System.Drawing.Point(635, 71);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(275, 46);
            this.boxCategoria.TabIndex = 112;
            this.boxCategoria.SelectedValueChanged += new System.EventHandler(this.boxCategoria_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::TESTE_GUNA.Properties.Resources.Departamentos__12_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.txtPesquisa.BorderRadius = 20;
            this.txtPesquisa.BorderThickness = 3;
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.DefaultText = "";
            this.txtPesquisa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(69)))));
            this.txtPesquisa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisa.IconLeft = global::TESTE_GUNA.Properties.Resources.Perfil__2_;
            this.txtPesquisa.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPesquisa.IconLeftSize = new System.Drawing.Size(33, 33);
            this.txtPesquisa.Location = new System.Drawing.Point(184, 70);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPesquisa.MaximumSize = new System.Drawing.Size(558, 48);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(69)))));
            this.txtPesquisa.PlaceholderText = "Pesquisar";
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.Size = new System.Drawing.Size(413, 48);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // DataGridViewProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewProdutos.ColumnHeadersHeight = 70;
            this.DataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProdutos.Location = new System.Drawing.Point(0, 123);
            this.DataGridViewProdutos.Name = "DataGridViewProdutos";
            this.DataGridViewProdutos.RowHeadersVisible = false;
            this.DataGridViewProdutos.RowHeadersWidth = 50;
            this.DataGridViewProdutos.RowTemplate.Height = 45;
            this.DataGridViewProdutos.Size = new System.Drawing.Size(1050, 586);
            this.DataGridViewProdutos.TabIndex = 10;
            this.DataGridViewProdutos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProdutos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewProdutos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProdutos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewProdutos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProdutos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProdutos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProdutos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewProdutos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewProdutos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProdutos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewProdutos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewProdutos.ThemeStyle.HeaderStyle.Height = 70;
            this.DataGridViewProdutos.ThemeStyle.ReadOnly = false;
            this.DataGridViewProdutos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProdutos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProdutos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProdutos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewProdutos.ThemeStyle.RowsStyle.Height = 45;
            this.DataGridViewProdutos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewProdutos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProdutos_CellContentClick);
            // 
            // AdmTelaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TESTE_GUNA.Properties.Resources._7_Sem_Título_20240714171925__1_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 709);
            this.Controls.Add(this.DataGridViewProdutos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmTelaCategoria";
            this.Text = "AdmTelaCategoria";
            this.Load += new System.EventHandler(this.AdmTelaCategoria_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2ComboBox boxCategoria;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewProdutos;
    }
}