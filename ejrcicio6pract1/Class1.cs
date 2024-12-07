using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicio6pract1
{
    internal class Hora
    {
            public int Horas { get; private set; }
            public int Minutos { get; private set; }
            public int Segundos { get; private set; }

            public Hora(int horas, int minutos, int segundos)
            {
                Horas = horas % 24; 
                Minutos = minutos % 60; 
                Segundos = segundos % 60; 
            }

            public void Incrementar(int horas = 0, int minutos = 0, int segundos = 0)
            {
                Segundos += segundos;
                Minutos += minutos + Segundos / 60;
                Horas += horas + Minutos / 60;

                Segundos %= 60;
                Minutos %= 60;
                Horas %= 24;
            }

            public static TimeSpan Diferencia(Hora h1, Hora h2)
            {
                TimeSpan t1 = new TimeSpan(h1.Horas, h1.Minutos, h1.Segundos);
                TimeSpan t2 = new TimeSpan(h2.Horas, h2.Minutos, h2.Segundos);

                return t1 - t2;
            }

            public static Hora Sumar(Hora h1, Hora h2)
            {
                int totalSegundos = (h1.Horas * 3600 + h1.Minutos * 60 + h1.Segundos) +
                                    (h2.Horas * 3600 + h2.Minutos * 60 + h2.Segundos);

                return new Hora(totalSegundos / 3600 % 24, (totalSegundos / 60) % 60, totalSegundos % 60);
            }

            public override string ToString()
            {
                return $"{Horas:D2}:{Minutos:D2}:{Segundos:D2}";
            }
    }
}

