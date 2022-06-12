using UnityEngine;

namespace StoreEditor.Cells
{
    [CreateAssetMenu(fileName = "BlockVirtualCurrency", menuName = "Blocks/VirtualCurrency", order = 0)]
    public class BlockVirtualCurrency: BlockBase
    {
        public float VirtualCurrency => _virtualCurrency;
        
        [SerializeField] private float _virtualCurrency;
    }
}