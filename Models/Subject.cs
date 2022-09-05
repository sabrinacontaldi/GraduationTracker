using System.ComponentModel.DataAnnotations;

namespace CoursePlanner.Models
{
    public class Subject
    {   
        public int ID { get; set; }
        public string Title { get; set; }
        public string CourseCode { get; set; }
        public string DistributionReq { get; set; }
        public string CompetencyReq { get; set; }
        
        [Range(1, 5)]
        public double Credits { get; set; }
        public string GradeL { get; set; }
        public double GradeN {get; set; }

        public double NGrade(string GradeL)
        {
            double numGrade = 0;
            switch (GradeL)
            {
                case "A":
                    numGrade = 4.0;
                    break;

                case "A-":
                    numGrade = 3.67;
                    break;

                case "B+":
                    numGrade = 3.33;
                    break;

                case "B":
                    numGrade = 3.0;
                    break;

                case "B-":
                    numGrade = 2.67;
                    break;

                case "C+":
                    numGrade = 2.33;
                    break;

                case "C":
                    numGrade = 2.0;
                    break;

                case "C-":
                    numGrade = 1.67;
                    break;

                case "D+":
                    numGrade = 1.33;
                    break;

                case "D":
                    numGrade = 1.0;
                    break;
                
                case "D-":
                    numGrade = 0.67;
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
    }
}