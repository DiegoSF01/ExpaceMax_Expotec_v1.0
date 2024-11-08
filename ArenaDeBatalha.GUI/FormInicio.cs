using MySql.Data.MySqlClient;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

            if (this.BackgroundImage != null)
            {
                this.ClientSize = this.BackgroundImage.Size;
            }
        }

        private void CLASSIFICACAO_Click_1(object sender, EventArgs e)
        {
            var jogoForm = new FormClassificacao();
            jogoForm.Show();
            this.Hide();
        }

        private void PLAY_Click_1(object sender, EventArgs e)
        {
            FormInicioModelo inicioModelo = new FormInicioModelo();
            inicioModelo.Show();
            this.Hide();
        }

        private void EXIT_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
