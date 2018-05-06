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
            bool validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite o modelo do avião: ");
                    aviaoModelo[atual] = Console.ReadLine();                    
                    if (aviaoModelo[atual].Length >= 5)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Nome do avião deve conter no mínimo 5 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nome invalido, digite novamente");
                }
            }
            bool validarAnoFabricacao = true;
            while (validarAnoFabricacao == true)
            {
                try
                {
                    Console.Write("Digite o ano de fabricação: ");
                    aviaoAno[atual] = Convert.ToInt32(Console.ReadLine());
                    if (aviaoAno[atual] >= 0)
                    {
                        validarAnoFabricacao = false;
                    }
                    else
                    {
                        Console.WriteLine("Ano de fabricação invalida");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ano de fabricação deve constar apenas números");
                }
            }
            validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite a cor do avião: ");
                    aviaoCor[atual] = Console.ReadLine();
                    validarTexto = false;
                    if(aviaoCor[atual].Length >= 3)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Cor do avião deve conter no mínimo 3 caracteres");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Cor do avião invalida, digite novamente");
                }
            }

            bool validarPrecoAviao = true;
            while(validarPrecoAviao == true)
            {
                try
                {
                    Console.Write("Digite o preço do avião: ");
                    aviaoPreco[atual] = Convert.ToDouble(Console.ReadLine());
                    if (aviaoPreco[atual] > 0)
                    {
                        validarPrecoAviao = false;
                    }
                    else
                    {
                        Console.WriteLine("Preço menor que zero é inexistente, digite novamente com um preço acima de zero");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Preço invalido, digite novamente");
                }

            }
            bool validarPesoAviao = true;
            while (validarPesoAviao == true)
            {
                try
                {
                    Console.Write("Digite o peso do avião: ");
                    aviaoPeso[atual] = Convert.ToInt32(Console.ReadLine());
                    if (aviaoPeso[atual] > 0)
                    {
                        validarPesoAviao = false;
                    }
                    else
                    {
                        Console.WriteLine("Peso menor que zero é inexistente, digite novamente com um peso acima de zero");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Peso invalido, digite novamente");
                }
            }
            bool validarPassageirosAviao = true;
            while(validarPassageirosAviao == true)
            {
                try
                {
                    Console.Write("Digite quantos passageiros comporta: ");
                    aviaoPessoas[atual] = Convert.ToInt32(Console.ReadLine());
                    if (aviaoPeso[atual] > 0)
                    {
                        validarPassageirosAviao = false;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de passageiros menor que zero é inexistente, digite novamente com um peso acima de zero");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                }
            }
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

                bool validarTexto = true;
                while (validarTexto == true)
                {
                    try
                    {
                        Console.Write("Digite o modelo do avião: ");
                        aviaoModelo[posicao] = Console.ReadLine();
                        if (aviaoModelo[posicao].Length >= 5)
                        {
                            validarTexto = false;
                        }
                        else
                        {
                            Console.WriteLine("Nome do avião deve conter no mínimo 5 caracteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Nome invalido, digite novamente");
                    }
                }
                bool validarAnoFabricacao = true;
                while (validarAnoFabricacao == true)
                {
                    try
                    {
                        Console.Write("Digite o ano de fabricação: ");
                        aviaoAno[posicao] = Convert.ToInt32(Console.ReadLine());
                        if (aviaoAno[posicao] >= 0)
                        {
                            validarAnoFabricacao = false;
                        }
                        else
                        {
                            Console.WriteLine("Ano de fabricação invalida");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ano de fabricação deve constar apenas números");
                    }
                }
                validarTexto = true;
                while (validarTexto == true)
                {
                    try
                    {
                        Console.Write("Digite a cor do avião: ");
                        aviaoCor[posicao] = Console.ReadLine();
                        if (aviaoCor[posicao].Length >= 3)
                        {
                            validarTexto = false;
                        }
                        else
                        {
                            Console.WriteLine("Cor do avião deve conter no mínimo 3 caracteres");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Cor do avião invalida, digite novamente");
                    }
                }

                bool validarPrecoAviao = true;
                while (validarPrecoAviao == true)
                {
                    try
                    {
                        Console.Write("Digite o preço do avião: ");
                        aviaoPreco[posicao] = Convert.ToDouble(Console.ReadLine());
                        if (aviaoPreco[posicao] > 0)
                        {
                            validarPrecoAviao = false;
                        }
                        else
                        {
                            Console.WriteLine("Preço menor que zero é inexistente, digite novamente com um preço acima de zero");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Preço invalido, digite novamente");
                    }

                }
                bool validarPesoAviao = true;
                while (validarPesoAviao == true)
                {
                    try
                    {
                        Console.Write("Digite o peso do avião: ");
                        aviaoPeso[posicao] = Convert.ToInt32(Console.ReadLine());
                        if (aviaoPeso[posicao] > 0)
                        {
                            validarPesoAviao = false;
                        }
                        else
                        {
                            Console.WriteLine("Peso menor que zero é inexistente, digite novamente com um peso acima de zero");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Peso invalido, digite novamente");
                    }
                }
                bool validarPassageirosAviao = true;
                while (validarPassageirosAviao == true)
                {
                    try
                    {
                        Console.Write("Digite quantos passageiros comporta: ");
                        aviaoPessoas[posicao] = Convert.ToInt32(Console.ReadLine());
                        if (aviaoPeso[posicao] > 0)
                        {
                            validarPassageirosAviao = false;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de passageiros menor que zero é inexistente, digite novamente com um peso acima de zero");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Quantidade de passageiros invalida, digite novamente");
                    }
                }


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

