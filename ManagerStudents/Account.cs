using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents
{
   public class Account
    {
        private String NameAccount;
        
        private String passWord;

        public string NameAccount1 { get => NameAccount; set => NameAccount = value; }
        public string PassWord { get => passWord; set => passWord = value; }


        public Account(String account , String password)
        {
            this.NameAccount = account;
            this.passWord = password;
        }
    }
    
}
