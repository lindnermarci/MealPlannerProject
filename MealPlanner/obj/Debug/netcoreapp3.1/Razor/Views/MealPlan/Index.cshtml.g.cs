#pragma checksum "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc12edc4d8fc432c591362eca84f0d81e74bb3e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MealPlan_Index), @"mvc.1.0.view", @"/Views/MealPlan/Index.cshtml")]
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
#nullable restore
#line 1 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\_ViewImports.cshtml"
using MealPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\_ViewImports.cshtml"
using MealPlanner.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\_ViewImports.cshtml"
using MealPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc12edc4d8fc432c591362eca84f0d81e74bb3e8", @"/Views/MealPlan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a6f10f5dedc7b4c71038e30109121ab94232fbe", @"/Views/_ViewImports.cshtml")]
    public class Views_MealPlan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MealPlanViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MealPlan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromMealPlan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClearMealPlan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Your mealPlan</h2>\r\n\r\n\r\n<div>\r\n    <table class=\"table table-striped table-bordered table-dark\">\r\n        <tbody>\r\n            <tr>\r\n                <td>Metabolic Data</td>\r\n                <td colspan=\"2\">TDEE: ");
#nullable restore
#line 11 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                 Write(Model.TDEE);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kcal </td>\r\n            </tr>\r\n            <tr>\r\n                <td>This Meal Plan</td>\r\n                <td colspan=\"2\">");
#nullable restore
#line 15 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                           Write(Model.DailyCalorieAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kcal</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Macros</td>\r\n                <td colspan=\"2\">Pro:");
#nullable restore
#line 19 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                               Write(Model.ProteinAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" g&nbsp;&nbsp;Carb::");
#nullable restore
#line 19 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                                                       Write(Model.CarbsAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" g&nbsp;&nbsp;Fat: ");
#nullable restore
#line 19 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                                                                                            Write(Model.FatAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" g</td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <td></td>\r\n                <td colspan=\"2\">Pro:");
#nullable restore
#line 24 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                               Write(Model.ProteinPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %&nbsp;&nbsp;Carb: ");
#nullable restore
#line 24 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                                                        Write(Model.CarbsPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %&nbsp;&nbsp;Fat: ");
#nullable restore
#line 24 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                                                                                              Write(Model.FatPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
#nullable restore
#line 31 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
 for (int i = 0; i < 7; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 colspan=\"3\" class=\"text-center\">");
#nullable restore
#line 33 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                    Write((DayOfWeek)i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral(@"    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Selected amount</th>
                <th>Meal</th>
                <th class=""text-right"">Subtotal</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
             foreach (var line in Model.MealPlan.MealPlanItems.Where(x => x.DayOfWeek == (DayOfWeek)i))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 49 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                       Write(line.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 50 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                     Write(line.Meal.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">\r\n                        ");
#nullable restore
#line 52 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                    Write((line.Amount * line.Meal.Calories).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"addToPlan\">\r\n                            <p class=\"button\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc12edc4d8fc432c591362eca84f0d81e74bb3e810455", async() => {
                WriteLiteral("Remove from plan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-dayOfWeek", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                            WriteLiteral(line.DayOfWeek);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dayOfWeek"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dayOfWeek", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dayOfWeek"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
                                         WriteLiteral(line.Meal.MealId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mealId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mealId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mealId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total calories:</td>\r\n                <td class=\"text-right\">\r\n                    ");
#nullable restore
#line 73 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"
               Write(Model.TotalCalories.ElementAt(i).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
#nullable restore
#line 78 "F:\documents\2019-20-01\projektmunka\MealPlanner3\MealPlannerProject\MealPlanner\Views\MealPlan\Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"addToPlan\">\r\n    <p class=\"button\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc12edc4d8fc432c591362eca84f0d81e74bb3e814957", async() => {
                WriteLiteral("Remove all from plan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MealPlanViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
