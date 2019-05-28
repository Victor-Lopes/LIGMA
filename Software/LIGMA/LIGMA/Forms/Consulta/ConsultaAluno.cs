using LIGMA.Forms.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Forms.Consulta
{

    public partial class ConsultaAluno : Form
    {
        SqlConnection con = new SqlConnection(StringConexao.connectionString);
        
        public ConsultaAluno()
        {
            InitializeComponent();
        }

        private void btnPgmt_Click(object sender, EventArgs e)
        {
            //colocar como pago
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Form aluno = new CadastroAluno();
            aluno.Show();
            this.Hide();
        }

        private void ConsultaAluno_Load(object sender, EventArgs e)
        {

        SqlCommand scmd = new SqlCommand("Select * from vwAluno", con);
        SqlDataAdapter dataAdapter  = new SqlDataAdapter(scmd);
        DataSet ds  = new DataSet(); 

            con.Open();
            dataAdapter.Fill(ds, "Clientes");
            con.Close();
            dgvAlunos.DataSource = ds.Tables;
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * https://code.msdn.microsoft.com/windowsapps/Realizar-select-e-exibir-8d90084c
             * USAR ESSE CÓDIGO DE EXEMPLO
             * 
             * public class Cliente 
        { 
            public int IdCliente { get; set; } 
            public string Nome { get; set; } 
            public string Email { get; set; } 
            public DateTime DataNascimento { get; set; } 
        } 
 
        private void Form1_Load(object sender, EventArgs e) 
        { 
            CarregaListBox(); 
        } 
 
        private void CarregaListBox() 
        { 
            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Clientes.sdf"); 
 
            //string com o comando a ser executado 
            string sql = "SELECT Nome from Cliente"; 
 
            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn); 
 
            //abro conexão 
            conn.Open(); 
 
            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader(); 
 
            //enquanto leitor lê 
            while (leitor.Read()) 
            { 
                //para cada iteração adiciono o nome 
                //ao listbox 
                listBox1.Items.Add(leitor["Nome"].ToString()); 
            } 
 
            //fecha conexão 
            conn.Close(); 
        } 
 
 
        //método que faz a consulta no bd e obtém o cliente 
        //cujo o nome é informado pelo parâmetro 
        private Cliente ObterClientePorNome(string nome) 
        { 
            //objeto cliente que será retornado pelo método 
            Cliente cliente = new Cliente(); 
 
            //instância da conexão 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Clientes.sdf"); 
 
            //string com o comando a ser executado 
            string sql = "SELECT * from Cliente WHERE Nome=@Nome"; 
 
            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCeCommand cmd = new SqlCeCommand(sql, conn); 
 
            //informo o parâmetro do comando 
            cmd.Parameters.AddWithValue("@Nome", nome); 
 
            //abro conexão 
            conn.Open(); 
 
            //instância do leitor 
            SqlCeDataReader leitor = cmd.ExecuteReader(); 
 
            //enquanto leitor lê 
            while (leitor.Read()) 
            { 
                //passo os valores para o objeto cliente 
                //que será retornado 
                cliente.IdCliente = Convert.ToInt32(leitor["IdCliente"].ToString()); 
                cliente.Nome = leitor["Nome"].ToString(); 
                cliente.Email = leitor["Email"].ToString(); 
                cliente.DataNascimento = Convert.ToDateTime(leitor["DataNascimento"].ToString()); 
            } 
 
            //fecha conexão 
            conn.Close(); 
 
            //Retorno o objeto cliente cujo o  
            //nome é igual ao informado no parâmetro 
            return cliente; 
        } 
 
        //evento mouseclick do listbox 
        private void listBox1_MouseClick(object sender, MouseEventArgs e) 
        { 
            //variável recebe o objeto cliente retornado pelo método 
            Cliente cliente = ObterClientePorNome(listBox1.SelectedItem.ToString()); 
 
            //passo os valores para os textbox 
            txtCodigo.Text = cliente.IdCliente.ToString(); 
            txtNome.Text = cliente.Nome; 
            txtEmail.Text = cliente.Email; 
            txtDataNascimento.Text = cliente.DataNascimento.ToShortDateString(); 
        }*/
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtFinalContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUF_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblComplemento_Click(object sender, EventArgs e)
        {

        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void lblPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblDataNasc_Click(object sender, EventArgs e)
        {

        }

        private void lblRG_Click(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form admin = new Administração();
            admin.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
