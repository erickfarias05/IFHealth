using System;
using System.Globalization;
using System.Threading;



class Program{
  public static void Main() {
       Thread.CurrentThread.CurrentCUlture = 
         new CultureInfo("pt-BR");
    
    Console.WriteLine("Seja bem-vindo ao IFHealth!");
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
          case 9 : ProfessorInserir(); break;
          case 10 : ProfessorListar(); break;
          case 11 : ProfessorAtualizar(); break;
          case 12 : ProfessorExcluir(); break;
          case 13 : ServicoespInserir(); break;
          case 14 : ServicoespListar(); break;
          case 15 : ServicoespAtualizar(); break;
          case 16 : ServicoespExcluir(); break;
          case 17 : AgendamentoAbrirAgenda(); break;
          case 18 : AgendamentoConsultarAgenda(); break;
          
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
    Console.WriteLine("..............:Menu Principal do ADM:................");
    Console.WriteLine(".------ Faça sua escolha! ----------.");
    Console.WriteLine(".");
    Console.WriteLine(".---Menu dos Esportes---");
    Console.WriteLine(".01 - Inserir um novo esporte à academia");
    Console.WriteLine(".02 - Listar os esportes cadastrados da academia");
    Console.WriteLine(".03 - Atualizar os dados de um esporte da academia");
    Console.WriteLine(".04 - Excluir um esporte da academia");
    Console.WriteLine(".");
    Console.WriteLine(".---Menu dos Alunos---");
    Console.WriteLine(".05 - Inserir um novo aluno à academia");
    Console.WriteLine(".06 - Listar os alunos cadastrados da academia");
    Console.WriteLine(".07 - Atualizar os dados de um aluno da academia");
    Console.WriteLine(".08 - Excluir um aluno da academia");
    Console.WriteLine(".");
    Console.WriteLine(".---Menu dos Professores---");
    Console.WriteLine(".09 - Inserir um novo professor à academia");
    Console.WriteLine(".10 - Listar os professores cadastrados da academia");
    Console.WriteLine(".11 - Atualizar os dados de um professor da academia");
    Console.WriteLine(".12 - Excluir um professor da academia");
    Console.WriteLine(".");
    Console.WriteLine(".---Menu dos Serviços especiais---");
    Console.WriteLine(".13 - Inserir um novo serviço à academia");
    Console.WriteLine(".14 - Listar os serviços cadastrados da academia");
    Console.WriteLine(".15 - Atualizar os dados de um serviço da academia");
    Console.WriteLine(".16 - Excluir um serviço da academia");
    Console.WriteLine(".");
     Console.WriteLine(".17 - Abrir agenda");
    Console.WriteLine(".18 - Consultar Agenda");
    Console.WriteLine(".");
    Console.WriteLine(".---Terminando trabalho---");
    Console.WriteLine(".00 - Finalizar o sistema");
    Console.WriteLine(".---------------------------------------------------");
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
    Console.WriteLine("------------------------------------------");
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
    Console.Write("Informe o peso do aluno: ");
    int peso = int.Parse(Console.ReadLine());
     Console.Write("Informe a altura do aluno: ");
    int altura = int.Parse(Console.ReadLine());
    
    EsporteListar();
    Console.Write("Informe o código do esporte: ");
    int ciEsporte = int.Parse(Console.ReadLine());

     ProfessorListar();
    Console.Write("Informe o código do professor: ");
    int ciProfessor = int.Parse(Console.ReadLine());
    
    Aluno objeto = new Aluno(nome, ci, matricula, email, ciEsporte, ciProfessor, peso, altura);
    Sistema.AlunoInserir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
  
  public static void AlunoListar() {
    Console.WriteLine("------ Listar os alunos cadastrados ------");
    foreach(Aluno objeto in Sistema.AlunoListar()) {
    Esporte e = Sistema.EsporteListar(objeto.GetCiEsporte());
    Professor p = Sistema.ProfessorListar(objeto.GetCiProfessor());
      Console.WriteLine($"{objeto} {e.GetCi()} {p.Ci}");
    }
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
    Console.Write("Informe o peso do aluno: ");
    int peso = int.Parse(Console.ReadLine());
    Console.Write("Informe a altura do aluno: ");
    int altura = int.Parse(Console.ReadLine());

    EsporteListar();
    Console.Write("Informe o código do esporte: ");
    int ciEsporte = int.Parse(Console.ReadLine());
   
    ProfessorListar();
    Console.Write("Informe o código do professor: ");
    int ciProfessor = int.Parse(Console.ReadLine());
    
    Aluno objeto = new Aluno(nome, ci, matricula, email, ciEsporte, ciProfessor, peso, altura);
    
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

/////////////////////////////////////////////////////////////////////

public static void ProfessorInserir() {
    Console.WriteLine("-------- Inserir um novo professor --------");
    Console.WriteLine("Informe o nome do professor: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o telefone do professor: ");
    string telefone = Console.ReadLine();

    
    Professor objeto = new Professor { Nome = nome, Telefone = telefone};
    Sistema.ProfessorInserir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
  public static void ProfessorListar() {
    Console.WriteLine("------ Listar os professores cadastrados ------");
    foreach(Professor objeto in Sistema.ProfessorListar())
      Console.WriteLine(objeto);
    Console.WriteLine("----------------------------");
  }
  public static void ProfessorAtualizar() {
    Console.WriteLine("-------- Atualizar dados de um professor --------");
    Console.Write("Informe o código do professor: ");
    int ci = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o nome do professor: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o telefone do professor: ");
    string telefone = Console.ReadLine();
    
    Professor objeto = new Professor { Ci= ci, Nome = nome, Telefone = telefone};
    
    Sistema.ProfessorAtualizar(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
    public static void ProfessorExcluir() {
    Console.WriteLine("-------- Excluir um professor --------");
    Console.Write("Informe o código do professor: ");
    int ci = int.Parse(Console.ReadLine());
    Professor objeto = new Professor { Ci= ci};
    Sistema.ProfessorExcluir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
    }
//////////////////////////////////////////////////////////////////////////
  
public static void ServicoespInserir() {
    Console.WriteLine("-------- Inserir um novo serviço especial --------");
    Console.WriteLine("Informe o nome do serviço: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o preço do serviço: ");
    double preco = double.Parse(Console.ReadLine());

    
    Servicoesp objeto = new Servicoesp { Nome = nome, Preco = preco};
    Sistema.ServicoespInserir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
  public static void ServicoespListar() {
    Console.WriteLine("------ Listar os serviços especiais cadastrados ------");
    foreach(Servicoesp objeto in Sistema.ServicoespListar())
      Console.WriteLine(objeto);
    Console.WriteLine("----------------------------");
  }
  public static void ServicoespAtualizar() {
    Console.WriteLine("-------- Atualizar dados de um serviço especial --------");
    Console.Write("Informe o código do serviço: ");
    int ci = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o nome do serviço: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o preco do serviço: ");
    double preco = double.Parse(Console.ReadLine());
    
    Servicoesp objeto = new Servicoesp { Ci= ci, Nome = nome, Preco = preco};
    
    Sistema.ServicoespAtualizar(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
    public static void ServicoespExcluir() {
    Console.WriteLine("-------- Excluir um serviço especial --------");
    Console.Write("Informe o código do serviço: ");
    int ci = int.Parse(Console.ReadLine());
    Servicoesp objeto = new Servicoesp { Ci= ci};
    Sistema.ServicoespExcluir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
    }
/////////////////////////////////////////////////////////////
   public static void AgendamentoAbrirAgenda() {
    Console.WriteLine("-------- Abrir Agenda --------");
     DateTime data = DateTime.Today;
    Console.WriteLine("Informe a data <enter para hoje> : ");
    string s = Console.ReadLine();
     if (s != "") data = DateTime.Parse(s);
    
    Sistema.AgendamentoAbrirAgenda(data);
    Console.WriteLine("------ Operação concluída! ------");
  }
  public static void AgendamentoConsultarAgenda() {
    Console.WriteLine("------ Consultar Agenda ------");
    foreach(Agendamento objeto in Sistema.AgendamentoListar())
      Console.WriteLine(objeto);
    Console.WriteLine("------------------------------------------");
  











  
}