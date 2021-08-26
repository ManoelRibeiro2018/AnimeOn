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
        private static AnimeRepositorio _animeRepositorio = new AnimeRepositorio();
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
                        AtualizarSerie();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
                        break;
                    case "C":
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
            Console.WriteLine("1 - Listar Série");
            Console.WriteLine("2 - Inserir novo Série");
            Console.WriteLine("3 - Atualizar  Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C -- Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            return Console.ReadLine().ToUpper();
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
                Console.WriteLine("#ID{0}: - {1} - {2}", anime.RetornaID(), anime.RetornaTitulo(), (anime.RetornaExluido() ? "Excluido" : ""));
            }
        }

        private static void InserirAnime()
        {
            Console.WriteLine("Inserindo Anime");
            foreach (int item in Enum.GetValues(typeof(GeneroEnum)))
            {
                Console.WriteLine(" {0} - {1}", item, Enum.GetName(typeof(GeneroEnum), item));
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

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o código da Série: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserindo Série");
            foreach (int item in Enum.GetValues(typeof(GeneroEnum)))
            {
                Console.WriteLine(" {0} - {1}", item, Enum.GetName(typeof(GeneroEnum), item));
            }

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da série: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da ´serie: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string descricao = Console.ReadLine();

            var serie = new Series(id, (GeneroEnum)genero, titulo, descricao, ano);

            _animeRepositorio.Atualiza(id, serie);
        }

        public static void Excluir()
        {
            Console.WriteLine("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());

            _animeRepositorio.Excluir(id);
        }

        public static void Visualizar()
        {
            Console.WriteLine("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = _animeRepositorio.RetornaPorId(id);

            Console.WriteLine(serie.ToString());
        }


    }
}
