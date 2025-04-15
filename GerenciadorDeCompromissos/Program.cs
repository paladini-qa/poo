using ConsoleApp.Modelos;

Compromisso compromisso = new();

Console.WriteLine("Vamos registrar um compromisso");

Console.Write("Digite a data do compromisso: ");

while (true)
{
  try
  {
    compromisso.Data = Console.ReadLine();
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova data: ");
  }
}

Console.Write("Digite a hora do compromisso: ");

while (true)
{
  try
  {
    compromisso.Hora = Console.ReadLine();
    break;
  }
  catch (Exception e)
  {
    Console.Write($"Erro: {e.Message}\nDigite uma nova hora: ");
  }
}