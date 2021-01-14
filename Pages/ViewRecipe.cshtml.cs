using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RecipeWebsiteRazorPages.Models;

namespace RecipeWebsiteRazorPages.Pages
{
    public class ViewRecipeModel : PageModel
    {
        private readonly IOptions<AppsettingsValues> config;

        public ViewRecipeModel(IOptions<AppsettingsValues> config)
        {
            this.config = config;
        }

        public void OnGet()
        {
            var recipeInfo = new List<RecipeModel>();
            string conn = config.Value.ConnectionName;
            
            //string connString = ConfigurationManager.ConnectionStrings["ConnectionName"].ConnectionString;
            
            using (IDbConnection db = new SqlConnection(conn))
            {
                recipeInfo = db.Query<RecipeModel>("SELECT RecipeId, RecipeName, RecipePhoto FROM RecipeTable").ToList();
            }
            if (recipeInfo != null)
            {
                ViewData["recipeInfo"] = recipeInfo;
            }
        }
    }
}
