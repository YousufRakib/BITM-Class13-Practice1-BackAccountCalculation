using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class CreateAccount
    {
        public string accountNumber;
        public string customerName;
        public string createCustomerAccount()
        {
            string info = "Account Number : '" + accountNumber + "'  Customer Name : '" + customerName +"' ";
            return info;
        }
    }
}
