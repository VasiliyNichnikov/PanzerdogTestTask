using UnityEngine;

namespace Products.Creators
{
    public class CreatorProductVirtualCurrency: ICreatorProduct
    {
        private readonly GameObject _prefab;
        private readonly float _number;

        public CreatorProductVirtualCurrency(GameObject prefab, float number)
        {
            _prefab = prefab;
            _number = number;
        }
        
        public ProductBase Create(int numberInList, float price, Transform parent)
        {
            var product = Object.Instantiate(_prefab, parent).GetComponent<ProductVirtualCurrency>();
            product.SetNumberInList(numberInList);
            product.SetPrice(price);
            product.SetVirtualCurrency(_number);
            return product;
        }
    }
}