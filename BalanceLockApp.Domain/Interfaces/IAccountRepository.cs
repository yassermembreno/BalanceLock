using BalanceLockApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Domain.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByAccountNumber(int accountNumber);

    }
}
