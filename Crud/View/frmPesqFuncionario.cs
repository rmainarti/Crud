using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class frmPesqFuncionario : Form
    {
        public frmPesqFuncionario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new frmCadFuncionario();
            frm.ShowDialog();
        }

        private void frmPesqFuncionario_Load(object sender, EventArgs e)
        {
            //trazer do banco os funcionarios cadastrados
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
