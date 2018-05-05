using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoGrupoMecanica
{
    class menuCaminhao
    {
        string[] modeloCaminhao = new string[100];
        int[] anoFabricacaoCaminhao = new int[100];
        string[] corCaminhao = new string[100];
        double[] precoCaminhao = new double[100];
        double[] pesoCaminhao = new double[100];
        int[] comportaQuantasPessoasCaminhao = new int[100];
        int atual = 0;
        public void CadastrarCaminhao()
        {
            Console.WriteLine("Cadastramento de caminhão");
            Console.Write("Digite o modelo do caminhao: ");
            modeloCaminhao[atual] = Console.ReadLine();
            Console.Write("Digite o ano de fabricação do caminhao: ");
            anoFabricacaoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a cor do caminhão: ");
            corCaminhao[atual] = Console.ReadLine();
            Console.Write("Digite o preço do caminhão: ");
            precoCaminhao[atual] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso do caminhão: ");
            pesoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite quantos passageiros comporta: ");
            comportaQuantasPessoasCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;
        }
        public void ListarCaminhao()
        {
            Console.Clear();
            Console.WriteLine("Lista de carros: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("\nModelos dos caminhões: {0} \nAnos de Fabricação: {1} \nCores dos caminhão: {2} \nPreço dos caminhões: {3} \nPeso dos caminhões: {4} \nQuantidade de passageiros que comportam dentro do caminhão: {5}", modeloCaminhao[i], anoFabricacaoCaminhao[i], corCaminhao[i], precoCaminhao[i], pesoCaminhao[i], comportaQuantasPessoasCaminhao[i]));
            }
        }

        public void EditarCaminhao()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para pesquisar: ");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == modeloCaminhao[i])
                {
                    posicao = i;
                }
            }
            if (posicao != -1)
            {
                Console.WriteLine("Cadastramento de caminhões");
                Console.Write("Digite o modelo do caminhão: ");
                modeloCaminhao[posicao] = Console.ReadLine();
                Console.Write("Digite o ano de fabricação do caminhão: ");
                anoFabricacaoCaminhao[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a cor do caminhão: ");
                corCaminhao[posicao] = Console.ReadLine();
                Console.Write("Digite o preço do caminhão: ");
                precoCaminhao[posicao] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o peso do caminhão: ");
                pesoCaminhao[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite quantos passageiros comporta: ");
                comportaQuantasPessoasCaminhao[posicao] = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("ERROR 404: Carro não encontrado");
            }
        }

        public void BuscarCaminhao()
        {
            Console.WriteLine("Digite o nome para a busca: ");
            string nomeBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == modeloCaminhao[i])
                {
                    Console.WriteLine(String.Format("\nModelos dos caminhões: {0} \nAnos de Fabricação: {1} \nCores dos caminhões: {2} \nPreço dos caminhões: {3} \nPeso dos caminhões: {4} \nQuantidade de passageiros que comportam dentro do caminhão: {5}", modeloCaminhao[i], anoFabricacaoCaminhao[i], corCaminhao[i], precoCaminhao[i], pesoCaminhao[i], comportaQuantasPessoasCaminhao[i]));
                    break;
                }
                achou = true;
            }
            if (!achou)
            {
                Console.WriteLine("Modelo solicitado não encontrado nos registros");
            }
        }

        public void TotalCaminhao()
        {
            //.Clear();
            //int totalCarros = modeloCarros[atual].Length;


        }

        public void MediaPrecoCaminhao()
        {

        }

        public void MediaAnosCaminhao()
        {

        }

        public void MediaPesosCaminhao()
        {

        }

        public void CaminhaoComMaiorPreco()
        {

        }

        public void CaminhaoMaiorAnoFabricacao()
        {

        }

        public void CaminhaoComMaiorPeso()
        {

        }

        public void CaminhaoComMenorPreco()
        {

        }

        public void CaminhaoComMenorAnoFabricacao()
        {

        }

        public void CaminhaoComMenorPeso()
        {

        }


        public void ApagarMenuCaminhao()
        {
            Console.Clear();
        }
    }
}

 

