using System;

namespace QuestionBase.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Answer { get; set; }
        public DateTime DateAdded { get; set; }
        public User Author { get; set; }
        public bool IsModified { get; set; }
        public DateTime LastModified { get; set; }
        public User LastModifiedBy { get; set; }
    }
}
