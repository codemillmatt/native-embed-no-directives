using System;
using Xamarin.Forms;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;

namespace NoDirectives
{
	public partial class NativeControls : INativeControls
	{
		public NativeControls()
		{
		}

		public void GetControlForNoDirectivesPage(Layout<View> layout)
		{
			var segmentedControl = new UISegmentedControl();
			segmentedControl.Frame = new CGRect(20, 20, 280, 40);
			segmentedControl.InsertSegment("One", 0, false);
			segmentedControl.InsertSegment("Two", 1, false);
			segmentedControl.SelectedSegment = 1;
			segmentedControl.ValueChanged += async (sender, e) =>
			{
				var selectedSegment = (sender as UISegmentedControl).SelectedSegment;
				await App.Current.MainPage.DisplayAlert(
					$"The selected segment is {selectedSegment}", "WHOA!!!!", "OK");
			};

			var holdingStack = new StackLayout { Padding = 8, HorizontalOptions = LayoutOptions.Center };
			holdingStack.Children.Add(segmentedControl);

			var overallStack = layout.FindByName<StackLayout>("overallStack");
			overallStack.Children.Insert(0, holdingStack);
		}
	}
}
