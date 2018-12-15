using System;
using System.Collections.Generic;

namespace Lab1.App.Models.Responses
{
    public class UserFullDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateBirth { get; set; }
    }
}
