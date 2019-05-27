using LIGMA.Forms.TelaPrincipal;
using LIGMA.Forms.Cadastro;
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
    public partial class Professor : Form
    {
        Form edit = new MudarSenha();
        Form novaAula = new CadastroAula();
        Form login = new frmLogin();

        public Professor()
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

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit.Show();
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.BackColor = Color.MidnightBlue;
            btnEditar.ForeColor = Color.Transparent;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.MidnightBlue;
            btnEditar.BackColor = Color.Transparent;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.Transparent;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.Red;
            btnLogout.BackColor = Color.Transparent;
        }

        private void btnRegistrarAula_Click(object sender, EventArgs e)
        {
            novaAula.Show();
            this.Hide();
        }

        private void btnLancarNota_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você voltará para a tela de Login. Deseja Sair?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }

        private void btnRegistrarAula_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarAula.ForeColor = Color.Transparent;
            btnRegistrarAula.BackColor = Color.Black;
        }

        private void btnRegistrarAula_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarAula.BackColor = Color.Transparent;
            btnRegistrarAula.ForeColor = Color.Black;
        }

    }
}
