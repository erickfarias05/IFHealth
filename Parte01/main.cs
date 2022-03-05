using System;

class Program{
  public static void Main() {
    Console.WriteLine("Bem-vindo ao IFGym");
    Esporte e1 = new Esporte("Muay Thai", 1);
    Esporte e2 = new Esporte("Musculacao", 2);
    Aluno a1 = new Aluno("Marcio", "2103912", "marcio@gmail.com", 1);
    Aluno a2 = new Aluno("Erika", "21032", "erika@gmail.com", 2);
    Console.WriteLine(e1);
    Console.WriteLine(e2);
    Console.WriteLine(a1);
    Console.WriteLine(a2);
  }
}