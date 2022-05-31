using MauiBindingDemo.Models;

namespace MauiBindingDemo;

public partial class MainPage : ContentPage
{
	private readonly ViewModel _viewModel = new();

	public MainPage()
	{
		InitializeComponent();
		BindingContext = _viewModel;
	}


}

