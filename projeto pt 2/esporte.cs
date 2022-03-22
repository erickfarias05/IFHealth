using System;

class Esporte {
  private string nome;
  private int ci;
  public Esporte(string nome, int ci) {
    this.nome = nome;
    this.ci = ci;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetCi(int ci) {
    this.ci = ci;
  }
  public string GetNome() {
    return nome;
  }
  public int GetCi() {
    return ci;
  }
  public override string ToString() {
    return $"{nome} - {ci}";
  }
}