using Products.Logic;
using UnityEngine;

namespace Tableau.Logic
{
    public class TableauConfirmPurchase: ITableau
    {
        private GameObject _createdTableau;
        private readonly ProductBase _product;

        public TableauConfirmPurchase(ProductBase product)
        {
            _product = product;
        }
        
        public void Create(GameObject prefab, Transform parent)
        {
            _createdTableau = Object.Instantiate(prefab, parent);
        }

        public void Send()
        {
            EventManager.Buy(_product);
        }

        public void Remove()
        {
            if(_createdTableau != null)
                Object.Destroy(_createdTableau);
        }
    }
}