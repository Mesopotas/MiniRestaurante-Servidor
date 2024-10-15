namespace Models;

public class Pedido{

    private  List<Producto> productos;

    public Pedido(){

        productos = new List<Producto>();

    }

    public void AnadirProducto (Producto producto){

        productos.Add(producto);
        Console.WriteLine($"Producto anañadido: {producto.Nombre}");

    }

        public void EliminarProducto (Producto producto){

        productos.Remove(producto);
        Console.WriteLine($"Producto Eliminado: {producto.Nombre}");

    }

    public void MostrarPedido(){

        Console.WriteLine($"Producto anañadido: ");

        foreach (var producto in productos){
            producto.MostrarDetalles();
            
        }
    }


    public void MostrarTotal(){
        double total = 0;
        foreach(var producto in productos){
            total = total + producto.Precio;
        }
        Console.WriteLine($"Total: {total}");
    }

    public double CalcularTotal(){

        double total = 0;
        foreach(var producto in productos){
            total = total+producto.Precio;
        }
        return total;

    }


    public double AplicarIva(){

        double Iva = 0.21;
        return CalcularTotal() * Iva;

    }

        public double AplicarDescuento(){
        double Descuento = 21;
        double DescuentoEnCero = Descuento/100;
        return CalcularTotal() * DescuentoEnCero;

    }


}