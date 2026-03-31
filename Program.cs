// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Runtime.CompilerServices;

// Console.WriteLine("Hello, World!");

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

// Console.WriteLine($"Assembly version: {version}");


// Variables
int quantityProducts = 0;
decimal totalValueInventory = 0.0m;


bool continueProcess = true;


while (continueProcess)
{
  string inputVarible = InputRead();  
  Console.WriteLine($"Command entered: {inputVarible}");
  continueProcess = CommandProcess(inputVarible);
}


// Functions

bool CommandProcess(string inputVarible)
{
 switch (inputVarible)
  {
    case "listar":
      ListProducts();
      return true;
    case "agregar":
      AddProduct();
      return true;
    case "buscar":
      SearchProduct();
      return true;
    case "salir":
      return false;
    case "ayuda":
      return false;
    default:
      Console.WriteLine($"Command not found: {inputVarible}");
      return true;
  }
}

string InputRead()
{
  return Console.ReadLine() ?? string.Empty;
  
}

void ListProducts()
{
  Console.WriteLine($"Total products {quantityProducts}");
  Console.WriteLine($"Total value {totalValueInventory}");
}


void AddProduct()
{
  Console.WriteLine("Add product");
  Console.WriteLine("------------");
}

void SearchProduct()
{
  Console.WriteLine("Search product");
  Console.WriteLine("---------------");
}


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








