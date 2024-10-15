using Models;

var platoprincipal = new PlatoPrincipal("Plato combinado", 10.50, "Pollo y lechuga");
platoprincipal.MostrarDetalles();


var bebida = new Bebida("servesa", 3, true);
bebida.MostrarDetalles();



var postre = new Postres("Heladito", 4, 800);
postre.MostrarDetalles();


var combo = new Combo( "CamboCombazo", 10, platoprincipal, bebida, postre, 10 );
combo.MostrarDetalles();

// var tapa = new Producto ("tortilla", 180) Si quito el comentario no funcionara porque Producto es una clase Abstracta