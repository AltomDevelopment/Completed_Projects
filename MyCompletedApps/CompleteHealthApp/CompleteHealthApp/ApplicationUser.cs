using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace CompleteHealthApp
{

    internal class ApplicationUser
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string eMail { get; set; }

        public ApplicationUser()
        {
        }

        public ApplicationUser(string userName, string passWord, string firstName, string lastName, string eMail)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.firstName = firstName;
            this.lastName = lastName;
            this.eMail = eMail;
        }
    }

}
