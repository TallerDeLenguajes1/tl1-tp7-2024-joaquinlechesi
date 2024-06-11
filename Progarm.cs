using System.Security.Cryptography;
using EspacioEmpleado;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Bienvenido al Sistema de Administracion del Personal.");

Empleado nuevoEmpleado = new Empleado();

string datoString;
//int opcionInt = 0;
double numeroDouble;

Console.WriteLine("Ingrese los datos del empleado\nIngrese el nombre:");
datoString = Console.ReadLine();
nuevoEmpleado.S = Console.ReadLine();

// do
// {
//     int.TryParse(opcion, out opcionInt);
//     switch (opcionInt)
//     {
//         case 1:
//             Console.WriteLine("Ingrese un numero para realizar una suma.");
//             numero = Console.ReadLine();
//             double.TryParse(numero, out numeroDouble);
//             NuevaCalculadora.Sumar(numeroDouble);
//             break;
//         case 2:
//             Console.WriteLine("Ingrese un numero para realizar una resta.");
//             numero = Console.ReadLine();
//             double.TryParse(numero, out numeroDouble);
//             NuevaCalculadora.Restar(numeroDouble);
//             break;
//         case 3:
//             Console.WriteLine("Ingrese un numero para realizar una multiplicacion.");
//             numero = Console.ReadLine();
//             double.TryParse(numero, out numeroDouble);
//             NuevaCalculadora.Mulpiplicar(numeroDouble);
//             break;
//         case 4:
//             Console.WriteLine("Ingrese un numero para realizar una divicion.");
//             numero = Console.ReadLine();
//             double.TryParse(numero, out numeroDouble);
//             NuevaCalculadora.Dividir(numeroDouble);
//             break;
//         default:
//             break;
//     }
//     Console.WriteLine("El resultado despues de la operacion concretada es: " + NuevaCalculadora.Dato + "\nPara continuar operando ingrese 1, para finalizar ingrese 0.");
//     opcion = Console.ReadLine();
//     int.TryParse(opcion, out opcionInt);
// } while (opcionInt != 0);

//NuevaCalculadora.Limpiar();