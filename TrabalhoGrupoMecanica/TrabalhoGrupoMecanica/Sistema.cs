﻿using System;
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
            Console.WriteLine(@"1 - Cadastrar carros
2 - Cadastrar motos
3 - Cadastrar bicicletas
4 - Cadastrar aviões
5 - Cadastrar caminhão
6 - Cadastrar ônibus
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
                        menuCarro.CadastrarCarro();
                        break;
                    case 2: menuMoto.CadastrarMoto();
                        break;
                    case 3: menuBicicleta.CadastrarBicicleta();
                        break;
                    case 4:
                        menuAviao.CadastrarAviao();
                        break;
                    case 5: menuCaminhao.CadastrarCaminhao();
                        break;
                    case 6:
                        menuOnibus.CadastrarOnibus();
                        break;

                }
                Menu();
                escolhaMenu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
