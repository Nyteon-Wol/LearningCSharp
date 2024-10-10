using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
                {
                        new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.1 },
                        new Aluno() { Nome = "Andre", Idade = 21, Nota = 4.0},
                        new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.9},
                        new Aluno() { Nome = "Jorge", Idade = 20, Nota = 8.8},
                        new Aluno() { Nome = "Ana", Idade = 21, Nota = 7.0},
                        new Aluno() { Nome = "Julia", Idade = 22, Nota = 7.8},
                        new Aluno() { Nome = "Marcio", Idade = 18, Nota = 7.1},
            };
            var pedro = alunos.Single(Aluno => Aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(Aluno => Aluno.Nota.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente!");
              }
            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana", 
                StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);


            var somatorioNota = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNota);

            var mediaDaTurma = alunos.Where(a => a.Nota >= 7)
                .Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
