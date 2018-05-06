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
            bool validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite o modelo do caminhão: ");
                    modeloCaminhao[atual] = Console.ReadLine();
                    if (modeloCaminhao[atual].Length >= 5)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Nome do caminhão deve conter no mínimo 5 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nome invalido, digite novamente");
                }
            }
            bool validarAnoFabricacao = true;
            while (validarAnoFabricacao == true)
            {
                try
                {
                    Console.Write("Digite o ano de fabricação: ");
                    anoFabricacaoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
                    if (anoFabricacaoCaminhao[atual] >= 0)
                    {
                        validarAnoFabricacao = false;
                    }
                    else
                    {
                        Console.WriteLine("Ano de fabricação invalida");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ano de fabricação deve constar apenas números");
                }
            }
            validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite a cor do caminhão: ");
                    corCaminhao[atual] = Console.ReadLine();
                    validarTexto = false;
                    if (corCaminhao[atual].Length >= 3)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Cor do caminhão deve conter no mínimo 3 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Cor do caminhão invalida, digite novamente");
                }
            }

            bool validarPrecoCaminhao = true;
            while (validarPrecoCaminhao == true)
            {
                try
                {
                    Console.Write("Digite o preço do caminhão: ");
                    precoCaminhao[atual] = Convert.ToDouble(Console.ReadLine());
                    if (precoCaminhao[atual] > 0)
                    {
                        validarPrecoCaminhao = false;
                    }
                    else
                    {
                        Console.WriteLine("Preço menor que zero é inexistente, digite novamente com um preço acima de zero");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Preço invalido, digite novamente");
                }

            }
            bool validarPesoCaminhao = true;
            while (validarPesoCaminhao == true)
            {
                try
                {
                    Console.Write("Digite o peso do caminhão: ");
                    pesoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
                    if (pesoCaminhao[atual] > 0)
                    {
                        validarPesoCaminhao = false;
                    }
                    else
                    {
                        Console.WriteLine("Peso menor que zero é inexistente, digite novamente com um peso acima de zero");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Peso invalido, digite novamente");
                }
            }
            bool validarPassageirosCaminhao = true;
            while (validarPassageirosCaminhao == true)
            {
                try
                {
                    Console.Write("Digite quantos passageiros comporta: ");
                    comportaQuantasPessoasCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
                    if (comportaQuantasPessoasCaminhao[atual] > 0)
                    {
                        validarPassageirosCaminhao = false;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de passageiros menor que zero é inexistente, digite novamente com um peso acima de zero");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                }
            }
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
                bool validarTexto = true;
                while (validarTexto == true)
                {
                    try
                    {
                        Console.Write("Digite o modelo do caminhão: ");
                        modeloCaminhao[atual] = Console.ReadLine();
                        if (modeloCaminhao[atual].Length >= 5)
                        {
                            validarTexto = false;
                        }
                        else
                        {
                            Console.WriteLine("Nome do caminhão deve conter no mínimo 5 caracteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nome invalido, digite novamente");
                    }
                }
                bool validarAnoFabricacao = true;
                while (validarAnoFabricacao == true)
                {
                    try
                    {
                        Console.Write("Digite o ano de fabricação: ");
                        anoFabricacaoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
                        if (anoFabricacaoCaminhao[atual] >= 0)
                        {
                            validarAnoFabricacao = false;
                        }
                        else
                        {
                            Console.WriteLine("Ano de fabricação invalida");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ano de fabricação deve constar apenas números");
                    }
                }
                validarTexto = true;
                while (validarTexto == true)
                {
                    try
                    {
                        Console.Write("Digite a cor do caminhão: ");
                        corCaminhao[atual] = Console.ReadLine();
                        validarTexto = false;
                        if (corCaminhao[atual].Length >= 3)
                        {
                            validarTexto = false;
                        }
                        else
                        {
                            Console.WriteLine("Cor do caminhão deve conter no mínimo 3 caracteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Cor do caminhão invalida, digite novamente");
                    }
                }

                bool validarPrecoCaminhao = true;
                while (validarPrecoCaminhao == true)
                {
                    try
                    {
                        Console.Write("Digite o preço do caminhão: ");
                        precoCaminhao[atual] = Convert.ToDouble(Console.ReadLine());
                        if (precoCaminhao[atual] > 0)
                        {
                            validarPrecoCaminhao = false;
                        }
                        else
                        {
                            Console.WriteLine("Preço menor que zero é inexistente, digite novamente com um preço acima de zero");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Preço invalido, digite novamente");
                    }

                }
                bool validarPesoCaminhao = true;
                while (validarPesoCaminhao == true)
                {
                    try
                    {
                        Console.Write("Digite o peso do caminhão: ");
                        pesoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
                        if (pesoCaminhao[atual] > 0)
                        {
                            validarPesoCaminhao = false;
                        }
                        else
                        {
                            Console.WriteLine("Peso menor que zero é inexistente, digite novamente com um peso acima de zero");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Peso invalido, digite novamente");
                    }
                }
                bool validarPassageirosCaminhao = true;
                while (validarPassageirosCaminhao == true)
                {
                    try
                    {
                        Console.Write("Digite quantos passageiros comporta: ");
                        comportaQuantasPessoasCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
                        if (comportaQuantasPessoasCaminhao[atual] > 0)
                        {
                            validarPassageirosCaminhao = false;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de passageiros menor que zero é inexistente, digite novamente com um peso acima de zero");
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

 

