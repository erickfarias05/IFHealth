using System;

class Esporte {
  private string nome;
  private int ci;
  public Esporte(int ci, string nome) {
    this.ci = ci;
    this.nome = nome;
  }
  public void SetCi(int ci) {
    this.ci = ci;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public int GetCi() {
    return ci;
  }
  public string GetNome() {
    return nome;
  }
  public override string ToString() {
    return $"{ci} - {nome}";
  }
}