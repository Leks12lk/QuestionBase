using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuestionBase.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; } 
    }
}
