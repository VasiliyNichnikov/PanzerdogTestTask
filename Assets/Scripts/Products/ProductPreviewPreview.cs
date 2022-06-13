using UnityEngine;
using UnityEngine.UI;

namespace Products
{
    public class ProductPreviewPreview : ProductPreview
    {
        [SerializeField] private Image _previewTwo;

        public void SetPreviewTwo(Sprite sprite)
        {
            _previewTwo.sprite = sprite;
        }
    }
}