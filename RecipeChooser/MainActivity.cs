using Android.App;
using Android.Widget;
using Android.OS;

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

            //FindViewById<Button>(Resource.Id.mainBtn).Click += (o, e) =>
            //{

            //};

            mainButton.Click += delegate {
                SetContentView(Resource.Layout.randomizedRecipe);
            };
        }
       
    }
}

