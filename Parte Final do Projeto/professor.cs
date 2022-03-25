using System;

public class Professor : IComparable <Professor> {
  public int Ci { get; set; }
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public override string ToString() {
      return $"{Ci} - {Nome} - {Telefone}";
  }

  public string GetNome() {
    return Nome;
  }
  
  public int CompareTo(Professor a){
    //string b = Professor.Nome;
    return this.Nome.CompareTo(a.GetNome());
  }
  

}
