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

            richTextBox1.BackColor = Color.Transparent;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ReadOnly = false;
            richTextBox1.TabStop = false;
        }

        private void retornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var jogoForm = new FormInicio();
            jogoForm.Show();
        }

        private void friendly_Click(object sender, EventArgs e)
        {
            this.Hide();
            var jogoForm = new FormPrincipal();
            jogoForm.Show();

            LimiteDePontuacao.LimitePontuacao = 50;
        }

        private void competitive_Click(object sender, EventArgs e)
        {
            this.Hide();
            var jogoForm = new FormPrincipal();
            jogoForm.Show();

            LimiteDePontuacao.LimitePontuacao = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
