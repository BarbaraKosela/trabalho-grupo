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
            Console.WriteLine(" Digite o Modelo Da Moto: ");
            modeloMoto[atual] = Console.ReadLine();

            Console.WriteLine("Digite oAno Da Moto: ");
            anoMoto[atual] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite aCor Da Moto: ");
            corMoto[atual] = Console.ReadLine();

            Console.WriteLine("Digite o Preço Da Moto: ");
            precoMoto[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Peso Da Moto: ");
            pesoMoto[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Comporta Quantas Pessoas: ");
            comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;
        }
    }
}
