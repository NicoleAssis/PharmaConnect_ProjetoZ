using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmComprasConcluidas : Form
    {
        public FrmComprasConcluidas()
        {
            InitializeComponent();
        }

        #region FunçãoPrintarCompras

        //PRINTAR COMPRAS
        public void PrintarCompra(string dataDaCompra, int qntProdutos)
        {
            // Criando o panel
            Panel panel = new Panel();
            panel.Size = new Size(320, 190);
            panel.BackColor = Color.LightCyan;
            // Adicione o Panel ao FlowLayoutPanel
            scrollComprasFinalizadas.Controls.Add(panel);

            // Criando a label
            Label label = new Label();
            label.Text = dataDaCompra;
            label.AutoSize = false;// Defina AutoSize como false para que o Label possa ser redimensionado
            label.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            label.ForeColor = Color.DarkCyan;
            label.Height = 30;       
            label.TextAlign = ContentAlignment.MiddleCenter; 
            label.BackColor = Color.LightCyan; 
            label.Dock = DockStyle.Top;
            // Adicione o label ao panel
            panel.Controls.Add(label);

            // Criando o FlowLayoutPanel
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Size = new Size(320, 180);
            flowLayoutPanel.BackColor = Color.LightCyan;
            flowLayoutPanel.AutoScroll = true;
            //panel para adicionar margem pq estava travado
              Panel panelMargin = new Panel();
              panelMargin.Size = new Size(287, 30);
              panelMargin.BackColor = Color.LightCyan;
              flowLayoutPanel.Controls.Add(panelMargin);
            panel.Controls.Add(flowLayoutPanel);

            //for para printar o user control na qnt de produtos comprados
            for(int i = 0; i < qntProdutos; i++)
            {
                UserControlPagItensEscolhidos itensUserControl = new UserControlPagItensEscolhidos();
                flowLayoutPanel.Controls.Add(itensUserControl);
            }

        }

        #endregion

        private void btnX_Click(object sender, EventArgs e)
        {
            //button fechar a tela de pagamento
            this.Close();
        }

        private void flowPanelCompras_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FrmComprasConcluidas_Load(object sender, EventArgs e)
        {
            //chama a classe que printa as compras ja feitas
                          //data       //qtd de produtos comprados
            PrintarCompra("27/08/2024", 3);
            PrintarCompra("28/08/2024", 4);
            PrintarCompra("29/08/2024", 1);
        }
    }
}
