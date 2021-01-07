using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecipeWebsiteRazorPages.Models;

namespace RecipeWebsiteRazorPages.Pages
{
    public class ViewDetailsRecipeModel : PageModel
    {
        public void OnGet(int id)
        {
            var recipeInfo = new RecipeModel();
            string connString = "Server=DESKTOP-IB6EGL9;Database=RecipeDB;Trusted_Connection=True;MultipleActiveResultSets=True;";
            string query = $"SELECT RecipeId, RecipeName, RecipeIngredients, RecipeDescription, RecipePhoto FROM RecipeTable WHERE RecipeId='{id}'";
            using (IDbConnection db = new SqlConnection(connString))
            {
                recipeInfo = db.QuerySingle<RecipeModel>(query);
            }
            if (recipeInfo != null)
            {
                ViewData["recipeInfo"] = recipeInfo;
                Image photo = (Bitmap)((new ImageConverter()).ConvertFrom(recipeInfo.RecipePhoto));
                
            }
            
        }
        
    }
    
}
