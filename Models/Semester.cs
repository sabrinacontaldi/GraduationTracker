using System;
using System.Collections.Generic;

namespace CoursePlanner.Models
{
    public class Semester
    {
        public string Title { get; set; }
        public int Num { get; set; }
        //num is the semester number ie. freshman year fall = 1, sophmore fall = 3
        public List<Subject> Courses { get; set; }
        public int SemCreditsP { get; set; }
        public double SemCredits { get; set; }
        public double SemGradePoints { get; set; }
        public double SemGPA { get; set; }
        public int SemType { get; set; }

        public Subject mayT { get; set; }
        
        public Semester()
        {
            Title = "";
            SemType = 1;
            Courses = new List<Subject>{
                new Subject {},
                new Subject {},
                new Subject {},
                new Subject {} 
            };
        }

        // void Display()
        // {
        //     SemCredits = 0;
        //     SemGradePoints = 0;
        //     SemGPA = 0;
        //     foreach (var c in Courses)
        //     {
        //         if (c.GradeN >= 0)
        //         {
        //             SemGradePoints += Math.Round(c.GradeN * c.Credits, 2, MidpointRounding.ToZero);
        //         }

        //         if ((c.GradeL == "P") || (c.GradeL == "-"))
        //         {
        //             SemCreditsP++;
        //         }
        //         SemCredits += c.Credits;
        //     }

        //     SemGPA = Math.Round(SemGradePoints / (SemCredits - SemCreditsP), 2, MidpointRounding.ToZero);
        // }
    }
}