using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RecipeWebsiteRazorPages.Models;

namespace RecipeWebsiteRazorPages.Pages
{
    public class AddRecipeModel : PageModel
    {
        private readonly IConfiguration configuration;
        public AddRecipeModel(IConfiguration config)
        {
            this.configuration = config;
        }
        [BindProperty]
        public string RecipeName { get; set; }
        [BindProperty]
        public string RecipeDescription { get; set; }
        [BindProperty]
        public string RecipeIngredients { get; set; }
        [BindProperty]
        public IFormFile MyPhoto { get; set; }

        public void OnGet()
        {
            var recipeList = new List<RecipeModel>();
            string connString = "Server=DESKTOP-IB6EGL9;Database=RecipeDB;Trusted_Connection=True;MultipleActiveResultSets=True;";
            using (IDbConnection db = new SqlConnection(connString))
            {
                recipeList = db.Query<RecipeModel>("SELECT RecipeName, RecipeDescription, RecipeIngredients FROM RecipeTable").ToList();
            }
            if(recipeList != null)
            {
                ViewData["recipeList"] = recipeList;
            }
            
            
        }

        public IActionResult OnPostInsertRecipe(/*IFormFile ThisIsTheNameOfThePhoto*/)
        {
            var recipe = new RecipeModel();
            recipe.RecipeName = RecipeName;
            recipe.RecipeDescription = RecipeDescription;
            recipe.RecipeIngredients = RecipeIngredients;

            string connString = "Server=DESKTOP-IB6EGL9;Database=RecipeDB;Trusted_Connection=True;MultipleActiveResultSets=True;";
            //string connString = ConfigurationManager.ConnectionStrings["ConnectionName"].ConnectionString;

            //rabis nuget system.data.sqlclient
            using (IDbConnection db = new SqlConnection(connString))
            {
                string sqlQuery = "INSERT INTO RecipeTable (RecipeName, RecipeDescription, RecipeIngredients) VALUES(@RecipeName, @RecipeDescription, @RecipeIngredients)";
                int rowsAffected = db.Execute(sqlQuery, recipe);
            }

            return RedirectToPage();
        }
    }
}
