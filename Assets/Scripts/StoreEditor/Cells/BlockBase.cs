using UnityEngine;

namespace StoreEditor.Cells
{
    public class BlockBase : ScriptableObject
    {
        public float Price => _price;
        [SerializeField] private float _price;
    }
}