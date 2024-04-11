
namespace UrnaBD
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnEleitores = new System.Windows.Forms.Button();
            this.btnCandidatos = new System.Windows.Forms.Button();
            this.btnChapa = new System.Windows.Forms.Button();
            this.btnEleicoes = new System.Windows.Forms.Button();
            this.pnlTelas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResultados);
            this.panel1.Controls.Add(this.btnEleitores);
            this.panel1.Controls.Add(this.btnCandidatos);
            this.panel1.Controls.Add(this.btnChapa);
            this.panel1.Controls.Add(this.btnEleicoes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 478);
            this.panel1.TabIndex = 0;
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(22, 389);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(112, 68);
            this.btnResultados.TabIndex = 4;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            // 
            // btnEleitores
            // 
            this.btnEleitores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleitores.Location = new System.Drawing.Point(22, 301);
            this.btnEleitores.Name = "btnEleitores";
            this.btnEleitores.Size = new System.Drawing.Size(112, 68);
            this.btnEleitores.TabIndex = 3;
            this.btnEleitores.Text = "Cadastro de Eleitores";
            this.btnEleitores.UseVisualStyleBackColor = true;
            this.btnEleitores.Click += new System.EventHandler(this.btnEleitores_Click);
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatos.Location = new System.Drawing.Point(22, 211);
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Size = new System.Drawing.Size(112, 68);
            this.btnCandidatos.TabIndex = 2;
            this.btnCandidatos.Text = "Cadastro de Candidatos";
            this.btnCandidatos.UseVisualStyleBackColor = true;
            this.btnCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // btnChapa
            // 
            this.btnChapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChapa.Location = new System.Drawing.Point(22, 120);
            this.btnChapa.Name = "btnChapa";
            this.btnChapa.Size = new System.Drawing.Size(112, 68);
            this.btnChapa.TabIndex = 1;
            this.btnChapa.Text = "Cadastro de Chapa";
            this.btnChapa.UseVisualStyleBackColor = true;
            this.btnChapa.Click += new System.EventHandler(this.btnChapa_Click);
            // 
            // btnEleicoes
            // 
            this.btnEleicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleicoes.Location = new System.Drawing.Point(22, 29);
            this.btnEleicoes.Name = "btnEleicoes";
            this.btnEleicoes.Size = new System.Drawing.Size(112, 68);
            this.btnEleicoes.TabIndex = 0;
            this.btnEleicoes.Text = "Cadastro de Eleições";
            this.btnEleicoes.UseVisualStyleBackColor = true;
            this.btnEleicoes.Click += new System.EventHandler(this.btnEleicoes_Click);
            // 
            // pnlTelas
            // 
            this.pnlTelas.Location = new System.Drawing.Point(181, 12);
            this.pnlTelas.Name = "pnlTelas";
            this.pnlTelas.Size = new System.Drawing.Size(676, 478);
            this.pnlTelas.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 502);
            this.Controls.Add(this.pnlTelas);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnEleitores;
        private System.Windows.Forms.Button btnCandidatos;
        private System.Windows.Forms.Button btnChapa;
        private System.Windows.Forms.Button btnEleicoes;
        private System.Windows.Forms.Panel pnlTelas;
    }
}

