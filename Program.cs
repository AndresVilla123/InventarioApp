// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine($"Assembly version: {version}");

// Progress project

Console.WriteLine("Project structure");
Console.WriteLine("-----------------");

Console.WriteLine("InventarioApp.csjproj");
Console.WriteLine("Program.cs");
Console.WriteLine("README.md");
Console.WriteLine("sr/Models");