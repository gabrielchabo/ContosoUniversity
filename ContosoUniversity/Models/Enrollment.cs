using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //? indicates that the Grade property is nullable
        public Grade? Grade { get; set; }

        public virtual Course course { get; set; }
        public virtual Student student { get; set; }
    }
}