using System;
using LIGMA.Forms.TelaPrincipal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace LIGMA.Forms.TelaPrincipal
{
    public partial class MudarSenha : Form
    {
        Form aluno = new Aluno();
        SqlConnection con = new SqlConnection(StringConexao.connectionString);
        SqlDataReader reader;

        public MudarSenha()
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

        private void btnEnviar_MouseEnter(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.MidnightBlue;
            btnEnviar.ForeColor = Color.Transparent;
        }

        private void btnEnviar_MouseLeave(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.Transparent;
            btnEnviar.ForeColor = Color.MidnightBlue;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.MidnightBlue;
            btnCancelar.ForeColor = Color.Transparent;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.ForeColor = Color.MidnightBlue;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using (con)
            {
                try
                {
                    if (txtSenhaNova == txtConfirmar)
                    {
                        SqlCommand scmd = new SqlCommand("sp_logar_usuario", con);
                        scmd.CommandType = CommandType.StoredProcedure;

                        scmd.Parameters.Add("@senhaatual", SqlDbType.NVarChar).Value = txtAtual.Text;
                        scmd.Parameters.Add("@senhanova", SqlDbType.NVarChar).Value = txtSenhaNova.Text;
                        con.Open();

                        int a = scmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            this.Hide();
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("As Senhas Não Batem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }    
        } 
    }
}
