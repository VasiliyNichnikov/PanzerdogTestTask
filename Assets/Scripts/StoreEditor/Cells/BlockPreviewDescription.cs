using UnityEngine;

namespace StoreEditor.Cells
{
    [CreateAssetMenu(fileName = "BlockPreviewDescription", menuName = "Blocks/PreviewDescription", order = 0)]
    public class BlockPreviewDescription: BlockBase
    {
        public Sprite Preview => _preview;
        public string Description => _description;
        
        [SerializeField] private Sprite _preview;
        [SerializeField] private string _description;
    }
}