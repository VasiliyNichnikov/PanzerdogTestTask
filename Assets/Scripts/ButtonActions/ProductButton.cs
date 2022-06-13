using Products;
using Seller;
using UnityEngine;

namespace ButtonActions
{
    public class ProductButton : MonoBehaviour, IButtonAction
    {
        [SerializeField] private ProductBase _product;

        public void Press()
        {
            EventManager.StartPurchase(_product, TypesOfActionsWithBalance.Subtraction);
        }
    }
}