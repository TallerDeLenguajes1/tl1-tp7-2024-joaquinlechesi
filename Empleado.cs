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
    //private int edad;
    //private int antiguedad;
    //private int restanteJuvilacion;
    //private double salario;
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
    // public int Edad {
    //     get => edad;
    //     set => edad = value;
    // }
    // public int Antiguedad {
    //     get => antiguedad;
    //     set => antiguedad = value;
    // }
    // public int RestanteJulilacion {
    //     get => restanteJuvilacion;
    //     set => restanteJuvilacion = value;
    // }
    // public double Salario {
    //     get => salario;
    //     set => salario = value;
    // }
    public string Nombre {
        get => nombre;
    }
    public string Apellido {
        get => apellido;
    }
    public int AñoIngreso {
        get => fechaIngreso.Year;
    }
    public int AñoNacimiento {
        get => fechaNacimiento.Year;
    }
    public double SueldoBasico {
        get => sueldoBasico;
    }
    public char EstadoCivil {
        get => estadoCivil;
    }
    // public Cargos TipoCargo {
    //     get => tipoCargo;
    // }
    //Calculo de la edad
    //Edad = DateTime.Now.Year - FechaNacimiento;
    public int calcularAntiguedad() {
        int antiguedad = 0;
        antiguedad = DateTime.Now.Year - AñoIngreso;
        return antiguedad;
    }
    public int calcularEdad() {
        int edadEmpleado = 0;
        edadEmpleado = DateTime.Now.Year - AñoNacimiento;
        return edadEmpleado;
    }
    public int aniosRestantesJubilacion() {
        int aniosRestantes = 0;
        aniosRestantes = 65 - calcularEdad();
        return aniosRestantes;
    }
    public double calcularSalario() {
        double salario = 0;
        if (calcularAntiguedad() <= 20)
        {
            salario = (calcularAntiguedad() * (sueldoBasico / 100));
        }else
        {
            salario = (calcularAntiguedad() * (sueldoBasico * 0.25));
        }
        if (tipoCargo == Cargos.Ingeniero || tipoCargo == Cargos.Especialista)
        {
            salario = salario + (salario/2);
        }
        if (EstadoCivil == 'C')
        {
            salario = salario + 150000;
        }
        //salario = salario + sueldoBasico;
        return salario;
    }
    //public void fichaEmpleado() {
        // //Calculo la antiguiedad
        // Antiguedad = DateTime.Now.Year - FechaIngreso;
        // //Calculo los años restantes para la juvilacion
        // RestanteJulilacion = 65 - Edad;
        // //Calculo del Salario
        // double adicional = 0, aux;
        // //double antiguedad = DateTime.Now.Year - FechaIngreso;
        // if (Antiguedad <= 20)
        // {
        //     adicional = (adicional * (sueldoBasico * 0.1));
        // }else
        // {
        //     adicional = (adicional * (sueldoBasico * 0.25));
        // }
        // if (tipoCargo == Cargos.Ingeniero || tipoCargo == Cargos.Especialista)//
        // {
        //     adicional = adicional + (adicional/2);
        // }
        // if (EstadoCivil == 'C')
        // {
        //     adicional = adicional + 150.000;
        // }
        // aux = sueldoBasico + adicional;
        // Salario = aux;
    //}
    
}
