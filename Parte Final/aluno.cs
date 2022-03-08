 using System;

class Aluno {
  private string nome;
  private int ci;
  private string matricula;
  private string email;
  private int ciEsporte;
  private double peso;
  private double altura;
  public Aluno(string nome, int ci, string matricula, string email, int ciEsporte, double peso, double altura) {
    this.nome = nome;
    this.ci = ci;
    this.matricula = matricula;
    this.email = email;
    this.ciEsporte = ciEsporte;
    this.peso = peso;
    this.altura = altura;
  }
  public Aluno(int ci) {
    this.ci = ci;
  }
  public Aluno(double peso, double altura) {
    this.peso = peso;
    this.altura = altura;
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
  public void SetPeso(double peso) {
    this.peso = peso;
  }
   public void SetAltura(double altura) {
    this.altura = altura;
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
  public double GetPeso() {
    return peso;
  }
  public double GetAltura() {
    return altura;
  }  
  public override string ToString() {
    return $"{nome} - {ci} - {matricula} - {email} - {peso} kg - {altura} cm";
  }

}