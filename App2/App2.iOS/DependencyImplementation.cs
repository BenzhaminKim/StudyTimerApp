using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(App2.iOS.DependencyImplementation))]
namespace App2.iOS
{
    public class DependencyImplementation : IDependencyDemo
    {
        public string GetThePlatformMessage()
        {
            return "I am iOS";
        }
    }
}