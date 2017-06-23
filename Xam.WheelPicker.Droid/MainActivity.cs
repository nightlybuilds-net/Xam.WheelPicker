using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using static Com.Aigestudio.Wheelpicker.WheelPicker;
using Com.Aigestudio.Wheelpicker;
using Java.Lang;
using System;

namespace Xam.WheelPicker.Droid
{
    [Activity(Label = "Xam.WheelPicker.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

			var wheel = this.FindViewById<Com.Aigestudio.Wheelpicker.WheelPicker>(Resource.Id.pickerWheel);

            // adding some data
            var test = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                test.Add($"item{i}");
            }
            wheel.Data = test;

            // ios style
            wheel.Curved = true;
            wheel.SetIndicator(true);
            wheel.SetBackgroundColor(Android.Graphics.Color.Transparent);

            wheel.SetCurtain(true);

            wheel.ItemSelected += (sender, e) => 
            {
                Console.WriteLine(e.P2);
                Console.WriteLine(e.P1);
            };

        }
    }

   
}

