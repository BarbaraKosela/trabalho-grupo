using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoGrupoMecanica
{
    class Sistema
    {
        menuCarro menuCarro = new menuCarro();
        menuMoto menuMoto = new menuMoto();
        menuBicicleta menuBicicleta = new menuBicicleta();
        MenuAviao menuAviao = new MenuAviao();
        menuCaminhao menuCaminhao = new menuCaminhao();
        menuOnibus menuOnibus = new menuOnibus();
        public Sistema()
        {
            GerirMenu();
        }
        public void Menu()
        {
            Console.WriteLine("O que deseja cadastrar?\n");
            Console.WriteLine(@"1 - carros
2 - Motos
3 - Bicicletas
4 - Aviões
5 - Caminhão
6 - Ônibus
7 - Sair");

        }


        public void GerirMenu()
        {
            Menu();
            int escolhaMenu = Convert.ToInt32(Console.ReadLine());


            while (escolhaMenu != 7)
            {
                switch (escolhaMenu)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine(@"1 - Cadastrar carro: 
2 - Editar Carro
3- Listar carro
4 - Buscar carro 
5 - Total
6 - Média de preço de carros
7 - Média de anos dos carros
8 - Média de pesos dos carros
9 - Carro com maior preço
10 - Carro com maior ano de fabricação
11 - Carro com maior peso
12 - Carro com menor preço
13 - Carro com menor ano de fabricação
14 - Carro com menor peso
15 - Sair");

                        escolhaMenu = Convert.ToInt32(Console.ReadLine());
                        while (escolhaMenu != 15)
                        {
                            switch (escolhaMenu)
                            {
                                
                                
                                
                                case 1:
                                    menuCarro.CadastrarCarro();
                                    break;
                                case 2:
                                    menuCarro.ListarCarros();
                                    break;
                        
                                case 3:
                                    menuCarro.ListarCarros();
                                    break;
                                case 4:
                                    menuCarro.BuscarCarro();
                                    break;
                                case 5:
                                    menuCarro.TotalCarros();
                                    break;
                                case 6:
                                    menuCarro.MediaPrecoCarros();
                                    break;
                                case 7:
                                    menuCarro.MediaAnosCarros();
                                    break;
                                case 8:
                                    menuCarro.MediaPesosCarros();
                                    break;
                                case 9:
                                    menuCarro.CarroComMaiorPreco();
                                    break;
                                case 10:
                                    menuCarro.CarroMaiorAnoFabricacao();
                                    break;
                                case 11:
                                    menuCarro.CarroComMaiorPeso();
                                    break;
                                case 12:
                                    menuCarro.CarroComMenorPreco();
                                    break;
                                case 13:
                                    menuCarro.CarroComMenorAnoFabricacao();
                                    break;
                                case 14:
                                    menuCarro.CarroComMenorPeso();
                                    break;


                        }

                        }

                        break;
                    case 2: 
                        break;
                    case 3:
                        break;
                    case 4:
                        
                        break;
                    case 5: 
                        break;
                    case 6:
                        
                        break;

                }
                Menu();
                escolhaMenu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
