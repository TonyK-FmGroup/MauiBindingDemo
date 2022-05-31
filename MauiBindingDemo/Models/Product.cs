namespace MauiBindingDemo.Models;
public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Visible { get; set; }

    public Product(int id, string name, bool visible = true)
    {
        ID = id;
        Name = name;
        Visible = visible;
    }
}
