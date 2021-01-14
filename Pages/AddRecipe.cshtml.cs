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
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace RecipeWebsiteRazorPages.Pages
{
    public class AddRecipeModel : PageModel
    {
        private readonly IOptions<AppsettingsValues> config;

        public AddRecipeModel(IOptions<AppsettingsValues> config)
        {
            this.config = config;
        }
        [Required]
        [BindProperty]
        //[Display(Prompt = "")] prompt je basically placeholder - value noter vpisan
        public string RecipeName { get; set; }
        [Required]
        [BindProperty]
        public string RecipeDescription { get; set; }
        [Required]
        [BindProperty]
        public string RecipeIngredients { get; set; }
        [Required]
        [BindProperty]
        public IFormFile RecipePhoto { get; set; }

        public IActionResult OnPostInsertRecipe()
        {
            if(ModelState.IsValid)
            {
                var recipe = new RecipeModel();

                var memoryStreamPhoto = new MemoryStream();
                RecipePhoto.CopyTo(memoryStreamPhoto);
                var imageBytes = memoryStreamPhoto.ToArray();

                recipe.RecipeName = RecipeName;
                recipe.RecipeDescription = RecipeDescription;
                recipe.RecipeIngredients = RecipeIngredients;
                recipe.RecipePhoto = imageBytes;

                string connString = config.Value.ConnectionName;

                //rabis nuget system.data.sqlclient
                using (IDbConnection db = new SqlConnection(connString))
                {
                    string sqlQuery = "INSERT INTO RecipeTable (RecipeName, RecipeDescription, RecipeIngredients, RecipePhoto) VALUES(@RecipeName, @RecipeDescription, @RecipeIngredients, @RecipePhoto)";
                    int rowsAffected = db.Execute(sqlQuery, recipe);
                }
                return RedirectToPage();

            }

            return Page();
        }
            
        public void OnGet(int? id)
        {
            
            string conn = config.Value.ConnectionName;
            if (id != null)
            {            
                using (IDbConnection db = new SqlConnection(conn))
                {
                    var sqlStatement = $"DELETE FROM RecipeTable WHERE RecipeId='{id}'";
                    db.Execute(sqlStatement);
                }
            }

            var recipeList = new List<RecipeModel>();
            
            using (IDbConnection db = new SqlConnection(conn))
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
