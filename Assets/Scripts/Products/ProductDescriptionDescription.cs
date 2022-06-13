using UnityEngine;
using UnityEngine.UI;

namespace Products
{
    public class ProductDescriptionDescription: ProductDescription
    {
        [SerializeField] private Text _descriptionTwo;

        public void SetDescriptionTwo(string text)
        {
            _descriptionTwo.text = text;
        }
    }
}