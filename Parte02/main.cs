using System;

class Program{
  public static void Main() {
    Console.WriteLine("Seja bem-vindo ao IFHealth");
    int op = 0;
    do {
      try {
      op = Menu();
        switch(op) {
          case 1 : EsporteInserir(); break;
          case 2 : EsporteListar(); break;
          case 3 : EsporteAtualizar(); break;
          case 4 : EsporteExcluir(); break;
        }
      }
      catch (Exception erro) {
        op = -1;
        Console.WriteLine("Erro: " + erro.Message);
      }
    } while (op != 0);
  }
  public static int Menu() {
    Console.WriteLine();
    Console.WriteLine("------ Faça sua escolha! ------");
    Console.WriteLine("01 - Inserir um novo esporte à academia");
    Console.WriteLine("02 - Listar os esportes cadastrados da academia");
    Console.WriteLine("03 - Atualizar os dados de algum esporte da academia");
    Console.WriteLine("04 - Excluir um esporte da academia");
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
  public static void EsporteAtualizar() {
    Console.WriteLine("-------- Atualizar dados de um esporte --------");
    Console.Write("Informe o id do esporte: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe o novo nome do esporte: ");
    string nome = Console.ReadLine();
    Esporte objeto = new Esporte(nome, id);
    Sistema.EsporteAtualizar(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
    public static void EsporteExcluir() {
    Console.WriteLine("-------- Excluir um esporte --------");
    Console.Write("Informe o id do esporte: ");
    int id = int.Parse(Console.ReadLine());
    string nome = "";
    Esporte objeto = new Esporte(nome, id);
    Sistema.EsporteExcluir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
}