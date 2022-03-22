using System;

class Professor {
public int Ci { get; set; }
public string Nome { get; set; }
public string Telefone { get; set; }
  public override string ToString() {
    return $"{Ci} {Nome} {Telefone}";
  }
}
