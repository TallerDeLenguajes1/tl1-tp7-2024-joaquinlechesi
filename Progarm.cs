using System.Security.Cryptography;
using EspacioEmpleado;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Bienvenido al Sistema de Administracion del Personal.");


string nombre, apellido;
string estadoCivil, dia, mes, anio;
string sueldo;
int diaInt, mesInt, anioInt;
double sueldoBasico;

//nuevoEmpleado.S = Console.ReadLine();

List<Empleado> Lista = new List<Empleado>(); //defino una lista (arreglo)
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Empleado n°: " + (i+1).ToString() +"\nIngrese los datos del empleado\nIngrese el nombre:");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido:");
    apellido = Console.ReadLine();
    Console.WriteLine("Ingrese una letra para indicar el ESTADO CIVIL\nS para soltero\nC para casado");
    estadoCivil = Console.ReadLine(); //es un arreglo de tipo string
    Console.WriteLine("Ingrese la fecha de nacimiento:\nDia:");
    dia = Console.ReadLine();
    Console.WriteLine("Mes (numero):");
    mes = Console.ReadLine();
    Console.WriteLine("Año:");
    anio = Console.ReadLine();
    int.TryParse(dia, out diaInt);
    int.TryParse(mes, out mesInt);
    int.TryParse(anio, out anioInt);
    DateTime fechaNacimiento = new DateTime(anioInt, mesInt, diaInt);
    Console.WriteLine("Ingrese la fecha de ingreso:\nDia:");
    dia = Console.ReadLine();
    Console.WriteLine("Mes (numero):");
    mes = Console.ReadLine();
    Console.WriteLine("Año:");
    anio = Console.ReadLine();
    int.TryParse(dia, out diaInt);
    int.TryParse(mes, out mesInt);
    int.TryParse(anio, out anioInt);
    DateTime fechaIngreso = new DateTime(anioInt, mesInt, diaInt);
    Console.WriteLine("Ingrese el sueldo del empleado:");
    sueldo = Console.ReadLine();
    double.TryParse(sueldo, out sueldoBasico);
    Empleado nuevoEmpleado = new Empleado(nombre, apellido, estadoCivil[0], fechaNacimiento, fechaIngreso, sueldoBasico);
    Lista.Add(nuevoEmpleado);
}

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