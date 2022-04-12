using System;
using System.Collections.Generic;

class Pasutijums {
  public Pircejs Klients { get; }
  public List<Produkts> Preces { get; }
  public double Cena { get; }
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
    Console.WriteLine($"Grozs klientam {this.Klients.KlientaID}");
    foreach(Produkts prece in this.Preces) {
      Console.WriteLine($"> {prece.Daudzums}x  {prece.Nosaukums}");
    }
    Console.WriteLine($"Kopā: {this.Cena}");
    Console.WriteLine("");
  }
}