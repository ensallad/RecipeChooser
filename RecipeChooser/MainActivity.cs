using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;

namespace RecipeChooser
{
    [Activity(Label = "RecipeChooser", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button mainButton = FindViewById<Button>(Resource.Id.mainBtn);

            //TextView reciepeTextMain = FindViewById<TextView>(Resource.Id.textViewMain);

            mainButton.Click += delegate
            {
                SetContentView(Resource.Layout.randomizedRecipe);

                TextView textan;
                textan = FindViewById<TextView>(Resource.Id.textViewNumber1);

                Random random = new Random();
                int randomNumber = random.Next(1, 20);

                string randomNumberInString = randomNumber.ToString();
                //reciepeText.Text = randomNumberInString;
                textan.Text = randomNumberInString;
            };

        }

    }
}

