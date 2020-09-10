using System.Collections.Generic;

namespace QandA.Data
{
    public class User
    {
        public User()
        {
            Answers = new List<Answer>();
            Questions = new List<Question>();
        }
        public int Id { get; set; }
        public string Usrname { get; set; }
        public string Password { get; set; }
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }
    }
}