using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_Assignment
{
    public class User
    {
        //chaining constructors:
        public User(string name) : this(name, 1)
        {
        }

        public User(string name, int id)
        {
            FName = name;
            Id = id;
        }
        public string Username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int sales { get; set; }
        public int Id { get; set; }
    }    
}