﻿using System;
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
    public partial class TelaDepartamentos : Form
    {
        public TelaDepartamentos()
        {
            InitializeComponent();

            this.DoubleBuffered = true;//parar de travar a tela
        }

        private void TelaDepartamentos_Load(object sender, EventArgs e)
        {

        }
    }
}