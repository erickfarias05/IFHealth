using System;

class Agendamento {
public int Ci { get; set; }
public DateTime DataHora { get; set; }
public int CiAluno { get; set; }
public int CiServicoesp { get; set; }
  public override string ToString() {
    string s = $"{Ci} {DataHora:dd/MM/yyyy HH:mm}";
    if (CiAluno == 0) s += "- Disponível"; 
    return s;
  }
}
