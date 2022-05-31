namespace MauiBindingDemo.Models;

public class ViewModel : NotifyBase
{
    private List<Product> _products;

    public List<Product> Products
    {
        get => _products;
        set => SetProperty(ref _products, value);
    }

    public List<Product> VisibleProducts => _products.Where(x => x.Visible).ToList();


    public ViewModel()
    {
        Products = GetProducts();
    }

    private List<Product> GetProducts()
    {
        List<Product> products = new()
        {
            new Product(1, "TV"),
            new Product(2, "Laptop"),
            new Product(3, "Radio"),
            new Product(4, "Mug"),
            new Product(5, "Water bottle", false),
            new Product(6, "Cables"),
            new Product(7, "Coffee", false),
            new Product(8, "Biscuit", false)
        };

        return products;
    }


}
