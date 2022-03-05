using System;

class Esporte {
  private string nome;
  private int id;
  public Esporte(string nome, int id) {
    this.nome = nome;
    this.id = id;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public string GetNome() {
    return nome;
  }
  public int GetId() {
    return id;
  }
  public override string ToString() {
    return $"{nome} - {id}";
  }
}