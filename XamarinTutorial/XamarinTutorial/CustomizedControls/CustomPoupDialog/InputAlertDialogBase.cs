using Rg.Plugins.Popup.Pages;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTutorial.CustomPoupDialog
{
    /// <summary>
    /// The awesome Transparent Popup Page
    /// sub-classed from Rg.Plugins.Popup
    /// Customized for our usecase with
    /// Generic data type support for the result
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InputAlertDialogBase<T> : PopupPage
    {
        public InputAlertDialogBase(View contentBody)
        {
            Content = contentBody;
            // init the task completion source
            this.BackgroundColor = new Color(0, 0, 0, 0.4);
            CloseWhenBackgroundIsClicked = false;
        }

        // Method for animation child in PopupPage
        // Invoced after custom animation end
        protected override Task OnAppearingAnimationEndAsync()
        {
            Content.FadeTo(1);
            return base.OnAppearingAnimationEndAsync();
        }

        // Method for animation child in PopupPage
        // Invoked before custom animation begin
        protected override Task OnDisappearingAnimationBeginAsync()
        {
            Content.FadeTo(1);
            return base.OnDisappearingAnimationBeginAsync();
        }
        protected override bool OnBackButtonPressed()
        {
            // Prevent back button pressed action on android
            //return base.OnBackButtonPressed();
            return true;
        }

        // Invoced when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Prevent background clicked action
            //return base.OnBackgroundClicked();
            return false;
        }
    }


}
