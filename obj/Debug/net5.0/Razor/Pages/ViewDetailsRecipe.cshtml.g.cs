#pragma checksum "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea02ceea6975e3eb0ba6b27697287197bb730da4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ViewDetailsRecipe), @"mvc.1.0.razor-page", @"/Pages/ViewDetailsRecipe.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea02ceea6975e3eb0ba6b27697287197bb730da4", @"/Pages/ViewDetailsRecipe.cshtml")]
    public class Pages_ViewDetailsRecipe : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea02ceea6975e3eb0ba6b27697287197bb730da43993", async() => {
                WriteLiteral("\r\n    <title>View Recipes</title>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea02ceea6975e3eb0ba6b27697287197bb730da44408", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea02ceea6975e3eb0ba6b27697287197bb730da45586", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea02ceea6975e3eb0ba6b27697287197bb730da47468", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand navbar-dark bg-dark"">
        <a href=""/Index"" class=""navbar-brand"">Home</a>
        <div class=""collapse navbar-collapse"">
            <ul class=""navbar-nav mr-lg-auto"">
                <li class=""nav-item"">
                    <a href=""/AddRecipe"">Add Recipe</a>
                </li>
                <li class=""nav-item"">
                    <a href=""/ViewRecipe"">View Recipe</a>
                </li>
            </ul>
        </div>
    </nav>
    <br /><br />
");
#nullable restore
#line 28 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
      
        var recipe = ViewData["recipeInfo"] as RecipeWebsiteRazorPages.Models.RecipeModel;
        if (recipe == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>model empty</p>\r\n");
#nullable restore
#line 33 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-1\">\r\n\r\n                    </div>\r\n                    <div class=\"col-sm-5\">\r\n                        <h1>");
#nullable restore
#line 42 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
                       Write(recipe.RecipeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                        <br />\r\n                        <br />\r\n                        <div class=\"form-group\">\r\n                            <label class=\"textarea\">Recipe Ingredients</label>\r\n                            <p>");
#nullable restore
#line 47 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
                          Write(recipe.RecipeIngredients);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""</p>
                        </div>
                        <br />
                        <br />

                        <div class=""form-group"">
                            <label class=""textarea"">Recipe Description</label>
                            <p>");
#nullable restore
#line 54 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
                          Write(recipe.RecipeDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"</p>\r\n                        </div>\r\n                        <br />\r\n\r\n\r\n                    </div>\r\n                    <div class=\"col-sm-1\">\r\n\r\n                    </div>\r\n                    <div class=\"col-sm-5\">\r\n                        <br />\r\n");
#nullable restore
#line 65 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
                          
                            var base64 = Convert.ToBase64String(recipe.RecipePhoto);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 2445, "\"", 2458, 1);
#nullable restore
#line 68 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
WriteAttributeValue("", 2451, imgsrc, 2451, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"400\" width=\"400\" />\r\n");
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 73 "D:\Visual Studio Projects\RecipeWebsiteRazorPages\RecipeWebsiteRazorPages\Pages\ViewDetailsRecipe.cshtml"
        }
    
                            
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeWebsiteRazorPages.Pages.ViewDetailsRecipeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeWebsiteRazorPages.Pages.ViewDetailsRecipeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipeWebsiteRazorPages.Pages.ViewDetailsRecipeModel>)PageContext?.ViewData;
        public RecipeWebsiteRazorPages.Pages.ViewDetailsRecipeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
