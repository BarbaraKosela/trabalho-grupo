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
    }
}
