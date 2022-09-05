using System.Collections.Generic;

namespace CoursePlanner.Models
{
    public class MajorInfo
    {
        public string Title { get; set; }
        public double Credits { get; set; }
        public string Info{ get; set; }
        public string CoreCoursesLeft { get; set; }
        public List<string> CoreCourses { get; set; }
        public List<string> ReqCourses { get; set; }
        public string ReqCoursesLeft { get; set; }
        public int Num300400 { get; set; }
    }
    
}