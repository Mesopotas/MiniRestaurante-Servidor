namespace Models;

public class Combo: Producto {


    public PlatoPrincipal PlatoPrincipal {get; set;}
    public Bebida Bebida {get; set;}
    public Postres Postres {get; set;}
    public double Descuento {get; set;}

    public Combo( string nombre, double precio, PlatoPrincipal platoPrincipal, Bebida bebida, Postres postres, double descuento):base(nombre, precio){

        PlatoPrincipal = platoPrincipal;
        Bebida = bebida;
        Postres = postres;
        Descuento = descuento;

    }

    public override void MostrarDetalles(){

        Console.WriteLine($"Combo: {Nombre}, {Precio:C} - {Descuento})");
        PlatoPrincipal.MostrarDetalles();
        Bebida.MostrarDetalles();
        Postres.MostrarDetalles();

    }

}