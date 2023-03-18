using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_02
{
    internal class Owner
    {
        public Score score;

        public string name { get; set; }
        public string surname { get; set; }
        public string lastName { get; set; }
        public string birthday { get; set; }
        public string passportNumber { get; set; }

        
        public Owner(string surname, string name, string lastname, string birthday, string passport, Score score)
        {
            this.surname = surname;
            this.name = name;
            lastName = lastname;
            this.birthday = birthday;
            passportNumber = passport;
            this.score = score;

        } 
    }
}
