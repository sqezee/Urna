using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        public int bastian = 0, lauren = 0, johnny = 0, totalvotos = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCorrige_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();
            pcbImage.Image = null;
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente votar nesse candidato ? ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)


            {
                



           


                if (txtNumero1.Text == "0" && txtNumero2.Text == "7")
                {
                    bastian = bastian + 1;
                    totalvotos = totalvotos + 1;

                    MessageBox.Show("Parabéns você votou em Bastian Schweinstiger");
                }

                else if (txtNumero1.Text == "2" && txtNumero2.Text == "4")
                {
                    lauren = lauren + 1;
                    totalvotos = totalvotos + 1;
                     pcbImage.Image = Properties.Resources.Johnny; 
                    txtNome.Text = "Lauren Findley";
                    MessageBox.Show("Parabéns você votou em Lauren Findley");
                }

                else if (txtNumero1.Text == "5" && txtNumero2.Text == "5")
                {
                    johnny = johnny + 1;
                    totalvotos = totalvotos + 1;
                   
                    txtNome.Text = "Johnny Depp";
                    MessageBox.Show("Parabéns você votou em Johnny Depp");
                }

                if (totalvotos == 5)
                {
                   
                    if (bastian > lauren && bastian > johnny)
                    {
                        Vencedor.nomeVencedor = "Bastian Schweinstiger";
                        Vencedor.votos = bastian;
                        Vencedor.totalVotos = totalvotos;
                    }
                    if (lauren > bastian && lauren > johnny)
                    {
                        Vencedor.nomeVencedor = "Lauren Findley";
                        Vencedor.votos = lauren;
                        Vencedor.totalVotos = totalvotos;
                    }
                    if (johnny > lauren && johnny > bastian)
                    {
                        Vencedor.nomeVencedor = "Johnny Depp";
                        Vencedor.votos = johnny;
                        Vencedor.totalVotos = totalvotos;
                    }


                    MessageBox.Show("Eleição Encerrada !!");
                    this.Hide();
                    VencedorForm2 novaform = new VencedorForm2();
                    novaform.ShowDialog();
                }
                
               

            }
               


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
          if(txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "1";
            }
          else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "1";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "2";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "2";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "3";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "3";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "4";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "4";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "5";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "5";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "6";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "6";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "7";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "7";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }

            if (txtNumero1.Text == "0" && txtNumero2.Text == "7")
            {

                pcbImage.Image = Properties.Resources.download;
                txtNome.Text = "Bastian Schweinstiger";

            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "8";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "8";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "9";
            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "9";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            
            if (txtNumero1.Text.Trim().Length == 0)
            {
                txtNumero1.Text = "0";

            }
            else if (txtNumero2.Text.Trim().Length == 0)
            {
                txtNumero2.Text = "0";
            }
            else
            {
                MessageBox.Show("O Candidato já foi selecionado !");

            }

           
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
    

