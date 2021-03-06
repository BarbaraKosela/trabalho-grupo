﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoGrupoMecanica
{
    class menuBicicleta
    {
        string[] modeloBicicleta = new string[100];
        string[] corBicicleta = new string[100];
        double[] precoBicicleta = new double[100];
        double[] pesoBicicleta = new double[100];
        int[] comportaQuantasPessoas = new int[100];
        int[] anoBicicleta = new int[100];
        double bicicletaMaiorPeso = double.MinValue;
        double bicicletaMenorPeso = double.MaxValue;
        int bicicletaMenorAnoFabricacao = int.MinValue;
        int bicicletaMaiorAnoFabricacao = int.MaxValue;
        double bicicletaMaiorPreco = double.MinValue;
        double bicicletaMenorPreco = double.MaxValue;
        int atual = 0;
        double somaValorBicicletas = 0;
        double somaPesoBicicletas = 0;
        int somaAnoFabricacao = 0;

        public void CadastrarBicicleta()
        {
            Console.Clear();
            bool validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite o modelo da bicicleta: ");
                    modeloBicicleta[atual] = Console.ReadLine();
                    if (modeloBicicleta[atual].Length >= 5)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Nome da bicicleta deve conter no mínimo 5 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nome invalido, digite novamente");
                }
            }
            Console.WriteLine(" ");
            bool validarAnoFabricacao = true;
            while (validarAnoFabricacao == true)
            {
                try
                {
                    Console.Write("Digite o ano de fabricação: ");
                    anoBicicleta[atual] = Convert.ToInt32(Console.ReadLine());
                    if (anoBicicleta[atual] >= 0)
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
            Console.WriteLine(" ");
            validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite a cor da bicicleta: ");
                    corBicicleta[atual] = Console.ReadLine();
                    validarTexto = false;
                    if (corBicicleta[atual].Length >= 3)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Cor da bicicleta deve conter no mínimo 3 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Cor da bicicleta invalida, digite novamente");
                }
            }
            Console.WriteLine(" ");
            bool validarPrecoBicicleta = true;
            while (validarPrecoBicicleta == true)
            {
                try
                {
                    Console.Write("Digite o preço da bicicleta: ");
                    precoBicicleta[atual] = Convert.ToDouble(Console.ReadLine());
                    if (precoBicicleta[atual] > 0)
                    {
                        validarPrecoBicicleta = false;
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
            Console.WriteLine(" ");
            bool validarPesoBicicleta = true;
            while (validarPesoBicicleta == true)
            {
                try
                {
                    Console.Write("Digite o peso da bicicleta: ");
                    anoBicicleta[atual] = Convert.ToInt32(Console.ReadLine());
                    if (anoBicicleta[atual] > 0)
                    {
                        validarPesoBicicleta = false;
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
            Console.WriteLine(" ");
            bool validarPassageirosBicicleta = true;
            while (validarPassageirosBicicleta == true)
            {
                try
                {
                    Console.Write("Digite quantos passageiros comporta: ");
                    comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
                    if (comportaQuantasPessoas[atual] > 0)
                    {
                        validarPassageirosBicicleta = false;
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
            somaAnoFabricacao = somaAnoFabricacao + anoBicicleta[atual];
            somaValorBicicletas = precoBicicleta[atual] + somaValorBicicletas;
            somaPesoBicicletas = pesoBicicleta[atual] + somaPesoBicicletas;
            atual++;
        }

        public void ListarBicicleta()
        {
            Console.Clear();
            Console.WriteLine("Lista de bicicletas cadastradas: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    string.Format(
                    "\nModelo Da Bicicleta: {0} \nAno da Bicicleta: {1} \nCor da bicicleta: {2} \nPreço da Bicicleta: {3}\nPeso da Bicicleta:{4} \nComporta Quantos passageiros:{5}", modeloBicicleta[i], anoBicicleta[i], precoBicicleta[i], pesoBicicleta[i], comportaQuantasPessoas[i]));
            }

        }

        public void EditarBicicleta()
        {
            Console.WriteLine("Digite um nome para Pesquisa: ");
            string nomeBicicletaPesquisada = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBicicletaPesquisada == modeloBicicleta[i])
                {
                    posicao = i;
                }
                if (posicao != 1)
                {
                    bool validarTexto = true;
                    while (validarTexto == true)
                    {
                        try
                        {
                            Console.Write("Digite o modelo da bicicleta: ");
                            modeloBicicleta[posicao] = Console.ReadLine();
                            if (modeloBicicleta[posicao].Length >= 5)
                            {
                                validarTexto = false;
                            }
                            else
                            {
                                Console.WriteLine("Nome da bicicleta deve conter no mínimo 5 caracteres");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Nome invalido, digite novamente");
                        }
                    }
                    Console.WriteLine(" ");
                    bool validarAnoFabricacao = true;
                    while (validarAnoFabricacao == true)
                    {
                        try
                        {
                            Console.Write("Digite o ano de fabricação: ");
                            anoBicicleta[posicao] = Convert.ToInt32(Console.ReadLine());
                            if (anoBicicleta[posicao] >= 0)
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
                    Console.WriteLine(" ");
                    validarTexto = true;
                    while (validarTexto == true)
                    {
                        try
                        {
                            Console.Write("Digite a cor da bicicleta: ");
                            corBicicleta[posicao] = Console.ReadLine();                            
                            if (corBicicleta[posicao].Length >= 3)
                            {
                                validarTexto = false;
                            }
                            else
                            {
                                Console.WriteLine("Cor da bicicleta deve conter no mínimo 3 caracteres");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Cor da bicicleta invalida, digite novamente");
                        }
                    }
                    Console.WriteLine(" ");
                    bool validarPrecoBicicleta = true;
                    while (validarPrecoBicicleta == true)
                    {
                        try
                        {
                            Console.Write("Digite o preço da bicicleta: ");
                            precoBicicleta[posicao] = Convert.ToDouble(Console.ReadLine());
                            if (precoBicicleta[posicao] > 0)
                            {
                                validarPrecoBicicleta = false;
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
                    Console.WriteLine(" ");
                    bool validarPesoBicicleta = true;
                    while (validarPesoBicicleta == true)
                    {
                        try
                        {
                            Console.Write("Digite o peso da bicicleta: ");
                            pesoBicicleta[posicao] = Convert.ToInt32(Console.ReadLine());
                            if (pesoBicicleta[posicao] > 0)
                            {
                                validarPesoBicicleta = false;
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
                    Console.WriteLine(" ");
                    bool validarPassageirosBicicleta = true;
                    while (validarPassageirosBicicleta == true)
                    {
                        try
                        {
                            Console.Write("Digite quantos passageiros comporta: ");
                            comportaQuantasPessoas[posicao] = Convert.ToInt32(Console.ReadLine());
                            if (comportaQuantasPessoas[posicao] > 0)
                            {
                                validarPassageirosBicicleta = false;
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

                
                Console.WriteLine("Dados alterados com sucesso");
                }
                else
                {
                    Console.WriteLine("Registro não encontrado");
                }

            }

        }

        public void BuscarBicicleta()
        {
            Console.Write("Digite um nome para ser pesquisado: ");
            string nomeBuscado = Console.ReadLine();
            bool bicicletaAchado = false;
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    string.Format(
                    "\nModelo da Bicicleta: {0} \nAno da Bicicleta: {1} \nCor da Bicicleta: {2} \nPreço da Bicicleta:{3} \n Peso daBicicleta: {4} \nComporta Quantos Passageiros:{5}", modeloBicicleta[i], anoBicicleta[i], corBicicleta[i], precoBicicleta[i], pesoBicicleta[i], comportaQuantasPessoas[i]));

                bicicletaAchado = true;
                break;
            }
            if (!bicicletaAchado)
            {
                Console.WriteLine("Bicicleta não encontrada");
            }
        }

        public void TotalDeBicicletas()
        {
            Console.WriteLine("Total de bicicletas: " + atual);
        }

        public void MediaDosPrecosDeBicicletas()
        {
            double mediaPreco = somaValorBicicletas / atual;
            Console.WriteLine("Média de preço das bicicletas: " + mediaPreco);
        }

        public void MediaDosAnosDasBicicletas()
        {
            int mediaAnoFabricacao = somaAnoFabricacao / atual;
            Console.WriteLine("Média de ano de fabricação das bicicletas: " + mediaAnoFabricacao);
        }

        public void MediaDosPesosDasBicicletas()
        {
            double mediaPesoBicicletas = somaPesoBicicletas / atual;
            Console.WriteLine("Média de ano de fabricação das bicicletas: " + mediaPesoBicicletas);
         }

        public void bicicletaComMaiorPreco()
        {
            for (int i = 0; i < precoBicicleta.Length; i++)
            {
                if (precoBicicleta[i] > bicicletaMaiorPreco)
                {
                    bicicletaMaiorPreco = pesoBicicleta[i];
                }
            }
            Console.WriteLine("Preço da bicicleta mais barata: " + bicicletaMaiorPreco);
        }

        public void BicicletaComMaiorAnoFabricacao()
        {
            for(int i = 0; i < anoBicicleta.Length; i++){
            if (anoBicicleta[i] > bicicletaMaiorAnoFabricacao)
            {
                bicicletaMaiorAnoFabricacao = anoBicicleta[i];
            }
        }
            Console.WriteLine("Ano de fabricação mais recente: " + bicicletaMaiorAnoFabricacao);
        }

        public void BicicletaComMaiorPeso()
        {
            for (int i = 0; i < pesoBicicleta.Length; i++)
            {
                if (pesoBicicleta[i] > bicicletaMaiorPeso)
                {
                    bicicletaMaiorPeso = pesoBicicleta[i];
                }
            }
            Console.WriteLine("Peso da bicicleta mais pesada: " + bicicletaMaiorPeso);
        }

        public void BicicletaComMenorPreco()
        {
            for (int i = 0; i < precoBicicleta.Length; i++)
            {
                if (precoBicicleta[i] < bicicletaMenorPeso)
                {
                    bicicletaMenorPeso = precoBicicleta[i];
                }
            }
            Console.WriteLine("Preço da bicicleta mais barata: " + bicicletaMenorPreco);
        }

        public void BicicletaComMenorAnoFabricacao()
        {
            for (int i = 0; i < anoBicicleta.Length; i++)
            {
                if (anoBicicleta[i] < bicicletaMenorAnoFabricacao)
                {
                    bicicletaMenorAnoFabricacao = anoBicicleta[i];
                }
            }
            Console.WriteLine("Ano de fabricação menos recente: " + bicicletaMenorAnoFabricacao);
        }

        public void BicicletaComMenorPeso()
        {
            for (int i = 0; i < pesoBicicleta.Length; i++)
            {
                if (pesoBicicleta[i] < bicicletaMenorPeso)
                {
                    bicicletaMenorPeso = pesoBicicleta[i];
                }
            }
            Console.WriteLine("Peso da bicicleta que possui menor peso: " + bicicletaMenorPeso);
        }

        public void ApagarMenuBicicleta()
        {
            Console.Clear();
        }

    }
}
