using System;
using UIKit;

namespace TabbedNav
{
	public class TabbedController : UITabBarController
	{
		public static UIStoryboard Storyboard = UIStoryboard.FromName ("Event", null);
		UIViewController tab1, tab2, tab3;
		public TabbedController ()
		{
			tab1 = new UIViewController();
			tab1.Title = "Green";
			tab1.View.BackgroundColor = UIColor.Green;

			tab2 = new UIViewController();
			tab2.Title = "Orange";
			tab2.View.BackgroundColor = UIColor.Orange;



			tab3 = Storyboard.InstantiateInitialViewController () as UIViewController;;
			tab3.Title = "Stuffs";


			var tabs = new UIViewController[] {
				tab1, tab2, tab3
			};

			ViewControllers = tabs;

			SelectedViewController = tab2; // normally you would default to the left-most tab (ie. tab1)
		}
	}
}

