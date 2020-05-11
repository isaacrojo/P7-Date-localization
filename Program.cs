using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
             
        // P7 - Date localization

        //Pedir al usuario que ingrese una fecha y hora
        System.Console.WriteLine("Escribe una fecha y hora: (yyyy - MM - dddd  Hora : minuto : segundo) \n Exclusivamente en ese formato");
        System.DateTime dateTyped =  System.DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("\nFecha introducida:");
        System.Console.WriteLine(dateTyped);    //fecha inicial

        //A partir de la fecha actual, obtener la fecha "dentro de 2 horas y 30 minutos" y mostrarla
        System.Console.WriteLine("\nHora despues de 2 horas y 30 minutos:");
        dateTyped = dateTyped.AddHours(2).AddMinutes(30);
        System.Console.WriteLine(dateTyped);

        //Mostrar la fecha y hora actual en horario UTC
         System.DateTime actualDate = System.DateTime.UtcNow;
            System.Console.WriteLine($"\nHora UTC actual:  {actualDate}");


        //Mostrar la fecha y hora actual en horario de otro país y mencionar el nombre del país
        TimeZoneInfo otraZona =  TimeZoneInfo.FindSystemTimeZoneById("Argentina Standard Time");   //aqui se puede obtener el standard time de cualquier pais
        System.DateTime horaArgentina = TimeZoneInfo.ConvertTime(System.DateTime.Now, otraZona);

        System.Console.WriteLine($"\nLa fecha y hora actual en Argentina es: {horaArgentina}");
        //fuente: https://www.campusmvp.es/recursos/post/Cambios-de-zona-horaria-en-NET.aspx

        //Comparar la fecha y hora actual con la fecha y hora ingresada. 
        //Si la fecha ingresada está en el futuro, mostrar cuántos días faltan. 
        //Si la fecha ingresada está en el pasado, mostrar cuántos días han transcurrido
            System.Console.WriteLine("\n");

            if (dateTyped < System.DateTime.Now)  {//past
                TimeSpan timeDif = System.DateTime.Now - dateTyped;
                System.Console.WriteLine($"{timeDif.Days} dias transcurridos desde fecha ingresada ");
            }
                
            else if (dateTyped == System.DateTime.Now) {
                System.Console.WriteLine("{0:d} es la fecha de hoy!", dateTyped);
            }
            else  {// compareValue > 0       future
                TimeSpan timeDif = dateTyped - System.DateTime.Now;

                System.Console.WriteLine($"{timeDif.Days} dias por transcurrir desde fecha ingresada");
            }

        }
    }
}
