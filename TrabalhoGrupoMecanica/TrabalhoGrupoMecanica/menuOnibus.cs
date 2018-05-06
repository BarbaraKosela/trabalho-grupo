﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoGrupoMecanica
{ 
   class menuOnibus
{
    string[] onibusModelo = new string[100];
    int[] onibusAno = new int[100];
    string[] onibusCor = new string[100];
    double[] onibusPreco = new double[100];
    double[] onibusPeso = new double[100];
    int[] onibusPessoas = new int[100];
    int atual = 0;

    public void CadastrarOnibus()
    {
            bool validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite o modelo do ônibus: ");
                    onibusModelo[atual] = Console.ReadLine();
                    if (onibusModelo[atual].Length >= 5)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Modelo do ônibus deve conter no mínimo 5 caracteres, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nome do ônibus invalido, digite novamente");
                }
            }
            bool validarAno = true;
            while (validarAno == true)
            {
                try
                {
                    Console.Write("Digite o ano do ônibus: ");
                    onibusAno[atual] = Convert.ToInt32(Console.ReadLine());
                    if (onibusAno[atual] > 0)
                    {
                        validarAno = false;
                    }
                    else
                    {
                        Console.WriteLine("Ano do ônibus invalido solicitado é 0 ou menor, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ano do ônibus invalido, digite novamente");
                }
            }
            bool validarCor = true;
            while (validarCor == true)
            {
                try
                {
                    Console.Write("Digite a cor do ônibus: ");
                    onibusCor[atual] = Console.ReadLine();
                    if (onibusCor[atual].Length >= 5)
                    {
                        validarCor = false;
                    }
                    else
                    {
                        Console.WriteLine("Cor do ônibus deve conter no mínimo 5 caracteres, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Cor do ônibus invalida, digite novamente");
                }
            }

            bool validarPreco = true;
            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Digite o preço do ônibus: ");
                    onibusPreco[atual] = Convert.ToDouble(Console.ReadLine());
                    if (onibusPreco[atual] > 0)
                    {
                        validarPreco = false;
                    }
                    else
                    {
                        Console.WriteLine("Preço do ônibus solicitado é 0 ou menor, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Preço do ônibus invalido, digite novamente");
                }
            }
            bool validarPeso = true;
            while (validarPeso == true)
            {
                try
                {
                    Console.Write("Digite o peso da moto: ");
                    onibusPeso[atual] = Convert.ToDouble(Console.ReadLine());
                    if (onibusPeso[atual] > 0)
                    {
                        validarPeso = false;
                    }
                    else
                    {
                        Console.WriteLine("Peso do ônibus solicitado é 0 ou menor, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Peso do ônibus invalido, digite novamente");
                }
            }
            bool validarPassageiros = true;
            while (validarPassageiros == true)
            {
                try
                {
                    Console.Write("Digite quantos passageiros comporta: ");
                    onibusPessoas[atual] = Convert.ToInt32(Console.ReadLine());
                    if (onibusPessoas[atual] > 0)
                    {
                        validarPassageiros = false;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de passageiros solicitado é 0 ou menor, digite novamente");
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

    public void EditarOnibus()
    {
        Console.Clear();
        Console.WriteLine("Digite um nome para pesquisa: ");
        string modeloPesquisado = Console.ReadLine().ToLower().Trim();
        int posicao = -1;
        for (int i = 0; i < atual; i++)
        {
            if (modeloPesquisado == onibusModelo[i])
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
                        Console.Write("Digite o modelo do ônibus: ");
                        onibusModelo[posicao] = Console.ReadLine();
                        if (onibusModelo[posicao].Length >= 5)
                        {
                            validarTexto = false;
                        }
                        else
                        {
                            Console.WriteLine("Modelo do ônibus deve conter no mínimo 5 caracteres, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nome do ônibus invalido, digite novamente");
                    }
                }
                bool validarAno = true;
                while (validarAno == true)
                {
                    try
                    {
                        Console.Write("Digite o ano do ônibus: ");
                        onibusAno[posicao] = Convert.ToInt32(Console.ReadLine());
                        if (onibusAno[posicao] > 0)
                        {
                            validarAno = false;
                        }
                        else
                        {
                            Console.WriteLine("Ano do ônibus invalido solicitado é 0 ou menor, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ano do ônibus invalido, digite novamente");
                    }
                }
                bool validarCor = true;
                while (validarCor == true)
                {
                    try
                    {
                        Console.Write("Digite a cor do ônibus: ");
                        onibusCor[posicao] = Console.ReadLine();
                        if (onibusCor[posicao].Length >= 5)
                        {
                            validarCor = false;
                        }
                        else
                        {
                            Console.WriteLine("Cor do ônibus deve conter no mínimo 5 caracteres, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Cor do ônibus invalida, digite novamente");
                    }
                }

                bool validarPreco = true;
                while (validarPreco == true)
                {
                    try
                    {
                        Console.Write("Digite o preço do ônibus: ");
                        onibusPreco[posicao] = Convert.ToDouble(Console.ReadLine());
                        if (onibusPreco[posicao] > 0)
                        {
                            validarPreco = false;
                        }
                        else
                        {
                            Console.WriteLine("Preço do ônibus solicitado é 0 ou menor, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Preço do ônibus invalido, digite novamente");
                    }
                }
                bool validarPeso = true;
                while (validarPeso == true)
                {
                    try
                    {
                        Console.Write("Digite o peso da moto: ");
                        onibusPeso[posicao] = Convert.ToDouble(Console.ReadLine());
                        if (onibusPeso[posicao] > 0)
                        {
                            validarPeso = false;
                        }
                        else
                        {
                            Console.WriteLine("Peso do ônibus solicitado é 0 ou menor, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Peso do ônibus invalido, digite novamente");
                    }
                }
                bool validarPassageiros = true;
                while (validarPassageiros == true)
                {
                    try
                    {
                        Console.Write("Digite quantos passageiros comporta: ");
                        onibusPessoas[posicao] = Convert.ToInt32(Console.ReadLine());
                        if (onibusPessoas[posicao] > 0)
                        {
                            validarPassageiros = false;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de passageiros solicitado é 0 ou menor, digite novamente");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                    }
                }


                Console.Clear();

            Console.WriteLine("Dados alterados com sucesso");
        }


        else
        {
            Console.WriteLine("Registro nao encontrado");
        }
    }

    public void ListarOnibus()
    {
        Console.Clear();
        Console.WriteLine("Lista de ônibus cadastrados: ");
        for (int i = 0; i < atual; i++)
        {
            Console.WriteLine(String.Format("\nModelo: {0} \nAno: {1} \nCor: {2} \nPreço: {3}, \nPeso: {4} \nQuantidade de pessoas que comporta: {5}", onibusModelo[i], onibusAno[i], onibusCor[i], onibusPreco[i], onibusPeso[i], onibusPessoas[i]));

        }
    }

    public void BuscarOnibus()
    {
        Console.WriteLine("Digite o nome do ônibus para a busca: ");
        string modeloBuscado = Console.ReadLine().ToLower().Trim();
        bool encontrado = false;
        for (int i = 0; i < atual; i++)
        {
            if (modeloBuscado == onibusModelo[i])
            {
                Console.WriteLine(String.Format("\nModelo: {0} \nAno: {1} \nCor: {2} \nPreço: {3}, \nPeso: {4} \nQuantidade de pessoas que comporta: {5}", onibusModelo[i], onibusAno[i], onibusCor[i], onibusPreco[i], onibusPeso[i], onibusPessoas[i]));
                break;
            }
            encontrado = true;
        }
        if (!encontrado)
        {
            Console.WriteLine("Modelo de ônibus não encontrado");
        }
    }






    public void TotalOnibus()
    {
        Console.WriteLine("O total dos ônibus é: ");
        atual++;
    }

    public void MediaPrecoOnibus()
    {

    }

    public void MediaAnosOnibus()
    {

    }

    public void MediaPesosOnibus()
    {

    }

    public void OnibusComMaiorPreco()
    {

    }

    public void OnibusMaiorAnoFabricacao()
    {

    }

    public void OnibusComMaiorPeso()
    {

    }

    public void OnibusComMenorPreco()
    {

    }

    public void OnibusComMenorAnoFabricacao()
    {

    }

    public void OnibusComMenorPeso()
    {

    }

    public void ApagarMenuOnibus()
    {

        Console.Clear();
    }
}
}

 