using BalanceLockApp.Application.Interfaces;
using BalanceLockApp.Domain.Entities;
using BalanceLockApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Application.Processes
{
    public class CreditTransactionProcess : ITransactionProcess
    {
        private IAccountRepository accountRepository;

        public CreditTransactionProcess(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public void Process(int accountNumber, decimal amount)
        {
            Validation(accountNumber, amount);

            Account account = accountRepository.GetByAccountNumber(accountNumber);

            account.Balance += amount;

            accountRepository.Update(account);
        }

        public void Validation(int accountNumber, decimal amount)
        {
            Account account = accountRepository.GetByAccountNumber(accountNumber);

            if (account == null)
            {
                throw new ArgumentNullException($"Account {accountNumber} does not exists.");
            }           

            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }

        }
    }
}
