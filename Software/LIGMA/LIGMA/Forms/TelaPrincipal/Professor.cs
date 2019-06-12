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
using LIGMA.Forms.Consulta;
using LIGMA.Classes;

namespace LIGMA
{
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            CodigosIguais fechar = new CodigosIguais();
            fechar.Fechar();
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


        private void btnLancarNota_Click(object sender, EventArgs e)
        {

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
            CodigosIguais deslogar = new CodigosIguais();
            deslogar.Deslogar(this);
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

        private void Professor_Load(object sender, EventArgs e)
        {

        }

        private void pcbFotoAluno_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form prova = new ConsultaAvaliacao();
            prova.Show();
            this.Hide();
        }

        private void btnConultarPagamento_Click(object sender, EventArgs e)
        {
            Form pgmt = new ConsultaPagamento();
            pgmt.Show();
            this.Close();
        }
    }
}
