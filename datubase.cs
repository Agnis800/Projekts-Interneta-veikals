using System;
using System.Reflection;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

// Saglabā objektu XML formātā
// https://stackoverflow.com/a/4267126

public class DB {
  public string path {get; private set;}
  public object ReferenceObject {get; private set;}

  public DB(string path, object objekts) {
    this.path = path;
    this.ReferenceObject = objekts;
  }

  public object load() {
    return 0;
  }

  public void save(object objekts) {
    FileStream fs = new FileStream(this.path, FileMode.Create);
    BinaryFormatter formatter = new BinaryFormatter();
    formatter.Serialize(fs, objekts);
    fs.Close();
  }

  public bool Exists() {
    FileInfo f = new FileInfo(this.path);
    return f.Exists;
  }
  
}