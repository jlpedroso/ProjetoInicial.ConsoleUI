using ListaDeFilmes.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeFilmes.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new FilmesDataContext())
            {
                var diretores = ctx.Diretores.ToList();
                foreach (var diretor in diretores)
                {
                    Console.WriteLine("ID: {0} - Nome: {1}",
                        diretor.Id, diretor.Nome
                        );

                }
            }
        }
    }
}
