using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace QandA.Data
{
    public class Question
    {
        public Question()
        {
         Answers =new List<Answer>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public User User { get; set; }
        public List<Answer>Answers { get; set; }

    }
}