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
    public partial class TelaCandidato : Form
    {
        public TelaCandidato()
        {
            InitializeComponent();
        }

        Conexao conx = new Conexao();

        private void btnSalvar3_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tb02_candidatos VALUES(" + (int)cbxChapa.SelectedValue + ", '" + txtCargo.Text + "', null, '" + txtNome2.Text + "' " + int.Parse(txtNumero.Text) + " );";
            if (conx.ComandoSql(sql))
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
            txtNumero.Text = null;
            txtNome2.Text = null;
            txtCargo.Text = null;
            cbxChapa.SelectedIndex = -1;
        }

        private void TelaCandidato_Load(object sender, EventArgs e)
        {
            carrega_combobox();
        }

        private void carrega_combobox()
        {
            string sql = "select * from tb04_chapas";
            DataTable dt = new DataTable();
            dt = conx.Retorna(sql);
            cbxChapa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxChapa.DataSource = null;
            cbxChapa.DataSource = dt;
            cbxChapa.ValueMember = "tb04_id_chapa";
            cbxChapa.DisplayMember = "tb04_nome";
            cbxChapa.Update();
        }
    }
}
