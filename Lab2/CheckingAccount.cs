using System;
namespace eu.sig.training.ch04.v1
{
    public class CheckingAccount
    {
        private int transferLimit = 100;

        public Transfer MakeTransfer(String counterAccount, Money amount)
        {
            // 1. Check withdrawal limit:
            if (amount.GreaterThan(this.transferLimit))
            {
                throw new BusinessException("Limit exceeded!");
            }

            Accounts.ValidateAccountNumber(counterAccount);

            // 3. Look up counter account and make transfer object:
            CheckingAccount acct = Accounts.FindAcctByNumber(counterAccount);
            Transfer result = new Transfer(this, acct, amount);
            return result;

        }

    }
}