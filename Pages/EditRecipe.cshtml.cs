using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using RecipeWebsiteRazorPages.Models;

namespace RecipeWebsiteRazorPages.Pages
{
    public class EditRecipeModel : PageModel
    {
        private readonly IOptions<AppsettingsValues> config;
        

        public EditRecipeModel(IOptions<AppsettingsValues> config)
        {
            this.config = config;
            
        }

        [BindProperty(SupportsGet = true)]
        public RecipeModel Recipe { get; set; }
        [BindProperty]
        public IFormFile RecipePhotoFormFile { get; set; }

        public IActionResult OnPost(int id)
        {
            string conn = config.Value.ConnectionName;
            string query = $"UPDATE RecipeTable SET RecipeName='{Recipe.RecipeName}', RecipeDescription='{Recipe.RecipeDescription}', RecipeIngredients='{Recipe.RecipeIngredients}' WHERE RecipeId='{id}'";
            
            if (RecipePhotoFormFile != null)
            {
                var memoryStreamPhoto = new MemoryStream();
                RecipePhotoFormFile.CopyTo(memoryStreamPhoto);
                var imageBytes = memoryStreamPhoto.ToArray();
                Recipe.RecipePhoto = imageBytes;
                Recipe.RecipeId = id;

                using (IDbConnection db = new SqlConnection(conn))
                {
                    query = $"UPDATE RecipeTable SET RecipeName='{Recipe.RecipeName}', RecipeDescription='{Recipe.RecipeDescription}', RecipeIngredients='{Recipe.RecipeIngredients}', RecipePhoto=CAST('{Recipe.RecipePhoto}' AS varbinary(MAX)) WHERE RecipeId='{id}'";
                    int rowsAffected = db.Execute(query);
                }
            }
            else
            {
                using (IDbConnection db = new SqlConnection(conn))
                {
                    int rowsaffected = db.Execute(query);
                }
            }
            return RedirectToPage("ViewDetailsRecipe", "OnGet", new {id}); // new {id = id} 
        }

        public IActionResult OnGet(int id)
        {
           
            string conn = config.Value.ConnectionName;
            string query = $"SELECT RecipeId, RecipeName, RecipeIngredients, RecipeDescription, RecipePhoto FROM RecipeTable WHERE RecipeId='{id}'";

            using (IDbConnection db = new SqlConnection(conn))
            {
                Recipe = db.QuerySingle<RecipeModel>(query);
            }

            if (Recipe != null)
            {
                    
            }
            return Page();
        }
    }
}
