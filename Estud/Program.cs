using System; 

namespace Estud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

                Aluno pA = new Aluno(new Random(), new Random(), new Random(), 0, "", "", 0, "");
                
                string[] curso = { 
                    "Administração",
                    "Agente Comunitário de Saúde",
                    "Agrimensura",
                    "Agroindústria",
                    "Agronegócio",
                    "Agropecuária",
                    "Alimentos",
                    "Automação Industrial",
                    "Biotecnologia",
                    "Comércio",
                    "Contabilidade"
                };

                pA.p = pA.cR.Next(curso.Length);
                pA.cursoR = curso[pA.p];
                pA.nota = pA.nR.NextDouble() * 10;
                switch (pA.nota)
                {
                    case < 5:
                        pA.nS = "I";
                    break;
                    case > 4 and < 7:
                        pA.nS = "R"; 
                    break;
                    case > 6 and < 9:
                        pA.nS = "B";
                    break;
                    case > 8:
                        pA.nS = "MB";
                    break;
                }

                Console.WriteLine("BANCO DE ALUNOS ETEC");
                Console.Write($"Nome do aluno: ");
                pA.nome = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine($"Nome: {pA.nome}");
                Console.WriteLine($"Idade: {pA.idade.Next(17, 60)} anos");
                Console.WriteLine($"Curso: Técnico em {pA.cursoR}");
                Console.WriteLine($"Média: {pA.nota.ToString("F1")} ({pA.nS})");

            Console.WriteLine("");
        }        
    }
}