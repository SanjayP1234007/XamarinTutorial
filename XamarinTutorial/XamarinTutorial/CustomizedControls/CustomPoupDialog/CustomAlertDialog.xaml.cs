using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiftTrackMobileApp.CustomizedControls.CustomPoupDialog
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomAlertDialog : ContentView
    {
       
        public  EventHandler OkButtonEventHandler { get; set; }

        public CustomAlertDialog(string messageHeader, string messageTextResult, string messageButtonText)
        {
            InitializeComponent();
            //TitleLabel.Text = messageHeader;
            MessageTextLabel.Text = messageTextResult;
            OkButton.Text = messageButtonText;
            OkButton.Clicked += OkButton_Clicked;
        }

        private void OkButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
            OkButtonEventHandler?.Invoke(this, e);
        }
    }
}