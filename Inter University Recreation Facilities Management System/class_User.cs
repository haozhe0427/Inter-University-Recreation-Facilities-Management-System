using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_University_Recreation_Facilities_Management_System
{
    public class User
    {
        private string email;
        private string password;
        private string accountRole;
        private string userName;
        private string contactNumber;

        public User(string email, string password, 
                    string accountRole, string userName, string contactNumber)
        {
            this.email         = email;
            this.password      = password;
            this.accountRole   = accountRole;
            this.userName      = userName;
            this.contactNumber = contactNumber;
        }

        public string Email 
        {
            get { return email; }
            set { email = value; }
        }

        public string Password 
        {
            get { return password; }
            set { password = value; }
        }

        public string AccountRole
        {
            get { return accountRole; }
            set { accountRole = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
    }
}