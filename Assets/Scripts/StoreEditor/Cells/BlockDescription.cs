using UnityEngine;

namespace StoreEditor.Cells
{
    [CreateAssetMenu(fileName = "BlockDescription", menuName = "Blocks/Description", order = 0)]
    public class BlockDescription: BlockBase
    {
        public string Description => _description;
        [SerializeField] private string _description;
    }
}