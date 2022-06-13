using System.Collections.Generic;
using Products;
using StoreEditor.Cells;
using UnityEngine;

namespace StoreEditor
{
    [RequireComponent(typeof(CreatorsBlock))]
    public class Shop : MonoBehaviour
    {
        [SerializeField] private Transform _parent;
        [SerializeField] private BlockBase[] _products;
        
        private List<ProductBase> _createdProducts;
        private CreatorsBlock _creator;


        private void OnEnable()
        {
            EventManager.DestroyerProduct += RemoveProduct;
        }

        private void OnDisable()
        {
            EventManager.DestroyerProduct -= RemoveProduct;
        }


        private void Start()
        {
            _createdProducts = new List<ProductBase>();
            _creator = GetComponent<CreatorsBlock>();
            FillInShowcase();
        }

        private void FillInShowcase()
        {
            for (var index = 0; index < _products.Length; index++)
            {
                var numberInList = index + 1;
                var block = _products[index];
                var creator = _creator.GetCreator(block);
                var product = creator.Create(numberInList, block.Price, _parent);
                _createdProducts.Add(product);
            }
        }

        private void RemoveProduct(ProductBase product)
        {
            Destroy(product.gameObject);
            _createdProducts.Remove(product);
            UpdateNumbers();
        }

        private void UpdateNumbers()
        {
            for (var index = 0; index < _createdProducts.Count; index++)
            {
                _createdProducts[index].SetNumberInList(index + 1);
            }
        }
    }
}