using ArenaDeBatalha.ObjetosDoJogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaDeBatalha.GUI
{
    public partial class FormInicioModelo : Form
    {
        public FormInicioModelo()
        {
            InitializeComponent();
        }

        private void retornar_Click(object sender, EventArgs e)
        {
            var jogoForm = new FormInicio();
            jogoForm.Show();
            this.Hide();
        }

        private void FRIENDLY_Click(object sender, EventArgs e)
        {
            var jogoForm = new FormPrincipal();
            jogoForm.Show();
            this.Hide();

            LimiteDePontuacao.LimitePontuacao = 2000;
        }

        private void COMPETITIVE_Click_1(object sender, EventArgs e)
        {
            FormPrincipal jogo = new FormPrincipal();
            jogo.NomeJogador = txtNome.Text;
            jogo.Show();
            this.Hide();

            LimiteDePontuacao.LimitePontuacao = 0;
        }

        private void RETURN_Click(object sender, EventArgs e)
        {
            var jogoForm = new FormInicio();
            jogoForm.Show();
            this.Hide();
        }
    }
}
