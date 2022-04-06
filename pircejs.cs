using System;

class Pircejs : Pasutijums {
  public string PersonasKods { get; set; }
  public int KlientaID { get; set; }
  public int LojalitatesPunkti { get; set; }
  public double Nauda { get; set; }

  public Pircejs(string personasKods, int klientaID, int lojalitatesPunkti, double nauda) : base (klientaID) {
    this.PersonasKods = personasKods;
    this.KlientaID = klientaID;
    this.LojalitatesPunkti = lojalitatesPunkti;
    this.Nauda = nauda;
  }
}