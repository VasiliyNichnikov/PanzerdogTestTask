using UnityEngine;

namespace Products.Creators
{
    public class CreatorProductDescription: ICreatorProduct
    {
        private readonly GameObject _prefab;
        private readonly string _description;
        
        public CreatorProductDescription(GameObject prefab, string description)
        {
            _prefab = prefab;
            _description = description;
        }
        
        public ProductBase Create(int numberInList, float price, Transform parent)
        {
            var product = Object.Instantiate(_prefab, parent).GetComponent<ProductDescription>();
            product.SetNumberInList(numberInList);
            product.SetPrice(price);
            product.SetDescription(_description);
            return product;
        }
    }
}