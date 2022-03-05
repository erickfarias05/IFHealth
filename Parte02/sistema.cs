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
    Esporte[] mud = new Esporte[nEsporte];
    Array.Copy(esportes, mud, nEsporte);
    return mud;
  }
  public static Esporte EsporteListar(int id) {
    foreach(Esporte objeto in esportes)
      if (objeto != null && objeto.GetId() == id) return objeto;
    return null;
  }
  public static void EsporteAtualizar(Esporte objeto) {
    Esporte mud = EsporteListar(objeto.GetId());
    if (mud != null)
      mud.SetNome(objeto.GetNome());
  }
  public static void EsporteExcluir(Esporte objeto) {
    int mud = EsporteIndice(objeto.GetId());
    if (mud != -1) {
      for (int i = mud; i < nEsporte - 1; i++)
        esportes[i] = esportes[i + 1];
      nEsporte--;
    }
  }
  private static int EsporteIndice(int id) {
    for (int i = 0; i < nEsporte; i++) {
      Esporte objeto = esportes[i];
      if (objeto.GetId() == id) return i;
    }
    return -1;
  }
}