using System;
namespace ASP_API.Models
{
    public class Question
    {
        public int id { get; set; }
        public int quizID { get; set; }
        public string text { get; set; }
        public string correctAnswer { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
    }
}
