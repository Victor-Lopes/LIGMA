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
using LIGMA.Forms.Consulta;

namespace LIGMA.Forms.Cadastro
{
    public partial class CadastroAluno : Form
    {

        Form aluno = new Aluno();

        public CadastroAluno()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form aluno = new ConsultaAluno();
            aluno.Show();
            this.Hide(); 
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                { 
                    var resultado = ws.consultaCEP(txtCEP.Text);
                    txtEndereco.Text = resultado.end;
                    txtCidade.Text = resultado.cidade;
                    txtBairro.Text = resultado.bairro;
                    cmbUF.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
 
        }
    }
}
