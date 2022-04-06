using System;

class Pasutijums: Produkts {
  public string KlientaID { get; set; }
  public string Preces { get; set; }
  public double Cena { get; set; }
  public string PasutijumaID { get; set; }

  public Pasutijums(string klientaID, string preces, double cena, string pasutijumaID) : base (cena) {
    this.KlientaID = klientaID;
    this.Preces = preces;
    this.Cena = cena;
    this.PasutijumaID = pasutijumaID;    
  }
}