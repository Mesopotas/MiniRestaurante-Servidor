namespace Models;

public class Bebida: Producto {


    public bool EsAlcoholica {get; set;}

    public Bebida(string nombre, double precio, bool esAlcoholica):base(nombre, precio){

        EsAlcoholica = esAlcoholica;

    }

    public override void MostrarDetalles(){

        string llevaAlcohol = EsAlcoholica ? "Si" : "Ni";
        Console.WriteLine($"Bebida: {Nombre}, {Precio} - {EsAlcoholica}");

    }

}