﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Firebase;

namespace TodoApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Initialize Firebase
            FirebaseApp.InitializeApp(this);

            // Other initialization code if necessary
        }
    }
}
