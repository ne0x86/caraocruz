using System;

namespace Cara_o_cruz
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCaras = 0; //contador de caras
            int nCruces = 0; //contador de cruces
            Random generador = new Random(); 
            Console.WriteLine("Dime cuantas tiradas quieres");
            int tiradas = int.Parse(Console.ReadLine());
            for (int i = 0; i < tiradas; i++) //bucle for para que se ejecute las tiradas que elija el usuario
            {
                int n = generador.Next(2); //generador de números del 0 al 1; 0 cruz y 1 cara
                if (n == 1)
                {
                    Console.WriteLine("Ha salido cara!"); //si sale 1 muestra este mensaje y suma 1 al contador caras
                     nCaras++;
                }
                else
                {
                    Console.WriteLine("Ha salido cruz!"); //si sale 0 muestra este mensaje y suma 1 al contador cruces
                    nCruces++;
                }    
            }
            double porcentajeCaras = nCaras*100/tiradas; //porcentaje caras
            double porcentajeCruz =nCruces*100/tiradas; //porcentaje cruces
            Console.WriteLine("El número de caras es " + nCaras + " y el porcentaje ha sido " + porcentajeCaras+"%");
            Console.WriteLine("El número de cruces es " + nCruces +" y el porcentaje ha sido " + porcentajeCruz+"%");
        }
    }
}
