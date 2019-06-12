using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIGMA.Forms.Cadastro;
using LIGMA.Forms;
using System.Data.SqlClient;
using System.Data;
using LIGMA.Classes;

namespace LIGMA.Forms.TelaPrincipal
{
    public partial class Aluno : Form
    {

        public Aluno()
        {
            InitializeComponent();
        }

        //Barra de Menu

        private void btnFechar_Click(object sender, EventArgs e)
        {

            CodigosIguais fechar = new CodigosIguais();
            fechar.Fechar();
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Componentes

        private void lblPresenca_Click(object sender, EventArgs e)
        {
            //Aqui é um select na tabela aula_aluno calculando a porcentagem de presença do aluno
        }

            //Botão Mudar Senha

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form edit = new MudarSenha();
            edit.Show();
        }

            //Botão LogOut
            
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

            //Botão Solicitar Aula Extra

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

            //DGV Notas

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SE TIVER ALGUM SELECT DE NOTAS DEIXA ISSO VISIVEL
        }

            //DGV Aulas

        private void Aluno_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            try{
                SqlCommand dadosIniciais = new SqlCommand("select Nome from vwAlunoPrincipal ", con);
                SqlCommand presenca = new SqlCommand("spSelectPresenca", con);
                presenca.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                String nome = dadosIniciais.ExecuteScalar().ToString();

                lblNome.Text = "Bem Vindo, " + nome + "!";

                String presencaal = presenca.ExecuteScalar().ToString();
                lblPresenca.Text = "Taxa de presença: " + presencaal;
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source + " " + ex.InnerException, "Erro!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source + " " + ex.InnerException, "Erro!", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
        }
    }
}