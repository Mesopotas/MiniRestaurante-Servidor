using Models;

var platoprincipal = new PlatoPrincipal("Plato combinado", 10.50, "Pollo y lechuga");
platoprincipal.MostrarDetalles();

Console.WriteLine("************");

var bebida = new Bebida("servesa", 3, true);
bebida.MostrarDetalles();

Console.WriteLine("************");

var postre = new Postres("Heladito", 4, 800);
postre.MostrarDetalles();

Console.WriteLine("************");

var combo = new Combo( "CamboCombazo", 10, platoprincipal, bebida, postre, 10 );
combo.MostrarDetalles();

// var tapa = new Producto ("tortilla", 180) Si quito el comentario no funcionara porque Producto es una clase Abstracta

Console.WriteLine("************");


var pedido = new Pedido();
pedido.AnadirProducto(platoprincipal);
pedido.AnadirProducto(bebida);
pedido.AnadirProducto(postre);
pedido.AnadirProducto(combo);
pedido.EliminarProducto(combo);
pedido.MostrarPedido();
pedido.MostrarTotal();


Console.WriteLine("************");

var totalIva = pedido.AplicarIva();
Console.WriteLine($"Iva calculado: {totalIva}");

Console.WriteLine("************");

var totalDescuento = pedido.AplicarDescuento();
Console.WriteLine($"Descuento calculado: {totalDescuento}");


