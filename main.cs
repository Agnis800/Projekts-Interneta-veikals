using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    Pircejs klients = default; 
    Pasutijums grozs = default;
    string Lapa = "sākums";

    List<Produkts> produkti = new List<Produkts>();

    produkti.Add(new Produkts("1234512345", 20.50, "Lenovo BrickPad 5 pro", 0.00, 500));
    produkti.Add(new Produkts("1516176185", 287.99, "Xiaomi Mop Pro", 0.00, 1000));
    produkti.Add(new Produkts("1516176185", 287.99, "Xiaomi Mop Pro", 0.00, 1000));
    produkti.Add(new Produkts("2536746726", 229.00, "Coleman Kobuk Valley 3 Plus", 0.00, 200));
    produkti.Add(new Produkts("6256197653", 31.01, "Brain Games Catan", 20.68, 400));
    
    
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
        Console.WriteLine("3 - Pievienot produktu grozam");
        Console.WriteLine("4 - Veikt pirkumu");
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
          foreach(Produkts produkts in produkti) {
            produkts.Print();
          }
          Console.WriteLine("Nospied Enter, lai aizietu atpakaļ");
          Console.ReadLine();
          continue;
        }

        if(input == "3") {
          Console.Clear();
          for(var i = 0; i < produkti.Count; i ++) { 
            Produkts produkts = produkti[i];
            Console.WriteLine($">>> Produkts {i}");
            produkts.Print();
          }
          Console.Write("Izvēlaties produktu (q lai izietu): ");
          string atbilde = Console.ReadLine();
          if(atbilde == "q"){
            Lapa = "sākums";
            continue;
          }
          if(Int32.TryParse(atbilde, out int j)) {
            Console.Write("Izvēlaties skaitu (q lai izietu): ");
            atbilde = Console.ReadLine();
            if(atbilde == "q"){
              Lapa = "sākums";
              continue;
            }
            if(Int32.TryParse(atbilde, out int skaits)) {
              grozs.PievienotGrozam( produkti[j].Take(skaits) );
              Lapa = "sākums";
              continue;
            } else {
              continue;
            }
          } else {
            continue;
          }
      }

     if(input == "4") {
        //TODO veikt pirkumu
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
