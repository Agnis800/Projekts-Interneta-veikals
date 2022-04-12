using System;

class Produkts {
  public string SvitruKods { get; set; }
  public double Cena { get; set; }
  public string Nosaukums { get; set; }
  public int Atlaide { get; set; }
  public int Daudzums {get; set;}

  public Produkts(string svitruKods, double cena, string nosaukums, int atlaide) {
    this.SvitruKods = svitruKods;
    this.Cena = cena;
    this.Nosaukums = nosaukums;
    this.Atlaide = atlaide;
  }

  public void AddProduct() {
    
  }
  
}