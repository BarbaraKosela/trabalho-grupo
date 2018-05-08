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
        int[] comportaQuantasPessoas = new int[100];
        int[] anoMoto = new int[100];
        double motoMaiorPeso = double.MinValue;
        double motoMenorPeso = double.MaxValue;
        int motoMenorAnoFabricacao = int.MinValue;
        int motoMaiorAnoFabricacao = int.MaxValue;
        double motoMaiorPreco = double.MinValue;
        double motoMenorPreco = double.MaxValue;
        double somaValorMoto = 0;
        double somaPesoMoto = 0;
        int somaAnoFabricacao = 0;

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
            Console.WriteLine("Digite o Nome da Moto que Deseja Editar: ");
            string nomemotoPesquisada = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomemotoPesquisada == modeloMoto[i])
                {
                    posicao = i;
                }
                if (posicao != 1)
                {
                    bool validarTexto = true;
                    while (validarTexto == true)
                    {
                        try
                        {
                            Console.Write("Digite o modelo da Moto: ");
                            modeloMoto[posicao] = Console.ReadLine();
                            if (modeloMoto[posicao].Length >= 5)
                            {
                                validarTexto = false;
                            }
                            else
                            {
                                Console.WriteLine("Nome da Moto deve conter no mínimo 5 caracteres");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Nome invalido, digite novamente");
                        }
                    }
                    Console.WriteLine(" ");
                    bool validarAnoFabricacao = true;
                    while (validarAnoFabricacao == true)
                    {
                        try
                        {
                            Console.Write("Digite o ano de fabricação: ");
                            anoMoto[posicao] = Convert.ToInt32(Console.ReadLine());
                            if (anoMoto[posicao] >= 0)
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
                    Console.WriteLine(" ");
                    validarTexto = true;
                    while (validarTexto == true)
                    {
                        try
                        {
                            Console.Write("Digite a cor da Moto: ");
                            corMoto[posicao] = Console.ReadLine();                            
                            if (corMoto[posicao].Length >= 3)
                            {
                                validarTexto = false;
                            }
                            else
                            {
                                Console.WriteLine("Cor da Moto deve conter no mínimo 3 caracteres");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Cor da Moto invalida, digite novamente");
                        }
                    }
                    Console.WriteLine(" ");
                    bool validarPrecoMoto = true;
                    while (validarPrecoMoto == true)
                    {
                        try
                        {
                            Console.Write("Digite o preço da Moto: ");
                            precoMoto[posicao] = Convert.ToDouble(Console.ReadLine());
                            if (precoMoto[posicao] > 0)
                            {
                                validarPrecoMoto = false;
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
                    Console.WriteLine(" ");
                    bool validarPesoMoto = true;
                    while (validarPesoMoto == true)
                    {
                        try
                        {
                            Console.Write("Digite o peso da Moto: ");
                            anoMoto[posicao] = Convert.ToInt32(Console.ReadLine());
                            if (anoMoto[posicao] > 0)
                            {
                                validarPesoMoto = false;
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
                    Console.WriteLine(" ");
                    bool validarPassageirosMoto = true;
                    while (validarPassageirosMoto == true)
                    {
                        try
                        {
                            Console.Write("Digite quantos passageiros comporta: ");
                            comportaQuantasPessoas[posicao] = Convert.ToInt32(Console.ReadLine());
                            if (comportaQuantasPessoas[posicao] > 0)
                            {
                                validarPassageirosMoto = false;
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

                
                Console.WriteLine("Dados Alterados Com Sucesso: ");
                }
                else
                {
                    Console.WriteLine("Registro Não Encontrado: ");
                }

            }

        }



        public void ListarMoto()
        {
            Console.Clear();
            Console.WriteLine("Listar Moto: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    string.Format(
                    "\nModelo Da Moto: {0} \nAno da Moto: {1} \nCor da Moto: {2} \nPreço da Moto: {3}\nPeso da Moto:{4} \nComporta Quantos passageiros:{5}", modeloMoto[i], anoMoto[i], precoMoto[i], pesoMoto[i], comportaQuantasPessoas[i]));
            }
        }



        public void BuscarMoto()
        {
            Console.Write("Digite um Nome Para  ser Pesquisado:");
            string nomeBuscado = Console.ReadLine();
            bool MotoAchada = false;
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    string.Format(
                    "\nModelo da Moto: {0} \nAno da Moto: {1} \nCor da Moto: {2} \nPreço da Moto:{3} \n Peso da Moto: {4} \nComporta Quantos Passageiros:{5}", modeloMoto[i], anoMoto[i], corMoto[i], precoMoto[i], pesoMoto[i], comportaQuantasPessoas[i]));

                MotoAchada = true;
                break;
                if (!MotoAchada)
                {
                    Console.WriteLine("Carro Não encontrado: ");
                }
            }
        }
        public void MediaPrecoMoto()
        {
            double mediaPreco = somaValorMoto / atual;
            Console.WriteLine("Média de preço das Motos: " + mediaPreco);
        }

        public void TotalMoto()
        {
            Console.WriteLine("Total de Motos: " + atual);
        }
        public void MediaAnosMoto()
        {
            int mediaAnoFabricacao = somaAnoFabricacao / atual;
            Console.WriteLine("Média de ano de fabricação das Motos: " + mediaAnoFabricacao);
        }

        public void MediaPesosMoto()
        {
            double mediaPesoMoto = somaPesoMoto / atual;
            Console.WriteLine("Média de ano de fabricação das bicicicletas: " + mediaPesoMoto);
        }

        public void MotoComMaiorPreco()
        {
            for (int i = 0; i < precoMoto.Length; i++)
            {
                if (precoMoto[i] > motoMaiorPreco)
                {
                    motoMaiorPreco = precoMoto[i];
                }
            }
            Console.WriteLine("Preço da Moto que possui menor preço: " + motoMaiorPreco);
        }

        public void MotoMaiorAnoFabricacao()
        {
            for (int i = 0; i < anoMoto.Length; i++)
            {
                if (anoMoto[i] > motoMaiorAnoFabricacao)
                {
                    motoMaiorAnoFabricacao = anoMoto[i];
                }
            }

            Console.WriteLine("Ano de fabricação da Moto que possui menor ano de fabricação: " + motoMaiorAnoFabricacao);
        }

        public void MotoComMaiorPeso()
        {
            for (int i = 0; i < pesoMoto.Length; i++)
            {
                if (pesoMoto[i] > motoMaiorPeso)
                {
                    motoMaiorPeso = pesoMoto[i];
                }
                Console.WriteLine("Peso da Moto que possui maior peso: " + motoMaiorPeso);
            }
        }

        public void MotoComMenorPreco()
        {
            for (int i = 0; i < precoMoto.Length; i++)
            {
                if (precoMoto[i] < motoMenorPeso)
                {
                    motoMenorPeso = precoMoto[i];
                }
            }
            Console.WriteLine("Preço da Moto que possui menor preço: " + motoMenorPreco);
        }

        public void MotoComMenorAnoFabricacao()
        {
            for (int i = 0; i < anoMoto.Length; i++)
            {
                if (anoMoto[i] < motoMenorAnoFabricacao)
                {
                    motoMenorAnoFabricacao = anoMoto[i];
                }
            }
            Console.WriteLine("Ano de fabricação da Moto que possui menor ano de fabricação: " + motoMenorAnoFabricacao);
        }

        public void MotoComMenorPeso()
        {
            for (int i = 0; i < pesoMoto.Length; i++)
            {
                if (pesoMoto[i] < motoMenorPeso)
                {
                    motoMenorPeso = pesoMoto[i];
                }
            }
            Console.WriteLine("Peso da Moto que possui menor peso: " + motoMenorPeso);
        }

        public void MotoApagarMenu()
        {
            Console.Clear();  
        }
    }
}
