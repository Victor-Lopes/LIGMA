using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Classes
{
    class CodigosIguais
    {

    public void Fechar()
        {
            DialogResult result = MessageBox.Show("O programa será fechado. Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                StringConexao con = new StringConexao();
                con.Deslogar();
                Application.Exit();
            }
        }

    
    public void Deslogar(Form esse)
        {
            Form login = new frmLogin();
            DialogResult result = MessageBox.Show("Você voltará para a tela de Login. Deseja Sair?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                StringConexao con = new StringConexao();
                con.Deslogar();

                login.Show();
                esse.Hide();
            }
        }
    }
}
