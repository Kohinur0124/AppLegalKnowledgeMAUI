namespace AppLegalKnowledge;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
	private void OnCounterClicked(object sender, EventArgs e)
	{

	}

	private async void EnterBtn_Clicked(object sender, EventArgs e)
	{

		await Navigation.PushModalAsync(new MainPage());

	}

	private async void RegBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new Home());
	}
}