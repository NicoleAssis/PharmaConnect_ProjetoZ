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
    public partial class TelaHome : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private int targetWidth;
        public TelaHome()
        {
            InitializeComponent();


            // Inicializa o Timer
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 200; // Intervalo de atualização da animação (em milissegundos)
            animationTimer.Tick += AnimationTimer_Tick;
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

        private void btnSideBarMenu_Click(object sender, EventArgs e)
        {
            // Define a largura alvo baseada na condição atual
            targetWidth = (SideBar.Width == 95) ? 256 : 95;

            // Inicia a animação
            animationTimer.Start();

        }
        #endregion



        private void label2_Click(object sender, EventArgs e)
        {
            // Evento do label, se necessário
        }


        private void TelaHome_Load(object sender, EventArgs e)
        {
            
        }

        private void PrintarTela(Form form)
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

        private void panelAbrirTela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSideBarProdutos_Click(object sender, EventArgs e)
        {
            Teste teste = new Teste();
            PrintarTela(teste);
        }
    }

}
