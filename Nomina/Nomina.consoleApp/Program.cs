// See https://aka.ms/new-console-template for more information
DateTime fecha = new DateTime(2020, 1, 6);
DateTime momentoActual = DateTime.Now;
Console.WriteLine(fecha.ToString());
Console.WriteLine(momentoActual.ToString());
TimeSpan lapso = DateTime.Now - fecha;
DateTime momentoCero = new DateTime(1, 1, 1);
int anios = (momentoCero + lapso).Year - 1;
Console.WriteLine(lapso.Days);
Console.WriteLine(lapso.TotalDays);
Console.WriteLine(lapso.TotalHours);