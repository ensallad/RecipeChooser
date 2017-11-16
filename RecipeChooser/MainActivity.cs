using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;
using System.Collections;
using System.Collections.Generic;
using Android.Content;

namespace RecipeChooser
{
    [Activity(Label = "RecipeChooser", MainLauncher = true, Icon = "@drawable/startbild")]
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
            recipeList.Add(new Recipes { Name = "Carbonara", imagePath = "Carbonara", webLink = "https://www.koket.se/mitt-kok/paolo-roberto/carbonara-paolo-robertos-recept" });
            recipeList.Add(new Recipes { Name = "Pannkaka", imagePath = "Pannkaka", webLink = "https://www.koket.se/pannkaka-2" });
            recipeList.Add(new Recipes { Name = "Biff Stroganoff", imagePath = "Biffstroganoff", webLink = "https://www.koket.se/mitt-kok/tommy-myllymaki/biff-stroganoff/" });
            recipeList.Add(new Recipes { Name = "Kycklingkebab med pitabröd", imagePath = "Kycklingkebab", webLink = "https://www.koket.se/kycklingkebab-med-pitabrod" });
            recipeList.Add(new Recipes { Name = "Vietnamesiska sommarrullar", imagePath = "Varrullar", webLink = "https://www.koket.se/nyhetsmorgon/jennie-wallden/vietnamesiska-sommarrullar/" });
            recipeList.Add(new Recipes { Name = "Kåldolmar", imagePath = "Kaldolmar", webLink = "https://www.koket.se/matgladje-hela-livet/leif-mannerstrom/kaldolmar/" });
            recipeList.Add(new Recipes { Name = "Falafel", imagePath = "Falafel", webLink = "https://www.koket.se/falafel-med-myntasas" });
            recipeList.Add(new Recipes { Name = "Fish and chips", imagePath = "Fishandchips", webLink = "https://www.koket.se/marcus_samuelsson/varmratter/fisk_och_skaldjur/fish_and_chips/" });
            recipeList.Add(new Recipes { Name = "Pasta kyckling Alfredo", imagePath = "Pastaalfredo", webLink = "https://www.koket.se/one-pot-kyckling-alfredo" });
            recipeList.Add(new Recipes { Name = "Pyttipanna", imagePath = "Pyttipanna", webLink = "https://www.koket.se/per_morberg/varmratter/kott/per_morbergs_pyttipanna/" });
            recipeList.Add(new Recipes { Name = "Köttbullar med potatis och gräddsås", imagePath = "Kottbullarpotatis", webLink = "https://www.koket.se/hemlagade-kottbullar-med-graddsas" });
            recipeList.Add(new Recipes { Name = "Hamburgare", imagePath = "Hamburgare", webLink = "https://www.koket.se/mitt-kok/tommy-myllymaki/tommy-myllymakis-saftiga-cheeseburgare/" });
            recipeList.Add(new Recipes { Name = "Wookade nudlar med grönsaker", imagePath = "Wookadenudlar", webLink = "https://www.koket.se/koket/pelle-johansson/wokade-nudlar-med-gronsaker/" });
            recipeList.Add(new Recipes { Name = "Gulaschsoppa", imagePath = "Gulaschsoppa", webLink = "https://www.koket.se/gulaschsoppa-pa-notfars" });
            recipeList.Add(new Recipes { Name = "Potatisgratäng", imagePath = "Potatisgratang", webLink = "https://www.koket.se/kramig-potatisgratang" });

            TextView recipeTitleName = FindViewById<TextView>(Resource.Id.recipeTitle);

            ImageView imageDialog = FindViewById<ImageView>(Resource.Id.imageDisplay);

            Random random = new Random();
            int randomNumber = random.Next(0, 19);

            recipeTitleName.Text = recipeList[randomNumber].Name + " " + randomNumber;

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
            else if (imageName == "Pannkaka")
            { imageDialog.SetImageResource(Resource.Drawable.Pannkaka); }
            else if (imageName == "Biffstroganoff")
            { imageDialog.SetImageResource(Resource.Drawable.Biffstroganoff); }
            else if (imageName == "Kycklingkebab")
            { imageDialog.SetImageResource(Resource.Drawable.Kycklingkebab); }
            else if (imageName == "Varrullar")
            { imageDialog.SetImageResource(Resource.Drawable.Varrullar); }
            else if (imageName == "Kaldolmar")
            { imageDialog.SetImageResource(Resource.Drawable.Kaldolmar); }
            else if (imageName == "Falafel")
            { imageDialog.SetImageResource(Resource.Drawable.Falafel); }
            else if (imageName == "Fishandchips")
            { imageDialog.SetImageResource(Resource.Drawable.Fishandchips); }
            else if (imageName == "Pastaalfredo")
            { imageDialog.SetImageResource(Resource.Drawable.Pastaalfredo); }
            else if (imageName == "Pyttipanna")
            { imageDialog.SetImageResource(Resource.Drawable.Pyttipanna); }
            else if (imageName == "Kottbullarpotatis")
            { imageDialog.SetImageResource(Resource.Drawable.Kottbullarpotatis); }
            else if (imageName == "Hamburgare")
            { imageDialog.SetImageResource(Resource.Drawable.Hamburgare); }
            else if (imageName == "Wookadenudlar")
            { imageDialog.SetImageResource(Resource.Drawable.Wookadenudlar); }
            else if (imageName == "Gulaschsoppa")
            { imageDialog.SetImageResource(Resource.Drawable.Gulaschsoppa); }
             else if (imageName == "Potatisgratang")
            { imageDialog.SetImageResource(Resource.Drawable.Potatisgratang); }

            Button newRecipeButton = FindViewById<Button>(Resource.Id.newRecipeBtn);
            newRecipeButton.Click += delegate
            { setNewLayout(); };

            Button goToRecipeButton = FindViewById<Button>(Resource.Id.goToRecipeBtn);
            string recipeUrl = recipeList[randomNumber].webLink;
            goToRecipeButton.Click += delegate
            {
                var uri = Android.Net.Uri.Parse(recipeUrl);
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            };

        }
    }
    }

