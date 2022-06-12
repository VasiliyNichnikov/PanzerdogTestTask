using UnityEngine;

namespace Products.Creators
{
    public interface ICreatorProduct
    {
        public ProductBase Create(int numberInList, float price, Transform parent);
    }
}