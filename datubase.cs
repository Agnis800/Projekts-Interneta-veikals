using System;
using System.IO;
using System.Collections.Generic;

// Saglabā objektu XML formātā
// https://stackoverflow.com/a/4267126

public class DB {

  const string path = "./dati/Produkti.txt";

  public static bool Exists() {
    return File.Exists(DB.path);
  }

  public static void Save(List<Produkts> produkti) {

    File.WriteAllText(DB.path, "");

    foreach (Produkts produkts in produkti) {
      
      File.AppendAllText(DB.path, produkts.Export() + "\n");
      
    }
    
  }

  public static List<Produkts> Load() {
    string[] lines = File.ReadAllLines(DB.path);

    List < Produkts > produkti = new List < Produkts > ();

    foreach(string line in lines) {

      if(line.Length == 0) {
        continue;
      }
      
      produkti.Add(new Produkts(line));
    }

    return produkti;
  }
  
}