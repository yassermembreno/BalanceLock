using BalanceLockApp.Domain.Entities;
using BalanceLockApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private List<Account> accounts;

        public AccountRepository()
        {
            accounts = new List<Account>();
        }
        public void Create(Account t)
        {
            accounts.Add(t);
        }

        public List<Account> GetAll()
        {
            return accounts;
        }

        public Account GetByAccountNumber(int accountNumber)
        {
            return accounts.Where(x => x.AccountNumber == accountNumber).FirstOrDefault();
        }

        public int Update(Account t)
        {
            int index = accounts.FindIndex(x => x.AccountNumber == t.AccountNumber);
            if(index < 0){
                throw new ArgumentException("Error, index out of range.");
            }

            accounts.Insert(index, t);

            return index;
        }
    }
}
