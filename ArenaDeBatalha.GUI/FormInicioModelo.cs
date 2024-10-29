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

        private void friendly_Click(object sender, EventArgs e)
        {
            var jogoForm = new FormPrincipal();
            jogoForm.Show();
            this.Hide();

            LimiteDePontuacao.LimitePontuacao = 50;
        }

        private void competitive_Click(object sender, EventArgs e)
        {
            FormPrincipal jogo  = new FormPrincipal();
            jogo.NomeJogador = txtNome.Text;
            jogo.Show();
            this.Hide();

            LimiteDePontuacao.LimitePontuacao = 0;
        }
    }
}
