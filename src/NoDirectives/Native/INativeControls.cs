using System;
using Xamarin.Forms;
namespace NoDirectives
{
	public interface INativeControls
	{
		void GetControlForNoDirectivesPage(Layout<View> layout);

		View Fancy_GetSwitch(string titleOne, string titleTwo, Action<int> onClick);
	}
}
