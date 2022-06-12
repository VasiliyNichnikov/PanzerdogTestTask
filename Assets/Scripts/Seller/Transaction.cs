using Products.Logic;
using Wallet.Logic;

namespace Seller
{
    public class Transaction
    {
        public void ToPerform(IBalance balance, ProductBase product)
        {
            var productPrice = product.Price;
            if (balance.AmountOfMoney - productPrice < 0)
            {
                EventManager.ReportPurchaseMistake();
                return;
            }
            balance.Subtract(productPrice);
        }
    }
}
