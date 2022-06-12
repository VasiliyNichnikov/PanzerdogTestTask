using Wallet.Logic;

namespace Seller
{
    public class Transaction
    {
        private readonly IBalance _balance;

        public Transaction(IBalance balance)
        {
            _balance = balance;
        }

        public bool CheckSubtractions(float productPrice)
        {
            return _balance.AmountOfMoney - productPrice >= 0;
        }

        public bool CheckAdditions()
        {
            return true; // можно сделать ограничение по размеру суммы
        }
        
        public void CloseWithSuccess(float amount, bool subtraction=true)
        {
            if(subtraction)
                _balance.Subtract(amount);
            else
                _balance.Add(amount);
        }
        
    }
}
