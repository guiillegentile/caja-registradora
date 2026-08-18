Console.WriteLine("Hello, World!");
string marketname = "open24";

Console.WriteLine("ingrese su nombre: ");
string username = Console.ReadLine();
Console.WriteLine($"hola, {username} bienvenido a {marketname}");
Console.ReadLine();

Console.WriteLine("Ingrese el nombre del producto: ");
string productname = Console.ReadLine();

Console.WriteLine("Ingrese el precio del producto: ");
decimal precio = decimal.Parse(Console.ReadLine());

Console.WriteLine($"El precio del producto es: {precio}");
Console.ReadLine();

int totalProductos = 0;
decimal totalVenta = 0;
int opcion;

do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Ingrese una opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("ingresa el nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            totalVenta += precioProducto;
            totalProductos++;

            Console.WriteLine("Producto cargado correctamente.");
            break;

        case 2:
            Console.WriteLine("Cerrando la venta...");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }

} while (opcion != 2);

Console.WriteLine("--- Resumen de la venta ---");
Console.WriteLine("Cantidad de productos: " + totalProductos);
Console.WriteLine("Total de la venta: $" + totalVenta);

