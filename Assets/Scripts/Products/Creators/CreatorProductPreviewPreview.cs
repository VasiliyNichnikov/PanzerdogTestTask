using UnityEngine;

namespace Products.Creators
{
    public class CreatorProductPreviewPreview: ICreatorProduct
    {
        private readonly GameObject _prefab;
        private readonly Sprite _spriteOne;
        private readonly Sprite _spriteTwo;
        
        public CreatorProductPreviewPreview(GameObject prefab, Sprite spriteOne, Sprite spriteTwo)
        {
            _prefab = prefab;
            _spriteOne = spriteOne;
            _spriteTwo = spriteTwo;
        }
        
        public ProductBase Create(int numberInList, float price, Transform parent)
        {
            var product = Object.Instantiate(_prefab, parent).GetComponent<ProductPreviewPreview>();
            product.NumberInList = numberInList;
            product.Price = price;
            product.SetPreview(_spriteOne);
            product.SetPreviewTwo(_spriteTwo);
            return product;
        }
    }
}