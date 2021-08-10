using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //while- do while- for - foreach 

            //While
            /*Console.WriteLine("Ingrese el número de invitados");
            int inv = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= inv)
            {
                Console.WriteLine("Ingrese el nombre del invitado");
                string ninv = (Console.ReadLine());
                Console.WriteLine("El invitado es el número " + i);
                i++;
            }*/

            /* Console.WriteLine("Ingrese la cantidad de notas");
            int cantNotas = int.Parse(Console.ReadLine()); */
            /*int i = 1;
            double promedio = 0;
            while (i <= cantNotas)
            {
                Console.WriteLine("Ingrese la nota " + i);
                double nota = double.Parse(Console.ReadLine());
                promedio += nota;
                i++;

            }
            promedio = promedio / cantNotas;
            Console.WriteLine("El promedio obtenido fue "+ promedio);*/
            //Ingrese el número de invitados

            //Do While 
            /* int j=0;
            do
            {
                System.Console.WriteLine(j);
                j++;
            } while (j<5);


            double promedio = 0;

            for (int i = 0; i < cantNotas; i++)
            {
                Console.WriteLine("Ingrese la nota " + i);
                double nota = double.Parse(Console.ReadLine());
                promedio += nota;
            }
            promedio = promedio / cantNotas;
            Console.WriteLine("El promedio obtenido fue "+ promedio); */

            //Ciclos anidados
            /* for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Saludo");
                for (int k = 0; k < 1; k++)
                {
                System.Console.WriteLine("Saludo desde otra dimensión");
                }
            } */
            //Solicitar la cantidad de productos a pagar
            //Solicitar el valor de cada producto
            //Mostrar al final el total a pagar por los productos


            /* System.Console.WriteLine("Indique la cantidad de productos");
            int p= int.Parse(Console.ReadLine());
            int costot=0;
            double descuento=0.5;
            for (int i = 1; i <=p; i++)
            {
                System.Console.WriteLine("Indique el precio del producto " +i);
                int producto= int.Parse(Console.ReadLine());
                costot+=producto;
                
                
            }
            System.Console.WriteLine("El total a pagar es $"+costot);
            if (costot>50000){
                costot-= (int)(costot*descuento);
            }
            System.Console.WriteLine("El total a pagar es $"+costot); */

            System.Console.WriteLine("Indique la cantidad de personas que van a pagar el impuesto");
            int cantidad= int.Parse(Console.ReadLine());
            double descuento=0.05;
            for (int i = 1; i <=cantidad; i++)
            {
                System.Console.WriteLine("Indique el valor del impuesto a pagar de la persona  "+i);
                int valor= int.Parse(Console.ReadLine());
                if (valor>500000)
                {
                    valor-=(int)(valor*descuento);
                    System.Console.WriteLine("El valor a pagar con descuento de la persona "+i+" es $"+valor);
                }else
                {
                    System.Console.WriteLine("El valor a pagar sin descuento de la persona " +i +" es $"+valor);
                }
            }
        
        
        
        }
    }
}
