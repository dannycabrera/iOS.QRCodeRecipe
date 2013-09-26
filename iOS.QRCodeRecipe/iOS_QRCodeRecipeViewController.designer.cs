// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace iOS.QRCodeRecipe
{
	[Register ("iOS_QRCodeRecipeViewController")]
	partial class iOS_QRCodeRecipeViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton generateQRCode { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imageView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField textField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}

			if (generateQRCode != null) {
				generateQRCode.Dispose ();
				generateQRCode = null;
			}

			if (imageView != null) {
				imageView.Dispose ();
				imageView = null;
			}
		}
	}
}
