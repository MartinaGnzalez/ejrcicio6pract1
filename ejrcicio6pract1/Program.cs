using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicio6pract1
{
    internal class Program
    {
         static void Main(string[] args)
          {
                Hora hora1 = new Hora(10, 30, 45); 
                Hora hora2 = new Hora(5, 15, 30);   

                Console.WriteLine($"Hora 1: {hora1}");
                Console.WriteLine($"Hora 2: {hora2}");

              
                hora1.Incrementar(segundos: 50); 
                Console.WriteLine($"Hora 1 incrementada (50 seg): {hora1}");

                hora1.Incrementar(minutos: 20);  
                Console.WriteLine($"Hora 1 incrementada (20 min): {hora1}");

                hora1.Incrementar(horas: 3);      
                Console.WriteLine($"Hora 1 incrementada (3 hrs): {hora1}");

                
                TimeSpan diferencia = Hora.Diferencia(hora1, hora2);
                Console.WriteLine($"Diferencia entre Hora 1 y Hora 2: {diferencia}");

                
                Hora sumaHoras = Hora.Sumar(hora1, hora2);
                Console.WriteLine($"Suma de Hora 1 y Hora 2: {sumaHoras}");
         }
    }
}

