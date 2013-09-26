using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoTouch.CoreImage;
using MonoTouch.CoreGraphics;

namespace iOS.QRCodeRecipe
{
	public partial class iOS_QRCodeRecipeViewController : UIViewController
	{
		public iOS_QRCodeRecipeViewController () : base ("iOS_QRCodeRecipeViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		/// <summary>
		/// QR code correction level
		/// </summary>
		/// <see cref="http://en.wikipedia.org/wiki/QR_Code#Error_correction"/>
		public enum CorrectionLevel
		{
			L, // Level L (Low)	7% of codewords can be restored.
			M, // Level M (Medium) 15% of codewords can be restored.
			Q, // Level Q (Quartile) 25% of codewords can be restored.
			H  // Level H (High) 30% of codewords can be restored.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Set default text
			textField.Text = "http://www.xamarin.com";

			generateQRCode.TouchUpInside += delegate(object sender, EventArgs e) {
				textField.ResignFirstResponder ();

				// Generate QR code
				var qrGen = new CIQRCodeGenerator ();
				qrGen.Message = NSData.FromString (textField.Text);
				qrGen.CorrectionLevel = CorrectionLevel.M.ToString();

				// Render image				
				var context = CIContext.FromOptions(null);
				var img = UIImage.FromImage (context.CreateCGImage (qrGen.OutputImage, qrGen.OutputImage.Extent));

				// Display image
				imageView.Image = img;
			};
		}
	}
}