using BalanceLockApp.Application.Factories;
using BalanceLockApp.Application.Interfaces;
using BalanceLockApp.Domain.Entities;
using BalanceLockApp.Domain.Enums;
using BalanceLockApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Application.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public void Create(Account t)
        {
            try
            {
                accountRepository.Create(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateTransaction(int accountNumber, decimal amount, TransactionType transactionType)
        {
            TransactionProcessFactory.CreateInstance(transactionType, accountRepository).Process(accountNumber,amount);
        }

        public List<Account> GetAll()
        {
            try
            {
                return accountRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public Account GetByAccountNumber(int accountNumber)
        {
            Account account = null;
            try
            {
                account = accountRepository.GetByAccountNumber(accountNumber);
                return account;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Account t)
        {
            int rowAffected = 0;
            try
            {
                rowAffected = accountRepository.Update(t);
                return rowAffected;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
