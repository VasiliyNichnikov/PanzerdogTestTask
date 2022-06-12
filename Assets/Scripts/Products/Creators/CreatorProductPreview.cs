using UnityEngine;

namespace Products.Creators
{
    public class CreatorProductPreview: ICreatorProduct
    {
        private readonly GameObject _prefab;
        private readonly Sprite _sprite;

        public CreatorProductPreview(GameObject prefab, Sprite sprite)
        {
            _prefab = prefab;
            _sprite = sprite;
        }
        
        public ProductBase Create(int numberInList, float price, Transform parent)
        {
            var product = Object.Instantiate(_prefab, parent).GetComponent<ProductPreview>();
            product.NumberInList = numberInList;
            product.Price = price;
            product.SetPreview(_sprite);
            return product;
        }
    }
}