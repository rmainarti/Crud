using Crud.Control;
using Crud.Model;
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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validações
                if (txtNome.Text == "")
                {
                    MessageBox.Show(this, "O nome é obrigatório (OK)"); 
                    // MessageBox.Show("O nome é obrigatório.", "Informação");
                    return;
                }

                if (txtTefelone.Text == "")
                {
                    MessageBox.Show("O telefone é obrigatório.", "Informação");
                    return;
                }

                if (cbxEstado.Text == "")
                {
                    MessageBox.Show("O estado é obrigatório.", "Informação");
                    return;
                }


                //Pegando os valores dos campos da formulário e passando para o objeto
                var funcionario = new Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.Telefone = Convert.ToInt32(txtTefelone.Text);
                funcionario.Estado = cbxEstado.Text;


                //Abrindo conexão com o banco de dados
                using (var ctx = new Contexto())
                {
                    //Add o objeto ao contexto
                    ctx.funcionario.Add(funcionario);
                    //Salvando dados no banco
                    ctx.SaveChanges();
                    txtCodigo.Text = funcionario.FuncionarioId.ToString();
                }


                MessageBox.Show("Dados Salvo com Sucesso","Informação");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
               
            }
            
        }
    }
}
