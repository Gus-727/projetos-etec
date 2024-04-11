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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private Form tela;

        private void btnEleicoes_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaEleicoes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTelas.Controls.Add(tela);
            tela.Show();
        }

        private void btnChapa_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaChapa
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTelas.Controls.Add(tela);
            tela.Show();
        }
    }
}
