using System;

class Servicoesp {
public int Ci { get; set; }
public string Nome { get; set; }
public double Preco { get; set; }
  public override string ToString() {
    return $"{Ci} {Nome} R$ {Preco:0.00}";
  }
}
