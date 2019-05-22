using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Forms.TelaPrincipal
{
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        private void Aluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLIGMADataSet.tbFuncionario' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dbLIGMADataSet.tbAluno' table. You can move, or remove it, as needed.

        }

        private void tbFuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void salarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
