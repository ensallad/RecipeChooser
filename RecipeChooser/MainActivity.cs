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
            int listSize = 0;
            for (int x = 0; x < recipeList.Count; x++)
            { listSize = x + 1; };
            int randomNumber = random.Next(0, listSize);
            
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

            recipeList.Add(new Recipes { Name = "Köttfärspaj", imagePath = "Kottfarspaj", webLink = "https://www.koket.se/lisa-lemkes-basta-kottfarspaj" });
            recipeList.Add(new Recipes { Name = "Morotssoppa", imagePath = "Morotssoppa", webLink = "https://www.koket.se/morotssoppa-med-ingefara-och-chili" });
            recipeList.Add(new Recipes { Name = "Kycklinggryta med curry", imagePath = "Kycklinggryta", webLink = "https://www.koket.se/anna-hallen/soppor-och-grytor/kyckling-och-fagel/kycklinggryta-med-curry/" });
            recipeList.Add(new Recipes { Name = "Makaronipudding", imagePath = "Makaronipudding", webLink = "https://www.koket.se/morberg-lagar-husmanskost/per-morberg/per-morbergs-makaronipudding/" });
            recipeList.Add(new Recipes { Name = "Ugnsbakad kyckling", imagePath = "Ugnsbakadkyckling", webLink = "https://www.koket.se/camilla_thulin_och_uluc_telmen/varmratter/kyckling_och_fagel/ugnsbakad_kyckling_med_klyftpotatis/" });

            recipeList.Add(new Recipes { Name = "Sushi", imagePath = "Sushi", webLink = "https://www.koket.se/sa-gor-du-egen-sushi" });
            recipeList.Add(new Recipes { Name = "Lax", imagePath = "Salmon", webLink = "https://www.koket.se/mitt-kok/tommy-myllymaki/sojamarinerad-lax-med-sesambroccoli/" });
            recipeList.Add(new Recipes { Name = "Wienerschnitzel", imagePath = "Wienerschnitzel", webLink = "https://www.koket.se/per-morbergs-wienerschnitzel" });
            recipeList.Add(new Recipes { Name = "Asiatisk kycklingsoppa", imagePath = "Kycklingsoppa", webLink = "https://www.koket.se/annika_wesslen/varmratter/kyckling_och_fagel/asiatisk_kycklingsoppa/" });
            recipeList.Add(new Recipes { Name = "Caesarsallad", imagePath = "Caesarsallad", webLink = "https://www.koket.se/svarslagen-caesarsallad" });
        }

    }
    }

