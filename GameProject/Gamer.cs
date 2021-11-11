using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer:GamerManager
    {
        public int GamerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string BirthDate { get; set; }
    }
}
