using System;

class Aluno {
  private string nome;
  private int ci;
  private string matricula;
  private string email;
  private int ciEsporte;
  public Aluno(string nome, int ci, string matricula, string email, int ciEsporte) {
    this.nome = nome;
    this.ci = ci;
    this.matricula = matricula;
    this.email = email;
    this.ciEsporte = ciEsporte;
  }
  public Aluno(int ci) {
    this.ci = ci;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetCi(int ci) {
    this.ci = ci;
  }
  public void SetMatricula(string matricula) {
    this.matricula = matricula;
  }
  public void SetEmail(string email) {
    this.email = email;
  }
  public void SetCiEsporte(int ciEsporte) {
    this.ciEsporte = ciEsporte;
  }
  public string GetNome() {
    return nome;
  }
  public int GetCi() {
    return ci;
  }
  public string GetMatricula() {
    return matricula;
  }
  public string GetEmail() {
    return email;
  }
  public int GetCiEsporte() {
    return ciEsporte;
  }
  public override string ToString() {
    return $"{nome} - {ci} - {matricula} - {email}";
  }
}