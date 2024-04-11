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
    public partial class TelaChapa : Form
    {
        public TelaChapa()
        {
            InitializeComponent();
        }

        private void TelaChapa_Load(object sender, EventArgs e)
        {
            carrega_combobox();
        }

        Conexao con = new Conexao();

        private void carrega_combobox()
        {
            string sql = "select * from tb01_eleicao";
            DataTable dt = new DataTable();
            dt = con.Retorna(sql);
            cbxEleicao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEleicao.DataSource = null;
            cbxEleicao.DataSource = dt;
            cbxEleicao.ValueMember = "tb01_id_eleicao";
            cbxEleicao.DisplayMember = "tb01_descricao";
            cbxEleicao.Update();
        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tb04_chapas VALUES(null, '" + txtSigla.Text + "', "+ (int)cbxEleicao.SelectedValue + ", '"+ txtNome.Text +"');";
            if (con.ComandoSql(sql))
            {
                MessageBox.Show("Cadstrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um problema!");
            }
            limpar();
        }

        public void limpar()
        {
            txtId2.Text = null;
            txtNome.Text = null;
            txtSigla.Text = null;
            cbxEleicao.SelectedIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tb04_chapas WHERE tb04_id_chapa ="+ txtId2.Text + ";";
            DataTable dt = new DataTable();
            dt = con.Retorna(sql);
            txtNome.Text = dt.Rows[0]["tb04_nome"].ToString();
            txtSigla.Text = dt.Rows[0]["tb04_sigla"].ToString();
            cbxEleicao.SelectedValue = dt.Rows[0]["tb04_id_eleicao"].ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tb04_chapas SET tb04_sigla='" + txtSigla.Text + "', tb04_id_eleicao=" + (int)cbxEleicao.SelectedValue + ", tb04_nome='" + txtNome.Text + "' WHERE tb04_id_chapa=" + txtId2.Text + ";";
            if (con.ComandoSql(sql))
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
            limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tb04_chapas WHERE tb04_id_chapa=" + txtId2.Text + "; ";
            if (con.ComandoSql(sql))
            {
                MessageBox.Show("Exluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
            limpar();
        }
    }
}
