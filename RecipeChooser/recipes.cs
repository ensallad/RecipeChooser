using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace RecipeChooser
{
    class Recipes
    {                 
            public string Name { get; set; }
            public string imagePath{ get; set; }
            public string webLink { get; set; }
    }
}