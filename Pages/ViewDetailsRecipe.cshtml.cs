using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using RecipeWebsiteRazorPages.Models;

namespace RecipeWebsiteRazorPages.Pages
{
    public class ViewDetailsRecipeModel : PageModel
    {
        private readonly IOptions<AppsettingsValues> config;
        private IWebHostEnvironment Environment;
        public ViewDetailsRecipeModel(IOptions<AppsettingsValues> config, IWebHostEnvironment _enviroment)
        {
            this.config = config;
            Environment = _enviroment;
        }
        [BindProperty(SupportsGet = true)]
        public RecipeModel Recipe { get; set; }
        public void OnGet(int id)
        {
            string conn = config.Value.ConnectionName;
            string query = $"SELECT RecipeId, RecipeName, RecipeIngredients, RecipeDescription, RecipePhoto FROM RecipeTable WHERE RecipeId='{id}'";
            using (IDbConnection db = new SqlConnection(conn))
            {
                Recipe = db.QuerySingle<RecipeModel>(query);
            }
            if (Recipe != null)
            {
                using (var memoryStream = new MemoryStream(Recipe.RecipePhoto))
                {
                    var imageBytes = memoryStream.ToArray();
                    var imageMemoryStream = new MemoryStream(imageBytes);
                    Image imageRecipe = Image.FromStream(imageMemoryStream);
                    string wwwRootPath = this.Environment.WebRootPath;
                    string fileName = "recipePhoto.png";
                    string combinedPathString = wwwRootPath + @"\Images\UserImages\" + fileName;

                    DirectoryInfo di = new DirectoryInfo(wwwRootPath + @"\Images\UserImages\");
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }

                    imageRecipe.Save(combinedPathString, System.Drawing.Imaging.ImageFormat.Png);
                }

            }
            
        }
        
    }
    
}
