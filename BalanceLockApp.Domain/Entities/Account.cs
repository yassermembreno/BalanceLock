using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        private decimal balance;
        private object balanceLock = new object();
        public decimal Balance {
            get {
                return this.balance;
            }
            set {
                lock (balanceLock)
                { 
                    balance = value;
                }
            }
        }
        public Customer Customer { get; set; }
        
    }
}
