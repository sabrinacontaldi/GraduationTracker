// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.Net.Http;
// using System.IO;
// using HtmlAgilityPack;
// using ScrapySharp.Extensions;
// using ScrapySharp.Network;

// namespace CoursePlanner.Data
// {
//     public class ScrapperService
//     {
//         public List<string> Majors { get; set; }
//         public List<string> Minors { get; set; }

//         public ScrapperService()
//         {
//             Majors = new List<string>();
//             Minors = new List<string>();

//             DoScrapping();
//         }

//         public async void DoScrapping()
//         {   
//             List<string> MajorList = new List<string>();

//             HttpClient hc = new HttpClient();
//             HttpResponseMessage result = await hc.GetAsync($"https://www.depauw.edu/academics/");
//             Stream stream = await result.Content.ReadAsStreamAsync();
//             HtmlDocument doc = new HtmlDocument();
//             doc.Load(stream);

//             var MajorNames = doc.DocumentNode.SelectNodes("//*[@id=\"majors\"]/ul/li");
           
//             foreach(var major in MajorNames)
//             {
//                 MajorList.Add(major.InnerText.Replace("&nbsp;", ""));
//             }
            
//             Majors = MajorList;
//         }
//     }
// }