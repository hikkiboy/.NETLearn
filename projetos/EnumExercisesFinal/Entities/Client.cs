using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercisesFinal.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirhDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birhDate)
        {
            Name = name;
            Email = email;
            BirhDate = birhDate;
        }
    }
}
