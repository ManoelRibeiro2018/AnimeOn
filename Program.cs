using Serie.Classes;
using Serie.Classes.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Serie
{
    class Program
    {
        private  static AnimeRepositorio _animeRepositorio = new AnimeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = OpcaoMenu();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarAnimes();
                        break;
                    case "2":
                        InserirAnime();
                        break;
                    case "3":
                       // _animeRepositorio.Atualiza();
                        break;
                    case "4":
                     //   _animeRepositorio.Excluir();
                        break;
                    case "5":
                      //  _animeRepositorio.Visualizar();
                        break;
                    case"C":
                           Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = OpcaoMenu();
            }
        }

        private static string OpcaoMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Animes On!!!!!");
            Console.WriteLine("1 - Listar animes");
            Console.WriteLine("2 - Inserir novo anime");
            Console.WriteLine("3 - Atualizar  anime");
            Console.WriteLine("4 - Excluir Anime");
            Console.WriteLine("5 - Visualizar anime");
            Console.WriteLine("C -- Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            return  Console.ReadLine().ToUpper();
        }


        private static void ListarAnimes()
        {
            Console.WriteLine("Listar Animes");

            var lista = _animeRepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum anime encontrado");
                return;
            }
            foreach (var anime in lista)
            {
                Console.WriteLine("#ID{0}: - {1}", anime.RetornaID(), anime.RetornaTitulo());
            }
        }

        private static void InserirAnime()
        {
            Console.WriteLine("Inserindo Anime");
            foreach (int item in Enum.GetValues(typeof(GeneroEnum)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(GeneroEnum),item));
            }

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da série: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da ´serie: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string descricao = Console.ReadLine();

            var serie = new Series(_animeRepositorio.ProximoId(), (GeneroEnum)genero, titulo, descricao, ano);

            _animeRepositorio.Inserir(serie);
        }
        
    }
}
