using System;

class Program {
  public static void Main (string[] args) {

    // Izveido klientu
    Pircejs klients = new Pircejs("1111-1111", 11111, 500.00);

    // Uzsāk pasūtījumu
    Pasutijums pasutijums = new Pasutijums(klients, "11111-123");

    // Izveido preci
    Produkts prece_dators = new Produkts("1234512345", 20.50, "Lenovo BrickPad 5 pro", 0, 500);

    // Ieliek grozā 50 preces
    pasutijums.PievienotGrozam( prece_dators.Take(50) );

    // Izdrukā čeku
    pasutijums.Print();
  }
}
