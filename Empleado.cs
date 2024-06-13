namespace EspacioEmpleado;

public class Empleado {
    private string Nombre;
    private string Apellido;
    private DateTime FechaNacimiento;
    private char EstadoCivil;
    private DateTime FechaIngreso;
    private double SueldoBasico;
    public enum Cargos {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    // public string S {
    //     set => Nombre = value;
    // }

    public Empleado(string nombre, string apellido, char estadoCivil, DateTime fechaNacimiento, DateTime fechaIngreso, double sueldoBasico){ //
        Nombre = nombre;
        Apellido = apellido;
        EstadoCivil = estadoCivil;
        FechaNacimiento = fechaNacimiento;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
    } 
}