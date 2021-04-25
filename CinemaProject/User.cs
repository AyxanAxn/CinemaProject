using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject
{
    public class User
    {
        public int Id { get; set; }
        private static int _staticId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
        public User()
        {
            Id = ++_staticId;
        }
        public override string ToString()
        {
            return $"\nId- {Id}\nEmail- {Email}\nPassword- {Password}";
        }
    }
}
