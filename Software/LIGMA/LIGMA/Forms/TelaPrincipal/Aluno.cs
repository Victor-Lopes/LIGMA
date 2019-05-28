using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIGMA.Forms.Cadastro;
using LIGMA.Forms;

namespace LIGMA.Forms.TelaPrincipal
{
    public partial class Aluno : Form
    {
        
        

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
            Form edit = new MudarSenha();
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
            Form login = new frmLogin();
            DialogResult result = MessageBox.Show("Você voltará para a tela de Login. Deseja Sair?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
        }

        private void btnAulaExtra_MouseEnter(object sender, EventArgs e)
        {
            btnAulaExtra.BackColor = Color.MidnightBlue;
            btnAulaExtra.ForeColor = Color.Transparent;
        }

        private void btnAulaExtra_MouseLeave(object sender, EventArgs e)
        {
            btnAulaExtra.ForeColor = Color.MidnightBlue;
            btnAulaExtra.BackColor = Color.Transparent;
        }

        private void btnAulaExtra_Click(object sender, EventArgs e)
        {
            Form aulaextra = new SolicitaçãoAulaExtra();
            aulaextra.Show();
            this.Hide();
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SE TIVER ALGUM SELECT DE NOTAS DEIXA ISSO VISIVEL
        }

        private void Aluno_Load(object sender, EventArgs e)
        {

        }
    }
}