using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTutorial.CustomizedControls.CustomPoupDialog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomConfirmAlertDialog : ContentView
    {
        public EventHandler YesButtonEventHandler { get; set; }
        public EventHandler NoButtonEventHandler { get; set; }
        public CustomConfirmAlertDialog(string messageTitle, string messageTextResult, string noButtonText, string yesButtonText)
        {
            InitializeComponent();
            MessageTextLabel.Text = messageTextResult;
            NoButton.Text = noButtonText;
            NoButton.Clicked += NoButton_Clicked;
            YesButton.Text = yesButtonText;
            YesButton.Clicked += YesButton_Clicked;
        }
        private void NoButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(animate: false);
            NoButtonEventHandler?.Invoke(this, e);
        }
        private void YesButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync(animate: false);
            YesButtonEventHandler?.Invoke(this, e);
        }
    }
}