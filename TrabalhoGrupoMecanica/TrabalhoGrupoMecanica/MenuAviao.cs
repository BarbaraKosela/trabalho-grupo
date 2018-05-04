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


            public void EditarAviao()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome para pesquisa: ");
            string modeloPesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (modeloPesquisado == aviaoModelo[i])
                {
                    posicao = i;
                }
            }
            
                if (posicao != -1)
            {
                
                Console.Write("Digite o modelo do avião: ");
            aviaoModelo[posicao] = Console.ReadLine();

                Console.Write("Digite o ano de fabricação: ");
            aviaoAno[posicao] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a cor do avião: ");
            aviaoCor[posicao] = Console.ReadLine();

                Console.Write("Digite o preço do avião: ");
            aviaoPreco[posicao] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o peso do avião: ");
            aviaoPeso[posicao] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite quantos passageiros comporta: ");
            aviaoPessoas[posicao] = Convert.ToInt32(Console.ReadLine());


                    Console.Clear();

                    Console.WriteLine("Dados alterados com sucesso");
            }


            else
            {
                Console.WriteLine("Registro nao encontrado");
            }
        }

         public void ListarAvioes()
        {
            Console.Clear();
            Console.WriteLine("Lista de aviões cadastrados: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(String.Format("\nModelo: {0} \nAno: {1} \nCor: {2} \nPreço: {3}, \nPeso: {4} \nQuantidade de pessoas que comporta: {5}", aviaoModelo[i], aviaoAno[i], aviaoCor[i], aviaoPreco[i], aviaoPeso[i], aviaoPessoas[i]));
                
            }
        }

         public void BuscarAviao()
         {
             Console.WriteLine("Digite o nome do avião para a busca: ");
             string modeloBuscado = Console.ReadLine();
             bool encontrado = false;
             for (int i = 0; i < atual; i++)
             {
                 if (modeloBuscado == aviaoModelo[i])
                 {
                     Console.WriteLine(String.Format("\nModelo: {0} \nAno: {1} \nCor: {2} \nPreço: {3}, \nPeso: {4} \nQuantidade de pessoas que comporta: {5}", aviaoModelo[i], aviaoAno[i], aviaoCor[i], aviaoPreco[i], aviaoPeso[i], aviaoPessoas[i]));
                     break;
                 }
                 encontrado = true;
             }
             if (!encontrado)
             {
                 Console.WriteLine("Modelo de avião não encontrado");
             }
         }






         public void TotalAvioes()
         {
             
         }

         public void MediaPrecoAviao()
         {
             
         }

         public void MediaAnosCarros()
         {
             
         }

         public void MediaPesosAviao()
         {
             
         }

         public void AviaoComMaiorPreco()
         {
             
         }

         public void AviaoMaiorAnoFabricacao()
         {
             
         }

         public void AviaoComMaiorPeso()
         {
             
         }

         public void AviaoComMenorPreco()
         {
             
         }

         public void AviaoComMenorAnoFabricacao()
         {
             
         }

         public void AviaoComMenorPeso()
         {
             
         }

    }
        





}

