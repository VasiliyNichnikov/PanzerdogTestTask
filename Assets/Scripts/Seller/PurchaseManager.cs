using System;
using Buyer;
using Products;
using Tableau;
using UnityEngine;
using Wallet.UI;

namespace Seller
{
    public class PurchaseManager : MonoBehaviour
    {
        [SerializeField] private BalanceTextManager _balanceTextManager;
        [SerializeField] private User _user;
        [SerializeField] private ManagerOfTableau _managerOfTableau;

        private Transaction _transaction;
        private IProduct _product;

        private void OnEnable()
        {
            EventManager.StartPurchase += StartPurchaseProduct;
            EventManager.CompletePurchase += CompletePurchaseProduct;
            EventManager.PurchaseWithoutConfirmation += PurchaseWithoutConfirmation;
        }

        private void OnDisable()
        {
            EventManager.StartPurchase -= StartPurchaseProduct;
            EventManager.CompletePurchase -= CompletePurchaseProduct;
            EventManager.PurchaseWithoutConfirmation -= PurchaseWithoutConfirmation;
        }

        private void Start()
        {
            ChangeTextBalance();
        }

        private void StartPurchaseProduct(IProduct product, TypesOfActionsWithBalance action)
        {
            _product = product;
            _transaction = new Transaction(_user.Balance, product.Price, action);
            var answer = _transaction.Confirmation();
            
            if (product.Price == 0)
            {
                CompletePurchaseProduct();
            }
            else
            {
                DisplayPurchaseConfirmations(answer, product.Price);
            }
        }

        private void DisplayPurchaseConfirmations(bool answer, float amount)
        {
            if (answer)
            {
                _managerOfTableau.OpenConfirmPurchase("Are you sure?",
                    $"After confirmation, you will receive the goods and you will be charged ${amount}");
            }
            else
            {
                _managerOfTableau.OpenMistake("Oops!", "You don't have enough money :(");
            }
        }

        private void CompletePurchaseProduct()
        {
            if (_transaction == null || _product == null)
                throw new ArgumentNullException();
            _transaction.ToProduce();
            _product.GetPurchased();
            ChangeTextBalance();
        }

        private void PurchaseWithoutConfirmation(float amount, TypesOfActionsWithBalance action)
        {
            _transaction = new Transaction(_user.Balance, amount, action);
            var answer = _transaction.Confirmation();
            if (answer)
            {
                _transaction.ToProduce();
                ChangeTextBalance();
            }
        }

        private void ChangeTextBalance()
        {
            _balanceTextManager.Change(_user.Balance.AmountOfMoney);
        }
    }
}