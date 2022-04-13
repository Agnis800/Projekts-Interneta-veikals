using System;

class Program {
  public static void Main (string[] args) {

    Pircejs klients = default;
    Pasutijums grozs = default;

    while(true) {
      if(klients == default(Pircejs)){
        Console.Clear();
        Console.WriteLine($"Sveicināti internetvaikalā!");
        Console.WriteLine($"1 - Pierakstīties");
        Console.WriteLine($"q - Aizvērt");

        Console.Write("\nJūsu izvēle: ");
        string input = Console.ReadLine();
        if(input == "q"){
          Console.Clear();
          Console.WriteLine("Paldies par ieprikšanos ar mums!");
          return;
        }
        if(input == "1") {
          Console.Clear();
          Console.WriteLine("Lūdu ievadiet savus datus lai reģistrētos!");
          Console.Write("\nJūsu personas kods: ");
          string persKods = Console.ReadLine();
          Console.Write("\nJūsu nauda bankā (esat godīgi): ");
          int nauda = Int32.Parse(Console.ReadLine());
          klients = new Pircejs(persKods, (int)(DateTime.Now.Ticks % 1000), nauda);
        }
      }
    }

    /*

    // Izveido klientu
    Pircejs klients = new Pircejs("1111-1111", 11111, 5000.00);

    klients.Print();

    // Uzsāk pasūtījumu
    Pasutijums pasutijums = new Pasutijums(klients, "11111-123");

    // Izveido preci
    Produkts prece_dators = new Produkts("1234512345", 20.50, "Lenovo BrickPad 5 pro", 0, 500);

    // Ieliek grozā 50 preces
    pasutijums.PievienotGrozam( prece_dators.Take(50) );

    // Izdrukā čeku
    pasutijums.Print();

    Console.WriteLine("===== Pasūta =====\n");

    // Pasūta
    klients.Pirkt(pasutijums);

    // Ir nopirkts
    pasutijums.Print();
    klients.Print();

*/
  }
}
