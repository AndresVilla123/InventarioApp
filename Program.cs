// See https://aka.ms/new-console-template for more information
using System.Reflection;

// Console.WriteLine("Hello, World!");

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

// Console.WriteLine($"Assembly version: {version}");

if (args.Length > 0)
{
    switch (args[0].ToLower())
    {
        case "--help":
          MostrarAyuda();
          Environment.Exit(0);
          break;
        
        case "--version":
          Console.WriteLine($"Assembly version: {version}");
          Environment.Exit(0);
          break;

        default:
          Console.WriteLine("Error: Command undefined");
          Console.WriteLine("Use --help for more information");
          Environment.Exit(1);
          break;    

        }

}

// Functions

void MostrarAyuda()
{
  Console.WriteLine("Use: Inventory project");

}

void MostrarBanner()
{
  Console.WriteLine("Project structure");
  Console.WriteLine("-----------------");

  Console.WriteLine("InventarioApp.csjproj");
  Console.WriteLine("Program.cs");
  Console.WriteLine("README.md");
  Console.WriteLine("sr/Models");  

}


int quantityProducts = 0;
decimal totalValueInventory = 0.0m;
bool activeSystem = true;
string systemName = "Inventory App";


Console.WriteLine("---System status----");
Console.WriteLine($"System Name: {systemName}");
Console.WriteLine($"registered produts: {quantityProducts}");
Console.WriteLine($"total inventory value: {totalValueInventory:N2}");
Console.WriteLine($"status system: {(activeSystem ? "ON" : "OFF")}");
Console.WriteLine("---------------------");


Console.WriteLine("Enter a quantity");
string? quantityClient = Console.ReadLine();

if (int.TryParse(quantityClient, out int quantity)) {
  Console.WriteLine("valid quantity");
  quantityProducts = quantity;
} else {
  Console.WriteLine("invalid quantity");
}

Console.WriteLine("Enter a price");
string? priceClient = Console.ReadLine();

if (decimal.TryParse(priceClient, out decimal price)) {
  Console.WriteLine($"valid  price: {price:N2}\n");
  totalValueInventory = quantityProducts * price;
  Console.WriteLine($"totalValueInventory is: {totalValueInventory}\n");
} else {
  Console.WriteLine("invalid price");
}



MostrarBanner();
Console.Write("Enter a command to run o 'salir' para terminar: "  );
string? inputClient = Console.ReadLine(); //STDIN to read the client input.

if (string.IsNullOrWhiteSpace(inputClient) || inputClient.ToLower() == "salir")
{
  Console.WriteLine("Good bye");
  Environment.Exit(0);
  
}



