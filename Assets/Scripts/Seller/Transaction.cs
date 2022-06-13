using System;
using Wallet.Logic;

namespace Seller
{
    public class Transaction
    {
        private readonly IBalance _balance;
        private readonly float _amount;
        private readonly TypesOfActionsWithBalance _action;
        private bool _confirmed;

        public Transaction(IBalance balance, float amount, TypesOfActionsWithBalance action)
        {
            _balance = balance;
            _amount = amount;
            _action = action;
        }

        public bool Confirmation()
        {
            var controller = new BalanceController(_balance);
            return _action switch
            {
                TypesOfActionsWithBalance.Addendum => _confirmed = controller.CheckAdditions(_amount),
                TypesOfActionsWithBalance.Subtraction => _confirmed = controller.CheckSubtractions(_amount),
                _ => false
            };
        }

        public void ToProduce()
        {
            if (_confirmed == false)
                throw new Exception("The Transaction Has Not Been Confirmed");


            switch (_action)
            {
                case TypesOfActionsWithBalance.Addendum:
                    _balance.Add(_amount);
                    break;
                case TypesOfActionsWithBalance.Subtraction:
                    _balance.Subtract(_amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}