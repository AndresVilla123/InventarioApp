namespace InventarioApp.Models;

public record Proveedor(
    int Id,
    string Nombre,
    string Direccion,
    string Email,
    string Telefono
);