using System;
using System.Globalization;
using System.Threading;

class Program{

  private static Professor professorLogin = null;
  
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

    try {
      Sistema.ArquivosAbrir();
    }
    catch (Exception erro) {
      Console.WriteLine(erro.Message);
    }
    
    Console.WriteLine("Seja bem-vindo ao IFHealth!");
    int op = 0;
    int perfil = 0;
    do {
      try {
        if (perfil == 0) {
          op = 0;
          perfil = MenuUsuario();
        }
        if (perfil == 1) {
          op = MenuAdmin();
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
            case 99: perfil = 0; break;
          }
        }
        if (perfil == 2 && professorLogin == null) {
          op = MenuProfessorLogin();
          switch(op) {
            case 1 : ProfessorLogin(); break;
            case 99: perfil = 0; break;
          }
        }
        if (perfil == 2 && professorLogin != null) {
          op = MenuProfessorLogout();
          switch(op) {
            case 1 : ProfessorListarAlunos(); break;
            case 99: ProfessorLogout(); break;
          }
        }
      }
      catch (Exception erro) {
        op = -1;
        Console.WriteLine("Erro: " + erro.Message);
      }
    } while (op != 0);

    try {
      Sistema.ArquivosSalvar();
    }
    catch (Exception erro) {
      Console.WriteLine(erro.Message);
    }    
  }

  public static void ProfessorLogin() {
    Console.WriteLine("------- Login do Professor -------");
    ProfessorListar();
    Console.Write("Informe o código do professor para logar: ");
    int ci = int.Parse(Console.ReadLine());
    professorLogin = Sistema.ProfessorListar(ci);
  }
  public static void ProfessorLogout() {
    Console.WriteLine("------- Logout do Professor -------");
    professorLogin = null;
  }

  public static void ProfessorListarAlunos() {
    Console.WriteLine("------ Meus alunos cadastrados ------");
    foreach(Aluno objeto in Sistema.AlunoListar()) {
      if(professorLogin.Ci.Equals(objeto.CiProfessor)){
        Esporte e = Sistema.EsporteListar(objeto.GetCiEsporte());
        Professor p = Sistema.ProfessorListar(objeto.GetCiProfessor());
        Console.WriteLine($"{objeto} - {e.GetCi()} - {p.Ci} ");
      }
    }
    Console.WriteLine("----------------------------");
  }
  
  public static int MenuUsuario() {
    Console.WriteLine();
    Console.WriteLine("---------------------------");
    Console.WriteLine("1 - Entrar como Administrador");
    Console.WriteLine("2 - Entrar como Professor");
    Console.WriteLine("0 - Fim");
    Console.WriteLine("----------------------------");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  
  public static int MenuAdmin() {
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
    Console.WriteLine(".99 - Voltar ao menu anterior");
    Console.WriteLine(".---Terminando trabalho---");
    Console.WriteLine(".00 - Finalizar o sistema");
    Console.WriteLine(".---------------------------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static int MenuProfessorLogin() {
    Console.WriteLine();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("01 - Login");
    Console.WriteLine("99 - Voltar");
    Console.WriteLine("00 - Finalizar");
    Console.WriteLine("------------------------------");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static int MenuProfessorLogout() {
    Console.WriteLine();
    Console.WriteLine("------------------------");
    Console.WriteLine("Bem vindo(a), " + professorLogin.Nome);
    Console.WriteLine("--------------------------");
    Console.WriteLine("01 - Listar meus alunos");
    Console.WriteLine("99 - Logout");
    Console.WriteLine("00 - Finalizar");
    Console.WriteLine("-----------------------------");
    Console.Write("Informe uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  
  ///////////////////////////////////////////////////////////////////////////////////////
  public static void EsporteInserir() {
    Console.WriteLine("-------- Inserir um novo esporte --------");
    Console.WriteLine("Informe o nome do esporte: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o código do esporte: ");
    int ci = int.Parse(Console.ReadLine());
    Esporte objeto = new Esporte(ci, nome);
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
    Esporte objeto = new Esporte(ci, nome);
    Sistema.EsporteAtualizar(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
    public static void EsporteExcluir() {
    Console.WriteLine("-------- Excluir um esporte --------");
    Console.Write("Informe o código do esporte: ");
    int ci = int.Parse(Console.ReadLine());
    string nome = "";
    Esporte objeto = new Esporte(ci, nome);
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
    
    Aluno objeto = new Aluno(nome, ci, matricula, email, ciEsporte, peso, altura, ciProfessor );
    Sistema.AlunoInserir(objeto);
    Console.WriteLine("------ Operação concluída! ------");
  }
  
  public static void AlunoListar() {
    Console.WriteLine("------ Listar os alunos cadastrados ------");
    foreach(Aluno objeto in Sistema.AlunoListar()) {
      Esporte e = Sistema.EsporteListar(objeto.GetCiEsporte());
      Professor p = Sistema.ProfessorListar(objeto.GetCiProfessor());
      Console.WriteLine($"{objeto} - {e.GetCi()} - {p.Ci} ");
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
    
    Aluno objeto = new Aluno(nome, ci, matricula, email, ciEsporte, peso, altura, ciProfessor);
    
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
  

}