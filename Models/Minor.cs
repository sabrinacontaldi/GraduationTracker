using System.Collections.Generic;

namespace CoursePlanner.Models
{
    public class Minor
    {
        public string Title { get; set; }
        public double Credits { get; set; }
        public string Preface{ get; set; }
        public string Department{ get; set; }
        public List<string> CoreCourses { get; set; }
        public List<string> OtherRequiredCourses { get; set; }
        public int Num300400 { get; set; }
    }
}