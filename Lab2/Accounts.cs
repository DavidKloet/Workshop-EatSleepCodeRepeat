using System;

namespace eu.sig.training.ch04.v1
{
    public static class Accounts
    {

        public static CheckingAccount FindAcctByNumber(string number)
        {
            return new CheckingAccount();
        }

        public static void ValidateAccountNumber(string accountNumber)
        {
            // 2. Assuming result is 9-digit bank account number, validate 11-test:
            if (String.IsNullOrEmpty(accountNumber) || accountNumber.Length != 9 || IsAccountNumberFormatValid(accountNumber))
            {
                throw new BusinessException("Invalid account number!");
            }
        }

        private static bool IsAccountNumberFormatValid(string accountNumber)
        {
            int sum = 0;
            for (int i = 0; i < accountNumber.Length; i++)
            {
                sum = sum + (9 - i) * (int)Char.GetNumericValue(accountNumber[i]);
            }

            return (sum % 11 != 0);
        }
    }
}