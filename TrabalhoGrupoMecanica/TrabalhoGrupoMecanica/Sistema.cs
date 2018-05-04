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
3 - Listar carro
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

<<<<<<< HEAD
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
                                case 15:
                                    menuCarro.ApagarMenu();
                                    break;

                       }

 

                       
                            break;
                    case 2: Console.Clear();
                            Console.WriteLine(@"1 - Cadastrar Bicicleta: 
2 - Editar Bicicleta
3 - Listar Bicicleta
4 - Buscar Bicicleta
5 - Total
6 - Média de preço de Bicicletas
7 - Média de anos das Bicicletas
8 - Média de pesos das Bicicletas
9 - Bicicleta com maior preço
10 - Bicicleta com maior ano de fabricação
11 - Bicicleta com maior peso
12 - Bicicleta com menor preço
13 - Bicicleta com menor ano de fabricação
14 - Bicicleta com menor peso
15 - Sair");

                            escolhaMenu = Convert.ToInt32(Console.ReadLine());

                            switch (escolhaMenu)
                            {

                                case 1:
                                    menuBicicleta.CadastrarBicicleta();
                                    break;
                                case 2:
                                    menuBicicleta.ListarBicicleta();
                                    break;
                                case 3:
                                    menuBicicleta.EditarBicicleta();
                                    break;
                                case 4:
                                    menuBicicleta.BuscarBicicleta();
                                    break;
                                case 5:
                                    menuBicicleta.TotalDeBicicletas();
                                    break;
                                case 6:
                                    menuBicicleta.MediaDosPrecosDeBicicletas();
                                    break;
                                case 7:
                                    menuBicicleta.MediaDosAnosDasBicicletas();
                                    break;
                                case 8:
                                    menuBicicleta.MediaDosPesosDasBicicletas();
                                    break;
                                case 9:
                                    menuBicicleta.bicicletaComMaiorPreco();
                                    break;
                                case 10:
                                    menuBicicleta.BicicletaComMaiorAnoFabricacao();
                                    break;
                                case 11:
                                    menuBicicleta. BicicletaComMaiorPeso();
                                    break;
                                case 12:
                                    menuBicicleta.BicicletaComMenorPreco();
                                    break;
                                case 13:
                                    menuBicicleta.BicicletaComMenorAnoFabricacao();
                                    break;
                                case 14:
                                    menuBicicleta.BicicletaComMenorPeso();
                                    break;
                                case 15:
                                    menuCarro.ApagarMenu();
                                    break;

                            }

=======
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
                            case 15:
                                menuCarro.ApagarMenu();
                                break;

                        }




                        break;
                    case 2:
>>>>>>> ffd71ca69a3cf10bc7e6074c4a58428f1a2850c7
                        break;
                    case 3:
                        break;
                    case 4:

                        Console.Clear();
                        Console.WriteLine(@"1 - Cadastrar avião: 
2 - Editar avião
3 - Listar avião
4 - Buscar avião 
5 - Total
6 - Média de preço dos aviões
7 - Média de anos dos aviões
8 - Média de pesos dos aviões
9 - Avião com maior preço
10 - Avião com maior ano de fabricação
11 - Avião com maior peso
12 - Avião com menor preço
13 - Avião com menor ano de fabricação
14 - Avião com menor peso
15 - Sair");

                        escolhaMenu = Convert.ToInt32(Console.ReadLine());

                        switch (escolhaMenu)
                        {
                            case 1:
                                menuAviao.CadastrarAviao();
                                break;
                            case 2:
                                menuAviao.EditarAviao();
                                break;

                            case 3:
                                menuAviao.ListarAvioes();
                                break;
                            case 4:
                                menuAviao.BuscarAviao();
                                break;
                            case 5:
                                menuAviao.TotalAvioes();
                                break;
                            case 6:
                                menuAviao.MediaPrecoAviao();
                                break;
                            case 7:
                                menuAviao.MediaAnosCarros();
                                break;
                            case 8:
                                menuAviao.MediaPesosAviao();
                                break;
                            case 9:
                                menuAviao.AviaoComMaiorPreco();
                                break;
                            case 10:
                                menuAviao.AviaoMaiorAnoFabricacao();
                                break;
                            case 11:
                                menuAviao.AviaoComMaiorPeso();
                                break;
                            case 12:
                                menuAviao.AviaoComMenorPreco();
                                break;
                            case 13:
                                menuAviao.AviaoComMenorAnoFabricacao();
                                break;
                            case 14:
                                menuAviao.AviaoComMenorPeso();
                                break;
                            case 15:
                                Console.Clear();
                                break;


                        }


                        break;
                    case 5:
                        break;

                    case 6:

                        Console.Clear();
                        Console.WriteLine(@"1 - Cadastrar ônibus
2 - Editar ônibus
3 - Listar ônibus
4 - Buscar ônibus 
5 - Total
6 - Média de preço dos ônibus
7 - Média de anos dos ônibus
8 - Média de pesos dos ônibus
9 - ônibus com maior preço
10 - ônibus com maior ano de fabricação
11 - ônibus com maior peso
12 - ônibus com menor preço
13 - ônibus com menor ano de fabricação
14 - ônibus com menor peso
15 - Sair");

                        escolhaMenu = Convert.ToInt32(Console.ReadLine());

                        switch (escolhaMenu)
                        {
                            case 1:
                                menuOnibus.CadastrarOnibus();
                                break;
                            case 2:
                                menuOnibus.EditarOnibus();
                                break;

                            case 3:
                                menuOnibus.ListarOnibus();
                                break;
                            case 4:
                                menuOnibus.BuscarOnibus();
                                break;
                            case 5:
                                menuOnibus.TotalOnibus();
                                break;
                            case 6:
                                menuOnibus.MediaPrecoOnibus();
                                break;
                            case 7:
                                menuOnibus.MediaAnosOnibus();
                                break;
                            case 8:
                                menuOnibus.MediaPesosOnibus();
                                break;
                            case 9:
                                menuOnibus.OnibusComMaiorPreco();
                                break;
                            case 10:
                                menuOnibus.OnibusMaiorAnoFabricacao();
                                break;
                            case 11:
                                menuOnibus.OnibusComMaiorPeso();
                                break;
                            case 12:
                                menuOnibus.OnibusComMenorPreco();
                                break;
                            case 13:
                                menuOnibus.OnibusComMenorAnoFabricacao();
                                break;
                            case 14:
                                menuOnibus.OnibusComMenorPeso();
                                break;
                            case 15:
                                menuOnibus.ApagarMenu();
                                break;

                        }
                        break;

                        Menu();
                        escolhaMenu = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
