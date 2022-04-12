using System;
using System.Collections.Generic;

class Pasutijums {
  public Pircejs Klients { get; }
  public List<Produkts> Preces { get; }
  public double Cena { get{
    double summa = 0;
    foreach(Produkts prece in this.Preces) {
      summa += prece.Cena * prece.Daudzums;
    }
    return summa;
  }}
  public string PasutijumaID { get; }

  public Pasutijums(Pircejs klients, string pasutijumaID) {
    this.Klients = klients;
    this.Preces = new List<Produkts>();
    this.PasutijumaID = pasutijumaID;    
  }

  public void PievienotGrozam(Produkts produkts) {
    this.Preces.Add(produkts);
  }

  public void Print() {
    Console.WriteLine($"Grozs klientam #{this.Klients.KlientaID}");
    Console.WriteLine($"Pasūtījums #{this.PasutijumaID}");
    foreach(Produkts prece in this.Preces) {
      Console.WriteLine($"> {prece.Daudzums}x {prece.Cena}€ {prece.Nosaukums}");
    }
    Console.WriteLine($"Kopā: {this.Cena}€");
    Console.WriteLine("");
  }
}