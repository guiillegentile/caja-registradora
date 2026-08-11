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
