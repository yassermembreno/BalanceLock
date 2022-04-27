using BalanceLockApp.Domain.Entities;
using BalanceLockApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Application.Interfaces
{
    public interface IAccountService : IService<Account>
    {
        Account GetByAccountNumber(int accountNumber0);
        void CreateTransaction(int accountNumber, decimal amount, TransactionType transactionType);        
    }
}
