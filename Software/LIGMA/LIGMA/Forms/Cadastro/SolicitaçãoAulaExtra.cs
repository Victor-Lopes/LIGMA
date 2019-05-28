using System;
using LIGMA.Forms.TelaPrincipal ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LIGMA.Forms.Cadastro
{
    public partial class SolicitaçãoAulaExtra : Form
    {
        SqlConnection con = new SqlConnection(StringConexao.connectionString);
        SqlDataReader reader;
        Form aluno = new Aluno();

        public SolicitaçãoAulaExtra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form aluno = new Aluno();
            if (cmbAulaAvaliacao.Text != "")
            {
                DialogResult result = MessageBox.Show("O programa será fechado. Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    aluno.Show();
                    this.Hide();
                }
            }
            else
            {
                aluno.Show();
                this.Hide();
            }
        }

        private void rbtFalta_CheckedChanged(object sender, EventArgs e)
        {
;
            if (rbtFalta.Checked == true)
            {
                lblAulaAvaliacao.Text = "Aula Perdida";

                SqlCommand cmd = new SqlCommand("SELECT CodAula as [Codigo],'Aula do dia: ' +  convert(varchar, Data_Hora, 3) as [Aula] from tbAula", con);
                
                con.Open();
                try
                {
                    reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Codigo", typeof(int));
                    dt.Columns.Add("Aula", typeof(string));
                    dt.Load(reader);

                    cmbAulaAvaliacao.ValueMember = "Codigo";
                    cmbAulaAvaliacao.DisplayMember = "Aula";
                    cmbAulaAvaliacao.DataSource = dt;
                    cmbAulaAvaliacao.SelectedIndex = -1;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
            else
            {
                lblAulaAvaliacao.Text = "Avaliação Perdida";

                SqlCommand cmd = new SqlCommand("SELECT CodAvaliacao as [Codigo], 'Prova do dia: ' + convert(varchar, DataAvaliacao, 3) as [Avaliacao] from tbAvaliacao", con);
                con.Open();
                try
                {
                    reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Codigo", typeof(int));
                    dt.Columns.Add("Avaliacao", typeof(string));
                    dt.Load(reader);

                    cmbAulaAvaliacao.ValueMember = "Codigo";
                    cmbAulaAvaliacao.DisplayMember = "Avaliacao";
                    cmbAulaAvaliacao.DataSource = dt;
                    cmbAulaAvaliacao.SelectedIndex = -1;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("O programa será fechado. Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void SolicitaçãoAulaExtra_Load(object sender, EventArgs e)
        {
            rbtFalta.Checked = true;

            SqlCommand cmd = new SqlCommand("SELECT A.CodAula as [Codigo], CONCAT(Estágio, ', Data: ', convert(varchar, Data, 3), ', Sala: ', [Número da Sala]) as [Aula] from vwListaPresença", con);
            try
            {
                con.Open();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            try
            {
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Codigo", typeof(int));
                dt.Columns.Add("Aula", typeof(string));
                dt.Load(reader);

                cmbAulaAvaliacao.ValueMember = "Codigo";
                cmbAulaAvaliacao.DisplayMember = "Aula";
                cmbAulaAvaliacao.DataSource = dt;
                cmbAulaAvaliacao.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message+"em: "+ex.Source + " "+ex.InnerException);
                this.Hide();
                Form aluno = new Aluno();
                aluno.Show();
            }
            finally
            {
                con.Close();
            }
        }
   

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.MidnightBlue;
            btnCancelar.ForeColor = Color.Transparent;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.MidnightBlue;
            btnCancelar.BackColor = Color.Transparent;
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.MidnightBlue;
            btnEnviar.ForeColor = Color.Transparent;
        }

        private void btnEnviar_MouseLeave(object sender, EventArgs e)
        {
            btnEnviar.ForeColor = Color.MidnightBlue;
            btnEnviar.BackColor = Color.Transparent;
        }

        private Administração form;

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT Nome from tbDadosComuns DC" +
                                            " inner join tbAluno A on A.CodDados = DC.CodDados" +
                                            "inner join tbLogin L on A.CodLogin = L.CodLogin where  ativada = 1", con);
            try
            {
                con.Open();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nome = reader["Nome"].ToString();
                    string ap = cmbAulaAvaliacao.SelectedValue.ToString();
                    form.ckdAulasSolicitas.Items.Add("Aluno: " + nome + " - Prova: " + ap);
                }
                reader.Close();

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

            this.Hide();
            aluno.Show();
        }
    }
}
