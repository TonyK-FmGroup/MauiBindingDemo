using MauiBindingDemo.Models;

namespace MauiBindingDemo.Controls;

public partial class ContentList : ContentView
{

    public static BindableProperty ContentItemsProperty =
       BindableProperty.Create(nameof(ContentItems),
           typeof(List<Product>),
           typeof(ContentList));

    public List<Product> ContentItems
    {
        get => (List<Product>)GetValue(ContentItemsProperty);
        set
        {
            SetValue(ContentItemsProperty, value);
            OnPropertyChanged(nameof(ContentItems));
        }
    }

    public ContentList()
    {
        BindingContext = this;
        InitializeComponent();
    }
}