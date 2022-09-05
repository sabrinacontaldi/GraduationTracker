// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_CoursePlanner.Shared
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
using Blazor_CoursePlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sabrinacontaldi/Desktop/CoursePlanner/_Imports.razor"
using Blazor_CoursePlanner.Shared;

#line default
#line hidden
#nullable disable
    public partial class Subject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Shared/Subject.razor"
      

    //Properties
    public int ID { get; set; }
    public string Title { get; set; }
    public string CourseCode { get; set; }
    public string DistributionReq { get; set; }
    public string CompetencyReq { get; set; }
    public double Credits { get; set; }
    public string GradeL { get; set; }

    public double NGrade(string s)
    {
        double numGrade = 0;
        switch (s)
        {
            case "A":
                numGrade = 4.0;
                break;

            case "A-":
                numGrade = 11.0 / 3.0;
                break;

            case "B+":
                numGrade = 10.0 / 3.0;
                break;

            case "B":
                numGrade = 3.0;
                break;

            case "B-":
                numGrade = 8.0 / 3.0;
                break;

            case "C+":
                numGrade = 7.0 / 3.0;
                break;

            case "C":
                numGrade = 2.0;
                break;

            case "C-":
                numGrade = 5.0 / 3.0;
                break;

            case "D+":
                numGrade = 4.0 / 3.0;
                break;

            case "D":
                numGrade = 1.0;
                break;

            case "F":
                numGrade = 0;
                break;

            case "P":
                numGrade = -1;
                break;

            default:
                numGrade = 5;
                break;
        }
        return numGrade;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
