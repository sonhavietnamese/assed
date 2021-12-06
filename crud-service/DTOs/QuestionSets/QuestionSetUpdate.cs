using System.ComponentModel.DataAnnotations;

namespace Assed.Models
{
    public class QuestionSetUpdate
    {
        [Key]
        public string QuestionSetId { get; set; }
        public string TeacherId { get; set; }
        public string QuestionSetName { get; set; }
        public string QuestionSetDay { get; set; }
        public int QuestionSetNumberOfQuestion { get; set; }
        public int QuestionSetStudentJoined { get; set; }
        public int QuestionSetTime { get; set; }
    }
}