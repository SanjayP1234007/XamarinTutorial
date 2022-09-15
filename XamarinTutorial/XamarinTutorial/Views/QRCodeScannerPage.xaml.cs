using System;
using System.Net.NetworkInformation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTutorial.CommonSource;

namespace XamarinTutorial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCodeScannerPage : ContentPage
    {
        public QRCodeScannerPage()
        {
            InitializeComponent();
            this.Title = "QRCode Scanner";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                zxingScanner.IsScanning = true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }
        protected override void OnDisappearing()
        {
            zxingScanner.IsScanning = false;
            base.OnDisappearing();
        }

        private void FlashlightButton_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                zxingScanner.IsTorchOn = !zxingScanner.IsTorchOn;
            });
        }

        private void zxingScanner_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                if (!string.IsNullOrEmpty(result.Text))
                {
                    QrCodeInfo.Text = result.Text;
                }
            });
        }
    }
}