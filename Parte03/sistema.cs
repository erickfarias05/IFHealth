using System;
using System.Collections.Generic;

class Sistema {
  private static Esporte[] esportes = new Esporte[10];
  private static int nEsporte;
  private static List<Aluno> alunos = new List<Aluno>();
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
  public static void AlunoInserir(Aluno objeto) {
    // Inserir o objeto
    alunos.Add(objeto);
  }
  public static List<Aluno> AlunoListar() {
    //Retornar objetos
    return alunos;
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
    }
  }
  public static void AlunoExcluir(Aluno objeto) {
    Aluno mud = AlunoListar(objeto.GetCi());
    if (mud != null)
      alunos.Remove(mud);
  }
}