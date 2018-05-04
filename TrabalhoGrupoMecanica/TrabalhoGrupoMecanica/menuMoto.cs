using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoGrupoMecanica
{
    class menuMoto
    {
        string[] modeloMoto = new string[100];
        string[] corMoto = new string[100];
        double[] precoMoto = new double[100];
        double[] pesoMoto = new double[100];
        int[] anoMoto = new int[100];
        int[] comportaQuantasPessoas = new int[100];
      
        int atual = 0;


        public void CadastrarMoto()
        {
            Console.WriteLine("Digite o modelo da moto: ");
            modeloMoto[atual] = Console.ReadLine();

            Console.WriteLine("Digite o ano da moto: ");
            anoMoto[atual] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a cor da moto: ");
            corMoto[atual] = Console.ReadLine();

            Console.WriteLine("Digite o preço da moto: ");
            precoMoto[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da moto: ");
            pesoMoto[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantos passageiros comporta: ");
            comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;
        }
    }
}
