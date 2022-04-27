using BalanceLockApp.Application.Interfaces;
using BalanceLockApp.Application.Processes;
using BalanceLockApp.Domain.Enums;
using BalanceLockApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Application.Factories
{
    public class TransactionProcessFactory
    {
        public static ITransactionProcess CreateInstance(TransactionType transactionType, IAccountRepository accountRepository)
        {
            switch (transactionType)
            {
                case TransactionType.Debit:
                    return new DebitTransactionProcess(accountRepository);
                case TransactionType.Credit:
                    return new CreditTransactionProcess(accountRepository);
                default:
                    throw new Exception("Transaction Type does not exists.");
            }
        }
    }
}
