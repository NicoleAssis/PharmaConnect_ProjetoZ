using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_GUNA.projeto.dao;
using TESTE_GUNA.projeto.model;

namespace TESTE_GUNA.projeto.view
{
    public partial class FrmDepartamentos : Form
    {
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //fechar o programa
            Environment.Exit(0);
        }


        #region buttonsDoMenu

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMenu telaMenu = new FrmMenu();
            this.Close();
            telaMenu.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras telaCompras = new FrmCompras();
            this.Close();
            telaCompras.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil telaPerfil = new FrmPerfil();
            this.Close();
            telaPerfil.Show();
        }

        #endregion


        #region PictureBoxDepartamentos

        //picBoxDiabeticos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region printarTela
            ProdutoDAO produtoDAO = new ProdutoDAO();
            DataTable produtos = produtoDAO.BuscarProdutosPorDepartamento("Diabéticos");

            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Diabéticos");

            foreach (DataRow row in produtos.Rows)
            {
                Produto produto = new Produto
                {
                    idproduto = Convert.ToInt32(row["ID Produto"]),
                    nomeProduto = row["Nome Produto"].ToString(),
                    descProduto = row["Descrição"].ToString(),
                    precoProduto = Convert.ToDecimal(row["Preço"]),
                    qtdEstoque = Convert.ToInt32(row["Qtd Estoque"]),
                    departamento = row["Departamentos"].ToString()
                };

                
            }

            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel

            // Tornar os itens invisíveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;

            telaDepEscolhido.Show();
            #endregion

        }

        private void picBoxAnal_Click(object sender, EventArgs e)
        {
            #region printarTela
            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Analgésicos");
            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel
            //tornar os itens invisiveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;
            telaDepEscolhido.Show();
            #endregion
        }

        private void picBoxAntidepressivos_Click(object sender, EventArgs e)
        {
            #region printarTela
            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Anti-Inflamátorios");
            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel
            //tornar os itens invisiveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;
            telaDepEscolhido.Show();
            #endregion
        }

        private void picBoxAnativirais_Click(object sender, EventArgs e)
        {
            #region printarTela
            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Antivirais e Antibióticos");
            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel
            //tornar os itens invisiveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;
            telaDepEscolhido.Show();
            #endregion
        }

        private void picBoxDerm_Click(object sender, EventArgs e)
        {
            #region printarTela
            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Dermatológicos");
            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel
            //tornar os itens invisiveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;
            telaDepEscolhido.Show();
            #endregion
        }

        private void picBoxGine_Click(object sender, EventArgs e)
        {
            #region printarTela
            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Ginecológicos");
            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel
            //tornar os itens invisiveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;
            telaDepEscolhido.Show();
            #endregion
        }

        private void picBoxHiper_Click(object sender, EventArgs e)
        {
            #region printarTela
            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Hipertensão");
            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel
            //tornar os itens invisiveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;
            telaDepEscolhido.Show();
            #endregion
        }

        private void picBoxSup_Click(object sender, EventArgs e)
        {
            #region printarTela
            FrmDepartamentoEscolhido telaDepEscolhido = new FrmDepartamentoEscolhido();
            telaDepEscolhido.NomeDepartamento("Suplementos e Vitaminas");
            telaDepEscolhido.TopLevel = false; // Indica que o frmDep não é mais um formulário top-level
            panelPrintarDep.Controls.Add(telaDepEscolhido); // Adiciona o frmDep ao panel
            telaDepEscolhido.Location = new Point(0, 0); // Define a localização dentro do panel
            //tornar os itens invisiveis
            paneiIconDep.Visible = false;
            btnX.Visible = false;
            label1.Visible = false;
            panelDep.Visible = false;
            telaDepEscolhido.Show();
            #endregion
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //volta para a tela e login
            FrmLogin telaLogin = new FrmLogin();
            this.Close();
            telaLogin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
