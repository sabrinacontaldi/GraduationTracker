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
    public partial class Semester : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Shared/Semester.razor"
      
    public string Title { get; set; }
        public int Num { get; set; } 
        //num is the semester number ie. freshman year fall = 1, sophmore fall = 3
        public List<Subject> Courses;

        public int SemCreditsP { get; set; }
        public double SemCredits { get; set; }
        public double SemGradePoints{ get; set; }
        public double SemGPA{ get; set; }

        void Display()
        {
            SemCredits = 0;
            SemGradePoints = 0;
            SemGPA = 0;
            foreach( var c in Courses )
            {
                if(c.NGrade(c.GradeL) >= 0)
                {
                    SemGradePoints += Math.Round(c.NGrade(c.GradeL)*c.Credits, 2, MidpointRounding.ToZero);
                }
                
                if((c.GradeL == "P") || (c.GradeL == "-"))
                {
                    SemCreditsP++;
                }
                SemCredits += c.Credits;
            }

            SemGPA = Math.Round(SemGradePoints/(SemCredits-SemCreditsP), 2, MidpointRounding.ToZero);
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
