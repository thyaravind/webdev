using System;
namespace ASP_API.Models
{
    public class Quiz
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string OwnerID { get; internal set; }
    }
}
