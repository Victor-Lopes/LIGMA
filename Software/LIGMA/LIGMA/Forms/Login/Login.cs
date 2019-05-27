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
using System.Data.SqlClient;

namespace LIGMA
{

    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(StringConexao.connectionString);
        SqlDataReader reader;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "Email";
            txtLogin.ForeColor = Color.Gray;
            txtSenha.Text = "Senha";
            txtSenha.ForeColor = Color.Gray;
            cmbUsuario.SelectionStart = cmbUsuario.SelectedIndex = 0;
            btnLogin.Focus();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Email")
            {
                txtLogin.Text = "";
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Email";
                txtLogin.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {

            if (txtSenha.Text == "Senha")
             {
                 txtSenha.Text = "";
                 txtSenha.ForeColor = Color.Gray;
             }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }

        Form aluno = new Aluno();
        Form prof = new Professor();
        Form admin = new Administração();
        void LoginSQL()
        {
            using (con)
            {
                try
                {
                    if ((txtLogin.Text == "Email") || (txtSenha.Text == "Senha"))
                    {
                        MessageBox.Show("Digite valores válidos nos campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand scmd = new SqlCommand("sp_logar_usuario", con);
                        scmd.CommandType = CommandType.StoredProcedure;

                        scmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtLogin.Text;
                        scmd.Parameters.Add("@senha_usuario", SqlDbType.NVarChar).Value = txtSenha.Text;
                        con.Open();

                        int a = scmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            if (cmbUsuario.SelectedValue.ToString() == "Aluno") aluno.Show();
                            else if (cmbUsuario.SelectedValue.ToString() == "Professor") prof.Show();
                            else admin.Show();

                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível logar! Verifique o login e a senha.", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginSQL();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.ForeColor = Color.Transparent;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.MidnightBlue;
        }

        private void lnkEsqueceuSenha_MouseEnter(object sender, EventArgs e)
        {
            lnkEsqueceuSenha.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
        }

        private void lnkEsqueceuSenha_MouseLeave(object sender, EventArgs e)
        {
            lnkEsqueceuSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular);
        }

        private void lnkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form esqueci = new EsqueceuSenha();
            esqueci.Show();
            this.Hide();
        }
    }
}
