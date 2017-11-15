using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;
using System.Collections;
using System.Collections.Generic;

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
            
                List<Recipes> recipeList = new List<Recipes>();
                recipeList.Add(new Recipes { Name = "Lasagne", imagePath = "Chili_con_carne", webLink = "sven" });
                recipeList.Add(new Recipes { Name = "Köttbullar och potatismos", imagePath = "lasagne", webLink = "tor" });
                recipeList.Add(new Recipes { Name = "Pizza", imagePath = "Meatballs", webLink = "tor" });
                recipeList.Add(new Recipes { Name = "Chili con carne", imagePath = "pizza", webLink = "tor" });
                recipeList.Add(new Recipes { Name = "Spaghetti med köttfärssås", imagePath = "spaghettibolognese", webLink = "tor" });
            
               
                TextView recipeTitleName = FindViewById<TextView>(Resource.Id.recipeTitle);

                //ImageView imageDialog = FindViewById<ImageView>(Resource.Id.imageDisplay);

                Random random = new Random();
                int randomNumber = random.Next(0, 4);


                string imageName = recipeList[randomNumber].imagePath;

                //recipeTitleName.Text = recipeList[randomNumber].Name;
                recipeTitleName.Text = recipeList[randomNumber].imagePath;

                //imageDialog.SetImageResource(Resource.Drawable.imageName);

            };

        }

    }
}

