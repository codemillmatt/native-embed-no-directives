using Xamarin.Forms;

namespace NoDirectives
{
	public partial class NoDirectivesPage : ContentPage
	{
		public NoDirectivesPage()
		{
			InitializeComponent();

			overallList.ItemsSource = new[] { "Hello", "World", "This", "Is", "Native", "Embedding" };

			var nc = new NativeControls();
			//nc.GetControlForNoDirectivesPage(overallAbs);

			// Fancy it up a bit
			var fancy = nc.Fancy_GetSwitch("first", "second", async (int obj) =>
			{
				await App.Current.MainPage.DisplayAlert($"The selected segment is {obj}",
														"WHOA!!!!", "OK");
			});

			if (fancy != null)
				overallStack.Children.Insert(0, fancy);
		}
	}
}
