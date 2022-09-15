using LiftTrackMobileApp.CustomizedControls.CustomPoupDialog;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using XamarinTutorial.CustomizedControls.CustomLoader;
using XamarinTutorial.CustomizedControls.CustomPoupDialog;
using XamarinTutorial.CustomPoupDialog;

namespace XamarinTutorial.CommonSource
{
    public class HelperUtility
    {
        #region Custom Alert Popup
        public async Task OpenCustomPopUp(int popupType, string messageTitle, string messageTextResult, string messageButtonText, string custoConfirmAlertButtonText)
        {
            switch (popupType)
            {
                case 1:
                    var alertDialog = new CustomAlertDialog(messageTitle, messageTextResult, messageButtonText);
                    var popupPage = new InputAlertDialogBase<string>(alertDialog);
                    await PopupNavigation.Instance.PushAsync(popupPage);
                    break;
                case 2:
                    CustomConfirmAlertDialog _customConfirmPopUpDialog = new CustomConfirmAlertDialog(messageTitle, messageTextResult, messageButtonText, custoConfirmAlertButtonText);
                    var ConfirmPopUpPage = new InputAlertDialogBase<string>(_customConfirmPopUpDialog);
                    await PopupNavigation.Instance.PushAsync(ConfirmPopUpPage);
                    break;
            }
        }
        #endregion

        #region Call custom loader
        public  async Task StartCustomLoader(string loaderString)
        {
            try
            {
                try
                {
                    CustomLoader alertDialog = new CustomLoader();
                    alertDialog.SetloaderText = loaderString;
                    var popupPage = new InputAlertDialogBase<string>(alertDialog);
                    await PopupNavigation.Instance.PushAsync(popupPage);
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }

        public static async Task StopCustomLoader(string loaderString)
        {
            try
            {
                if (PopupNavigation.Instance.PopupStack.Count > 0)
                {
                    await PopupNavigation.Instance.PopAllAsync(false);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
        #endregion
    }
}
