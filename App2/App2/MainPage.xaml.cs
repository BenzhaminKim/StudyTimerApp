using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        private string version;
        public string Version
        {
            get { return version; }
            set
            {
                version = value;
                OnPropertyChanged(nameof(Version));
            }
        }
        Stopwatch stopwatch;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            
            string mode = DependencyService.Get<IDependencyDemo>().GetThePlatformMessage();
            Version = mode;
            stopwatch = new Stopwatch();
            lbl_stopWatch.Text = "00:00:00";
        }

        private void Btn_start_Clicked(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
                btn_start.Text = "Stop";
                Device.StartTimer(TimeSpan.FromSeconds(0.01), () =>
                {
                    lbl_stopWatch.Text = stopwatch.Elapsed.ToString();
                    if(!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    return true;
                }
            );
            }
            else
            {
                btn_start.Text = "Resume";
                stopwatch.Stop();
            }

           
            
        }

        private void Btn_reset_Clicked(object sender, EventArgs e)
        {
            lbl_stopWatch.Text = "00:00:00.00000";
            btn_start.Text = "Start";
            stopwatch.Reset();
        }
    }
}
