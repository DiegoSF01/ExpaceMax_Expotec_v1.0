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

        private void play_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a tela de início
            var jogoForm = new FormInicioModelo();
            jogoForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
