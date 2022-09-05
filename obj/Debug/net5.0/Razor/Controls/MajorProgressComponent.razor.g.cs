#pragma checksum "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bea48dde728c4926d3a1d9169cbb8e8a8519b703"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_CoursePlanner.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using CoursePlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using CoursePlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Blazor_CoursePlanner.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Blazor_CoursePlanner.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Blazor_CoursePlanner.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Microsoft.EntityFrameworkCore.SqlServer;

#line default
#line hidden
#nullable disable
    public partial class MajorProgressComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
 if(CourseP.DegreeType == "Bachelor of Arts")
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3>Major Progess Report</h3>\n    ");
            __builder.OpenElement(1, "p");
#nullable restore
#line 5 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
         foreach(var m in CourseP.MajorChoices)
        {
            if(m.Title.Equals("-"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>Select a Major for more information!</p>");
#nullable restore
#line 10 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, 
#nullable restore
#line 13 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
                    m.Info

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n                ");
            __builder.AddMarkupContent(6, "<p>OUTSTANDING REQUIREMENTS:</p>\n                ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Credits: ");
            __builder.AddContent(9, 
#nullable restore
#line 15 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
                             m.Credits

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, "Core Courses: ");
            __builder.AddContent(13, 
#nullable restore
#line 16 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
                                  m.CoreCoursesLeft

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "Required Courses: ");
            __builder.AddContent(17, 
#nullable restore
#line 17 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
                                      m.ReqCoursesLeft

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Number of 300 and 400: ");
            __builder.AddContent(21, 
#nullable restore
#line 18 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
                                           m.Num300400

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<hr>");
#nullable restore
#line 21 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 23 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Controls/MajorProgressComponent.razor"
      
    [CascadingParameter(Name="CourseP")]
    public CoursePlan CourseP { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
