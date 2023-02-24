using DataBinding.Models;

namespace DataBinding;

public partial class MainPage : ContentPage
{
	Person person = new Person();
	public MainPage()
	{
		InitializeComponent();

        person = new Person
        {
            Name = "John",
            Phone = "9999999999",
            Address = "X Address"
        };

        BindingContext = person;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        person.Name = "Peter";
        person.Phone = "00000";
        person.Address = "xxxxxx";
    }
}
