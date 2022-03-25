using System;

public class Esporte : IComparable <Esporte> {
  private int ci;
  private string nome;


  public int Ci {
    get => ci;
    set => ci = value;
  }

  public string Nome {
    get => nome;
    set => nome = value;
  }
  
  public Esporte(int ci, string nome) {
    this.ci = ci;
    this.nome = nome;
  }

  public Esporte() { } //Arquivo vazio
  
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

  public int CompareTo(Esporte a){
    return nome.CompareTo(a.GetNome());
  }

  public override string ToString() {
    return $"{ci} - {nome}";
  }
}