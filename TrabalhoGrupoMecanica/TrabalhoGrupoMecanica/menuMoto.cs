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
        double motoMaiorPeso = double.MinValue;
        double motoMenorPeso = double.MaxValue;
        int motooMenorAnoFabricacao = int.MinValue;
        int motoMaiorAnoFabricacao = int.MaxValue;
        double motoMaiorPreco = double.MinValue;
        double motoMenorPreco = double.MaxValue;

        int atual = 0;


        public void CadastrarMoto()
        {
            Console.Clear();
            bool validarTexto = true;
            while (validarTexto == true)
            {
                try
                {
                    Console.Write("Digite o modelo da moto: ");
                    modeloMoto[atual] = Console.ReadLine();
                    if (modeloMoto[atual].Length >= 5)
                    {
                        validarTexto = false;
                    }
                    else
                    {
                        Console.WriteLine("Modelo da moto deve conter no mínimo 5 caracteres, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nome da moto invalido, digite novamente");
                }
            }
            Console.WriteLine(" ");
            bool validarAno = true;
            while (validarAno == true)
            {
                try
                {
                    Console.Write("Digite o ano da moto: ");
                    anoMoto[atual] = Convert.ToInt32(Console.ReadLine());
                    if (anoMoto[atual] > 0)
                    {
                        validarAno = false;
                    }
                    else
                    {
                        Console.WriteLine("Ano da moto invalido solicitado é 0 ou menor, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ano da moto invalido, digite novamente");
                }
            }
            Console.WriteLine(" ");
            bool validarCor = true;
            while (validarCor == true)
            {
                try
                {
                    Console.Write("Digite a cor da moto: ");
                    corMoto[atual] = Console.ReadLine();
                    if (corMoto[atual].Length >= 5)
                    {
                        validarCor = false;
                    }
                    else
                    {
                        Console.WriteLine("Cor da moto deve conter no mínimo 5 caracteres, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Cor da moto invalida, digite novamente");
                }
            }
            Console.WriteLine(" ");
            bool validarPreco = true;
            while (validarPreco == true)
            {
                try
                {
                    Console.Write("Digite o preço da moto: ");
                    precoMoto[atual] = Convert.ToDouble(Console.ReadLine());
                    if(precoMoto[atual] > 0)
                    {
                        validarPreco = false;
                    }
                    else
                    {
                        Console.WriteLine("Preço da moto solicitado é 0 ou menor, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Preço da moto invalido, digite novamente");
                }
            }
            Console.WriteLine(" ");
            bool validarPeso = true;
            while (validarPeso == true)
            {
                try
                {
                    Console.Write("Digite o peso da moto: ");
                    pesoMoto[atual] = Convert.ToDouble(Console.ReadLine());
                    if(pesoMoto[atual] > 0)
                    {
                        validarPeso = false;
                    }
                    else
                    {
                        Console.WriteLine("Peso da moto solicitado é 0 ou menor, digite novamente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Peso da moto invalido, digite novamente");
                }         
            }
            Console.WriteLine(" ");
            bool validarPassageiros = true;
            while (validarPassageiros == true)
            {
                try
                {
                    Console.Write("Digite quantos passageiros comporta: ");
                    comportaQuantasPessoas[atual] = Convert.ToInt32(Console.ReadLine());
                    if (comportaQuantasPessoas[atual] > 0)
                    {
                        validarPassageiros = false;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de passageiros solicitado é 0 ou menor, digite novamente");
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

        public void EditarMoto()
        {
           
        }

        public void ListarMoto()
        {
           
        }

        public void MediaPrecoMoto()
        {
            
        }

        public void TotalMoto()
        {
            
        }

        public void BuscarMoto()
        {

        }

        public void MediaAnosMoto()
        {
            
        }

        public void MediaPesosMoto()
        {

        }

        public void MotoComMaiorPreco()
        {
           
        }

        public void MotoMaiorAnoFabricacao()
        {
            
        }

        public void MotoComMaiorPeso()
        {

        }

        public void MotoComMenorPreco()
        {

        }

        public void MotoComMenorAnoFabricacao()
        {
                
        }

        public void MotoComMenorPeso()
        {
            
        }

        public void MotoApagarMenu()
        {
            Console.Clear();  
        }
    }
}
