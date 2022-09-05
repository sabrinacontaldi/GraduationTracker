using System.Collections.Generic;
using CoursePlanner.Models;

namespace CoursePlanner.Models
{
    public static class CLA
    {
        //public ICollection<Major> Majors { get; set; }
        public static readonly Major[] Majors = new Major[]
        {
            new Major {
                Title = "Actuarial Science",
                Credits = 10,
                Preface = "MATH/ECON",
                Department = "Mathematics",
                CoreCourses = new List<string>() {"MATH151", "MATH152", "ECON100"},
                OtherRequiredCourses = new List<string>() {"MATH223/MATH247/MATH251/MATH270", "MATH331", "MATH332", "MATH441", 
                "MATH442", "ECON294/ECON295", "MATH336/MATH341/MATH348/ECON385/ECON393/ECON450"},
                Num300400 = 5
            },
            new Major {
                Title = "Computer Science",
                Credits = 11.5,
                Preface = "CSC",
                Department = "Computer Science",
                CoreCourses = new List<string>() {"CSC121", "CSC122", "CSC231", "CSC232", "CSC233", "CSC240", "CSC498"},
                OtherRequiredCourses = new List<string>() {"MATH123|MATH223", "Allied Course"},
                Num300400 = 4
            },
            new Major {
                Title = "Film Studies",
                Credits = 9.25,
                Preface = "FILM",
                Department = "Film Studies",
                CoreCourses = new List<string>() {"FILM100/ENG167", "FILM200/COMM237", "FILM429", "FILM430"},
                OtherRequiredCourses = new List<string>() {},
                Num300400 = 4 //INCLUDING FILM429
            }, 
            new Major {
                Title = "Mathematics",
                Credits = 10,
                Preface = "MATH",
                Department = "Mathematics",
                CoreCourses = new List<string>() {"MATH151", "MATH152", "MATH223", "MATH251", "MATH270", "MATH495"},
                OtherRequiredCourses = new List<string>() {},
                Num300400 = 5 //INCLUDING MATH495
            }
            // new Major {
            //     Title = "Italian",
            //     //Credits = 10,
            //     Preface = "ITAL",
            //     Department = "Italian",
            //     CoreCourses = new List<string>() {"MATH151", "MATH152", "MATH223", "MATH251", "MATH270", "MATH495"},
            //     OtherRequiredCourses = new List<string>() {},
            //     Num300400 = 5 //INCLUDING MATH495
            //}
        };

        public static string[] MajorTitles = new string[]
        {
            "Actuarial Science", "Computer Science", "Film Studies", "Mathematics"
            
        };

        public static readonly Minor[] Minors = new Minor[]
        {
            new Minor {
                Title = "Women's, Gender, and Sexuality Studies",
                Credits = 5,
                Preface = "WGSS",
                Department = "Women's, Gender, and Sexuality Studies",
                CoreCourses = new List<string>() {"WGSS140", "WGSS340"},
                OtherRequiredCourses = new List<string>() {"WGSS250/WGSS260/WGSS262", 
                "WGSS342/WGSS362/WGSS355/WGSS332"},
                Num300400 = 2
            },
            new Minor {
                Title = "Data Science",
                Credits = 5,
                Preface = "CSC/MATH",
                Department = "Mathematics",
                CoreCourses = new List<string>() {"CSC121", "CSC122", "MATH141/PSY214/ECON350/BIO375", 
                "MATH261/CSC370", "MATH341/ECON385/ECON450"},
                OtherRequiredCourses = new List<string>() {},
                Num300400 = 1
            },
            new Minor {
                Title = "Mathematics",
                Credits = 5,
                Preface = "MATH",
                Department = "Mathematics",
                CoreCourses = new List<string>() {"MATH151", "MATH152", "MATH223", 
                "MATH270"},
                OtherRequiredCourses = new List<string>() {},
                Num300400 = 1
            }
        };

    }
}