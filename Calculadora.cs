namespace EspacioCalculadora;

public class Calculadora {
    private double dato;
    public void Sumar (double termino){
        dato = dato + termino;
    }
    public void Restar (double termino){
        dato = dato - termino;
    }
    public void Mulpiplicar (double termino){
        dato = dato * termino;
    }
    public void Dividir (double termino) {
        dato = dato / termino;
    }
    public void Limpiar (){
        dato = 0;
    }
    public double Dato{
        get => dato;
    }

}