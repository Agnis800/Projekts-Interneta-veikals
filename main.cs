using System;

class Program {
  public static void Main (string[] args) {

    Pircejs klients = default;
    Pasutijums grozs = default;
    string Lapa = "sākums";
    Produkts prece_dators = new Produkts("1234512345", 20.50, "Lenovo BrickPad 5 pro", 0.00, 500);
    Produkts prece_putekļsūcējs = new Produkts("1516176185", 287.99, "Xiaomi Mop Pro", 0.00, 1000);
    Produkts prece_telts = new Produkts("2536746726", 229.00, "Coleman Kobuk Valley 3 Plus", 0.00, 200);
    Produkts prece_spēle = new Produkts("6256197653", 31.01, "Brain Games Catan", 20.68, 400);
    
    
    while(true) {
      if(klients == default(Pircejs)){
        Console.Clear();
        Console.WriteLine("Sveicināti internetveikalā!");
        Console.WriteLine("1 - Pierakstīties");
        Console.WriteLine("q - Aizvērt");

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
          double nauda = Double.Parse(Console.ReadLine());
          klients = new Pircejs(persKods, (int)(DateTime.Now.Ticks % 1000), nauda);
          grozs = new Pasutijums(klients, (int)(DateTime.Now.Ticks % 100));
        }
      }
      if(Lapa == "sākums") {
        Console.Clear();
        Console.WriteLine("1 - Apskatīt grozu");
        Console.WriteLine("2 - Apskatīt produktus");
        Console.WriteLine("q - Aizvērt");

        Console.Write("\nJūsu izvēle: ");
        string input = Console.ReadLine();
        if(input == "q"){
        Console.Clear();
        Console.WriteLine("Paldies par ieprikšanos ar mums!");
        return;
        }
        if(input == "1") {
          Console.Clear();
          grozs.Print();
          Console.WriteLine("Nospied Enter, lai aizietu atpakaļ");
          Console.ReadLine();
          continue;
        }
        if(input == "2") {
          Console.Clear();
          prece_dators.Print();
          prece_putekļsūcējs.Print();
          prece_spēle.Print();
          prece_telts.Print();
          Console.WriteLine("Nospied Enter, lai aizietu atpakaļ");
          Console.ReadLine();
          continue;
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
