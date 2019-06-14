using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Hardware;

[assembly: Xamarin.Forms.Dependency(typeof(App2.Droid.DependencyImplementation))]
namespace App2.Droid
{
    public class DependencyImplementation : IDependencyDemo, ISensorEventListener
    {

        public string GetThePlatformMessage()
        {
            return "I am Android";
        }


    }
}