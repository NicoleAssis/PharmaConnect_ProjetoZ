using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.projeto.window
{
    public partial class AdmTelaHome : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private int targetWidth;
        public AdmTelaHome()
        {
            InitializeComponent();

            #region animacaoSideBar
            // Inicializa o Timer
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 200; // Intervalo de atualização da animação (em milissegundos)
            animationTimer.Tick += AnimationTimer_Tick;
            #endregion


            this.DoubleBuffered = true;//parar de travar a tela
        }

        #region ANIMACAO side bar
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            SideBar.BringToFront();
            // Calcula a direção da animação (aumentar ou diminuir a largura)
            int change = (targetWidth > SideBar.Width) ? 20 : -20;

            // Atualiza a largura da SideBar com o passo de animação
            SideBar.Width += change * 50; // Ajuste o valor do incremento conforme necessário

            // Verifica se a animação deve parar
            if ((change == 20 && SideBar.Width >= targetWidth) || (change == -20 && SideBar.Width <= targetWidth))
            {
                animationTimer.Stop();
                SideBar.Width = targetWidth; // Garante que a largura seja exatamente a largura alvo no final da animação
            }
        }

        #endregion

        #region Barra de menos, tela cheia e fechar
        private void btnBarraMeno_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBarraTelaCheia_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                bool sideBar = true;
                if (SideBar.Width == 95)
                {
                    sideBar = true;
                }
                else
                {
                    sideBar = false;
                }

                this.WindowState = FormWindowState.Normal;
                panelAbrirTela.Size = new Size(1050, 709);

                if (sideBar = true)
                {
                    SideBar.Width = 95;
                }
                else
                {
                    SideBar.Width = 256;
                }
            }
            else
            {
                bool sideBar = true;
                if (SideBar.Width == 95)
                {
                    sideBar = true;
                }
                else
                {
                    sideBar = false;
                }

                panelAbrirTela.Size = new Size(1338, 858);
                this.WindowState = FormWindowState.Maximized;

                if (sideBar = true)
                {
                    SideBar.Width = 95;
                }
                else
                {
                    SideBar.Width = 256;
                }
            }
        }

        private void btnBarraX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region PrintarTela

        public void PrintarTela(Form form)
        {
            if (this.panelAbrirTela.Controls.Count > 0)
                this.panelAbrirTela.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelAbrirTela.Controls.Add(form);
            this.panelAbrirTela.Tag = form;
            form.Show();
        }

        public void PrintarTelaForaDaHome(Form form)
        {
            PrintarTela(form);
            form.BringToFront();
        }

        public void ReiniciarHome()
        {
            if (this.panelAbrirTela.Controls.Count > 0)
                this.panelAbrirTela.Controls.RemoveAt(0);
        }












        #endregion

        private void btnSideBarMenu_Click(object sender, EventArgs e)
        {
            SideBar.BringToFront();
            // Define a largura alvo baseada na condição atual
            targetWidth = (SideBar.Width == 95) ? 282 : 95;

            // Inicia a animação
            animationTimer.Start();
        }

        private void btnSideBarVendas_Click(object sender, EventArgs e)
        {
            AdmTelaVendas tela = new AdmTelaVendas(this);
            PrintarTela(tela);
            tela.BringToFront();
        }

        private void btnSideBarProdutos_Click(object sender, EventArgs e)
        {
            AdmTelaProdutos tela = new AdmTelaProdutos(this);
            PrintarTela(tela);
            tela.BringToFront();
        }
    }
}
