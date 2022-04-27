using BalanceLockApp.Application.Interfaces;
using BalanceLockApp.Domain.Entities;
using BalanceLockApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Application.Services
{
    public class AccountService : IAccountService
    {

        public void Create(Account t)
        {
            throw new NotImplementedException();
        }

        public void CreateTransaction(int accountNumber, decimal amount, TransactionType transactionType)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetByAccountNumber(int accountNumber0)
        {
            throw new NotImplementedException();
        }

        public int Update(Account t)
        {
            throw new NotImplementedException();
        }
    }
}
