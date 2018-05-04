using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoGrupoMecanica
{
    class Sistema
    {
        MenuAviao menuAviao = new MenuAviao();
        public void Menu()
        {
            Console.WriteLine("O que deseja cadastrar?");
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
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        menuAviao.CadastrarAviao();
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
