using Prism.Mvvm;
using System;
using Xamarin.Forms;

namespace XamarinTutorial.CustomizedControls.CustomLoader
{
    public class CustomPNGControlViewModel : BindableBase
    {
        private ImageSource _ImagePath;
        public ImageSource ImagePath
        {
            get
            {
                return _ImagePath;
            }
            set
            {
                SetProperty<ImageSource>(ref _ImagePath, value, "ImagePath");
            }
        }
        public CustomPNGControlViewModel()
        {
            var imageName = ImageSource.FromResource("LiftTrackMobileApp.CustomizedControls.CustomLoader.LoaderImages.Loader_1.png");
            ImagePath = imageName;
            SetImageAnimation();
        }
        private void SetImageAnimation()
        {
            try
            {
                int imageCounter = 1;
                Device.StartTimer(TimeSpan.FromMilliseconds(30), () =>
                {
                    var imageName = ImageSource.FromResource("LiftTrackMobileApp.CustomizedControls.CustomLoader.LoaderImages." + "Loader_" + imageCounter + ".png");
                    ImagePath = imageName;
                    imageCounter++;
                    if (imageCounter > 31)
                    {
                        imageCounter = 1;
                    }
                    return true;
                });
            }
            catch (Exception ex)
            {
               string msg=ex.Message;
            }
           
        }
    }
}
