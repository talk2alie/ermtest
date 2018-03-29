using System;

namespace ErmTest.Models.Entities
{
    public class Grade
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int GradedAssessmentId { get; set; }

        public double EarnedPoints { get; set; }

        public DateTime? SubmissionDeadlineDate { get; set; }

        public string LateSubmissionAuthorizedBy { get; set; }

        public DateTime SubmissionDate { get; set; }

        public virtual GradedAssessment GradedAssessment { get; set; }

        public virtual Student Student { get; set; }
    }
}