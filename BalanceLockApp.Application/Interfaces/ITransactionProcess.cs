using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceLockApp.Application.Interfaces
{
    public interface ITransactionProcess
    {
        void Process(int accountNumber, decimal amount);

       
    }
}
