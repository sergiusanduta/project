using System;

namespace QandA.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public int QuestionId { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public Question Question { get; set; }
    }
}