using System.Security.Cryptography;
using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Bienvenido a la Calculadora");

Calculadora NuevaCalculadora = new Calculadora();

string opcion, numero;
int opcionInt = 0;
double numeroDouble;

do
{
    Console.WriteLine("Ingrese una opcion:");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionInt);
    switch (opcionInt)
    {
        case 1:
            Console.WriteLine("Ingrese un numero para realizar una suma.");
            numero = Console.ReadLine();
            double.TryParse(numero, out numeroDouble);
            NuevaCalculadora.Sumar(numeroDouble);
            break;
        default:
            break;
    }
    Console.WriteLine("El resultado despues de la operacion concretada es: " + NuevaCalculadora.resultado + "\nPara continuar operando ingrese 1, para finalizar ingrese 0.");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionInt);
} while (opcionInt != 0);