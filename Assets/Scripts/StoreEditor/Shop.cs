using StoreEditor.Cells;
using UnityEngine;

namespace StoreEditor
{
    [RequireComponent(typeof(CreatorsBlock))]
    public class Shop: MonoBehaviour
    {
        [SerializeField] private Transform _parent;
        [SerializeField] private BlockBase[] _products;
        private CreatorsBlock _creator;

        private void Start()
        {
            _creator = GetComponent<CreatorsBlock>();
            Fill0InShowcase();
        }
        
        private void Fill0InShowcase()
        {
            for(var index = 0; index < _products.Length; index++)
            {
                var numberInList = index + 1;
                var block = _products[index];
                var creator = _creator.GetCreator(block);
                creator.Create(numberInList, block.Price, _parent);
            }
        }
    }
}