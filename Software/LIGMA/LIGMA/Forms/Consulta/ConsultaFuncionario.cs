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

namespace LIGMA.Forms.Consulta
{
    public partial class ConsultaFuncionario : Form
    {
        public ConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ABRIR CADASTRO DE PROFESSOR
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblIdioma_Click(object sender, EventArgs e)
        {

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form admin = new Administração();
            admin.Show();
            this.Close();
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            Form nf = new CadastroFuncionario();
            nf.Show();
            this.Hide();
        }
    }
}
