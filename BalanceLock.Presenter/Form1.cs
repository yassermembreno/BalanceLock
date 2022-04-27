using BalanceLockApp.Application.Interfaces;
using BalanceLockApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceLock.Presenter
{
    public partial class Form1 : Form
    {
        private IAccountService accountService;
        public Form1(IAccountService accountService)
        {
            this.accountService = accountService;
            InitializeComponent();
        }    

        private void BtnTest_Click(object sender, EventArgs e)
        {
            List<decimal> amounts = new List<decimal>() { 100M, 20, 1000M, 300M, };
            int i = 1;
            foreach (decimal value in amounts)
            {
                if (i % 2 == 1)
                {
                    Task.Run(() =>
                    {
                        accountService.CreateTransaction(123, value, TransactionType.Credit);
                    });
                }
                else
                {
                    Task.Run(() =>
                    {
                        accountService.CreateTransaction(123, value, TransactionType.Debit);
                    });
                }

            }
        }
    }
}
