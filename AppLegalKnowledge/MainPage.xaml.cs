namespace AppLegalKnowledge
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}



		private async void EnterMainbtn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Home());


		}

		private async void RegMainBtn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new Register());
		}
	}

}
