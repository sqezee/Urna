namespace WindowsFormsApp2
{
    partial class VencedorForm2
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
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeVencedor = new System.Windows.Forms.Label();
            this.lblVotosVencedor = new System.Windows.Forms.Label();
            this.lblTotalVotos = new System.Windows.Forms.Label();
            this.lblPorcentagemVotos = new System.Windows.Forms.Label();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(64, 395);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 32);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CANDIDATO VENCEDOR DA ELEIÇÃO";
            // 
            // lblNomeVencedor
            // 
            this.lblNomeVencedor.AutoSize = true;
            this.lblNomeVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNomeVencedor.Location = new System.Drawing.Point(67, 105);
            this.lblNomeVencedor.Name = "lblNomeVencedor";
            this.lblNomeVencedor.Size = new System.Drawing.Size(101, 13);
            this.lblNomeVencedor.TabIndex = 3;
            this.lblNomeVencedor.Text = "Nome do vencedor:";
            this.lblNomeVencedor.Click += new System.EventHandler(this.LblNomeVencedor_Click);
            // 
            // lblVotosVencedor
            // 
            this.lblVotosVencedor.AutoSize = true;
            this.lblVotosVencedor.Location = new System.Drawing.Point(67, 163);
            this.lblVotosVencedor.Name = "lblVotosVencedor";
            this.lblVotosVencedor.Size = new System.Drawing.Size(100, 13);
            this.lblVotosVencedor.TabIndex = 4;
            this.lblVotosVencedor.Text = "Votos do vencedor:";
            // 
            // lblTotalVotos
            // 
            this.lblTotalVotos.AutoSize = true;
            this.lblTotalVotos.Location = new System.Drawing.Point(64, 223);
            this.lblTotalVotos.Name = "lblTotalVotos";
            this.lblTotalVotos.Size = new System.Drawing.Size(75, 13);
            this.lblTotalVotos.TabIndex = 5;
            this.lblTotalVotos.Text = "Total de votos";
            // 
            // lblPorcentagemVotos
            // 
            this.lblPorcentagemVotos.AutoSize = true;
            this.lblPorcentagemVotos.Location = new System.Drawing.Point(67, 293);
            this.lblPorcentagemVotos.Name = "lblPorcentagemVotos";
            this.lblPorcentagemVotos.Size = new System.Drawing.Size(67, 13);
            this.lblPorcentagemVotos.TabIndex = 6;
            this.lblPorcentagemVotos.Text = "% dos votos:";
            // 
            // pcbImagem
            // 
            this.pcbImagem.Location = new System.Drawing.Point(272, 85);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(215, 290);
            this.pcbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbImagem.TabIndex = 0;
            this.pcbImagem.TabStop = false;
            // 
            // VencedorForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.lblPorcentagemVotos);
            this.Controls.Add(this.lblTotalVotos);
            this.Controls.Add(this.lblVotosVencedor);
            this.Controls.Add(this.lblNomeVencedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pcbImagem);
            this.Name = "VencedorForm2";
            this.Text = "VencedorForm2";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeVencedor;
        private System.Windows.Forms.Label lblVotosVencedor;
        private System.Windows.Forms.Label lblTotalVotos;
        private System.Windows.Forms.Label lblPorcentagemVotos;
    }
}