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
using System.IO;
using System.Drawing;

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
        public IFormFile RecipePhoto { get; set; }

        public IActionResult OnPostInsertRecipe()
        {
            var recipe = new RecipeModel();
                    
            var memoryStreamPhoto = new MemoryStream();
            RecipePhoto.CopyTo(memoryStreamPhoto);
            //Image image = Image.FromStream(memoryStreamPhoto, true, true);
            var imageBytes = memoryStreamPhoto.ToArray();

            recipe.RecipeName = RecipeName;
            recipe.RecipeDescription = RecipeDescription;
            recipe.RecipeIngredients = RecipeIngredients;
            recipe.RecipePhoto = imageBytes;

            string connString = "Server=DESKTOP-IB6EGL9;Database=RecipeDB;Trusted_Connection=True;MultipleActiveResultSets=True;";
            //string connString = ConfigurationManager.ConnectionStrings["ConnectionName"].ConnectionString;

            //rabis nuget system.data.sqlclient
            using (IDbConnection db = new SqlConnection(connString))
            {
                string sqlQuery = "INSERT INTO RecipeTable (RecipeName, RecipeDescription, RecipeIngredients, RecipePhoto) VALUES(@RecipeName, @RecipeDescription, @RecipeIngredients, @RecipePhoto)";
                int rowsAffected = db.Execute(sqlQuery, recipe);
            }

            return RedirectToPage();
        }

        public void OnGet(int ? id)
        {
            if(id != null)
            {
                string conn = "Server=DESKTOP-IB6EGL9;Database=RecipeDB;Trusted_Connection=True;MultipleActiveResultSets=True;";
                using (IDbConnection db = new SqlConnection(conn))
                {
                    var sqlStatement = $"DELETE FROM RecipeTable WHERE RecipeId='{id}'";
                    db.Execute(sqlStatement);
                }
            }

            var recipeList = new List<RecipeModel>();
            string connString = "Server=DESKTOP-IB6EGL9;Database=RecipeDB;Trusted_Connection=True;MultipleActiveResultSets=True;";
            using (IDbConnection db = new SqlConnection(connString))
            {
                recipeList = db.Query<RecipeModel>("SELECT RecipeName, RecipeId FROM RecipeTable").ToList();
            }
            if(recipeList != null)
            {
                ViewData["recipeList"] = recipeList;
            }     
        }

       
    }
}
