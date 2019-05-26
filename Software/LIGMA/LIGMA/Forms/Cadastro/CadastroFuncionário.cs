using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Forms.Cadastro
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
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

        private void cmbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFuncao.SelectedValue.ToString() == "Professor")
            {
                lblIdioma.Visible = true;
                cmbIdioma.Visible = true;
            }
            else{
                lblIdioma.Visible = false;
                cmbIdioma.Visible = false;
            }
        }
    }
}
