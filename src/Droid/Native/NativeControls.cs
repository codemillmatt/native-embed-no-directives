using System;
using Xamarin.Forms;
using Android.Support.Design.Widget;
using Xamarin.Forms.Platform.Android;

namespace NoDirectives
{
	public partial class NativeControls : INativeControls
	{
		public NativeControls()
		{
		}

		public void GetControlForNoDirectivesPage(Layout<View> layout)
		{
			var fab = new FloatingActionButton(Forms.Context);
			fab.Click += async (sender, e) =>
			{
				await App.Current.MainPage.DisplayAlert("Native FAB Clicked",
														"WHOA!!!!!", "OK");
			};

			fab.UseCompatPadding = true;

			var holdingStack = new StackLayout { Padding = 8, HorizontalOptions = LayoutOptions.Center };
			holdingStack.Children.Add(fab);

			layout.Children.Add(holdingStack);

			AbsoluteLayout.SetLayoutFlags(holdingStack, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(holdingStack, new Rectangle(1f, 1f,
																	   AbsoluteLayout.AutoSize,
			                                                           AbsoluteLayout.AutoSize));
		}


		public View Fancy_GetSwitch(string titleOne, string titleTwo, Action<int> onClick) => null;
	
	}
}
