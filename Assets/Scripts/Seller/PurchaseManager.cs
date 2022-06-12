using Products.Logic;
using UnityEngine;
using Wallet.UI;

namespace Seller
{
    public class PurchaseManager : MonoBehaviour
    {
        [SerializeField] private BalanceTextManager _balanceTextManager;
        [SerializeField] private User _user;
        private Transaction _transaction;
        
        private void OnEnable()
        {
            EventManager.StartPurchase += StartPurchase;
            EventManager.CompletePurchase += CompletePurchase;
        }

        private void OnDisable()
        {
            EventManager.StartPurchase -= StartPurchase;
            EventManager.CompletePurchase -= CompletePurchase;
        }

        private void Start()
        {
            ChangeTextBalance();
        }
        
        private void StartPurchase(ProductBase product)
        {
            _transaction = new Transaction(_user.Balance, product);
            _transaction.Check();
        }

        private void CompletePurchase()
        {
            _transaction.CloseWithSuccess();
            ChangeTextBalance();
        }

        private void ChangeTextBalance()
        {
            _balanceTextManager.ChangeBalance(_user.Balance.AmountOfMoney);
        }
    }
}
