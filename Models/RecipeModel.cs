using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeWebsiteRazorPages.Models
{
    public class RecipeModel
    {
        [BindProperty]
        public int RecipeId { get; set; }
        [BindProperty]
        public string RecipeName { get; set; }
        [BindProperty]
        public string RecipeDescription { get; set; }
        [BindProperty]
        public string RecipeIngredients { get; set; }
        [BindProperty]
        public byte[] RecipePhoto { get; set; }
    }
}
