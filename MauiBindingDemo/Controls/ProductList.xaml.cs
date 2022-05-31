using MauiBindingDemo.Models;

namespace MauiBindingDemo.Controls;

public partial class ProductList : ContentView
{

    public static BindableProperty ProductsProperty =
       BindableProperty.Create(nameof(Products),
           typeof(List<Product>),
           typeof(ProductList));


    public List<Product> Products
    {
        get => (List<Product>)GetValue(ProductsProperty);
        set
        {
            SetValue(ProductsProperty, value);
            OnPropertyChanged(nameof(Products));
        }
    }

    public ProductList()
	{
		InitializeComponent();
	}
}