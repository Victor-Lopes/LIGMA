using LIGMA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Forms.Cadastro
{
    public partial class CadastroAula : Form
    {
        public CadastroAula()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            CodigosIguais fechar = new CodigosIguais();
            fechar.Fechar();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Enviar Formulário aqui
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form p = new Professor();
            p.Show();
            this.Hide();
        }
    }
}
