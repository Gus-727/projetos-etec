
namespace Urna_BD
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResultados = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnCandidatos);
            this.panel1.Controls.Add(this.btnChapa);
            this.panel1.Controls.Add(this.btnEleicoes);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 715);
            this.panel1.TabIndex = 0;
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(9, 561);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(151, 100);
            this.btnResultados.TabIndex = 3;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatos.Location = new System.Drawing.Point(9, 376);
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Size = new System.Drawing.Size(151, 100);
            this.btnCandidatos.TabIndex = 2;
            this.btnCandidatos.Text = "Cadastrar Candidatos";
            this.btnCandidatos.UseVisualStyleBackColor = true;
            // 
            // btnChapa
            // 
            this.btnChapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChapa.Location = new System.Drawing.Point(6, 208);
            this.btnChapa.Name = "btnChapa";
            this.btnChapa.Size = new System.Drawing.Size(151, 100);
            this.btnChapa.TabIndex = 1;
            this.btnChapa.Text = "Cadastrar Chapa";
            this.btnChapa.UseVisualStyleBackColor = true;
            this.btnChapa.Click += new System.EventHandler(this.btnChapa_Click);
            // 
            // btnEleicoes
            // 
            this.btnEleicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleicoes.Location = new System.Drawing.Point(9, 24);
            this.btnEleicoes.Name = "btnEleicoes";
            this.btnEleicoes.Size = new System.Drawing.Size(151, 100);
            this.btnEleicoes.TabIndex = 0;
            this.btnEleicoes.Text = "Cadastrar Eleições";
            this.btnEleicoes.UseVisualStyleBackColor = true;
            this.btnEleicoes.Click += new System.EventHandler(this.btnEleicoes_Click);
            // 
            // pnlTelas
            // 
            this.pnlTelas.Location = new System.Drawing.Point(200, 15);
            this.pnlTelas.Name = "pnlTelas";
            this.pnlTelas.Size = new System.Drawing.Size(954, 714);
            this.pnlTelas.TabIndex = 1;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 746);
            this.Controls.Add(this.pnlTelas);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnCandidatos;
        private System.Windows.Forms.Button btnChapa;
        private System.Windows.Forms.Button btnEleicoes;
        private System.Windows.Forms.Panel pnlTelas;
    }
}