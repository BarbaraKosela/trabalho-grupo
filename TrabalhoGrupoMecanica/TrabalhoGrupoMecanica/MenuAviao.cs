using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrupoMecanica
{
    class MenuAviao

    {

        string[] aviaoModelo = new string[100];
        int[] aviaoAno = new int[100];
        string[] aviaoCor = new string[100];
        double[] aviaoPreco = new double[100];
        double[] aviaoPeso = new double[100];
        int[] aviaoPessoas = new int[100];
        int atual = 0;

        
        
        public void CadastrarAviao()
        {
            Console.Write("Digite o modelo do avião: ");
            aviaoModelo[atual] = Console.ReadLine();

            Console.Write("Digite o ano de fabricação: ");
            aviaoAno[atual] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a cor do avião: ");
            aviaoCor[atual] = Console.ReadLine();

            Console.Write("Digite o preço do avião: ");
            aviaoPreco[atual] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso do avião: ");
            aviaoPeso[atual] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite quantos passageiros comporta: ");
            aviaoPessoas[atual] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            atual++;


        }
        





    }
}
