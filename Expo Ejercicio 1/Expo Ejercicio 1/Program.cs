﻿using System;

namespace Expo_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se ingresa por teclado la cantidad de agua caida, en mílimetros día a día durante una semana.
            //Se pide determinar el día de mayor lluvia, el de menor y el promedio.

            //GRUPO 2 PROGRAMACION 1 //

            int flag = 0, i = 0, mayordia = 0, menordia = 0, x = 7;
            int[] dia = new int[7];
            float menor = 0, mayor = 0, promedio = 0, contagua = 0;
            float[] agua = new float[x + 1];


            do
            {
                
                Console.Write(" Ingrese el dia :\n");
                dia[i] = int.Parse(Console.ReadLine());

                Console.Write(" Ingrese la cantidad de agua caida :\n");
                agua[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayordia = dia[i];
                    menordia = dia[i];
                    mayor = agua[i];
                    menor = agua[i];
                    flag = 1;
                }
                else
                {
                    if (agua[i] > mayor)
                    {
                        mayordia = dia[i];
                        mayor = agua[i];
                    }
                    if (agua[i] < menor)
                    {
                        menordia = dia[i];
                        menor = agua[i];
                    }
                }

                contagua += agua[i];

                if (i == 7)
                {
                    Console.Write("La semana tiene 7 dias s/n ?");
                    if (Console.ReadLine() == "s")
                        x = x + 1;
                }
                i++;
            } while (i < x);

            promedio = contagua / i;

            if (menor == mayor)
            {
                Console.Write("\nNo hubo mayor y menor dia de agua caida, fue igual en toda la semana");
            }
            else
            {
                Console.WriteLine("\nLa mayor cantidad de agua caida fue de {0} milímetros en los dias ...", mayor);
                for (i = 0; i < x; i++)
                    if (agua[i] == mayor)
                        Console.Write("\nDia {0}", dia[i]);

                Console.WriteLine("\n\nLa menor cantidad de agua caida fue de {0} milímetros en los dias ...", menor);
                for (i = 0; i < x; i++)
                    if (agua[i] == menor)
                        Console.Write("\nDia {0}", dia[i]);
            }
            Console.WriteLine("\n\nEl promedio de agua caida en {0} dias es {1}", x, promedio);
            Console.ReadKey();
        }
    }
}