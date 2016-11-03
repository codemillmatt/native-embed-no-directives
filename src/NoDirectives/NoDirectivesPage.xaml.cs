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
			nc.GetControlForNoDirectivesPage(overallAbs);
		}
	}
}
