using System;
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
        int atual = 0;


        public void CadastrarBicicleta()
        {
            Console.WriteLine("Digite o modelo da bicicleta: ");
            modeloBicicleta[atual] = Console.ReadLine();

            Console.WriteLine("Digite o ano da bicicleta: ");
            anoBicicleta[atual] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a cor da bicicleta: ");
            corBicicleta[atual] = Console.ReadLine();

            Console.WriteLine("Digite o preço da bicicleta: ");
            precoBicicleta[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da bicicleta: ");
            pesoBicicleta[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantos passageiros comporta: ");
            comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;
        }
    }
}
