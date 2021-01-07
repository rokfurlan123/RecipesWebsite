using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipeWebsiteRazorPages.Pages
{
    public class ViewRecipeModel : PageModel
    {
        [BindProperty]
        public string RecipeName { get; set; }
        [BindProperty]
        public byte[] RecipePhoto { get; set; }

        public void OnGet()
        {
            var recipeInfo = new List<ViewRecipeModel>();
            string connString = "Server=DESKTOP-IB6EGL9;Database=RecipeDB;Trusted_Connection=True;MultipleActiveResultSets=True;";
            using (IDbConnection db = new SqlConnection(connString))
            {
                recipeInfo = db.Query<ViewRecipeModel>("SELECT RecipeName, RecipePhoto FROM RecipeTable").ToList();
            }
            if (recipeInfo != null)
            {
                ViewData["recipeInfo"] = recipeInfo;
            }
        }
    }
}
