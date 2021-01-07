using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWebsiteRazorPages.Models
{
    public class RecipeModel
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeIngredients { get; set; }
        public byte[] RecipePhoto { get; set; }
    }
}
