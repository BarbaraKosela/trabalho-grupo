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
    }
}
