using System;


namespace _02
{
    class Progamn
    {
        
        static void Main(string[] args)
        {
           RegistroDeCompras compra = new RegistroDeCompras("Café", 5.50, DateTime.Now.AddDays(-15), 10);

           compra.MostrarDetalhes();
           Console.WriteLine($"A compra está valida ? {compra.VerificarValidade()}");
            
        }
    }
}
