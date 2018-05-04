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

        public void ListarBicicleta()
        {
            Console.Clear();
            Console.WriteLine("Listar Biciccleta: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    string.Format(
                    "\nModelo Da Bicicleta: {0} \nAno da Bicicleta: {1} \nCor da bicicleta: {2} \nPreço da Bicicleta: {3}\nPeso da Bicicleta:{4} \nComporta Quantos passageiros:{5}", modeloBicicleta[i], anoBicicleta[i], precoBicicleta[i], pesoBicicleta[i], comportaQuantasPessoas[i]));
            }

        }

        public void EditarBicicleta()
        {
            Console.WriteLine("Digite um Nome Para Pesquisa: ");
            string nomeBicicletaPesquisada = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBicicletaPesquisada == modeloBicicleta[i])
                {
                    posicao = i;
                }
                if (posicao != 1)
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
                    Console.WriteLine("Dados Alterados Com Sucesso: ");
                }
                else
                {
                    Console.WriteLine("Registro Não Encontrado: ");
                }

            }

        }

        public void BuscarBicicleta()
        {
            Console.WriteLine("Digite um Nome Para  ser Pesquisado:");
            string nomeBuscado = Console.ReadLine();
            bool carroAchado = false;
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(
                    string.Format(
                    "\nModelo da Bicicleta: {0} \nAno da Bicicleta: {1} \nCor da Bicicleta: {2} \nPreço da Bicicleta:{3} \n Peso daBicicleta: {4} \nComporta Quantos Passageiros:{5}", modeloBicicleta[i], anoBicicleta[i], corBicicleta[i], precoBicicleta[i], pesoBicicleta[i], comportaQuantasPessoas[i]));

                carroAchado = true;
                break;
            }
            if (!carroAchado)
            {
                Console.WriteLine("Carro Não encontrado: ");
            }
        }

        public void TotalDeBicicletas()
        {

        }

        public void MediaDosPrecosDeBicicletas()
        {

        }

        public void MediaDosAnosDasBicicletas()
        {

        }

        public void MediaDosPesosDasBicicletas()
        {

        }

        public void bicicletaComMaiorPreco()
        {

        }

        public void BicicletaComMaiorAnoFabricacao()
        {

        }

        public void BicicletaComMaiorPeso()
        {

        }

        public void BicicletaComMenorPreco()
        {

        }

        public void BicicletaComMenorAnoFabricacao()
        {

        }

        public void BicicletaComMenorPeso()
        {

        }

        public void ApagarMenu()
        {
            Console.Clear();
        }

    }
}
