using System;

public class Aluno
{
    public Random idade {get; set;}
    public Random cR {get; set;}
    public Random nR {get; set;}
    public int p {get; set;}
    public string cursoR {get; set;}   
    public string nome {get; set;}
    public double nota {get; set;}
    public string nS {get; set;}

    public Aluno (Random Idade, Random CR, Random NR, int P, string CursoR, string Nome, double Nota, string NS) => 
    (idade, cR, nR, p, cursoR, nome, nota, nS) = (Idade, CR, NR, P, CursoR, Nome, Nota, NS);
}