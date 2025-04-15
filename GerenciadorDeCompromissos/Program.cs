using ConsoleApp.Modelos;

//Compromisso compromisso = new Compromisso();
//var compromisso = new Compromisso();

Compromisso compromisso = new();
compromisso.Data = DateTime.Now.Date;

Console.Write(compromisso.Data);
Console.Write(compromisso.DataBR);