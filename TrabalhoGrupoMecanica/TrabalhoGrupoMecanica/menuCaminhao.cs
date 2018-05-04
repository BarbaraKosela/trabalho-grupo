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
            Console.Write("Comporta Quantas Pessoas no caminhão: ");
            comportaQuantasPessoasCaminhao[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;

        }
    }
}
