//using Blazor_CoursePlanner.Models;
// using System.Linq;
// using System;
// using CoursePlanner.Models;
// using System.Collections.Generic;

// namespace CoursePlanner.Data
// {
//   public static class DbInitializer
//   {
//     //Major[] Majors = new Major[]{new Major {}new Major{}}
//     public static void Initialize()
//     {
//       /*context.Database.EnsureCreated();

//       // Look for any Teams.
//       if (context.Teams.Any())
//       {
//         return;   // DB has been seeded
//       }

//       // create the league name and id
//       var Leagues = new League.Models.League[]
//       {
//         new League.Models.League{LeagueId="NFL",Name="National Football League"},
//       };

//       foreach (League.Models.League s in Leagues)
//       {
//         context.Leagues.Add(s);
//       }

//       // create the conference names and ids
//       var Conferences = new Conference[]
//       {
//         new Conference{ConferenceId="AFC",Name="American Football Conference"},
//         new Conference{ConferenceId="NFC",Name="National Football Conference"}
//       };

//       foreach (Conference c in Conferences)
//       {
//         context.Conferences.Add(c);
//       }*/

//       var Majors = new Major[]
//       {
//         new Major {
//         Title = "Computer Science",
//         Credits = 11.5,
//         Preface = "CSC",
//         Department = "Computer Science",
//         CoreCourses = new List<string>() {"CSC121", "CSC122", "CSC231", "CSC232", "CSC233", "CSC240", "CSC498"},
//         OtherRequiredCourses = new List<string>() {"MATH123/MATH223", "Allied Course"},
//         Num300400 = 4
//         }, 
//         new Major {
//         Title = "Actuarial Science",
//         Credits = 10,
//         Preface = "MATH/ECON",
//         Department = "Mathematics",
//         CoreCourses = new List<string>() {"MATH151", "MATH152", "ECON100"},
//         OtherRequiredCourses = new List<string>() {"MATH223/MATH247/MATH251/MATH270", "MATH331", "MATH332", "MATH441", 
//         "MATH442", "ECON294/ECON295", "MATH336/MATH341/MATH348/ECON385/ECON393/ECON450"},
//         Num300400 = 5
//         },
//         new Major {
//         Title = "Mathematics",
//         Credits = 10,
//         Preface = "MATH",
//         Department = "Mathematics",
//         CoreCourses = new List<string>() {"MATH151", "MATH152", "MATH223", "MATH251", "MATH270", "MATH495"},
//         OtherRequiredCourses = new List<string>() {},
//         Num300400 = 5 //INCLUDING MATH495
//         },
//         new Major {
//         Title = "Film Studies",
//         Credits = 9.25,
//         Preface = "FILM",
//         Department = "Film Studies",
//         CoreCourses = new List<string>() {"FILM100/ENG167", "FILM200/COMM237", "FILM429", "FILM430"},
//         OtherRequiredCourses = new List<string>() {},
//         Num300400 = 4 //INCLUDING FILM429
//         }
//       };
//     }
//   }
// }