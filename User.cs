using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdminRole6
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string AdditionalInfo { get; set; } // Assuming this is the missing property  
        public string EWalletBalance { get; set; }

        // Constructor to match the usage in AddOrRemoveUsersForm.cs  
        public User(int userID, string name, string email, string ewalletBalance, string role, string additionalInfo, string password)
        {
            UserID = userID;
            Name = name;
            Email = email;
            EWalletBalance = ewalletBalance;
            Role = role;
            AdditionalInfo = additionalInfo;
            Password = password;
        }

        public User()
        {
        }
    }
}
