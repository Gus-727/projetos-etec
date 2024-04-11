using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_BD
{
    public partial class TelaEleicoes : Form
    {
        public TelaEleicoes()
        {
            InitializeComponent();
        }

        Eleicoes eleicoes = new Eleicoes();
        Conexao conexao = new Conexao();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                eleicoes.Data = Convert.ToDateTime(txtData.Text);
                eleicoes.Descricao = txtDescricao.Text;
                if (conexao.Cadastra_Eleicao(eleicoes))
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro!");
                }
            } else
            {
                eleicoes.Id = int.Parse(txtId.Text);
            }
            
        }
    }
}
