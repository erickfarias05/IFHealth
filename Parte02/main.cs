using System;

class Program{
  public static void Main() {
    Console.WriteLine("Bem-vindo ao IFHealth");
    int op = 0;
    do {
      op = Menu();
      switch(op) {
        case 1 : EsporteInserir(); break;
        case 2 : EsporteListar(); break;
      }
    } while (op != 0);
  }
  public static int Menu() {
    Console.WriteLine();
    Console.WriteLine("------ Faça sua escolha! ------");
    Console.WriteLine("01 - Inserir um novo esporte à academia");
    Console.WriteLine("02 - Listar os esportes cadastrados da academia");
    Console.WriteLine("00 - Finalizar o sistema");
    Console.WriteLine("-------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static void EsporteInserir() {
    Console.WriteLine("-------- Inseir um novo esporte --------");
    Console.WriteLine("Informe o nome do esporte: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o id: ");
    int id = int.Parse(Console.ReadLine());
    Esporte objeto = new Esporte(nome, id);
    Sistema.EsporteInserir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
  public static void EsporteListar() {
    Console.WriteLine("------ Listar os esportes cadastrados ------");
    foreach(Esporte objeto in Sistema.EsporteListar())
      Console.WriteLine(objeto);
    Console.WriteLine("----------------------------");
  }
}