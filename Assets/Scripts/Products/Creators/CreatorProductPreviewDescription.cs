using UnityEngine;

namespace Products.Creators
{
    public class CreatorProductPreviewDescription: ICreatorProduct
    {
        private readonly GameObject _prefab;
        private readonly string _description;
        private readonly Sprite _sprite;
        
        public CreatorProductPreviewDescription(GameObject prefab, string description, Sprite sprite)
        {
            _prefab = prefab;
            _description = description;
            _sprite = sprite;
        }
        
        public ProductBase Create(int numberInList, float price, Transform parent)
        {
            var product = Object.Instantiate(_prefab, parent).GetComponent<ProductPreviewDescription>();
            product.SetNumberInList(numberInList);
            product.SetPrice(price);
            product.SetDescription(_description);
            product.SetPreview(_sprite);
            return product;
        }
    }
}