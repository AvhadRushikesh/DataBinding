using DataBinding.Models;

namespace DataBinding;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var person = new Person
		{
			Name = "John",
			Phone = "9999999999",
			Address = "X Address"
		};
    }
}
