using Spedizioni;

var plico1 = new Plico("Giovanni","Leonardo","Mobile",300,100,200);

var plico2 = new Plico("Federico", "Franco","Scarpe", 70, 40, 50);


var pacco1 = new Pacco("Vincenzo", "Maria", "Lettera", 30, 10, 20, 5);


var pacco2 = new Pacco("Paolo", "Baldo", "Televisione", 300, 70, 110,20);

Console.WriteLine($"Il pacco 1: {pacco1} è meno ingombrante rispetto al pacco 2 {pacco2}");
Console.WriteLine(pacco1.Equals(pacco2) ? "I pacchi sono uguali" : "I pacchi sono diversi");

var bartolini = new Corriere("Bartolini");

bartolini.AddSpedizione(plico1);
bartolini.AddSpedizione(plico2);
bartolini.AddSpedizione(pacco1);
bartolini.AddSpedizione(pacco2);

bartolini.ListSpedizioni();



Console.ReadLine();