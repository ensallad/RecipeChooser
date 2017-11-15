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
                recipeList.Add(new Recipes { Name = "Lasagne", imagePath = "Lasagne", webLink = "sven" });
                recipeList.Add(new Recipes { Name = "Köttbullar och potatismos", imagePath = "Meatballs", webLink = "tor" });
                recipeList.Add(new Recipes { Name = "Pizza", imagePath = "pizza", webLink = "tor" });
                recipeList.Add(new Recipes { Name = "Chili con carne", imagePath = "Chili_con_carne", webLink = "tor" });
                recipeList.Add(new Recipes { Name = "Spaghetti med köttfärssås", imagePath = "spaghettibolognese", webLink = "tor" });
            
               
                TextView recipeTitleName = FindViewById<TextView>(Resource.Id.recipeTitle);

                ImageView imageDialog = FindViewById<ImageView>(Resource.Id.imageDisplay);

                Random random = new Random();
                int randomNumber = random.Next(0, 4);


                string imageName = recipeList[randomNumber].imagePath;              
                //string imageString = "Resource.Drawable.imageName." + imageName;
                recipeTitleName.Text = recipeList[randomNumber].Name;
               
                //recipeTitleName.Text = recipeList[randomNumber].imagePath;

                //imageDialog.SetImageResource(Resource.Drawable.imageName);
                //imageDialog.SetImageResource(imageString);

                if (imageName == "Lasagne")
                { imageDialog.SetImageResource(Resource.Drawable.Lasagne); }
                else if(imageName == "Meatballs")
                { imageDialog.SetImageResource(Resource.Drawable.Meatballs); }
                else if (imageName == "pizza")
                { imageDialog.SetImageResource(Resource.Drawable.pizza); }
                else if (imageName == "Chili_con_carne")
                { imageDialog.SetImageResource(Resource.Drawable.Chili_con_carne); }
                else if (imageName == "spaghettibolognese")
                { imageDialog.SetImageResource(Resource.Drawable.spaghettibolognese); }
            };

        }

    }
}

