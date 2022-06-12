using Products.Logic;
using Wallet.Logic;

namespace Seller
{
    public class Transaction
    {
        private readonly IBalance _balance;
        private readonly ProductBase _product;
        
        public Transaction(IBalance balance, ProductBase product)
        {
            _balance = balance;
            _product = product;
        }

        public void Check()
        {
            var productPrice = _product.Price;
            if (_balance.AmountOfMoney - productPrice < 0)
            {
                EventManager.ReportPurchaseMistake();
                return;
            }

            EventManager.ReportPurchase();
        }

        public void CloseWithSuccess()
        {
            EventManager.ReportClosure();
            _balance.Subtract(_product.Price);
            _product.GetPurchased();
        }
    }
}
