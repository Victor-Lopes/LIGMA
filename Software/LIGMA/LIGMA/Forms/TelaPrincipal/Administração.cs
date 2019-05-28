using LIGMA.Forms.Consulta;
using LIGMA.Forms.TelaPrincipal;
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
    public partial class Administração : Form
    {
        Form edit = new MudarSenha();

        public Administração()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edit.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form consaluno = new ConsultaAluno();
            consaluno.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form consprof = new ConsultaFuncionario();
            consprof.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin();
            DialogResult result = MessageBox.Show("Você voltará para a tela de Login. Deseja Sair?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form turma = new ConsultaTurma();
            turma.Show();
            this.Hide();
        }
    }
}
