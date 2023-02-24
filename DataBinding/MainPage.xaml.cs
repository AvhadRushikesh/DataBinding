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
			Name = " John ",
			Phone = "  9999999999 ",
			Address = "  X Address"
		};

		Binding personBinding = new Binding();
        Binding personPhone = new Binding();
        Binding personAddress = new Binding();

        personBinding.Source = person;
		personBinding.Path = "Name";

        personPhone.Source = person;
        personPhone.Path = "Phone";

        personAddress.Source = person;
        personAddress.Path = "Address";

        txtName.SetBinding(Label.TextProperty, personBinding);
        txtPhone.SetBinding(Label.TextProperty, personPhone);
        txtAddress.SetBinding(Label.TextProperty, personAddress);
    }
}
