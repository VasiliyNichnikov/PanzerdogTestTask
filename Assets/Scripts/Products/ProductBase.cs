using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Products
{
    public abstract class ProductBase : MonoBehaviour, IProduct
    {
        public float Price { get; private set; }

        [SerializeField] private Text _numberText;
        [SerializeField] private Text _priceText;
        private int _numberInList;

        public void SetNumberInList(int value)
        {
            if (value >= 1)
                _numberInList = value;
            else
                throw new ArgumentOutOfRangeException();
            _numberText.text = _numberInList.ToString();
        }

        public void SetPrice(float value)
        {
            if (value >= 0)
                Price = value;
            else
                throw new ArgumentOutOfRangeException();
            _priceText.text = GetPriceText();
        }

        public virtual void GetPurchased()
        {
            EventManager.DestroyerProduct(this);
        }

        private string GetPriceText()
        {
            return Price == 0 ? "Free" : $"{Price.ToString(CultureInfo.InvariantCulture)}$";
        }
    }
}