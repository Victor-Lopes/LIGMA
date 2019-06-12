using LIGMA.Classes;
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
    public partial class ConsultaTurma : Form
    {
        public ConsultaTurma()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaTurma_Load(object sender, EventArgs e)
        {

        }

        private void cmbEstagio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEstagio_Click(object sender, EventArgs e)
        {

        }

        private void cmbProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProfessor_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCurso_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Form nt = new CadastroTurma();
            nt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form at = new AlunosTurma();
            at.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            CodigosIguais fechar = new CodigosIguais();
            fechar.Fechar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form admin = new Administração();
            admin.Show();
            this.Hide();
        }
    }
}
