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
    Console.WriteLine("Ingrese una opcion: 1 para operacion SUMA, 2 para operacion RESTA, 3 para la operacion MULTIPLICACION, 4 para la operacion division.");
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
        case 2:
            Console.WriteLine("Ingrese un numero para realizar una resta.");
            numero = Console.ReadLine();
            double.TryParse(numero, out numeroDouble);
            NuevaCalculadora.Restar(numeroDouble);
            break;
        case 3:
            Console.WriteLine("Ingrese un numero para realizar una multiplicacion.");
            numero = Console.ReadLine();
            double.TryParse(numero, out numeroDouble);
            NuevaCalculadora.Mulpiplicar(numeroDouble);
            break;
        case 4:
            Console.WriteLine("Ingrese un numero para realizar una divicion.");
            numero = Console.ReadLine();
            double.TryParse(numero, out numeroDouble);
            NuevaCalculadora.Dividir(numeroDouble);
            break;
        default:
            break;
    }
    Console.WriteLine("El resultado despues de la operacion concretada es: " + NuevaCalculadora.Dato + "\nPara continuar operando ingrese 1, para finalizar ingrese 0.");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionInt);
} while (opcionInt != 0);

NuevaCalculadora.Limpiar();