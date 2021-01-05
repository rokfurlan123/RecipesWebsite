using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWebsiteRazorPages.Models
{
    public class RecipeModel
    {
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeIngredients { get; set; }
    }
}
