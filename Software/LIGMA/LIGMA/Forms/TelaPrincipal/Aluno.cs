using System;
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
    public partial class Aluno : Form
    {
        
        
        Form login = new frmLogin();

        public Aluno()
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
            Form edit = new EditarAluno();
            edit.Show();
        }

        private void lblPresenca_Click(object sender, EventArgs e)
        {
            //Aqui é um select na tabela aula_aluno calculando a porcentagem de presença do aluno
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Sair?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }

    }
}