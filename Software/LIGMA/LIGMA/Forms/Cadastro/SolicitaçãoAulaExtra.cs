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
     

        public SolicitaçãoAulaExtra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form aluno = new Aluno();
            if (cmbAulaAvaliacao.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Você retornará a Tela Principal. Deseja mesmo cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

            if (rbtFalta.Checked)
            {
                lblAulaAvaliacao.Text = "Aula Perdida";

                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                SqlCommand cmd = new SqlCommand("SELECT [Codigo], [Aula] from vwAulaAluno where Ativada = 1", con);
                SqlDataReader reader;
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
            
            else if(rbtProvaPerdida.Checked)
            {
                lblAulaAvaliacao.Text = "Avaliação Perdida";

                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                SqlCommand cmd = new SqlCommand("SELECT [Codigo], [Avaliacao] from vwAvaliacaoAluno where Ativada = 1", con);
                SqlDataReader reader;
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
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                SqlCommand cmd = new SqlCommand("sp_deslogar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Application.Exit();

            }
        }

        private void SolicitaçãoAulaExtra_Load(object sender, EventArgs e)
        {
            rbtFalta.Checked = true;
            if (rbtFalta.Checked == true){
                lblAulaAvaliacao.Text = "Aula";
                lblAulaAvaliacao.Enabled = true;
                cmbAulaAvaliacao.Enabled = true;
                rbtProvaPerdida.Checked = false;
            }
            else if(rbtProvaPerdida.Checked == true){
                lblAulaAvaliacao.Text = "Avaliação";
                lblAulaAvaliacao.Enabled = true;
                cmbAulaAvaliacao.Enabled = true;
                rbtFalta.Checked = false;
            }
            else
            {
                lblAulaAvaliacao.Enabled = false;
                cmbAulaAvaliacao.Enabled = false;
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Administração form = new Administração();

            SqlConnection con = new SqlConnection(StringConexao.connectionString);
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("select Aluno from vwNotifAluno	where  Ativada = 1", con);
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
                    string txt = reader["Aluno"].ToString();
                    string aulaav = cmbAulaAvaliacao.SelectedValue.ToString();
                    if (aulaav == "")
                    {
                        MessageBox.Show("Selecione alguma coisa!");
                    }
                    else {
                        form.ckdAulasSolicitas.Items.Add(txt + " - " + aulaav);
                         }
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
            Form aluno = new Aluno();
            this.Hide();
            aluno.Show();
        }

        private void grpMotivo_Enter(object sender, EventArgs e)
        {

        }

        private void rbtProvaPerdida_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFalta.Checked)
            {
                lblAulaAvaliacao.Text = "Aula Perdida";

                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                SqlCommand cmd = new SqlCommand("SELECT [Codigo], [Aula] from vwAulaAluno where Ativada = 1", con);
                SqlDataReader reader;
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
            else if (rbtProvaPerdida.Checked)
            {
                lblAulaAvaliacao.Text = "Avaliação Perdida";

                SqlConnection con = new SqlConnection(StringConexao.connectionString);
                SqlCommand cmd = new SqlCommand("SELECT [Codigo], [Avaliacao] from vwAvaliacaoAluno where Ativada = 1", con);
                SqlDataReader reader;
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
    }
}
