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
                setNewLayout();
                //SetContentView(Resource.Layout.randomizedRecipe);
                
                //List<Recipes> recipeList = new List<Recipes>();
                //recipeList.Add(new Recipes { Name = "Lasagne", imagePath = "Lasagne", webLink = "https://www.koket.se/vad-blir-det-for-mat/per-morberg/lasagne-bolognese--per-morbergs-recept/" });
                //recipeList.Add(new Recipes { Name = "Köttbullar och potatismos", imagePath = "Meatballs", webLink = "https://www.koket.se/stefanos-kottbullar-med-potatismos" });
                //recipeList.Add(new Recipes { Name = "Pizza", imagePath = "pizza", webLink = "https://www.koket.se/niclas_wahlgren/varmratter/mjol/akta_hemlagad_pizza/" });
                //recipeList.Add(new Recipes { Name = "Chili con carne", imagePath = "Chili_con_carne", webLink = "https://www.koket.se/mat-for-stora-och-sma/charlotta-malhotra/chili-con-carne/" });
                //recipeList.Add(new Recipes { Name = "Spaghetti med köttfärssås", imagePath = "spaghettibolognese", webLink = "https://www.koket.se/mitt-kok/jennie-wallden/klassisk-kottfarssas-med-spaghetti/" });



                //TextView recipeTitleName = FindViewById<TextView>(Resource.Id.recipeTitle);

                //ImageView imageDialog = FindViewById<ImageView>(Resource.Id.imageDisplay);

                //Random random = new Random();
                //int randomNumber = random.Next(0, 4);
                        
                //recipeTitleName.Text = recipeList[randomNumber].Name;



                //string imageName = recipeList[randomNumber].imagePath;
                //if (imageName == "Lasagne")
                //{ imageDialog.SetImageResource(Resource.Drawable.Lasagne); }
                //else if(imageName == "Meatballs")
                //{ imageDialog.SetImageResource(Resource.Drawable.Meatballs); }
                //else if (imageName == "pizza")
                //{ imageDialog.SetImageResource(Resource.Drawable.pizza); }
                //else if (imageName == "Chili_con_carne")
                //{ imageDialog.SetImageResource(Resource.Drawable.Chili_con_carne); }
                //else if (imageName == "spaghettibolognese")
                //{ imageDialog.SetImageResource(Resource.Drawable.spaghettibolognese); }



                //Button newRecipeButton = FindViewById<Button>(Resource.Id.newRecipeBtn);
                //newRecipeButton.Click += delegate
                //{ recipeTitleName.Text = "fungerar"; };
            };

           

        }
        private void setNewLayout()
        {
            SetContentView(Resource.Layout.randomizedRecipe);

            List<Recipes> recipeList = new List<Recipes>();
            recipeList.Add(new Recipes { Name = "Lasagne", imagePath = "Lasagne", webLink = "https://www.koket.se/vad-blir-det-for-mat/per-morberg/lasagne-bolognese--per-morbergs-recept/" });
            recipeList.Add(new Recipes { Name = "Köttbullar och potatismos", imagePath = "Meatballs", webLink = "https://www.koket.se/stefanos-kottbullar-med-potatismos" });
            recipeList.Add(new Recipes { Name = "Pizza", imagePath = "pizza", webLink = "https://www.koket.se/niclas_wahlgren/varmratter/mjol/akta_hemlagad_pizza/" });
            recipeList.Add(new Recipes { Name = "Chili con carne", imagePath = "Chili_con_carne", webLink = "https://www.koket.se/mat-for-stora-och-sma/charlotta-malhotra/chili-con-carne/" });
            recipeList.Add(new Recipes { Name = "Spaghetti med köttfärssås", imagePath = "spaghettibolognese", webLink = "https://www.koket.se/mitt-kok/jennie-wallden/klassisk-kottfarssas-med-spaghetti/" });



            TextView recipeTitleName = FindViewById<TextView>(Resource.Id.recipeTitle);

            ImageView imageDialog = FindViewById<ImageView>(Resource.Id.imageDisplay);

            Random random = new Random();
            int randomNumber = random.Next(0, 4);

            recipeTitleName.Text = recipeList[randomNumber].Name;



            string imageName = recipeList[randomNumber].imagePath;
            if (imageName == "Lasagne")
            { imageDialog.SetImageResource(Resource.Drawable.Lasagne); }
            else if (imageName == "Meatballs")
            { imageDialog.SetImageResource(Resource.Drawable.Meatballs); }
            else if (imageName == "pizza")
            { imageDialog.SetImageResource(Resource.Drawable.pizza); }
            else if (imageName == "Chili_con_carne")
            { imageDialog.SetImageResource(Resource.Drawable.Chili_con_carne); }
            else if (imageName == "spaghettibolognese")
            { imageDialog.SetImageResource(Resource.Drawable.spaghettibolognese); }



            Button newRecipeButton = FindViewById<Button>(Resource.Id.newRecipeBtn);
            newRecipeButton.Click += delegate
            { setNewLayout(); };
        }
    }
    }

