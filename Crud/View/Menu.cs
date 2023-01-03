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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void addFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var  frm = new frmPesqFuncionario();
            frm.ShowDialog();

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
