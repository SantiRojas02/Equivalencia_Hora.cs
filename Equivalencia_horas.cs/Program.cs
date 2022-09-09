using System;


namespace Equivalencia_horas.cs
{
    class Program
    {
        static void Main(string[] args)

        {
            int dias, segundos, minutos, hora;
            Console.Write("Ingrese hora: ");
            hora =  Convert.ToInt32(Console.ReadLine());
    

            dias = 24 / hora;
            segundos = 3600 / hora;
            minutos = 60 / hora;

            Console.WriteLine("Equivalente en dias: " + dias);
            Console.WriteLine("Equivalente en segundos: " + segundos);
            Console.WriteLine("Equivalente en minutos: " + minutos);

            Console.ReadKey();


        }
    }
}
