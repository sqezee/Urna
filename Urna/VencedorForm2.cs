using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class VencedorForm2 : Form
    {
        public VencedorForm2()
        {
            InitializeComponent();

            lblNomeVencedor.Text = Vencedor.nomeVencedor;
            lblVotosVencedor.Text = Vencedor.votos.ToString();
            lblTotalVotos.Text = Vencedor.totalVotos.ToString();

            double resultado;

            resultado = 100 * Vencedor.votos / Vencedor.totalVotos;  
            lblPorcentagemVotos.Text = resultado.ToString();

            if (Vencedor.nomeVencedor== "Johnny Depp")
            {
                pcbImagem.Image = Properties.Resources.Johnny;
            }

            if (Vencedor.nomeVencedor == "Lauren Findley")
            {
                pcbImagem.Image = Properties.Resources.images;
            }

            if (Vencedor.nomeVencedor == "Bastian Schweinstiger")
            {
                pcbImagem.Image = Properties.Resources.download;
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LblNomeVencedor_Click(object sender, EventArgs e)
        {
            /*Form1 A = new Form1();
            A.bastian;*/

            

        }
    }
}
