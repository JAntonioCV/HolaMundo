using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Esto es un comentario de una linea
            //Console.WriteLine("Hola mundo");

            ///* Esto es un comentario de varias 
            // * lineas como ejemplo
            // */

            ////Declarar las varibales
            //int myInt = 5;
            //float myFloat = 5.2f;
            //double myDouble = 5.99;
            //char myChar = 'H';
            //string myString = "!Hola Que Hace?";

            ////Imprimimos Valores de las Variables
            //Console.WriteLine(myInt);
            //Console.WriteLine(myFloat);
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myChar);
            //Console.WriteLine(myString);

            ////Variables constante
            //const int MYCONST = 10;
            ////myConst = 15; Error
            //Console.WriteLine(MYCONST);

            ////Concatenacion de variables
            //Console.WriteLine("Pedro, " + myString);

            ////
            //Console.WriteLine("Este es el valor del entero {0} y este del cadena de caracter {1}",myInt,myString);

            ////
            //Console.WriteLine($"Este es el valor del entero {myInt} y este del cadena de caracter {myString}");

            //Suma
            int numero1, numero2, resultado; // Definicion

            //Entrada 
            Console.WriteLine("Ingrese el numero 1");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero 2");
            numero2 = int.Parse(Console.ReadLine());
            //numero1 = 1;
            //numero2 = 2;

            //Proceso
            resultado = numero1 + numero2;

            //Salida
            Console.WriteLine("El número 1 es: " + numero1);
            Console.WriteLine("El número 2 es: " + numero2);
            Console.WriteLine("El resultado de la suma es: " + resultado);




            Console.ReadKey();
        }
    }
}
