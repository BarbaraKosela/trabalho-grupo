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
2 - Bicicletas
3 - Motos
4 - Aviões
5 - Caminhão
6 - Ônibus
7 - Sair");

        }


        public void GerirMenu()
        {
            Menu();
            bool validarNumeroMenu = true;
            int escolhaMenu = 0;
            while (validarNumeroMenu == true)
            
            {
                try
                {
                    Console.Write("Digite a opçao desejada: ");
                    escolhaMenu = Convert.ToInt32(Console.ReadLine());
                    if ((escolhaMenu >= 1) && (escolhaMenu <= 7))
                    {
                        validarNumeroMenu = false;
                    }
                    else
                    {
                        Console.WriteLine("Opção desejada invalida, digite novamente");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Opcao deve conter somente números");
                }
            }
            


            while (escolhaMenu != 7)
            {
                switch (escolhaMenu)
                {
                    case 1:
                        //();
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
15 - Voltar menu inicial");

                        validarNumeroMenu = true;
                        while (validarNumeroMenu == true)
                        {
                            try
                            {
                                Console.WriteLine("Digite a opção desejada: ");
                                escolhaMenu = Convert.ToInt32(Console.ReadLine());
                                if ((escolhaMenu >= 1) && (escolhaMenu <= 15))
                                {
                                    validarNumeroMenu = false;
                                }
                                else
                                {
                                    Console.WriteLine("Opçao invalida, respostas validas são números entre 1 e 15");                               
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("Opção deve conter somente números");
                            }
                        }                 
                                                                      
                            switch (escolhaMenu)
                            {

                                case 1:
                                    menuCarro.CadastrarCarro();
                                    break;
                                    

                                case 2:
                                    menuCarro.EditarCarro();
                                    //Console.Clear();
                                    //GerirMenu();

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
                                    menuCarro.ApagarMenuCarro();
                                    break;
                        }
                           

                      //  GerirMenu();

                       
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

                        validarNumeroMenu = true;
                        while (validarNumeroMenu == true)
                        {
                            try
                            {
                                Console.WriteLine("Digite a opção desejada: ");
                                escolhaMenu = Convert.ToInt32(Console.ReadLine());
                                if ((escolhaMenu >= 1) && (escolhaMenu <= 15))
                                {
                                    validarNumeroMenu = false;
                                }
                                else
                                {
                                    Console.WriteLine("Opçao invalida, respostas validas são números entre 1 e 15");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Opção deve conter somente números");
                            }
                        }

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
                                menuBicicleta.ApagarMenuBicicleta();
                                    break;

                            }
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

                        validarNumeroMenu = true;
                        while (validarNumeroMenu == true)
                        {
                            try
                            {
                                Console.WriteLine("Digite a opção desejada: ");
                                escolhaMenu = Convert.ToInt32(Console.ReadLine());
                                if ((escolhaMenu >= 1) && (escolhaMenu <= 15))
                                {
                                    validarNumeroMenu = false;
                                }
                                else
                                {
                                    Console.WriteLine("Opçao invalida, respostas validas são números entre 1 e 15");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Opção deve conter somente números");
                            }
                        }

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
                        Console.Clear();
                        Console.WriteLine(@"1 - Cadastrar caminhão
2 - Editar caminhão
3 - Listar caminhões
4 - Buscar caminhão
5 - Total de caminhões
6 - Média de preço dos caminhões
7 - Média de anos dos caminhões
8 - Média de pesos dos caminhões
9 - caminhão com maior preço
10 - caminhão com maior ano de fabricação
11 - caminhão com maior peso
12 - caminhão com menor preço
13 - caminhão com menor ano de fabricação
14 - caminhão com menor peso
15 - Sair");
                        validarNumeroMenu = true;
                        while (validarNumeroMenu == true)
                        {
                            try
                            {
                                Console.WriteLine("Digite a opção desejada: ");
                                escolhaMenu = Convert.ToInt32(Console.ReadLine());
                                if ((escolhaMenu >= 1) && (escolhaMenu <= 15))
                                {
                                    validarNumeroMenu = false;
                                }
                                else
                                {
                                    Console.WriteLine("Opçao invalida, respostas validas são números entre 1 e 15");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Opção deve conter somente números");
                            }
                        }
                        switch (escolhaMenu)
                        {
                            case 1:
                                menuCaminhao.CadastrarCaminhao();
                                break;
                            case 2:
                                menuCaminhao.EditarCaminhao();
                                break;
                            case 3:
                                menuCaminhao.ListarCaminhao();
                                break;
                            case 4:
                                menuCaminhao.BuscarCaminhao();
                                break;
                            case 5:
                                menuCaminhao.TotalCaminhao();
                                break;
                            case 6:
                                menuCaminhao.MediaPrecoCaminhao();
                                break;
                            case 7:
                                menuCaminhao.MediaAnosCaminhao();
                                break;
                            case 8:
                                menuCaminhao.MediaPesosCaminhao();
                                break;
                            case 9:
                                menuCaminhao.CaminhaoComMaiorPreco();
                                break;
                            case 10:
                                menuCaminhao.CaminhaoMaiorAnoFabricacao();
                                break;
                            case 11:
                                menuCaminhao.CaminhaoComMaiorPeso();
                                break;
                            case 12:
                                menuCaminhao.CaminhaoComMenorPreco();
                                break;
                            case 13:
                                menuCaminhao.CaminhaoComMenorAnoFabricacao();
                                break;
                            case 14:
                                menuCaminhao.CaminhaoComMenorPeso();
                                break;
                            case 15:
                                menuCaminhao.ApagarMenuCaminhao();
                                break;
                                                                                    
                        }

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

                        validarNumeroMenu = true;
                        while (validarNumeroMenu == true)
                        {
                            try
                            {
                                Console.WriteLine("Digite a opção desejada: ");
                                escolhaMenu = Convert.ToInt32(Console.ReadLine());
                                if ((escolhaMenu >= 1) && (escolhaMenu <= 15))
                                {
                                    validarNumeroMenu = false;
                                }
                                else
                                {
                                    Console.WriteLine("Opçao invalida, respostas validas são números entre 1 e 15");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Opção deve conter somente números");
                            }
                        }

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
                                menuOnibus.ApagarMenuOnibus();
                                break;

                        }
                        break;

                        Menu();
                        
                }
            }
        }
    }
}
