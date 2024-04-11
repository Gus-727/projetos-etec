using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtd1.Enabled = false;
            txtd2.Enabled = false;
            txtd3.Enabled = false;
            btnConfirma.Enabled = false;
            pnlMensagem.Visible = false;
            lblfim.Visible = false;
            insereCandidato();
        }

        string numero = "";
        Candidato alguem;
        List<Candidato> lista = new List<Candidato>();
        int valido, branco = 0, nulo = 0, eleitores = 0;

        private void insereCandidato()
        {
            alguem = new Candidato("475", "Antonio Silva", "Raio", "Antonio.jpg", 0);
            lista.Add(alguem);
            alguem = new Candidato("990", "Frederico Lima", "Nuvem", "Frederico.jpg", 0);
            lista.Add(alguem);
            alguem = new Candidato("223", "Joana Ferreira", "Sol", "Joana.jpg", 0);
            lista.Add(alguem);
            alguem = new Candidato("535", "Vivian Almeida", "Arco-Íris", "Vivian.jpg", 0);
            lista.Add(alguem);

        }

        private void preenche(string n)
        {
            SoundPlayer som = new SoundPlayer(@"A:\Etec 2º DS\D.S\Projetos VS\Telas\Urna-eletronica\Som\Tecla.wav");
            som.Play();


            if (numero.Length == 0)
            {
                txtd1.Text = n;
            }
            if (numero.Length == 1)
            {
                txtd2.Text = n;
            }
            if (numero.Length == 2)
            {
                txtd3.Text = n;
            }
            numero += n;
            if (numero.Length == 3)
            {
                valido = 0;
                for (int i=0; i < lista.Count; i++)
                {
                    if (numero == lista[i].Numero)
                    {
                        pbxFoto.Image = System.Drawing.Image.FromFile(@"A:\Etec 2º DS\D.S\Projetos VS\Telas\Urna-eletronica\Imagem\" + lista[i].Imagem);
                        lblPresidente.Text = "PRESIDENTE DA CHAPA:  " + lista[i].Nome;
                        lblChapa.Text = "CHAPA:  " + lista[i].Chapa;
                        pnlMensagem.Visible = true;
                        valido = 1;
                    }
                }
                if (valido == 0)
                {
                    lblPresidente.Text = "VOTO NULO";
                    pnlMensagem.Visible = true;
                }
                btnConfirma.Enabled = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            preenche("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            preenche("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            preenche("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            preenche("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            preenche("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            preenche("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            preenche("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            preenche("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            preenche("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            preenche("0");
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtd1.Text = null;
            txtd2.Text = null;
            txtd3.Text = null;
            pbxFoto.Image = null;
            pnlMensagem.Visible = false;
            numero = "";
            lblChapa.Text = null;
            lblPresidente.Text = null;
            btnConfirma.Enabled = false;
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            numero = "branco";
            pnlMensagem.Visible = true;
            btnConfirma.Enabled = true;
            lblPresidente.Text = "VOTO EM BRANCO!";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            eleitores++;
            SoundPlayer som = new SoundPlayer(@"A:\Etec 2º DS\D.S\Projetos VS\Telas\Urna-eletronica\Som\urna.wav");
            som.Play();
            if (numero == "branco")
            {
                branco++;
            } else {
                valido = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (numero == lista[i].Numero)
                    {
                        lista[i].Voto++;
                        valido = 1;
                    }
                }
                if (valido == 0)
                {
                    nulo++;
                }
            }
            btnCorrige_Click(sender, e);
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtd1.Visible = false;
            txtd2.Visible = false;
            txtd3.Visible = false;
            lblfim.Visible = true;

            Thread.Sleep(5000);

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtd1.Visible = true;
            txtd2.Visible = true;
            txtd3.Visible = true;
            lblfim.Visible = false;

            if (eleitores == 4)
            {
                Document doc = new Document(PageSize.A4);
                doc.SetMargins(80, 80, 80, 80);
                string caminho = @"A:\Etec 2º DS\D.S\Projetos VS\Telas\Urna-eletronica\resultado.pdf";
                PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.Open();

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"A:\Etec 2º DS\D.S\Projetos VS\Telas\Urna-eletronica\Imagem\logo-etec.png");
                img.Alignment = Element.ALIGN_CENTER;
                img.ScaleAbsolute(300, 100);
                doc.Add(img);

                Paragraph titulo = new Paragraph();
                titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN);
                titulo.Font.Size = 18;
                titulo.Alignment = Element.ALIGN_CENTER;
                string txtTitulo = "Resultado da eleição para o Grêmio Estudantil\n\nEtec 2021\n";
                titulo.Add(txtTitulo);
                doc.Add(titulo);

                Paragraph conteudo = new Paragraph();
                conteudo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16);
                string texto = "";
                for (int i = 0; i < lista.Count; i++)
                {
                    texto += "\n" + lista[i].Numero + " - " + lista[i].Chapa + "=" + lista[i].Voto + "\n";
                }
                texto += "\nBranco= " + branco + "\n\n" + "Nulo= " + nulo + "\n";
                conteudo.Add(texto);
                doc.Add(conteudo);
                doc.Close();
            }
        }

    }
}
