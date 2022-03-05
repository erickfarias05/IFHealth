using System;

class Sistema {
  private static Esporte[] esportes = new Esporte[10];
  private static int nEsporte;
  public static void EsporteInserir(Esporte objeto) {
    // Verificação do vetor
    if (nEsporte == esportes.Length)
      Array.Resize(ref esportes, 2 * esportes.Length);
    // Inserir o objeto
    esportes[nEsporte] = objeto;
    // Incrementar
    nEsporte++;
  }
  public static Esporte[] EsporteListar() {
    //Retornar objetos
    Esporte[] alo = new Esporte[nEsporte];
    Array.Copy(esportes, alo, nEsporte);
    return alo;
  }
}