using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int Paginas { get; set; }
    }

    class Livraria
    {
        private static List<Livro> livros = new List<Livro>();

        public static void Executar()
        {
            bool executar = true;

            while (executar)
            {
                Console.WriteLine("==== Livraria ====");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Pesquisar Livro");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarLivro();
                        break;
                    case "2":
                        ListarLivros();
                        break;
                    case "3":
                        PesquisarLivro();
                        break;
                    case "4":
                        executar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void AdicionarLivro()
        {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o nome do autor: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o Gênero do livro: ");
            string genero = Console.ReadLine();

            int paginas;
            do
            {
                Console.Write("Digite a quantidade de páginas do livro: ");
            } while (!int.TryParse(Console.ReadLine(), out paginas) || paginas < 0);

            Livro novoLivro = new Livro { Titulo = titulo, Autor = autor, Genero = genero, Paginas = paginas };
            livros.Add(novoLivro);

            Console.WriteLine("Livro adicionado com sucesso!");
        }

        private static void ListarLivros()
        {
            Console.WriteLine("Livros disponíveis na livraria:");

            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
            }
            else
            {
                foreach (var livro in livros)
                {
                    Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Gênero: {livro.Genero}, Páginas: {livro.Paginas}");
                }
            }
        }

        private static void PesquisarLivro()
        {
            Console.Write("Digite o título do livro que deseja pesquisar: ");
            string tituloPesquisa = Console.ReadLine();

            Livro livroEncontrado = livros.Find(l => l.Titulo.Equals(tituloPesquisa, StringComparison.OrdinalIgnoreCase));

            if (livroEncontrado != null)
            {
                Console.WriteLine($"Livro encontrado - Título: {livroEncontrado.Titulo}, Autor: {livroEncontrado.Autor}, Gênero: {livroEncontrado.Genero}, Páginas: {livroEncontrado.Paginas}");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
    }
}