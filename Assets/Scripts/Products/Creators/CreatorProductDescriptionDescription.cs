using UnityEngine;

namespace Products.Creators
{
    public class CreatorProductDescriptionDescription: ICreatorProduct
    {
        private readonly GameObject _prefab;
        private readonly string _descriptionOne;
        private readonly string _descriptionTwo;
        
        public CreatorProductDescriptionDescription(GameObject prefab, string descriptionOne, string descriptionTwo)
        {
            _prefab = prefab;
            _descriptionOne = descriptionOne;
            _descriptionTwo = descriptionTwo;
        }
        
        public ProductBase Create(int numberInList, float price, Transform parent)
        {
            var product = Object.Instantiate(_prefab, parent).GetComponent<ProductDescriptionDescription>();
            product.NumberInList = numberInList;
            product.Price = price;
            product.SetDescription(_descriptionOne);
            product.SetDescriptionTwo(_descriptionTwo);
            return product;
        }
    }
}