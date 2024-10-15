using Models;

class MenusApp{

    private Pedido pedido {get; set;}

    public MenusApp(){

        pedido = new Pedido();

    }
 
    public void MostrarMenu(){

        int opcion = 0;

        do{

            Console.WriteLine("\n--- Menú del Restaurante ---");
            Console.WriteLine("1. Añadir Plato Principal");
            Console.WriteLine("2. Añadir Bebida");
            Console.WriteLine("3. Añadir Postre");
            Console.WriteLine("4. Mostrar Pedido");
            Console.WriteLine("5. Calcular Total y Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5);
            Console.WriteLine("Selecciona entre 1 y 5");
            continue;

        }while ( opcion != 5 );

    }



}