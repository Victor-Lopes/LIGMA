using System;
using LIGMA.Forms.TelaPrincipal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Forms.TelaPrincipal
{
    public partial class MudarSenha : Form
    {
        Form aluno = new Aluno();

        public MudarSenha()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnviar_MouseEnter(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.MidnightBlue;
            btnEnviar.ForeColor = Color.Transparent;
        }

        private void btnEnviar_MouseLeave(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.ForeColor = Color.MidnightBlue;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.MidnightBlue;
            btnCancelar.ForeColor = Color.Transparent;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.ForeColor = Color.MidnightBlue;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
