using System.Reflection.Metadata;

namespace EspacioEmpleado;

public class Empleado {
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
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
    public Empleado(string parametroNombre, string parametroApellido, char parametroEstadoCivil, DateTime parametroFechaNacimiento, DateTime parametroFechaIngreso, double parametroSueldoBasico, int parametroTipo){ //
        nombre = parametroNombre;
        apellido = parametroApellido;
        estadoCivil = parametroEstadoCivil;
        fechaNacimiento = parametroFechaNacimiento;
        fechaIngreso = parametroFechaIngreso;
        sueldoBasico = parametroSueldoBasico;
        tipoCargo = (Cargos)parametroTipo;
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
        get => fechaIngreso.Year;
    }

    public int Edad {
        get => fechaNacimiento.Year;
    }
    public double SueldoBasico {
        get => sueldoBasico;
    }
    public char EstadoCivil {
        get => estadoCivil;
    }
    public void salario() {
        double adicional = 0;
        double antiguedad = DateTime.Now.Year - AnioIngreso;
        if (antiguedad <= 20)
        {
            adicional = (adicional * (sueldoBasico * 0.1));
        }else
        {
            adicional = (adicional * (sueldoBasico * 0.25));
        }
        if (tipoCargo == Cargos.Ingeniero || tipoCargo == Cargos.Especialista)//
        {
            adicional = adicional + (adicional/2);
        }
        if (EstadoCivil == 'C')
        {
            adicional = adicional + 150.000;
        }
    }
}
