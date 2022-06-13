using UnityEngine;
using UnityEngine.UI;

namespace Products
{
    public class ProductPreview: ProductBase
    {
        [SerializeField] private Image _preview;

        public void SetPreview(Sprite sprite)
        {
            _preview.sprite = sprite;
        }
    }
}