using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaulty.Classes
{
    public class PasswordEntry
    {
        public string Uuid { get; set; } = Guid.NewGuid().ToString(); //id unique
        public string Group { get; set; } = "Général";
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string Notes { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}