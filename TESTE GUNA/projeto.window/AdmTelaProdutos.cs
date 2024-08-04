using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;

namespace TESTE_GUNA.projeto.window
{
    public partial class AdmTelaProdutos : Form
    {
        private AdmTelaHome admHome;

        public AdmTelaProdutos(AdmTelaHome home)
        {
            InitializeComponent();
            this.admHome = home;
            this.DoubleBuffered = true;//parar de travar a tela
        }


        #region COLUNAS EDITAR E EXCLUIR NO DATA GRID
        private void AdicionandoColunaExcluir(DataGridView dataGridView)
        {
            // Adicionar coluna de botão para Ação
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            buttonColumn.Name = "Excluir";
            buttonColumn.HeaderText = "Excluir";
            buttonColumn.Width = 90;
            dataGridView.Columns.Add(buttonColumn);

            // Configurar eventos para desenhar o botão e lidar com o clique
            dataGridView.CellPainting += btnExcluirColuna;
        }

        // Desenhar o botão na célula
        private void btnExcluirColuna(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewVendas.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Guna2Button btn = new Guna2Button();


                btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.FillColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 9F);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Image = global::TESTE_GUNA.Properties.Resources.Produtos__7_;
                btn.ImageSize = new System.Drawing.Size(35, 35);
                btn.Location = new System.Drawing.Point(432, 12);
                btn.Name = "btnExcluir";
                btn.Size = new System.Drawing.Size(42, 38);
                btn.TabIndex = 4;


                // Renderizar o botão na célula
                Bitmap bmp = new Bitmap(btn.Width, btn.Height);
                btn.DrawToBitmap(bmp, new Rectangle(0, 0, btn.Width, btn.Height));
                e.Graphics.DrawImage(bmp, e.CellBounds.Left + (e.CellBounds.Width - btn.Width) / 2, e.CellBounds.Top + (e.CellBounds.Height - btn.Height) / 2);

                e.Handled = true;
            }
        }


        private void AdicionandoColunaEditar(DataGridView dataGridView)
        {
            // Adicionar coluna de botão para Ação
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            buttonColumn.Name = "Editar";
            buttonColumn.HeaderText = "Editar";
            buttonColumn.Width = 90;
            dataGridView.Columns.Add(buttonColumn);

            // Configurar eventos para desenhar o botão e lidar com o clique
            dataGridView.CellPainting += btnEditarColuna;
        }

        // Desenhar o botão na célula
        private void btnEditarColuna(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewVendas.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Guna2Button btn = new Guna2Button();


                btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                btn.FillColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 9F);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Image = global::TESTE_GUNA.Properties.Resources.Produtos__8_;
                btn.ImageSize = new System.Drawing.Size(32, 32);
                btn.Location = new System.Drawing.Point(493, 12);
                btn.Name = "btnEditar";
                btn.Size = new System.Drawing.Size(38, 38);
                btn.TabIndex = 5;

                // Renderizar o botão na célula
                Bitmap bmp = new Bitmap(btn.Width, btn.Height);
                btn.DrawToBitmap(bmp, new Rectangle(0, 0, btn.Width, btn.Height));
                e.Graphics.DrawImage(bmp, e.CellBounds.Left + (e.CellBounds.Width - btn.Width) / 2, e.CellBounds.Top + (e.CellBounds.Height - btn.Height) / 2);

                e.Handled = true;
            }
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdmTelaProdutos_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();

           // DataGridViewVendas.DataSource = dao.Teste();

            AdicionandoColunaExcluir(DataGridViewVendas);
            AdicionandoColunaEditar(DataGridViewVendas);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
