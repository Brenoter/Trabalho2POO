using consoleBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro livro1 = new Livro { Titulo = "Aventuras de Pi", Autor = "Breno Couto" };
            Livro livro2 = new Livro { Titulo = "Amor e Sangue", Autor = "Mahatma Gandhi" };

            Leitor leitor1 = new Leitor { Nome = "Richard", Sobrenome = "Francis" };
            Leitor leitor2 = new Leitor { Nome = "Lucas", Sobrenome = "CuPretinho" };

            biblioteca.Livros.Add(livro1);
            biblioteca.Livros.Add(livro2);

            biblioteca.Leitores.Add(leitor1);
            biblioteca.Leitores.Add(leitor2);

            Console.WriteLine("Bem-vindo à biblioteca!");

            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1. Emprestar livro");
                Console.WriteLine("2. Devolver livro");
                Console.WriteLine("3. Listar livros disponíveis");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Digite o título do livro: ");
                    string tituloLivro = Console.ReadLine();
                    Livro livro = biblioteca.Livros.FirstOrDefault(l => l.Titulo == tituloLivro);

                    if (livro != null)
                    {
                        Console.Write("Digite o nome do leitor: ");
                        string nomeLeitor = Console.ReadLine();
                        Leitor leitor = biblioteca.Leitores.FirstOrDefault(l => l.Nome == nomeLeitor);

                        if (leitor != null)
                        {
                            biblioteca.EmprestarLivro(livro, leitor);
                        }
                        else
                        {
                            Console.WriteLine("Leitor não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado.");
                    }
                }
                else if (opcao == "2")
                {
                    Console.Write("Digite o título do livro: ");
                    string tituloLivro = Console.ReadLine();
                    Livro livro = biblioteca.Livros.FirstOrDefault(l => l.Titulo == tituloLivro);

                    if (livro != null)
                    {
                        Console.Write("Digite o nome do leitor: ");
                        string nomeLeitor = Console.ReadLine();
                        Leitor leitor = biblioteca.Leitores.FirstOrDefault(l => l.Nome == nomeLeitor);

                        if (leitor != null)
                        {
                            biblioteca.DevolverLivro(livro, leitor);
                        }
                        else
                        {
                            Console.WriteLine("Leitor não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado.");
                    }
                }
                else if (opcao == "3")
                {
                    biblioteca.ListarLivrosDisponiveis();
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Até logo!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                }
            }
        }
    }
}
