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
    [Activity(Label = "Receptväljaren", MainLauncher = true, Icon = "@drawable/startbild")]
    public class MainActivity : Activity
    {
        List<Recipes> recipeList = new List<Recipes>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
           
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button mainButton = FindViewById<Button>(Resource.Id.mainBtn);
            
            mainButton.Click += delegate
            {
                fillRecipeList();
                setNewLayout();               
            };


        }
        private void setNewLayout()
        {
            SetContentView(Resource.Layout.randomizedRecipe);
                   
            TextView recipeTitleName = FindViewById<TextView>(Resource.Id.recipeTitle);
            ImageView imageDialog = FindViewById<ImageView>(Resource.Id.imageDisplay);

            Random random = new Random();
            int randomNumber = random.Next(0, 20);
         
            string imageName = recipeList[randomNumber].imagePath;
            int resourceId = (int)typeof(Resource.Drawable).GetField(imageName).GetValue(null);

            recipeTitleName.Text = recipeList[randomNumber].Name;
            imageDialog.SetImageResource(resourceId);

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

        private void fillRecipeList()
        {
            recipeList.Add(new Recipes { Name = "Lasagne", imagePath = "Lasagne", webLink = "https://www.koket.se/vad-blir-det-for-mat/per-morberg/lasagne-bolognese--per-morbergs-recept/" });
            recipeList.Add(new Recipes { Name = "Köttbullar och potatismos", imagePath = "Meatballs", webLink = "https://www.koket.se/stefanos-kottbullar-med-potatismos" });
            recipeList.Add(new Recipes { Name = "Pizza", imagePath = "pizza", webLink = "https://www.koket.se/niclas_wahlgren/varmratter/mjol/akta_hemlagad_pizza/" });
            recipeList.Add(new Recipes { Name = "Chili con carne", imagePath = "Chili_con_carne", webLink = "https://www.koket.se/mat-for-stora-och-sma/charlotta-malhotra/chili-con-carne/" });
            recipeList.Add(new Recipes { Name = "Spaghetti med köttfärssås", imagePath = "spaghettibolognese", webLink = "https://www.koket.se/mitt-kok/jennie-wallden/klassisk-kottfarssas-med-spaghetti/" });

            recipeList.Add(new Recipes { Name = "Pasta carbonara", imagePath = "Carbonara", webLink = "https://www.koket.se/mitt-kok/paolo-roberto/carbonara-paolo-robertos-recept" });
            recipeList.Add(new Recipes { Name = "Pannkaka", imagePath = "Pannkaka", webLink = "https://www.koket.se/pannkaka-2" });
            recipeList.Add(new Recipes { Name = "Biff Stroganoff", imagePath = "Biffstroganoff", webLink = "https://www.koket.se/mitt-kok/tommy-myllymaki/biff-stroganoff/" });
            recipeList.Add(new Recipes { Name = "Kycklingkebab med pitabröd", imagePath = "Kycklingkebab", webLink = "https://www.koket.se/kycklingkebab-med-pitabrod" });
            recipeList.Add(new Recipes { Name = "Vietnamesiska sommarrullar", imagePath = "Varrullar", webLink = "https://www.koket.se/nyhetsmorgon/jennie-wallden/vietnamesiska-sommarrullar/" });

            recipeList.Add(new Recipes { Name = "Kåldolmar", imagePath = "Kaldolmar", webLink = "https://www.koket.se/matgladje-hela-livet/leif-mannerstrom/kaldolmar/" });
            recipeList.Add(new Recipes { Name = "Falafel", imagePath = "Falafel", webLink = "https://www.koket.se/falafel-med-myntasas" });
            recipeList.Add(new Recipes { Name = "Fish and chips", imagePath = "Fishandchips", webLink = "https://www.koket.se/marcus_samuelsson/varmratter/fisk_och_skaldjur/fish_and_chips/" });
            recipeList.Add(new Recipes { Name = "Pasta kyckling Alfredo", imagePath = "Pastaalfredo", webLink = "https://www.koket.se/one-pot-kyckling-alfredo" });
            recipeList.Add(new Recipes { Name = "Pyttipanna", imagePath = "Pyttipanna", webLink = "https://www.koket.se/per_morberg/varmratter/kott/per_morbergs_pyttipanna/" });

            recipeList.Add(new Recipes { Name = "Köttbullar med gräddsås", imagePath = "Kottbullarpotatis", webLink = "https://www.koket.se/hemlagade-kottbullar-med-graddsas" });
            recipeList.Add(new Recipes { Name = "Hamburgare", imagePath = "Hamburgare", webLink = "https://www.koket.se/mitt-kok/tommy-myllymaki/tommy-myllymakis-saftiga-cheeseburgare/" });
            recipeList.Add(new Recipes { Name = "Wookade nudlar med grönsaker", imagePath = "Wookadenudlar", webLink = "https://www.koket.se/koket/pelle-johansson/wokade-nudlar-med-gronsaker/" });
            recipeList.Add(new Recipes { Name = "Gulaschsoppa", imagePath = "Gulaschsoppa", webLink = "https://www.koket.se/gulaschsoppa-pa-notfars" });
            recipeList.Add(new Recipes { Name = "Potatisgratäng", imagePath = "Potatisgratang", webLink = "https://www.koket.se/kramig-potatisgratang" });
        }

    }
    }

