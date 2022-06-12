using Products.Logic;
using UnityEngine;

namespace ButtonActions
{
    public class ProductButton : MonoBehaviour, IButtonAction
    {
        [SerializeField] private ProductBase _product;

        public void Press()
        {
            EventManager.ReportPurchase(_product);
        }
    }
}