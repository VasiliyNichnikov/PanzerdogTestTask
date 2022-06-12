using System;
using Buyer;
using Products;
using UnityEngine;
using Wallet.UI;

namespace Seller
{
    public class PurchaseManager : MonoBehaviour
    {
        [SerializeField] private BalanceTextManager _balanceTextManager;
        [SerializeField] private User _user;

        private Transaction _transaction;
        private IProduct _selectedProduct;

        private void OnEnable()
        {
            EventManager.StartPurchase += StartPurchase;
            EventManager.CompletePurchase += CompletePurchase;
            EventManager.AddAmount += AddAmount;
        }

        private void OnDisable()
        {
            EventManager.StartPurchase -= StartPurchase;
            EventManager.CompletePurchase -= CompletePurchase;
            EventManager.AddAmount -= AddAmount;
        }

        private void Start()
        {
            _transaction = new Transaction(_user.Balance);
            ChangeTextBalance();
        }

        private void StartPurchase(IProduct product)
        {
            _selectedProduct = product;
            if (product.Price == 0)
            {
                CompletePurchase(free: true);
                return;
            }
            
            if (_transaction.CheckSubtractions(product.Price))
            {
                EventManager.ReportPurchase();
            }
            else
            {
                EventManager.ReportPurchaseMistake();
            }
        }

        private void CompletePurchase(bool free = false)
        {
            if (_selectedProduct == null)
                throw new ArgumentNullException();
            
            if (free == false)
            {
                EventManager.ReportClosure();
                _transaction.CloseWithSuccess(_selectedProduct.Price);
                ChangeTextBalance();
            }
            _selectedProduct.GetPurchased();
        }

        private void AddAmount(float amount)
        {
            if (_transaction.CheckAdditions() == false) return;

            _transaction.CloseWithSuccess(amount, subtraction: false);
            ChangeTextBalance();
        }

        private void ChangeTextBalance()
        {
            _balanceTextManager.Change(_user.Balance.AmountOfMoney);
        }
    }
}