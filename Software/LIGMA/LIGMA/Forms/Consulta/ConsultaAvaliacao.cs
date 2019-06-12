using LIGMA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIGMA.Forms.Consulta
{
    public partial class ConsultaAvaliacao : Form
    {
        public ConsultaAvaliacao()
        {
            InitializeComponent();
        }

        private void ConsultaAvaliacao_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form prof = new Professor();
            prof.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            CodigosIguais fechar = new CodigosIguais();
            fechar.Fechar();
        }
    }
}
