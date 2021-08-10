using System;
using sintaxisBasica.Enumetartions;
using sintaxisBasica.Structure;

namespace sintaxisBasica
{
    class Program
    {



        static void Main(string[] args)
        {
            string nombre = "Pedro Pérez";
            short edad = 35;
            int numeroDocumento = 14568950;
            float peso = 65.35F;
            double estatura = 1.78;
            bool tieneMascota = true;

            Direccion dir1;
            dir1.numeroCalle = 85;
            dir1.letra = "A";
            dir1.numero = 35;
            string Direccion = $"Dirección: Calle {dir1.numeroCalle} {dir1.letra} #{dir1.numero}";
            var genero = Genero.masculino;
            var tipoDocumento = TipoDocumento.cedula;
            DateTime fechaNacimiento = new DateTime(1995, 7, 26);
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Tipo de Documento: " + tipoDocumento);
            Console.WriteLine("Número de Documento: " + numeroDocumento);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine(fechaNacimiento);//Fecha + Hora
            Console.WriteLine(fechaNacimiento.Date.ToShortDateString());//Fecha sin la hora
            System.Console.WriteLine(fechaActual);





            System.Console.WriteLine("Indique su edad");
            int edadp = int.Parse(Console.ReadLine());
            if (edadp >= 0 && edadp < 13) System.Console.WriteLine("Usted se encuentra en la categoría niños");
            else if (edadp >= 13 && edadp < 29) System.Console.WriteLine("Usted se encuentra en la categoría jóvenes");
            else if (edadp >= 29 && edadp < 65) System.Console.WriteLine("Usted se encuentra en la categoría adultos");
            else if (edadp >= 65 && edadp < 150) System.Console.WriteLine("Usted se encuentra en la categoría adulto mayor");
            else System.Console.WriteLine("Edad no valida");





            System.Console.WriteLine("Indique su genero: 1- Femenino 2-Masculino");
            int generoc = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Indique su estado civil 1-Soltero 2-Casado 3-Otro");
            int estado = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Indique su edad");
            int edadc = int.Parse(Console.ReadLine());
            if (generoc == 1)
            {
                if (estado == 1)
                {
                    if (edadc >= 18 && edadc < 26)
                    {
                        System.Console.WriteLine("Bienvenida al club");
                    }
                    else
                    {
                        System.Console.WriteLine("No cumples los requisitos para entrar al club");
                    }
                }
                else
                {
                    System.Console.WriteLine("No cumples los requisitos para entrar al club");
                }

            }
            else if (generoc == 2)
            {
                if (estado == 1)
                {
                    if (edadc >= 18 && edadc < 39)
                    {
                        System.Console.WriteLine("Bienvenido al club");
                    }
                    else
                    {
                        System.Console.WriteLine("No cumples los requisitos para entrar al club");
                    }
                }
                else
                {
                    System.Console.WriteLine("No cumples los requisitos para entrar al club");
                }
            }
            else System.Console.WriteLine("No cumples los requisitos para entrar al club");

        System.Console.WriteLine("Escribe 1-Enero 2-Febrero");
        int opcion= int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1: 
                System.Console.WriteLine("El mes de enero tiene 31 días");
                break;
            case 2:
                System.Console.WriteLine("El mes de febrero tiene 28 o 29 días");
                break;
            default:
                System.Console.WriteLine("Ingresa un valor correcto");
                break;

        }


        System.Console.WriteLine("Menu");
        System.Console.WriteLine("1- Hamburguesa \n2-Perro Caliente \n3-Salchipapas");
        System.Console.WriteLine("Elige una opción ");
        opcion= int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digita la cantidad de productos");
        int cantidadProductos= int.Parse(Console.ReadLine());
        int precioHamburguesa=15000, precioPerro=8000, precioSalchipapas=12000;
        int totalPago=0;
        double desc=0.10;
        if (opcion==1){
            totalPago=precioHamburguesa*cantidadProductos;
            if (cantidadProductos>=5){
                totalPago-=(int)(totalPago*desc);
            }
        }
        else if (opcion==2){
            totalPago=precioPerro*cantidadProductos;
            if (cantidadProductos>=5){
                totalPago-=(int)(totalPago*desc);
            }
        }
        else if (opcion==3){
            totalPago=precioSalchipapas*cantidadProductos;
            if (cantidadProductos>=5){
                totalPago-=(int)(totalPago*desc);
            }
        }

        switch (opcion)
        {
            case 1:
            totalPago=precioSalchipapas*cantidadProductos;
            if (cantidadProductos>=5){
                totalPago-=(int)(totalPago*desc);
            }
            System.Console.WriteLine("El total a pagar es: "+totalPago);
            break;
            case 2:
            totalPago=precioSalchipapas*cantidadProductos;
            if (cantidadProductos>=5){
                totalPago-=(int)(totalPago*desc);
            }
            System.Console.WriteLine("El total a pagar es: "+totalPago);
            break;
            case 3:
            totalPago=precioSalchipapas*cantidadProductos;
            if (cantidadProductos>=5){
                totalPago-=(int)(totalPago*desc);
            }
            System.Console.WriteLine("El total a pagar es: "+totalPago);
            break;
            default:
            System.Console.WriteLine("Debes elegir una opción valida");
            break;
        }








    }
}
}








