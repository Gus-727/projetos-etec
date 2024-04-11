using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class TelaNota : Form
    {
        public TelaNota()
        {
            InitializeComponent();
        }

        List<Nota> notas = new List<Nota>();
        int linha = 0;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Nota notta = new Nota(txtNomeA.Text, txtTurma.Text, int.Parse(txtNota1.Text), int.Parse(txtNota2.Text), int.Parse(txtMedia.Text));
            notas.Add(notta);
            dgvAluno.Rows.Add();
            dgvAluno.Rows[linha].Cells[0].Value = notta.Aluno;
            dgvAluno.Rows[linha].Cells[1].Value = notta.Turma;
            dgvAluno.Rows[linha].Cells[2].Value = notta.Nota1;
            dgvAluno.Rows[linha].Cells[3].Value = notta.Nota2;
            dgvAluno.Rows[linha].Cells[4].Value = notta.Media;
            linha++;

            MessageBox.Show("Cadastrado com sucesso!");
            limpar();
        }

        public void limpar()
        {
            txtNomeA.Text = null;
            txtTurma.Text = null;
            txtNota1.Text = null;
            txtNota2.Text = null;
            txtMedia.Text = null;

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int status = 0;
            for(int i = 0; i < notas.Count; i++)
            {
                if (notas[i].Aluno == txtNomeA.Text)
                {
                    txtTurma.Text = notas[i].Turma;
                    txtNota1.Text = notas[i].Nota1.ToString();
                    txtNota2.Text = notas[i].Nota2.ToString();
                    txtMedia.Text = notas[i].Media.ToString();
                    status = 1;
                }
            }
            if (status == 0)
            {
                limpar();
                MessageBox.Show("Aluno não cadastrado!");
            }
        }
    }
}
