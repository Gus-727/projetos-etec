using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaBD
{
    public partial class TelaEleicao : Form
    {
        public TelaEleicao()
        {
            InitializeComponent();
        }

        Eleicao eleicao = new Eleicao();
        Conexao conexao = new Conexao();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            eleicao.Data = Convert.ToDateTime(txtData.Text).ToString("yyyy-MM-dd");
            eleicao.Descricao = txtDescricao.Text;
            //eleicao.Id = int.Parse(txtID.Text);
            if (conexao.Cadastra_Eleicao(eleicao))
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            eleicao.Id = int.Parse(txtID.Text);
            eleicao = conexao.Busca_eleicoes(eleicao);
            txtData.Text = Convert.ToDateTime(eleicao.Data).ToString("dd/MM/yyyy");
            txtDescricao.Text = eleicao.Descricao;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            eleicao.Data = Convert.ToDateTime(txtData.Text).ToString("dd/MM/yyyy");
            eleicao.Descricao = txtDescricao.Text;
            eleicao.Id = int.Parse(txtID.Text);
            if (conexao.Atualiza_Eleicao(eleicao))
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }
    }
}
