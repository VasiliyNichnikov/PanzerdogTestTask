using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Products.Logic
{
    public abstract class ProductBase: MonoBehaviour, IProduct
    {
        public int NumberInList
        {
            get => _numberInList;
            set
            {
                if (value >= 1)
                    _numberInList = value;
                throw new ArgumentOutOfRangeException();
            }
        }

        public float Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                    _price = value;
                throw new ArgumentOutOfRangeException();
            }
        }

        [SerializeField] private Text _numberText;
        [SerializeField] private Text _priceText;
        
        private float _price;
        private int _numberInList;

        public virtual void GetPurchased()
        {
            Destroy(gameObject);
        }

        public virtual void Start()
        {
            _price = 500;
            _numberText.text = _numberInList.ToString();
            _priceText.text = GetPriceText();
        }

        private string GetPriceText()
        {
            return _price == 0 ? "Free" : $"{_price.ToString(CultureInfo.InvariantCulture)}$";
        }
    }
}
