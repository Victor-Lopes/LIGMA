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
    public partial class ConsultaPagamento : Form
    {
        public ConsultaPagamento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form prof = new Professor();
            prof.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            CodigosIguais fechar = new CodigosIguais();
            fechar.Fechar();
        }
    }
}
