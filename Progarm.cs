using System.Globalization;
using System.Security.Cryptography;
using EspacioEmpleado;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Bienvenido al Sistema de Administracion del Personal.");


//Console.WriteLine("Depuracion\nLa hora actual es: "+ DateTime.Now.Day);

string nombre, apellido;
string estadoCivil, dia, mes, anio;
string sueldo, tipoCargo;
int diaInt, mesInt, anioInt, tipoCargoInt;
double sueldoBasico;

//nuevoEmpleado.S = Console.ReadLine();

List<Empleado> Lista = new List<Empleado>(); //defino una lista (arreglo)
for (int i = 0; i < 1; i++)
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
    //DateOnly fecha = new DateOnly(anioInt, mesInt, diaInt);
    //TimeOnly hora = new TimeOnly();
    DateTime fechaNacimiento = new DateTime(anioInt, mesInt, diaInt);
    //Console.WriteLine("La edad del empleado es: "+ (DateTime.Now.Year - fechaNacimiento.Year));
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
    Console.WriteLine("Ingrese el cargo que tiene el empleado:\n0 para AUXILIAR.\n1 para ADMINISTRATIVO.\n2 para INGENIERO.\n3 para ESPECIALISTA.\n4 para INVESTIGADOR.");
    tipoCargo = Console.ReadLine();
    int.TryParse(tipoCargo, out tipoCargoInt);
    Empleado nuevoEmpleado = new Empleado(nombre, apellido, estadoCivil[0], fechaNacimiento, fechaIngreso, sueldoBasico, tipoCargoInt);
    Lista.Add(nuevoEmpleado);
}

int contador = 0;
foreach (var empleado in Lista)
{
    Console.WriteLine("Empleado nº: " + (contador+1));
    Console.WriteLine("La antiguedad del empleado es: " + empleado.calcularantiguedad());
    Console.WriteLine("La edad del empleado es: " + empleado.calcularEdad());
    Console.WriteLine("Al empleado le faltan un total de: " + empleado.aniosRestantesJubilacion() + " años para jubilarse.");
    //Console.WriteLine("El SALARIO del empleado es: " + empleado.Salario);
    
    //contador++;
}

// Console.WriteLine("Sueldo basico del empleado");
// contador = 0;
// foreach (var empleado in Lista)
// {
//     Console.WriteLine("Empleado: " + (contador + 1));
//     Console.WriteLine("El salario correspondiente al empleado es de: " + empleado.Salario);
//     contador++;
// }
// do
// {
// } while (true);
//Empleado.calcularSalario(sueldoBasico);

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