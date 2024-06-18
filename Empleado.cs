using System.Reflection.Metadata;

namespace EspacioEmpleado;

public class Empleado {
    private string Nombre;
    private string Apellido;
    private DateTime FechaNacimiento;
    private char EstadoCivil;
    private DateTime FechaIngreso;
    private double SueldoBasico;
    private enum Cargos {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    Cargos tipoCargo;
    // public string S {
    //     set => Nombre = value;
    // }

    //CONSTRUCTOR
    public Empleado(string nombre, string apellido, char estadoCivil, DateTime fechaNacimiento, DateTime fechaIngreso, double sueldoBasico, int tipo){ //
        Nombre = nombre;
        Apellido = apellido;
        EstadoCivil = estadoCivil;
        FechaNacimiento = fechaNacimiento;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        tipoCargo = (Cargos)tipo;
        // switch (tipo)
        // {
        //     case 1:
        //         //tipoCargo(1);
        //         break;
        //     case 2:
                
        //         break;
        //}
    }

    //METODO
    public int AnioIngreso {
        get => FechaIngreso.Year;
    }

    public int Edad {
        get => FechaNacimiento.Year;
    }
    public double sueldoBasico {
        get => SueldoBasico;
    }
}