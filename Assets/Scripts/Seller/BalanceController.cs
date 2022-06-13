using Wallet.Logic;

namespace Seller
{
    public class BalanceController
    {
        private readonly IBalance _balance;

        public BalanceController(IBalance balance)
        {
            _balance = balance;
        }

        public bool CheckSubtractions(float amount)
        {
            return _balance.AmountOfMoney - amount >= 0;
        }

        public bool CheckAdditions(float amount)
        {
            return true; // можно сделать ограничение по размеру суммы
        }
    }
}
