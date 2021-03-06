using System;

public class Produkts {
  public string SvitruKods { get; set; }
  public double Cena { get; set; }
  public string Nosaukums { get; set; }
  public double Atlaide { get; set; }
  public int Daudzums {get; set;}

  public Produkts(string svitruKods, double cena, string nosaukums, double atlaide, int daudzums) {
    this.SvitruKods = svitruKods;
    this.Cena = cena;
    this.Nosaukums = nosaukums;
    this.Atlaide = atlaide;
    this.Daudzums = daudzums;
  }

  public Produkts(string import) {
    string[] parts = import.Split("|");

    Console.WriteLine(import);

    this.SvitruKods = parts[0];
    this.Cena = Double.Parse(parts[1]);
    this.Nosaukums = parts[2];
    this.Atlaide = Double.Parse(parts[3]);
    this.Daudzums = (int)Int64.Parse(parts[4]);
    
  }

  public void Print() {
    Console.WriteLine($"Svītru kods: {this.SvitruKods}");
    Console.WriteLine($"Cena: {this.Cena}");
    Console.WriteLine($"Nosaukums: {this.Nosaukums}");
    Console.WriteLine($"Atlaide: {this.Atlaide}");
    Console.WriteLine($"Daudzums: {this.Daudzums}");
    Console.WriteLine("");
  }

  // "Izņem" produktu no veikala pievienošanai pasūtījumam
  public Produkts Take(int daudzums) {
    if(this.Daudzums<daudzums) {
      // Ja nepietiek naudas visam, pievieno maksimālo iespējamo
      Console.WriteLine($">> Nepietiek produkta {this.Nosaukums}. Prasīti {daudzums}, bet ir tikai {this.Daudzums}!");
      daudzums = this.Daudzums;
    }
    this.Daudzums -= daudzums;
    return new Produkts(this.SvitruKods, this.Cena, this.Nosaukums, this.Atlaide, daudzums);
  }

  // Atgriež produktu kā string
  public string Export() {
    return $"{this.SvitruKods}|{this.Cena}|{this.Nosaukums}|{this.Atlaide}|{this.Daudzums}";
  }
  
}