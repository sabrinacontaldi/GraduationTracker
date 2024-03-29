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
    public partial class CoursePlan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "/Users/sabrinacontaldi/Desktop/CoursePlanner/Shared/CoursePlan.razor"
       
    
    public double TCredits { get; set;}
    public double PCredits { get; set; } 
    public double TGradePoints { get; set; }
    public double TGPA{ get; set; }
    public string GradStatus{ get; set; }
    public string DistribuReq { get; private set; }
    public string DistribuReqInfo { get; private set; }
    public string CompReq{ get; private set; }
    public string CompReqInfo{ get; private set; }

    //Semesters List
    public List<Semester> SemList;

    //Graduation Requirement methods
    //Credits complete
    public void Credits()
    {
        double totCredits = 0;
        TCredits = 0;
        PCredits = 0;
        
        foreach (var sem in SemList)
        {
            foreach (var c in sem.Courses)
            {
                if(c.NGrade(c.GradeL) < 5)
                    totCredits+= c.Credits;

                if(c.NGrade(c.GradeL) < 0)
                    PCredits++;
            }
        }
        TCredits = totCredits;
    }

    //GPA and GradePoints
    public void GPA()
    {   TGPA = 0;

        double semGP = 0;
        TGradePoints = 0;
        foreach (var sem in SemList)
        {
            foreach (var c in sem.Courses)
            {
                if (c.NGrade(c.GradeL) >= 0 && c.NGrade(c.GradeL) < 5)
                {
                    semGP += c.NGrade(c.GradeL) * c.Credits;
                }
            }
        }
        TGradePoints = Math.Round(semGP, 2, MidpointRounding.ToZero);
        
        double g = TGradePoints/(TCredits-PCredits);
        TGPA = Math.Round((g), 2, MidpointRounding.ToZero);
    }

    //Graduationg with Honors
    public void Grad()
    {
        if(TGPA>3.8)
            GradStatus = "Graduating Summa Cum Laude";
        else if(TGPA>3.7)
            GradStatus = "Graduating Magna Cum Laude";
        else if(TGPA>3.5)
            GradStatus = "Graduating Cum Laude";
        else if(TGPA>2.0)
            GradStatus = "Graduating";
        else
            GradStatus = "Not Graduating";
    }

    //Competency Requirements
    public void Comp()
    {
        CompReq = "";
        CompReqInfo = "";
        bool q = false;
        bool w = false;
        bool s = false;

        foreach (var sem in SemList)
        {
            foreach (var c in sem.Courses)
            {
                if(c.CompetencyReq == "Q")
                    q = true;
                if(c.CompetencyReq == "W" && (sem == SemList[2] || sem == SemList[3]))
                    w = true;
                if(c.CompetencyReq == "S") 
                    s = true;              
            }
        }

        if( q && w && s )
            CompReq = "Complete";
        else{
            CompReq = "Incomplete";
            if(!q)
                CompReqInfo+= "Q Requirement Incomplete ";
            if(!w)
                CompReqInfo+= "W Requirement Incomplete ";
            if(!s)
                CompReqInfo+= "S Requirement Incomplete";
        }
    }

    //Distribution Requirements
    
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
