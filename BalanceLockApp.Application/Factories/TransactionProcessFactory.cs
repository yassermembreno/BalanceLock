using BalanceLockApp.Application.Interfaces;
using BalanceLockApp.Application.Processes;
using BalanceLockApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Application.Factories
{
    public class TransactionProcessFactory
    {
        public static ITransactionProcess CreateInstance(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.Debit:
                    return new DebitTransactionProcess();
                case TransactionType.Credit:
                    return null;
                default:
                    throw new Exception("Transaction Type does not exists.");
            }
        }
    }
}
