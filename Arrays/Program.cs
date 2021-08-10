using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] letras = new string[5];
            letras[0] = "b";
            letras[1] = "c";
            letras[2] = "d";
            letras[3] = "e";
            letras[4] = "f";
            System.Console.WriteLine(letras[4]);

            int[] numeros = { 23, 56, 89, 78, 45, 25 };
            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.WriteLine(numeros[i]);
            }
            foreach (var l in letras)
            {
                System.Console.WriteLine(l);
            }

            System.Console.WriteLine("Ingrese la cantidad de frutas");
            int cantFrutas = int.Parse(Console.ReadLine());
            string[] frutas = new string[cantFrutas];
            for (int i = 0; i < frutas.Length; i++)
            {
                System.Console.WriteLine("Ingrese una fruta");
                string fruta=Console.ReadLine();
                frutas[i]=fruta;

            }

            foreach (var item in frutas)
            {
                System.Console.Write(item+ " ");
            }*/


            //Ejercicio 1 
            /*System.Console.WriteLine("Indique la cantidad de personas que asisten a la fiesta");
            int personas= int.Parse(Console.ReadLine());
            int femenino=0;
            int masculino=0;
            for (int i = 1; i <= personas; i++)
            {
                System.Console.WriteLine("Indique el género del invitado "+i+ "(F o M)");
                string genero= (Console.ReadLine());
                if (genero=="F")
                {
                    femenino++;
                }else if (genero=="M")
                {
                    masculino++;
                }else
                {
                    System.Console.WriteLine("Ingrese un género válido");
                }

            }
            System.Console.WriteLine("La cantidad de hombre fueron: "+masculino+" Y la cantidad de mujeres fueron: "+femenino);*/


            //Ejercicio 2
            /*System.Console.WriteLine("Indique la cantidad de clientes");
            int clientes= int.Parse(Console.ReadLine());
            int costot=0;
            for (int i = 1; i <= clientes; i++)
            {  
                 System.Console.WriteLine("Indique la cantidad de productos que compró el cliente "+i);
                int productos= int.Parse(Console.ReadLine());

                for (int j = 1; j <= productos; j++)
            {   
                System.Console.WriteLine("Indique el costo del producto:"+j+ " Del cliente: "+i);
                int costop= int.Parse(Console.ReadLine());
                costot= costot+costop;
                
            }
                System.Console.WriteLine("El total pagado por el cliente:"+i+" es: "+costot);
            }
            System.Console.WriteLine("El dinero que recibió el supermercado fue: "+costot);*/
            //Ejercicio 3
            /*System.Console.WriteLine("Indique el número de autos que ingresan");
            int autos= int.Parse(Console.ReadLine());
            int ad= 0;
            int n= 0;
            int m=0;
            int e=0;
            int it=0;

            for (int i = 1; i <=autos; i++)
            {
                System.Console.WriteLine("Indique el código del auto "+i+" Del 0 al 9");
                int codigo= int.Parse(Console.ReadLine());
                if (codigo==1 || codigo==2)
                {
                    ad++;
                }else if (codigo==3||codigo==4)
                {
                    n++;
                }else if (codigo==5||codigo==6)
                {
                    m++;
                }else if (codigo==7||codigo==8)
                {
                    e++;
                }else if (codigo==9||codigo==0)
                {
                    it++;
                }else
                {
                    System.Console.WriteLine("Escriba un código valido");
                }
            }
            System.Console.WriteLine("La cantidad de autos que pertenecen a Aguilas Doradas es "+ad);
            System.Console.WriteLine("La cantidad de autos que pertenecen a Nacional es "+n);
            System.Console.WriteLine("La cantidad de autos que pertenecen a Medellín es "+m);
            System.Console.WriteLine("La cantidad de autos que pertenecen a Envigado es "+e);
            System.Console.WriteLine("La cantidad de autos que pertenecen a Itagui "+it);*/
            //Ejercicio 4
            /*System.Console.WriteLine("La cantidad de alumnos que ingresa al teatro son 10");
            int alumnos = 10;
            int costot = 1000;

            int perdida1 = 0;
            int perdida2 = 0;
            int perdida3 = 0;
            int perdida4 = 0;
            int perdida5 = 0;

            for (int i = 1; i <= alumnos; i++)
            {
                System.Console.WriteLine("Indique la edad del alumno " + i);
                int edad = int.Parse(Console.ReadLine());
                if (edad >= 5 && edad <= 14)
                {
                    perdida1 = perdida1 + (int)(costot * 0.35);

                }
                else if (edad >= 15 && edad <= 19)
                {
                    perdida2 = perdida2 + (int)(costot * 0.25);

                }
                else if (edad >= 20 && edad <= 45)
                {
                    perdida3 = perdida3 + (int)(costot * 0.10);

                }
                else if (edad >= 46 && edad <= 65)
                {
                    perdida4 = perdida4 + (int)(costot * 0.25);

                }
                else if (edad >= 66)
                {
                    perdida5 = perdida5 + (int)(costot * 0.35);

                }
                else
                {
                    System.Console.WriteLine("La persona no puede ingresar al teatro");
                }

            }
            System.Console.WriteLine("El total del dinero perdido por la categoría 1 fue: " + perdida1);
            System.Console.WriteLine("El total del dinero perdido por la categoría 2 fue: " + perdida2);
            System.Console.WriteLine("El total del dinero perdido por la categoría 3 fue: " + perdida3);
            System.Console.WriteLine("El total del dinero perdido por la categoría 4 fue: " + perdida4);
            System.Console.WriteLine("El total del dinero perdido por la categoría 5 fue: " + perdida5);

            int perdidat = perdida1 + perdida2 + perdida3 + perdida4 + perdida5;
            System.Console.WriteLine("La cantidad total perdida fue: " + perdidat);*/

            /*System.Console.WriteLine("Ingrese la cantidad de frutas");
            int cantFrutas= int.Parse(Console.ReadLine());
            string[,]frutas=new string[cantFrutas,4];
            for (int i = 0; i < cantFrutas; i++)
            {
                System.Console.WriteLine("Ingresa los datos de la fruta "+(i+1));
                for (int j = 0; j < 4; j++)
                {
                    string dato=(Console.ReadLine());
                    frutas[i,j]=dato;
                }
            }

                int sumPrecioCompra=0, sumPrecioVenta=0, ganancias=0,contCategoriaA=0;
                
            for (int i = 0; i < cantFrutas; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j==2)
                    {
                        sumPrecioCompra+=int.Parse(frutas[i,j]);
                    }
                    if (j==3)
                    {
                        sumPrecioVenta+=int.Parse(frutas[i,j]);
                    }
                    if (j==1)
                    {
                        if (frutas[i,j]=="a")
                        {
                            contCategoriaA++;
                        }
                    }
                    
                    
                }
            }
            ganancias=sumPrecioVenta-sumPrecioCompra;
            System.Console.WriteLine(contCategoriaA); 
            System.Console.WriteLine(ganancias);*/

            System.Console.WriteLine("Indique la cantidad de invitados");
            int inv = int.Parse(Console.ReadLine());
            string[,] fiesta = new string[inv, 4];
            int masculino = 0;
            int femenino = 0;
            double edadTotal = 0;
            int regalos=0;
            for (int i = 0; i < inv; i++)
            {
                System.Console.WriteLine("Indique los datos del invitado " + (i + 1));
                for (int j = 0; j < 4; j++)
                {
                    
                    
                    if (j==0)
                    {
                        System.Console.WriteLine("Nombre del invitado");
                        string dato = (Console.ReadLine());
                        fiesta[i, j] = dato;
                    }
                    if (j == 1)
                    {
                        System.Console.WriteLine("Indique el genero");
                        string dato = (Console.ReadLine());
                        fiesta[i, j] = dato;
                        if (fiesta[i, 1] == "M")
                        {
                            masculino++;
                        }
                        else if (fiesta[i, 1] == "F")
                        {
                            femenino++;
                        }
                        else
                        {
                            System.Console.WriteLine("Ingrese un genero valido");
                        }
                    }
                    if (j == 2)
                    {   
                        System.Console.WriteLine("Indique la edad");
                        string dato = (Console.ReadLine());
                        fiesta[i, j] = dato;
                        edadTotal += int.Parse(fiesta[i, j]);
                    }
                    if (j==3)
                    {   System.Console.WriteLine("¿Regalo?");
                        string dato = (Console.ReadLine());
                        fiesta[i, j] = dato;
                        if (fiesta[i,j]=="Si")
                        {
                            regalos++;
                        }
                    }


                }

            }
            System.Console.WriteLine("La cantidad de hombres es " + masculino);
            System.Console.WriteLine("La cantidad de mujeres es " + femenino);
            System.Console.WriteLine("El promedio de edad es " + (edadTotal / inv));
            System.Console.WriteLine("La cantidad de regalos fueron "+regalos);
        }
    }
}
