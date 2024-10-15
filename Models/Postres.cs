namespace Models;

public class Postres: Producto {


    public bool ConGluten {get; set;} = true;
    public bool ConAzucar {get; set;} = false;
    public int Calorias {get; set;}

    public Postres(string nombre, double precio, int calorias):base(nombre, precio){

        Calorias = calorias;

    }

    public override void MostrarDetalles(){

        string llevaAzucar = ConAzucar ? "Si" : "No";
        Console.WriteLine($"Postre: {Nombre}, {Precio:C} - {llevaAzucar} (Calorías {Calorias})");

    }

}