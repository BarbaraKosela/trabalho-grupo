using System;
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
        Console.Write("Digite o modelo do ônibus: ");
        onibusModelo[atual] = Console.ReadLine();

        Console.Write("Digite o ano de fabricação: ");
        onibusAno[atual] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a cor do ônibus: ");
        onibusCor[atual] = Console.ReadLine();

        Console.Write("Digite o preço do ônibus: ");
        onibusPreco[atual] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o peso do ônibus: ");
        onibusPeso[atual] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite quantos passageiros comporta: ");
        onibusPessoas[atual] = Convert.ToInt32(Console.ReadLine());

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

            Console.Write("Digite o modelo do avião: ");
            onibusModelo[posicao] = Console.ReadLine();

            Console.Write("Digite o ano de fabricação: ");
            onibusAno[posicao] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a cor do avião: ");
            onibusCor[posicao] = Console.ReadLine();

            Console.Write("Digite o preço do avião: ");
            onibusPreco[posicao] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso do avião: ");
            onibusPeso[posicao] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite quantos passageiros comporta: ");
            onibusPessoas[posicao] = Convert.ToInt32(Console.ReadLine());


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
        string modeloBuscado = Console.ReadLine();
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

 