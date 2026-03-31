namespace InventarioApp.Repositories;

using InventarioApp.Models;

public interface IRepositoryProduct
{
    IEnumerable<Producto> GetAll();

    bool UpdateProduct(Producto product);

    bool DeleteProduct(int productId);

    int Cantidad { get; }
}