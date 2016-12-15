using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        enum Opcoes { Pedra, Papel, Tesoura }; //cria enumeracao das opcoes de escolha
        enum Resultado { Jogador, Computador, Empate};//cria enumeracao das opcoes de resultado
        Opcoes jogador = new Opcoes(); // cria variavel opcoes do jogador
        Opcoes computador = new Opcoes(); // cria variavel opcoes do computador
        Random rdm = new Random(); // cria numero aleatorio de 1 a 3 ( 1 Pedra, 2 papel, 3 Tesoura) 
        Resultado ganhador = new Resultado(); // cria variavel opcoes do resultado


        public Form1() // inicializa a janela
        {
            InitializeComponent();
        }

        private void botaoPedra_Click(object sender, EventArgs e) //evento click do botao pedra
        {
            jogador = Opcoes.Pedra; // se o jogador clicar no botao pedra
            escolhaJogador(); // chama a metodo escolha do jogador
            escolhaComputador();// chama a metodo escolha do computador
            verificarGanhador();// chama a metodoo que verifica ganhador
        }

        private void botaoPapel_Click(object sender, EventArgs e) //evento click do botao papel
        {
            jogador = Opcoes.Papel; // se o jogador clicar no botao papel
            escolhaJogador(); // chama a funcao escolha do jogador
            escolhaComputador();// chama a funcao escolha do computador
            verificarGanhador();// chama a metodoo que verifica ganhador
        }

        private void botaoTesoura_Click(object sender, EventArgs e) //evento click do botao tesoura
        {
            jogador = Opcoes.Tesoura; // se o jogador clicar no botao tesoura
            escolhaJogador(); // chama a funcao escolha do jogador 
            escolhaComputador();// chama a funcao escolha do computador
            verificarGanhador();// chama a metodoo que verifica ganhador
        }

        void escolhaJogador() // funcao escolha do jogador
        {
            switch(jogador) 
            {
                case Opcoes.Pedra: // se a escolha do jogador for pedra
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("Pedra.jpg"); //quando jogador escolhe pedra, exibe imagem pedra no grupbox do jogador
                    break;
                case Opcoes.Papel: // se a escolha do jogador for  papel
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("Papel.jpg"); //quando jogador escolhe papel, exibe imagem papel no grupbox do jogador
                    break;
                case Opcoes.Tesoura: // se a escolha do jogador for tesoura
                    imgEscolhaJogador.BackgroundImage = Image.FromFile("Tesoura.jpg"); //quando jogador escolhe papel, exibe imagem tesoura no grupbox do jogador
                    break;
            }
        }

        void escolhaComputador() // funcao escolha do cumputador
        {
            int numero = rdm.Next(1, 4); // chama a funcao que gera o numero aleatorio de 1 a 3

            if (numero == 1 ) // se o numero gerado for 1
            {
                computador = Opcoes.Pedra;// escolha computador = pedra
                imgEscolhaComputador.BackgroundImage = Image.FromFile("Pedra.jpg"); //quando computador escolhe pedra, exibe imagem pedra no grupbox do computador
            }
            else if (numero == 2)// se o numero gerado for 2
            {
                computador = Opcoes.Papel;// escolha computador = papel
                imgEscolhaComputador.BackgroundImage = Image.FromFile("Papel.jpg"); //quando computador escolhe papel, exibe imagem papel no grupbox do computador
            }
            else if (numero == 3)// se o numero gerado for 3
            {
                computador = Opcoes.Tesoura;// escolha computador = tesoura
                imgEscolhaComputador.BackgroundImage = Image.FromFile("Tesoura.jpg"); //quando computador escolhe tesoura, exibe imagem tesoura no grupbox do computador
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void verificarGanhador() //metodoo que verifica o ganhador
        {
            switch(jogador)
            {
                case Opcoes.Pedra: // se jogador escolheu pedra
                    if (computador == Opcoes.Pedra) // computador escolheu pedra
                        ganhador = Resultado.Empate; // empate
                    else if (computador == Opcoes.Papel)// computador escolheu papel
                        ganhador = Resultado.Computador;//Computador ganha
                    else if (computador == Opcoes.Tesoura)// computador escolheu tesoura
                        ganhador = Resultado.Jogador;//jogador ganha
                    break;

                case Opcoes.Papel:// se jogador escolheu Papel 
                    if (computador == Opcoes.Pedra)// computador escolheu pedra
                        ganhador = Resultado.Jogador; //jogador ganha
                    else if (computador == Opcoes.Papel)// computador escolheu papel
                        ganhador = Resultado.Empate;// empate
                    else if (computador == Opcoes.Tesoura)// computador escolheu tesoura
                        ganhador = Resultado.Computador;//Computador ganha
                    break;
                case Opcoes.Tesoura:// se jogador escolheu tesoura
                    if (computador == Opcoes.Pedra)// computador escolheu pedra
                        ganhador = Resultado.Computador;//Computador ganha
                    else if (computador == Opcoes.Papel)// computador escolheu papel
                        ganhador = Resultado.Jogador;//jogador ganha
                    else if (computador == Opcoes.Tesoura)// computador escolheu tesoura
                        ganhador = Resultado.Empate;// empate
                    break;
            }
            
            if (ganhador == Resultado.Jogador)//se jogador ganha
            {
                grupoPlacar.BackColor = Color.Lime; // fundo placar cor verde
                placarJogador.Text = (int.Parse(placarJogador.Text) + 1).ToString(); //soma 1 no placar jogador
            }
            else if (ganhador == Resultado.Computador)//se computador ganha
            {
                grupoPlacar.BackColor = Color.Red; // fundo placar cor vermelho
                placarComputador.Text = (int.Parse(placarJogador.Text) + 1).ToString();//soma 1 no placar computador
            }
           else 
            {
                grupoPlacar.BackColor = Color.Blue;   // se empata fundo placar cor azul  e nao altera placar        
            }
        }
    }
}
