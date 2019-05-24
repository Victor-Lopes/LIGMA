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

        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            btnVoltar.Font = new Font("Calibri", 9, FontStyle.Underline);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == null) lblMensagem.Text = "Email Inválido!";
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
    }
}
