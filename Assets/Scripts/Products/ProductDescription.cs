using UnityEngine;
using UnityEngine.UI;

namespace Products
{
    public class ProductDescription : ProductBase
    {
        [SerializeField] private Text _description;

        public void SetDescription(string text)
        {
            _description.text = text;
        }
        
        public override void GetPurchased()
        {
            base.GetPurchased();
        }
    }
}