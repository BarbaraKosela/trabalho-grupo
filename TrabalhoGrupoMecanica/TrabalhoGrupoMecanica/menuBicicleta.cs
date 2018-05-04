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
            Console.WriteLine("Modelo Da Bicicleta: ");
            modeloBicicleta[atual] = Console.ReadLine();

            Console.WriteLine("Ano Da Bicicleta: ");
            anoBicicleta[atual] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cor Da Bicicleta: ");
            corBicicleta[atual] = Console.ReadLine();

            Console.WriteLine("Preço Da Bicicleta: ");
            precoBicicleta[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso Da Bicicleta: ");
            pesoBicicleta[atual] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Comporta Quantas Pessoas: ");
            comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            atual++;
        }
    }
}
