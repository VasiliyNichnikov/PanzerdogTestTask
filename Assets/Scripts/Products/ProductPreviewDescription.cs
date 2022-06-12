using UnityEngine;
using UnityEngine.UI;

namespace Products
{
    public class ProductPreviewDescription: ProductPreview
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