using System;

class Aluno {
  private string nome;
  private string matricula;
  private string email;
  private int idEsporte;
  public Aluno(string nome, string matricula, string email, int idEsporte) {
    this.nome = nome;
    this.matricula = matricula;
    this.email = email;
    this.idEsporte = idEsporte;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetMatricula(string matricula) {
    this.matricula = matricula;
  }
  public void SetEmail(string email) {
    this.email = email;
  }
  public void SetIdEsporte(int idEsporte) {
    this.idEsporte = idEsporte;
  }
  public string GetNome() {
    return nome;
  }
  public string GetMatricula() {
    return matricula;
  }
  public string GetEmail() {
    return email;
  }
  public int GetIdEsporte() {
    return idEsporte;
  }
  public override string ToString() {
    return $"{nome} - {matricula} - {email}";
  }
}