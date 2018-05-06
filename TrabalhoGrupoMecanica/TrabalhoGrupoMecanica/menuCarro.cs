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
        double menorPrecoCarro = double.MaxValue;
        double maiorPrecoCarro = 0;
        double menorPesoCarro = double.MaxValue;
        double maiorPesoCarro = double.MinValue;
        int maiorAnoFabricacao = int.MinValue;
        int menorAnoFabricacao = int.MaxValue;
        double somaPrecoCarros = 0;
        double somaPesoCarros = 0;
        int somaAnoFabricacao = 0;
        int atual = 0;
        public void CadastrarCarro()
        {
            Console.Clear();
            Console.WriteLine("Cadastramento de carros");
            bool validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite o modelo do carro: ");
                    modeloCarros[atual] = Console.ReadLine();
                    if (modeloCarros[atual].Length >= 5)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Modelo do carro deve conter no mínimo 5 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Modelo do carro invalido, digite novamente");
                }
            }
            bool validarAnoFabricacao = true;
            while (validarAnoFabricacao == true)
            {
                try
                {
                    Console.Write("Digite o ano de fabricação do carro: ");
                    anoFabricacaoCarros[atual] = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {

                }
            }
            bool validarCor = true;
            while(validarCor == true)
            {
                try
                {
                    Console.Write("Digite a cor do carro: ");
                    corCarros[atual] = Console.ReadLine();
                    if (corCarros[atual].Length >= 5)
                    {
                        validarCor = false;
                    }
                    else
                    {
                        Console.WriteLine("Cor do carro deve conter no mínimo 5 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Cor do carro invalida, digite novamente");
                }
            }
            bool validarPreco = true;
            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Digite o preço do carro: ");
                    precoCarros[atual] = Convert.ToDouble(Console.ReadLine());
                    if (precoCarros[atual] > 0)
                    {
                        validarPreco = false;
                    }
                    else
                    {
                        Console.WriteLine("Preço do carro solicitado é 0 ou menor tornando invalido, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Preço do carro invalido, digite novamente");
                }
            }

            bool validarPeso = true;
            while (validarPeso == true)
            {
                try
                {
                    Console.Write("Digite o peso do carro: ");
                    pesoCarros[atual] = Convert.ToInt32(Console.ReadLine());
                    if (pesoCarros[atual] > 0)
                    {
                        validarPeso = false;
                    }
                    else
                    {
                        Console.WriteLine("Peso invalido, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Peso invalido, digite novamente");
                }
            }
            bool validarQuantidadePassageiros = true;
            while (validarQuantidadePassageiros == true)
            {
                try
                {
                    Console.Write("Digite quantos passageiros comporta: ");
                    comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
                    if (comportaQuantasPessoas[atual] > 0)
                    {
                        validarQuantidadePassageiros = false;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                }
            }
            Console.Clear();
            somaPrecoCarros = somaPrecoCarros + precoCarros[atual];
            somaPesoCarros = somaPesoCarros + pesoCarros[atual];
            somaAnoFabricacao = somaAnoFabricacao + anoFabricacaoCarros[atual];
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
                bool validarTexto = true;
                while (validarTexto == true)
                {
                    try
                    {
                        Console.Write("Digite o modelo do carro: ");
                        modeloCarros[posicao] = Console.ReadLine();
                        if (modeloCarros[posicao].Length >= 5)
                        {
                            validarTexto = false;
                        }
                        else
                        {
                            Console.WriteLine("Modelo do carro deve conter no mínimo 5 caracteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Modelo do carro invalido, digite novamente");
                    }
                }
                bool validarAnoFabricacao = true;
                while (validarAnoFabricacao == true)
                {
                    try
                    {
                        Console.Write("Digite o ano de fabricação do carro: ");
                        anoFabricacaoCarros[atual] = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception)
                    {

                    }
                }
                bool validarCor = true;
                while (validarCor == true)
                {
                    try
                    {
                        Console.Write("Digite a cor do carro: ");
                        corCarros[posicao] = Console.ReadLine();
                        if (corCarros[posicao].Length >= 5)
                        {
                            validarCor = false;
                        }
                        else
                        {
                            Console.WriteLine("Cor do carro deve conter no mínimo 5 caracteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Cor do carro invalida, digite novamente");
                    }
                }
                bool validarPreco = true;
                while (validarPreco == true)
                {
                    try
                    {
                        Console.Write("Digite o preço do carro: ");
                        precoCarros[posicao] = Convert.ToDouble(Console.ReadLine());
                        if (precoCarros[posicao] > 0)
                        {
                            validarPreco = false;
                        }
                        else
                        {
                            Console.WriteLine("Preço do carro solicitado é 0 ou menor tornando invalido, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Preço do carro invalido, digite novamente");
                    }
                }

                bool validarPeso = true;
                while (validarPeso == true)
                {
                    try
                    {
                        Console.Write("Digite o peso do carro: ");
                        pesoCarros[posicao] = Convert.ToInt32(Console.ReadLine());
                        if (pesoCarros[posicao] > 0)
                        {
                            validarPeso = false;
                        }
                        else
                        {
                            Console.WriteLine("Peso invalido, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Peso invalido, digite novamente");
                    }
                }
                bool validarQuantidadePassageiros = true;
                while (validarQuantidadePassageiros == true)
                {
                    try
                    {
                        Console.Write("Digite quantos passageiros comporta: ");
                        comportaQuantasPessoas[posicao] = Convert.ToInt32(Console.ReadLine());
                        if (comportaQuantasPessoas[posicao] > 0)
                        {
                            validarQuantidadePassageiros = false;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                    }
                }
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
            Console.Clear();
            //int totalCarros = modeloCarros[atual].Length;
           // Console.WriteLine("Total de carros " + atual);
            
            
        }

        public void MediaPrecoCarros()
        {
            double mediaPreco = somaPrecoCarros / atual;
            Console.WriteLine("Média de peso dos carros: " + mediaPreco);
        }

        public void MediaAnosCarros()
        {
            int mediaAnosCarros = somaAnoFabricacao / atual;
            Console.WriteLine("Média ano dos carros: " + mediaAnosCarros);
            
        }

        public void MediaPesosCarros()
        {
            double mediaPesosCarros = somaPesoCarros / atual;
            Console.WriteLine("Média peso dos carros: " + mediaPesosCarros);
        }

        public void CarroComMaiorPreco()
        {
            if (precoCarros[atual] > maiorPrecoCarro)
            {
                maiorPrecoCarro = precoCarros[atual];
            }
            Console.WriteLine("Preço do carro mais caro: " + maiorPrecoCarro);
        }

        public void CarroMaiorAnoFabricacao()
        {
            if (anoFabricacaoCarros[atual] > maiorAnoFabricacao)
            {
                maiorAnoFabricacao = anoFabricacaoCarros[atual];
            }
            Console.WriteLine("Ano de fabricação mais recente: " + maiorAnoFabricacao);
        }

        public void CarroComMaiorPeso()
        {
            if (pesoCarros[atual] > maiorPesoCarro)
            {
                maiorPesoCarro = pesoCarros[atual];
            }
            Console.WriteLine("Peso do carro mais pesado: " + maiorPesoCarro);
        }

        public void CarroComMenorPreco()
        {
            if (precoCarros[atual] < menorPrecoCarro)
            {
                menorPrecoCarro = precoCarros[atual];
            }
            Console.WriteLine("Preço do carro mais barato: " + menorPrecoCarro);
        }

        public void CarroComMenorAnoFabricacao()
        {
            if (anoFabricacaoCarros[atual] < menorAnoFabricacao)
            {
                menorAnoFabricacao = anoFabricacaoCarros[atual];
            }
            Console.WriteLine("Maior ano fabricação: " + menorAnoFabricacao);
        }

        public void CarroComMenorPeso()
        {
            if (pesoCarros[atual] < menorPesoCarro)
            {
                menorPrecoCarro = pesoCarros[atual];
            }
            Console.WriteLine("Preço do carro mais barato: " + menorPrecoCarro);
        }

        public void ApagarMenuCarro()
        {
            Console.Clear();
            
        }
    }
}
