using Syncfusion.XForms.iOS.ProgressBar;
using Syncfusion.XForms.iOS.Cards;
using Syncfusion.SfRating.XForms.iOS;
using Syncfusion.XForms.iOS.ComboBox;
using Syncfusion.XForms.iOS.TextInputLayout;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.XForms.iOS.Core;
using Syncfusion.XForms.iOS.Graphics;
using Syncfusion.XForms.iOS.EffectsView;
using Syncfusion.XForms.iOS.Border;
using Syncfusion.XForms.iOS.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Soons.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Forms.Forms.Init();
            XF.Material.iOS.Material.Init();
            
            global::Xamarin.Forms.Forms.Init();
            SfLinearProgressBarRenderer.Init();
            SfCardViewRenderer.Init();
            SfRatingRenderer.Init();
            SfComboBoxRenderer.Init();
            SfTextInputLayoutRenderer.Init();
            SfAvatarViewRenderer.Init();
            SfSegmentedControlRenderer.Init();
            SfRadioButtonRenderer.Init();
            SfListViewRenderer.Init();
            SfEffectsViewRenderer.Init();
            Core.Init();
            SfGradientViewRenderer.Init();
            SfBorderRenderer.Init();
            SfButtonRenderer.Init();
            ZXing.Net.Mobile.Forms.iOS.Platform.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
