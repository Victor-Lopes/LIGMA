using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA
{
    public partial class EsqueceuSenha : Form
    {
        public EsqueceuSenha()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form login = new frmLogin();
            login.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                lblMensagem.ForeColor = Color.Red;
                lblMensagem.Text = "Email Inválido!";
                lblMensagem.Location = new System.Drawing.Point(80, 128);
            }
            else
            {
                lblMensagem.ForeColor = Color.Black;
                lblMensagem.Text = "Sua senha será enviada para esse email.";
                lblMensagem.Location = new System.Drawing.Point(26, 128);
            }
            lblMensagem.Visible = true;
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
    }
}
