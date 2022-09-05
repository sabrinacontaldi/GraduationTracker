using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoursePlanner.Models
{
    public class CoursePlan
    {
        public string DegreeType { get; set;}
        /*Degree types:
            College of Liberal 
                - Bachelor of Arts
            School of Music 
                - Bachelor of Music
                    - Performance
                    - Performance with a Second Major
                    - Performance with an Emphasis in Business
                    - 5 year Bachelor of Music/Bachelor of Arts Double Degree Program (B.M/B.A)
                - Bachelor of Music Education
                    - Choral/General Music Emphasis
                    - Instrumental/General Music Emphasis
                - Bachelor of Musical Arts (B.M.A)
        */

        //CREDITS
        public double TotalCredits { get; set; } //total required credits
        public double TCredits { get; set; } //total completed credits
        public double PCredits { get; set; } //credits completed P/F

        //GPA
        public double TGradePoints { get; set; }
        public double TGPA { get; set; }
        public string GradStatus { get; set; } //Graduating/Graduating with honors - calculated with GPA only

        //DISTRIBUTION REQUIREMENTS
        public string DistribuReq { get; private set; } //Whether or not Distribution requirements are complete - could be t/f
        public string DistribuReqInfo { get; private set; } //Information about Distribution Requirements that still need to be complete

        //COMPETENCY REQUIREMENTS
        public string CompReq { get; private set; } //Whether or not Competency requirements are complete - could be t/f
        public string CompReqInfo { get; private set; } //Information about Competency Requirements that still need to be complete
        
        public List<Semester> SemList { get; set; } //Semesters List
        public List<MajorInfo> MajorChoices { get; set; } //MAJORS
        public List<MinorInfo> MinorChoices { get; set; } //MINORS

        //Constructor
        public CoursePlan()
        {
            DegreeType = "Bachelor of Arts";
            TotalCredits = 0;
            MajorChoices = new List<MajorInfo>{
                new MajorInfo { Title = "-"} };
            MinorChoices = new List<MinorInfo>{
                new MinorInfo { Title = "-"} };
            SemList = new List<Semester>{ 
                new Semester {
                    SemType = 1,
                    Courses = new List<Subject>
                    {
                        new Subject {},
                        new Subject {},
                        new Subject {},
                        new Subject {}
                    }
                }
            };
        }

        public void GradRequirements() //problem
        {
            if(DegreeType == "Bachelor of Arts")
            {
                TotalCredits = 31;
            }
            else if(DegreeType == "Bachelor of Music/Bachelor of Arts Double Degree")
            {
                TotalCredits = 43;
            }
            else
            {
                TotalCredits = 36;
            }

            //Total of 31 credits
            Credits();
            //GPA has to be over 2
            GPA();
            //Total of 31 credits
            //Distribution Requirements
            DistributionRequirements();
            //Competency Requirements
            CompetencyRequirements();
            //Graduating with honors?
            Grad();
            //MajorMethod();
            MajorProgress();
        }
        
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
                    if (c.NGrade(c.GradeL) < 5)
                        totCredits += c.Credits;

                    if (c.NGrade(c.GradeL) < 0)
                        PCredits++;
                }
            }
            TCredits = totCredits;
        }

        //GPA and GradePoints
        public void GPA()
        {
            double semGP = 0;
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
            double g = TGradePoints / (TCredits - PCredits);
            TGPA = Math.Round((g), 2, MidpointRounding.ToZero);
        }

        //Graduationg with Honors
        public void Grad()
        {   
            if(DegreeType == "Bachelor of Arts")
            {
                if (TGPA > 3.8)
                    GradStatus = "Graduating Summa Cum Laude";
                else if (TGPA > 3.7)
                    GradStatus = "Graduating Magna Cum Laude";
                else if (TGPA > 3.5)
                    GradStatus = "Graduating Cum Laude";
                else if (TGPA > 2.0)
                    GradStatus = "Graduating";
                else
                    GradStatus = "Not Graduating";
            }
            else
            {
                if (TGPA > 3.9)
                    GradStatus = "Graduating Summa Cum Laude";
                else if (TGPA > 3.8)
                    GradStatus = "Graduating Magna Cum Laude";
                else if (TGPA > 3.7)
                    GradStatus = "Graduating Cum Laude";
                else if (TGPA > 2.0)
                    GradStatus = "Graduating";
                else
                    GradStatus = "Not Graduating";
                
                if (TGPA < 2.8 && (DegreeType == "Bachelor of Music Education" || DegreeType == "Bachelor of Music/Bachelor of Arts Double Degree"))
                    GradStatus = "Not Graduating";
                                
            }
        }

        //Competency Requirements
        public void CompetencyRequirements()
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
                    if (c.CompetencyReq == "Q")
                        q = true;
                    if (c.CompetencyReq == "W" && SemList.IndexOf(sem) > 1)
                        w = true;
                    if (c.CompetencyReq == "S")
                        s = true;
                }
            }

            if(DegreeType == "Bachelor of Arts" || DegreeType == "Bachelor of Music/Bachelor of Arts Double Degree")
            {
                if (q && w && s)
                    CompReq = "Complete";
                else
                {
                    CompReq = "Incomplete";
                    if (!q)
                        CompReqInfo += "Q Requirement Incomplete ";
                    if (!w)
                        CompReqInfo += "W Requirement Incomplete ";
                    if (!s)
                        CompReqInfo += "S Requirement Incomplete";
                }
            }
            else
            {
                if (w && s)
                    CompReq = "Complete";
                else
                {
                    CompReq = "Incomplete";
                    if (!w)
                        CompReqInfo += "W Requirement Incomplete ";
                    if (!s)
                        CompReqInfo += "S Requirement Incomplete";
                }                
            }
        }

        //distribution Requirements
        public void DistributionRequirements()
        {
            //How will we do extended studies? Have you completed a may or winter term? / semester abroad
            //2xAH, 2xSS, 2xSM, 2XLA, 2xES, PPD
            int ah = 0, ss = 0, sm = 0, la = 0, es = 0, ppd = 0, gl = 0;
            string pAH = "", pSS = "", pSM = "", pLA = "";

            foreach (Semester sem in SemList)
            {   
                if(sem.SemType != 1)
                {
                    es++;
                }

                foreach (var sub in sem.Courses)
                {
                    switch (sub.DistributionReq)
                    {
                        case "AH":
                            //check to see if pAH is empty      or  not equal to previous AH code   
                            if ((String.IsNullOrEmpty(pAH)) || (pAH != GetPrefix(sub.CourseCode)))
                            {
                                ah++;
                                pAH = sub.CourseCode.Substring(0, 3);
                            }
                            break;

                        case "SS":
                            if ((String.IsNullOrEmpty(pSS)) || (pSS != GetPrefix(sub.CourseCode)))
                            {
                                ss++;
                                pSS = GetPrefix(sub.CourseCode);
                            }
                            break;

                        case "SM":
                            if ((String.IsNullOrEmpty(pSM)) || (pSM != GetPrefix(sub.CourseCode)))
                            {
                                sm++;
                                pSM = GetPrefix(sub.CourseCode);
                            }
                            break;

                        case "LA":
                            if ((String.IsNullOrEmpty(pLA)) || (pLA != GetPrefix(sub.CourseCode)))
                            {
                                la++;
                                pLA = GetPrefix(sub.CourseCode);
                            }
                            break;

                        case "PPD":
                            ppd++;
                            break;
                        
                        case "GL":
                            gl++;
                            break;

                        default:
                            break;
                    }
                }
            }
            if (DegreeType == "Bachelor of Arts" || DegreeType == "Bachelor of Music/Bachelor of Arts Double Degree")
            {
                if ((ah > 1) && (ss > 1) && (sm > 1) && (ppd > 0) && (la > 1) && (es > 1) && (gl > 0))
                {
                    DistribuReq = "Complete";
                    DistribuReqInfo = "Distribution Requirements Complete";
                }
                else
                {
                    DistribuReq = "Incomplete";
                    DistribuReqInfo = $"Distribution Requirements: AH({ah}/2) \nSS({ss}/2) \nSM({sm}/2) \nLA({la}/2) \nES({es}/2) \nPPD({ppd}/1) \nGL({gl}/1) ";
                    
                }
            }
            else
            {
               if (es > 1)
                {
                    DistribuReq = "Complete";
                    DistribuReqInfo = "Distribution Requirements Complete";
                }
                else
                {
                    DistribuReq = "Incomplete";
                    DistribuReqInfo = $"Distribution Requirements: ES({es}/2)";
                    
                } 
            }
        }
        
        //Methods used for Majors
        public void MajorProgress()
        {
            List<Subject> completedCourses = new List<Subject>(); //list for all of the completed courses
            foreach (var sem in SemList)
            {
                foreach (var c in sem.Courses)
                {
                    if (!String.IsNullOrEmpty(c.CourseCode))
                        completedCourses.Add(c);
                }
            }

            foreach(var m in MajorChoices)
            {
                if(m.Title == "")
                {
                    m.Info = "Select a Major for more information!"; //no m.Info variable
                    return;
                }
                else
                {
                    foreach(var maj in CLA.Majors)
                    {
                        if(m.Title == maj.Title)
                        {
                            m.Info = $"Your selected Major is {maj.Title}! "; //MAJOR INFORMATION
                            m.Credits = maj.Credits; //Credits
                            m.Num300400 = maj.Num300400; //Number of 300 and 400 level courses
                            
                            //Number of 300 and 400 level Courses
                            if(maj.Num300400 != 0 )
                            {
                                string three = maj.Preface + "3";
                                string four = maj.Preface + "4";
                                foreach(var course in completedCourses) 
                                {
                                    if(course.CourseCode.Contains(three) || course.CourseCode.Contains(four))
                                    {
                                        m.Num300400--;
                                        m.Credits -= course.Credits;
                                    }
                                }
                            }
                                if(m.Num300400 < 0)
                                {
                                    m.Num300400 = 0;
                                }

                            //CORE COURSES
                            m.CoreCourses = new List<string>(); //Core courses list
                            List<string> copy = new List<string>();
                            foreach(var c in maj.CoreCourses)
                            {
                                m.CoreCourses.Add(c);
                                copy.Add(c);
                            }
                                if(copy.Count != 0 )
                                {
                                    foreach(var course in completedCourses) 
                                    {
                                        for(int x = 0; x < m.CoreCourses.Count; x++)
                                        {
                                            if(m.CoreCourses[x].Contains(course.CourseCode))
                                            {
                                                // string item = m.CoreCourses[x];
                                                copy.Remove(m.CoreCourses[x]);
                                                m.Credits -= course.Credits;
                                            }
                                        }
                                    }
                                }    
                                        if(copy.Count > 0)
                                        {
                                            m.CoreCoursesLeft = "";
                                            foreach( var core in copy)
                                            {
                                                m.CoreCoursesLeft += core + ", ";
                                            }
                                        }
                                        else
                                        {
                                            m.CoreCoursesLeft = "Core Courses Complete.";
                                        }
                                
                            
                            //REQUIRED COURSES
                            m.ReqCourses = new List<string>(); //Required courses list
                            copy = new List<string>();
                            foreach(var c in maj.OtherRequiredCourses)
                            {
                                m.ReqCourses.Add(c);
                                copy.Add(c);
                            }
                                if(copy.Count != 0 )
                                {
                                    foreach(var course in completedCourses) 
                                    {
                                        for(int x = 0; x < m.ReqCourses.Count; x++)
                                        {
                                            if(m.ReqCourses[x].Contains(course.CourseCode))
                                            {
                                                //string item = m.ReqCourses[x];
                                                copy.Remove(m.ReqCourses[x]);
                                                m.Credits -= course.Credits;
                                            }
                                            
                                        }
                                    }
                                }
                                    if(copy.Count > 0)
                                    {
                                        m.ReqCoursesLeft = "";
                                        foreach( var req in copy)
                                        {
                                            m.ReqCoursesLeft += req + ", ";
                                        }
                                    }
                                    else
                                    {
                                        m.ReqCoursesLeft = "Complete";
                                    }
                        }
                    }
                }
            }
        }//WHY DO CREDITS KEEP REFRESHING
        
        //Methods used for Calculations
        public string GetPrefix(string courseCode)
        {
            string prefix = "";

            //check where the first number is
            int index = courseCode.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ' });
            prefix = courseCode.Substring(0, index-1).ToUpper();
            
            return prefix;
        }

        public string GetCourseNumber(string courseCode)
        {
            string suffix = "";

            //check where the first number is
            int index = courseCode.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ' });
            suffix = courseCode.Substring(index+1, courseCode.Length);
            
            return suffix;
        }

        // public string FormatCourseCode(string courseCode)
        // {   
        //     if(courseCode.Contains(" "))
        //     {
        //         string newCourseCode = GetPrefix(courseCode) + GetCourseNumber(courseCode);
        //         int index = courseCode.IndexOf(" ");
        //         courseCode = courseCode.Remove(index, 1);
        //     }
            
        //     return courseCode;
        // }

    }
}