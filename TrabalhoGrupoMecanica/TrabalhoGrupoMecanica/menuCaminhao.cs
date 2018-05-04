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
            Console.Write("Digite o modelo do carro: ");
            modeloCaminhao[atual] = Console.ReadLine();
            Console.Write("Digite o ano de fabricação do carro: ");
            anoFabricacaoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a cor do carro: ");
            corCaminhao[atual] = Console.ReadLine();
            Console.Write("Digite o preço do carro: ");
            precoCaminhao[atual] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso do carro: ");
            pesoCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Comporta Quantas Pessoas: ");
            comportaQuantasPessoasCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;

        }
    }
}
