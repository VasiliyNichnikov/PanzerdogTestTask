using Products.Logic;
using UnityEngine;
using Wallet.UI;

namespace Seller
{
    public class PurchaseManager : MonoBehaviour
    {
        [SerializeField] private BalanceTextManager _balanceTextManager;
        [SerializeField] private User _user;

        private void OnEnable()
        {
            EventManager.Buy += Buy;
        }

        private void OnDisable()
        {
            EventManager.Buy -= Buy;
        }

        private void Start()
        {
            ChangeTextBalance();
        }
        
        private void Buy(ProductBase product)
        {
            var newTransaction = new Transaction();
            newTransaction.ToPerform(_user.Balance, product);
            ChangeTextBalance();
            product.GetPurchased();
        }

        private void ChangeTextBalance()
        {
            _balanceTextManager.ChangeBalance(_user.Balance.AmountOfMoney);
        }
    }
}
