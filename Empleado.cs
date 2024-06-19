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
    private int edad;
    private int antiguedad;
    private double salario;
    private Cargos tipoCargo;
    //CONSTRUCTOR
    public Empleado(string parametroNombre, string parametroApellido, char parametroEstadoCivil, DateTime parametroFechaNacimiento, DateTime parametroFechaIngreso, double parametroSueldoBasico, int parametroTipo){ //
        nombre = parametroNombre;
        apellido = parametroApellido;
        estadoCivil = parametroEstadoCivil;
        fechaNacimiento = parametroFechaNacimiento;
        fechaIngreso = parametroFechaIngreso;
        sueldoBasico = parametroSueldoBasico;
        tipoCargo = (Cargos)parametroTipo;
    }
    //METODO
    public int Edad {
        get => edad;
        set => edad = value;
    }
    public int Antiguedad {
        get => antiguedad;
        set => antiguedad = value;
    }
    public double Salario {
        get => salario;
        set => salario = value;
    }
    public int FechaIngreso {
        get => fechaIngreso.Year;
    }
    public int FechaNacimiento {
        get => fechaNacimiento.Year;
    }
    public double SueldoBasico {
        get => sueldoBasico;
    }
    public char EstadoCivil {
        get => estadoCivil;
    }
    public void fichaEmpleado() {
        //Calculo de la edad
        Edad = DateTime.Now.Year - FechaNacimiento;
        //Calculo la antiguiedad
        Antiguedad = DateTime.Now.Year - FechaIngreso;
        //Calculo del Salario
        double adicional = 0, aux;
        //double antiguedad = DateTime.Now.Year - FechaIngreso;
        if (Antiguedad <= 20)
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
        aux = sueldoBasico + adicional;
        Salario = aux;
    }
    
}
