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
            this.Hide();
            var jogoForm = new FormInicio();
            jogoForm.Show();
        }

        private void friendly_Click(object sender, EventArgs e)
        {
            this.Hide();
            var jogoForm = new FormPrincipal();
            jogoForm.Show();
        }
    }
}
