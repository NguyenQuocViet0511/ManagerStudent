using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents
{
   public class ListAccount
    {
        private static ListAccount Setting;
        public static ListAccount Setting1
        {
            get
            {
                if (Setting == null)
                    Setting = new ListAccount();
                return Setting;
            }
            set => Setting = value;
        }

        List<Account> listaccount;

        public List<Account> Listaccount { get => listaccount; set => listaccount = value; }
      

        public  ListAccount()
        {
            Listaccount = new List<Account>();
            Listaccount.Add(new Account("nguyenviet","123456"));
        }
    }
}
