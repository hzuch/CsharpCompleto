using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise123.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name)
        {
            Name = name;
        }

        public Client(string name, string email) : this(name)
        {
            Email = email;
        }

        public Client(string name, string email, DateTime birthDate) : this(name, email)
        {
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Client name: {Name}, email: {Email}, birth date: {BirthDate}";
        }
    }
}
