using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoGrupoMecanica
{
    class menuCarro
    {
        string[] modeloCarros = new string[100];
        int[] anoFabricacaoCarros = new int[100];
        string[] corCarros = new string[100];
        double[] precoCarros = new double[100];
        double[] pesoCarros = new double[100];
        int[] comportaQuantasPessoas = new int[100];
        int atual = 0;
        public void CadastrarCarro()
        {
            //Console.Clear();
            Console.WriteLine("Cadastramento de carros");
            Console.Write("Digite o modelo do carro: ");
            modeloCarros[atual] = Console.ReadLine();
            Console.Write("Digite o ano de fabricação do carro: ");
            anoFabricacaoCarros[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a cor do carro: ");
            corCarros[atual] = Console.ReadLine();
            Console.Write("Digite o preço do carro: ");
            precoCarros[atual] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso do carro: ");
            pesoCarros[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite quantos passageiros comporta: ");
            comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;
        }
        public void ListarCarros()
        {
            Console.Clear();
            Console.WriteLine("Lista de carros: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("\nModelos dos carros: {0} \nAnos de Fabricação: {1} \nCores dos carros: {2} \nPreço dos carros: {3} \nPeso dos carros: {4} \nQuantidade de passageiros que comportam dentro do carro: {5}",modeloCarros[i], anoFabricacaoCarros[i], corCarros[i], precoCarros[i], pesoCarros[i], comportaQuantasPessoas[i]));
            }
        }

        public void EditarCarro()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para pesquisar: ");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == modeloCarros[i])
                {
                    posicao = i;
                }
            }
            if (posicao != -1)
            {
                Console.WriteLine("Cadastramento de carros");
                Console.Write("Digite o modelo do carro: ");
                modeloCarros[posicao] = Console.ReadLine();
                Console.Write("Digite o ano de fabricação do carro: ");
                anoFabricacaoCarros[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a cor do carro: ");
                corCarros[posicao] = Console.ReadLine();
                Console.Write("Digite o preço do carro: ");
                precoCarros[posicao] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o peso do carro: ");
                pesoCarros[posicao] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite quantos passageiros comporta: ");
                comportaQuantasPessoas[posicao] = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("ERROR 404: Carro não encontrado");
            }
        }

        public void BuscarCarro()
        {
            Console.WriteLine("Digite o nome para a busca: ");
            string nomeBuscado = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBuscado == modeloCarros[i])
                {
                    Console.WriteLine(String.Format("\nModelos dos carros: {0} \nAnos de Fabricação: {1} \nCores dos carros: {2} \nPreço dos carros: {3} \nPeso dos carros: {4} \nQuantidade de passageiros que comportam dentro do carro: {5}", modeloCarros[i], anoFabricacaoCarros[i], corCarros[i], precoCarros[i], pesoCarros[i], comportaQuantasPessoas[i]));
                    break;
                }
                achou = true;
            }
            if (!achou)
            {
                Console.WriteLine("Modelo solicitado não encontrado nos registros");
            } 
        }

        public void TotalCarros()
        {
            
        }

        public void MediaPrecoCarros()
        {
            
        }

        public void MediaAnosCarros()
        {
            
        }

        public void MediaPesosCarros()
        {
            
        }

        public void CarroComMaiorPreco()
        {
            
        }

        public void CarroMaiorAnoFabricacao()
        {
            
        }

        public void CarroComMaiorPeso()
        {
            
        }

        public void CarroComMenorPreco()
        {
            
        }

        public void CarroComMenorAnoFabricacao()
        {
            
        }

        public void CarroComMenorPeso()
        {
            
        }

        public void ApagarMenu()
        {
            Console.Clear();
        }
    }
}
