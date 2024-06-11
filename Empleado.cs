namespace EspacioEmpleado;

public class Empleado {
    private string Nombre;
    private string Apellido;
    private DateTime FechaNacimiendo;
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
    public string S {
        set => Nombre = value;
    }
}