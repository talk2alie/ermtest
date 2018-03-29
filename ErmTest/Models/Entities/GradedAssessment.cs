using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class GradedAssessment : Assessment
    {
        public double PercentageWeightOnFinalGrade { get; set; }

        public double PercentageCostForLateSubmission { get; set; }

        public int PossiblePoints { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }

        public GradedAssessment()
        {
            Grades = new HashSet<Grade>();
        }
    }
}