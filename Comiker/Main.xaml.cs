using System;
using Xamarin.Forms;

namespace Comiker
{
	public partial class Main : ContentPage
	{
		public Main()
		{
			InitializeComponent();
		}

		private async void SayHelloButton_OnClicked(object sender, EventArgs e)
		{
			var name = NameEntry.Text;
			await DisplayAlert("Greeting", $"Hello {name}!", "Howdy");
		}
	}
}