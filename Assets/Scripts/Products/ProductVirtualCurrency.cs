using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Products
{
    public class ProductVirtualCurrency: ProductBase
    {
        [SerializeField] private Text _virtualCurrency;
        private float _number;

        public void SetVirtualCurrency(float number)
        {
            _number = number;
            _virtualCurrency.text = $"{number.ToString(CultureInfo.InvariantCulture)}$";
        }
        
        public override void GetPurchased()
        {
            base.GetPurchased();
        }
    }
}