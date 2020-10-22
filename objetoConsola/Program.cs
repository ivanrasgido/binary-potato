using System;
using Carrera.Modelo;

namespace objetoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bicicleta miBici = new Bicicleta();
            miBici.color = "Rojo";
            miBici.cambio = 1;
            Bicicleta otraBici = new Bicicleta();
            otraBici.color = "Negra";
            otraBici.cambio = 1;
            Console.WriteLine($"miBici: Color {miBici.color} Cambio {miBici.cambio}");
            Console.WriteLine($"otraBici: Color {otraBici.color} Cambio {otraBici.cambio}");
            Bicicleta terceraBici = miBici;
            Console.WriteLine($"terceraBici: Color {terceraBici.color} Cambio {terceraBici.cambio}");
            terceraBici.SubirCambio();
            Console.WriteLine($"miBici: Color {miBici.color} Cambio {miBici.cambio}");
            Console.WriteLine($"otraBici: Color {otraBici.color} Cambio {otraBici.cambio}");
            Console.WriteLine($"terceraBici: Color {terceraBici.color} Cambio {terceraBici.cambio}");
        }
    }
}
