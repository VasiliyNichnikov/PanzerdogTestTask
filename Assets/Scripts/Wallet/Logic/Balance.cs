using System;

namespace Wallet.Logic
{
    public class Balance: IBalance
    {
        public float AmountOfMoney { get; private set; }

        public Balance(float amountOfMoney)
        {
            AmountOfMoney = amountOfMoney;
        }

        public void Subtract(float productPrice)
        {
            if (AmountOfMoney - productPrice < 0)
            {
                throw new Exception("The balance cannot be negative");
            }

            AmountOfMoney -= productPrice;
        }

        public void Add(float amount)
        {
            AmountOfMoney += amount;
        }
    }
}