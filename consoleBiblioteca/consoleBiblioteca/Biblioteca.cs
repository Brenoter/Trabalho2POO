using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleBiblioteca
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; set; }
        public List<Leitor> Leitores { get; set; }

        public Biblioteca()
        {
            Livros = new List<Livro>();
            Leitores = new List<Leitor>();
        }

        public void EmprestarLivro(Livro livro, Leitor leitor)
        {
            if (livro.Estado)
            {
                Console.WriteLine("O livro não está disponível para empréstimo.");
            }
            else
            {
                livro.Estado = true;
                Console.WriteLine($"O livro '{livro.Titulo}' foi emprestado a '{leitor.Nome}'.");
            }
        }

        public void DevolverLivro(Livro livro, Leitor leitor)
        {
            if (!livro.Estado)
            {
                Console.WriteLine("O livro não estava emprestado.");
            }
            else
            {
                livro.Estado = false;
                Console.WriteLine($"O livro '{livro.Titulo}' foi devolvido por '{leitor.Nome}'.");
            }
        }

        public void ListarLivrosDisponiveis()
        {
            var livrosDisponiveis = Livros.Where(livro => !livro.Estado);
            Console.WriteLine("Livros disponíveis na biblioteca:");
            foreach (var livro in livrosDisponiveis)
            {
                Console.WriteLine($"- {livro.Titulo} ({livro.Autor})");
            }
        }

    }
}
