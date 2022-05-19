using System;

class Pircejs {
  public string PersonasKods { get; set; }
  public int KlientaID { get; set; }
  public int LojalitatesPunkti { get; set; }
  public double Nauda { get; set; }

  public Pircejs(string personasKods, int klientaID, double nauda) {
    this.PersonasKods = personasKods;
    this.KlientaID = klientaID;
    this.LojalitatesPunkti = 0;
    this.Nauda = nauda;
  }

  public void Print() {
    Console.WriteLine($"Klients #{this.KlientaID}");
    Console.WriteLine($"Nauda: {this.Nauda}");
    Console.WriteLine($"Lojalitāts punkti: {this.LojalitatesPunkti}");
    Console.WriteLine("");
  }

  public void Pirkt(Pasutijums pasutijums) {
    
    if(this.Nauda < pasutijums.Cena) {
      Console.WriteLine($">> Klientam {this.KlientaID} nepietiek naudas pasūtījumam {pasutijums.PasutijumaID}!");
      return false;
    }

    this.Nauda -= pasutijums.Cena;
    
    // 1% no cenas ir lojalitātes punkti
    this.LojalitatesPunkti += (int)Math.Floor(pasutijums.Cena / 100);

    pasutijums.nopirkts = true;

    return true;
  }
}