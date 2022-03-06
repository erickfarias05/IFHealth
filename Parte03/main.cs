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
          case 5 : AlunoInserir(); break;
          case 6 : AlunoListar(); break;
          case 7 : AlunoAtualizar(); break;
          case 8 : AlunoExcluir(); break;
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
    Console.WriteLine("03 - Atualizar os dados de um esporte da academia");
    Console.WriteLine("04 - Excluir um esporte da academia");
    Console.WriteLine("05 - Inserir um novo aluno à academia");
    Console.WriteLine("06 - Listar os alunos cadastrados da academia");
    Console.WriteLine("07 - Atualizar os dados de um aluno da academia");
    Console.WriteLine("08 - Excluir um aluno da academia");
    Console.WriteLine("00 - Finalizar o sistema");
    Console.WriteLine("-------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static void EsporteInserir() {
    Console.WriteLine("-------- Inserir um novo esporte --------");
    Console.WriteLine("Informe o nome do esporte: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o código do esporte: ");
    int ci = int.Parse(Console.ReadLine());
    Esporte objeto = new Esporte(nome, ci);
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
    Console.Write("Informe o código do esporte: ");
    int ci = int.Parse(Console.ReadLine());
    Console.Write("Informe o novo nome do esporte: ");
    string nome = Console.ReadLine();
    Esporte objeto = new Esporte(nome, ci);
    Sistema.EsporteAtualizar(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
    public static void EsporteExcluir() {
    Console.WriteLine("-------- Excluir um esporte --------");
    Console.Write("Informe o código do esporte: ");
    int ci = int.Parse(Console.ReadLine());
    string nome = "";
    Esporte objeto = new Esporte(nome, ci);
    Sistema.EsporteExcluir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
  //////////////////////////////////////////////////////////////////
  public static void AlunoInserir() {
    Console.WriteLine("-------- Inserir um novo aluno --------");
    Console.WriteLine("Informe o nome do aluno: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o código do aluno: ");
    int ci = int.Parse(Console.ReadLine());
    Console.Write("Informe a matrícula do aluno: ");
    string matricula = Console.ReadLine();
    Console.Write("Informe o email do aluno: ");
    string email = Console.ReadLine();

    EsporteListar();
    Console.Write("Informe o código do esporte: ");
    int ciEsporte = int.Parse(Console.ReadLine());
    
    Aluno objeto = new Aluno(nome, ci, matricula, email, ciEsporte);
    Sistema.AlunoInserir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
  public static void AlunoListar() {
    Console.WriteLine("------ Listar os alunos cadastrados ------");
    foreach(Aluno objeto in Sistema.AlunoListar())
      Console.WriteLine(objeto);
    Console.WriteLine("----------------------------");
  }
  public static void AlunoAtualizar() {
    Console.WriteLine("-------- Atualizar dados de um aluno --------");
    Console.Write("Informe o código do aluno: ");
    int ci = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o nome do aluno: ");
    string nome = Console.ReadLine();
    Console.Write("Informe a matrícula do aluno: ");
    string matricula = Console.ReadLine();
    Console.Write("Informe o email do aluno: ");
    string email = Console.ReadLine();

    EsporteListar();
    Console.Write("Informe o código do esporte: ");
    int ciEsporte = int.Parse(Console.ReadLine());

    Aluno objeto = new Aluno(nome, ci, matricula, email, ciEsporte);
    
    Sistema.AlunoAtualizar(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
    public static void AlunoExcluir() {
    Console.WriteLine("-------- Excluir um aluno --------");
    Console.Write("Informe o código do aluno: ");
    int ci = int.Parse(Console.ReadLine());
    Aluno objeto = new Aluno(ci);
    Sistema.AlunoExcluir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
}