using System;
using System.Collections.Generic;

class Sistema {
  private static Esporte[] esportes = new Esporte[10];
  private static int nEsporte;
  private static List<Aluno> alunos = new List<Aluno>();
  private static List<Professor> professores = new List<Professor>();
  private static List<Servicoesp> servicos = new List<Servicoesp>();
    private static List<Agendamento> agendamentos = new List<Agendamento>();
  public static void EsporteInserir(Esporte objeto) {
    // Verificação do vetor
    if (nEsporte == esportes.Length)
      Array.Resize(ref esportes, 2 * esportes.Length);
    // Inserir o objeto
    esportes[nEsporte] = objeto;
    // Incrementar
    nEsporte++;
  }
  public static Esporte[] EsporteListar() {
    //Retornar objetos
    Esporte[] mud = new Esporte[nEsporte];
    Array.Copy(esportes, mud, nEsporte);
    return mud;
  }
  public static Esporte EsporteListar(int ci) {
    foreach(Esporte objeto in esportes)
      if (objeto != null && objeto.GetCi() == ci) return objeto;
    return null;
  }
  public static void EsporteAtualizar(Esporte objeto) {
    Esporte mud = EsporteListar(objeto.GetCi());
    if (mud != null)
      mud.SetNome(objeto.GetNome());
  }
  public static void EsporteExcluir(Esporte objeto) {
    int mud = EsporteIndice(objeto.GetCi());
    if (mud != -1) {
      for (int i = mud; i < nEsporte - 1; i++)
        esportes[i] = esportes[i + 1];
      nEsporte--;
    }
  }
  private static int EsporteIndice(int ci) {
    for (int i = 0; i < nEsporte; i++) {
      Esporte objeto = esportes[i];
      if (objeto.GetCi() == ci) return i;
    }
    return -1;
  }
  /////////////////////////////////////////////////////////////
   public static void ProfessorInserir(Professor objeto) {
    int ci = 0;
     foreach(Professor mud in professores)
       if (mud.Ci > ci) ci = mud.Ci;
     objeto.Ci = ci + 1;
     // Inserir o objeto
     
    professores.Add(objeto);
  }
  public static List<Professor> ProfessorListar() {
    //Retornar objetos
    return professores;
  }
  public static Professor ProfessorListar(int ci) {
    foreach(Professor objeto in professores)
      if (objeto.Ci == ci) return objeto;
    return null;
  }
  public static void ProfessorAtualizar(Professor objeto) {
    Professor mud = ProfessorListar(objeto.Ci);
    if (mud != null) {
      mud.Nome = objeto.Nome;
      mud.Telefone = objeto.Telefone;
  }
  }
    
  public static void ProfessorExcluir(Professor objeto) {
    Professor mud = ProfessorListar(objeto.Ci);
    if (mud != null)
      professores.Remove(mud);
  }


  ////////////////////////////////////////////////////////////////////////
  public static void AlunoInserir(Aluno objeto) {
    // Inserir o objeto
    alunos.Add(objeto);
  }
  public static List<Aluno> AlunoListar() {
    //Retornar objetos
    return alunos;
  }
    public static List<Aluno> AlunoListar(Professor professor) {
    //Retornar objetos
      List<Aluno> a = new List<Aluno>();
       foreach(Aluno objeto in alunos)
      if (objeto.GetCiProfessor() == professor.Ci) 
        a.Add(objeto);
    return a;
  }
  public static Aluno AlunoListar(int ci) {
    foreach(Aluno objeto in alunos)
      if (objeto.GetCi() == ci) return objeto;
    return null;
  }
  public static void AlunoAtualizar(Aluno objeto) {
    Aluno mud = AlunoListar(objeto.GetCi());
    if (mud != null) {
      mud.SetNome(objeto.GetNome());
      mud.SetMatricula(objeto.GetMatricula());
      mud.SetEmail(objeto.GetEmail());
      mud.SetCiEsporte(objeto.GetCiEsporte());
      mud.SetPeso(objeto.GetPeso());
      mud.SetAltura(objeto.GetAltura());
    }
  }
  public static void AlunoExcluir(Aluno objeto) {
    Aluno mud = AlunoListar(objeto.GetCi());
    if (mud != null)
      alunos.Remove(mud);
  }


//////////////////////////////////////////////////////////////////

 public static void ServicoespInserir(Servicoesp objeto) {
    int ci = 0;
     foreach(Servicoesp mud in servicos)
       if (mud.Ci > ci) ci = mud.Ci;
     objeto.Ci = ci + 1;
     // Inserir o objeto
     
    servicos.Add(objeto);
  }
  public static List<Servicoesp> ServicoespListar() {
    //Retornar objetos
    return servicos;
  }
  public static Servicoesp ServicoespListar(int ci) {
    foreach(Servicoesp objeto in servicos)
      if (objeto.Ci == ci) return objeto;
    return null;
  }
  public static void ServicoespAtualizar(Servicoesp objeto) {
    Servicoesp mud = ServicoespListar(objeto.Ci);
    if (mud != null) {
      mud.Nome = objeto.Nome;
      mud.Preco = objeto.Preco;
  }
  }
    
  public static void ServicoespExcluir(Servicoesp objeto) {
    Servicoesp mud = ServicoespListar(objeto.Ci);
    if (mud != null)
      servicos.Remove(mud);
  }

////////////////////////////////////////////////////////////////////////


   public static void AgendamentoInserir(Agendamento objeto) {
    int ci = 0;
     foreach(Agendamento mud in agendamentos)
       if (mud.Ci > ci) ci = mud.Ci;
     objeto.Ci = ci + 1;
     // Inserir o objeto
     
    agendamentos.Add(objeto);
  }

  public static void AgendamentoAbrirAgenda (DateTime data) {
   int[] horas = {12, 13, 14, 15, 16, 17, 18, 19, 20};
    DateTime hoje= data.Date;
    foreach (int h in horas) {
      TimeSpan horario = new TimeSpan(0, h, 0, 0);
      Agendamento objeto = new Agendamento { DataHora = hoje + horario };
      AgendamentoInserir(objeto);
    }
    
  }
  public static List<Agendamento> AgendamentoListar() {
    //Retornar objetos
    return agendamentos;
  }
  public static Agendamento AgendamentoListar(int ci) {
    foreach(Agendamento objeto in agendamentos)
      if (objeto.Ci == ci) return objeto;
    return null;
  }
  public static List<Agendamento> AgendamentoListar(Aluno aluno) { 
    List<Agendamento> r = new List<Agendamento>();
    foreach(Agendamento objeto in agendamentos)
      if (objeto.CiAluno == Aluno.Ci )
        r.add (objeto);
        return r;
    
  }
  public static void AgendamentosAtualizar(Agendamento objeto) {
    Agendamento mud = AgendamentoListar(objeto.Ci);
    if (mud != null) {
      mud.DataHora = objeto.DataHora;
      mud.CiAluno = objeto.CiAluno;
      mud.CiServicoesp = objeto.CiServicoesp;
  }
  }
    
  public static void AgendamentoExcluir(Agendamento objeto) {
    Agendamento mud = AgendamentoListar(objeto.Ci);
    if (mud != null)
      agendamentos.Remove(mud);

    
  }


}
