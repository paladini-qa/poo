namespace ConsoleApp.Modelos;

public class Compromisso
{
  private DateTime _data;
  private TimeSpan _hora;
  public bool eHoje { get; set; } = true;
  public string Hora
  {
    get { return _hora.ToString(); }
    set
    {
      _validarHoraInformada(value);
      _validarHoraValidaParaCompromisso();
    }
  }
  public String Data
  {
    get { return _data.ToString(); }
    set
    {
      _validarDataInformada(value);
      _validarDataValidaParaCompromisso();
      _validarEHoje();
    }
  }
  private void _validarEHoje()
  {
    if (_data.Date < DateTime.Now.Date)
    {
      eHoje = false;
    }
    else
    {
      eHoje = true;
    }
  }
  private void _validarHoraInformada(string hora)
  {
    if (!TimeSpan.TryParse(hora, out TimeSpan parsedHora))
    {
      throw new Exception($"Hora {hora} Inválida!");
    }
    _hora = parsedHora;
  }
  private void _validarHoraValidaParaCompromisso()
  {
    if (eHoje == true)
    {
      if (_hora < DateTime.Now.TimeOfDay)
      {
        throw new Exception($"Hora {_hora} é inferior a permitida.");
      }
    }
  }
  private void _validarDataInformada(string data)
  {
    if (!DateTime.TryParseExact(data,
                   "dd/MM/yyyy",
                   System.Globalization.CultureInfo.GetCultureInfo("pt-BR"),
                   System.Globalization.DateTimeStyles.None,
                   out _data))
    {
      throw new Exception($"Data {data} Inválida!");
    }
  }
  private void _validarDataValidaParaCompromisso()
  {
    if (_data.Date < DateTime.Now.Date)
    {
      throw new Exception($"Data {_data.ToString("dd/MM/yyyy")} é inferior a permitida.");
    }
  }
}