using System.Collections.Generic;

namespace QuestionBase.Domain.Entities
{
    public class Team
    {
        public Team()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
