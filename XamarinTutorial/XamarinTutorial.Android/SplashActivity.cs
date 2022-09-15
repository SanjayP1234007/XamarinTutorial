using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using System.Threading;
using System.Threading.Tasks;

namespace XamarinTutorial.Droid
{
    [Activity(Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen", Label = "Xamarin", MainLauncher =true, NoHistory = false,ScreenOrientation = ScreenOrientation.Portrait, LaunchMode = LaunchMode.SingleTop)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.SplashInfo);
            // You can load a video, image or something that will be render at the Activity
            var videoView = FindViewById<VideoView>(Resource.Id.SplashScreenVideo);
            string videoPath = string.Format("android.resource://{0}/{1}", ApplicationContext.PackageName, Resource.Raw.InitialScreen);
            videoView.SetVideoPath(videoPath);
            // In a different thread than a main thread you have to mark the video to initialize and freeze the this thread until finish your video, so after that redirect to another Activity.
            Task.Run(() =>
            {
                videoView.Start();
                Thread.Sleep(4000);
                //OnResume();
                RunOnUiThread(() =>
                {
                    StartActivity(typeof(MainActivity));
                });
            });
        }
    }
}