using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTutorial.CustomizedControls.CustomLoader
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomLoader : ContentView
    {
        public static readonly BindableProperty SetloaderTextProperty = null;
        static CustomLoader()
        {
            SetloaderTextProperty= BindableProperty.Create("SetloaderText", typeof(string), typeof(CustomLoader), defaultValue: "",
            defaultBindingMode: BindingMode.OneWay);
        }
        public CustomLoader()
        {
            InitializeComponent();
        }
      
     
        public string SetloaderText
        {
            get { return (string)GetValue(SetloaderTextProperty); }
            set { SetValue(SetloaderTextProperty, value); }
        }
    }
}