using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Threading;

namespace TabbedNav
{
	partial class RootViewController : UIViewController
	{
		public RootViewController (IntPtr handle) : base (handle)
		{
		}

		partial void GoToOtherStuff (UIButton sender)
		{
			/* METHOD 1 */
			/*
			this.BeginInvokeOnMainThread(() => {
				NavigationController.PerformSegue("OtherStuff", this);
			});
			*/

			/* METHOD 2 */
			/*
			this.BeginInvokeOnMainThread(() => {
				NavigationController.PerformSegue("OtherStuff", this);
			});
			*/

			/* METHOD 3 */
			/*
			this.BeginInvokeOnMainThread (() => {
				var timer = new Timer(new TimerCallback((state) => {
					this.BeginInvokeOnMainThread (() => {
						NavigationController.PerformSegue ("OtherStuff", this);
					});
				}), null, 500, Timeout.Infinite);
			});
			*/
			PerformSegue ("OtherStuff", this);
		}
	}
}
